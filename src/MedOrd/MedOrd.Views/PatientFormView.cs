using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedOrd.ViewInterfaces;
using MedOrd.Presenter;
using MedOrd.DomainModel;

namespace MedOrd.Views {

	public enum PatientFormMode {
		New,
		Details,
		Edit
	}

	public partial class PatientFormView : Form, IPatientView {

		#region Members

		private PatientPresenter patientPresenter;

		private PatientFormMode patientFormMode = PatientFormMode.New;

		#region IPatientView Members

		public Guid PatientId { get; set; }

		public Guid PersonId { get; set; }

		public string PersonName {
			get {
				return nameTextBox.Text;
			}
			set {
				nameTextBox.Text = value;
			}
		}

		public string PersonSurname {
			get {
				return surnameTextBox.Text;
			}
			set {
				surnameTextBox.Text = value;
			}
		}

		public string Jmbg {
			get {
				return jmbgTextBox.Text;
			}
			set {
				jmbgTextBox.Text = value;
			}
		}

		public MedOrd.DomainModel.City SelectedCity {
			get {
				return cityComboBox.SelectedItem as City;
			}
			set {
				cityComboBox.SelectedValue = value.Id;
			}
		}

		public string Street {
			get {
				return streetTextBox.Text;
			}
			set {
				streetTextBox.Text = value;
			}
		}

		public string StreetNumber {
			get {
				return streetNumberTextBox.Text;
			}
			set {
				streetNumberTextBox.Text = value;
			}
		}

		public DateTime BirthDate {
			get {
				return birthDateTimePicker.Value;
			}
			set {
				birthDateTimePicker.Value = value;
			}
		}

		public int NumberOfInsuredPerson {
			get {
				return Int32.Parse(numberOfInsuredPersonTextBox.Text);
			}
			set {
				numberOfInsuredPersonTextBox.Text = value.ToString();
			}
		}

		public int CardNumber {
			get {
				return Int32.Parse(cardNumberTextBox.Text);
			}
			set {
				cardNumberTextBox.Text = value.ToString();
			}
		}

		public IList<MedOrd.DomainModel.City> Cities {
			set {
				citiesBindingSource.DataSource = value;
			}
		}

		#endregion

		#endregion

		#region Constructors and Init

		public PatientFormView(Patient patientForEdit) : this() {
			PersonName = patientForEdit.Person.Name;
			PersonSurname = patientForEdit.Person.Surname;
			Jmbg = patientForEdit.Jmbg;
			Street = patientForEdit.Person.Address.StreetAddress;
			StreetNumber = patientForEdit.Person.Address.StreetAddressNumber;
			SelectedCity = patientForEdit.Person.Address.City;
			NumberOfInsuredPerson = patientForEdit.NumberOfInsuredPerson;
			CardNumber = patientForEdit.CardNumber;
			PatientId = patientForEdit.Id;
			PersonId = patientForEdit.Person.Id;

			detailsMode();
		}

		public PatientFormView() {
			InitializeComponent();
			patientFormMode = PatientFormMode.New;
		}


		private void PatientFormView_Load(object sender, EventArgs e) {
			patientPresenter = new PatientPresenter(this);
			patientPresenter.GeneralInit();
			if (patientFormMode == PatientFormMode.New) {
				patientPresenter.InitForNewPatientView();
			}
		}

		#endregion

		#region Methods

		private void saveEditButton_Click(object sender, EventArgs e) {
			bool isDone = patientPresenter.SavePatient();
			if (isDone) {
				DialogResult = DialogResult.OK;
				MessageBox.Show("Pacijent je uspješno unesen u sustav.",
					"Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			} else {
				MessageBox.Show("Unjeli ste pogrešne podatke o pacijentu.",
					"Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

		}

		private void editButton_Click(object sender, EventArgs e) {
			editMode();
		}

		private void detailsMode() {
			patientFormMode = PatientFormMode.Details;
			Text = "Detalji pacijenta";

			nameTextBox.Enabled = false;
			surnameTextBox.Enabled = false;
			jmbgTextBox.Enabled = false;
			birthDateTimePicker.Enabled = false;
			streetTextBox.Enabled = false;
			streetNumberTextBox.Enabled = false;
			cityComboBox.Enabled = false;
			numberOfInsuredPersonTextBox.Enabled = false;
			cardNumberTextBox.Enabled = false;

			saveButton.Enabled = false;
			editButton.Enabled = true;
		}

		private void editMode() {
			patientFormMode = PatientFormMode.Edit;
			Text = "Uređivanje pacijenta";

			nameTextBox.Enabled = true;
			surnameTextBox.Enabled = true;
			jmbgTextBox.Enabled = true;
			birthDateTimePicker.Enabled = true;
			streetTextBox.Enabled = true;
			streetNumberTextBox.Enabled = true;
			cityComboBox.Enabled = true;
			numberOfInsuredPersonTextBox.Enabled = true;
			cardNumberTextBox.Enabled = true;

			saveButton.Enabled = true;
			editButton.Enabled = false;
		}

		#endregion

	}
}
