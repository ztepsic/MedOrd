using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedOrd.ViewInterfaces;
using MedOrd.DomainModel;
using MedOrd.Presenter;
using MedOrd.DomainModel.Exceptions;

namespace MedOrd.Views {
	public partial class PatientSearchFormView : Form, IPatientSearchView {

		#region Members

		private PatientSearchPresenter patientSearchPresenter;

		#region IPatientSearchView Members

		public string PatientName {
			get { return nameTextBox.Text; }
		}

		public string PatientSurname {
			get { return surnameTextBox.Text; }
		}

		public IList<MedOrd.DomainModel.Patient> Patients {
			set {
				patientBindingSource.DataSource = value;
			}
		}

		public MedOrd.DomainModel.Patient SelectedPatient {
			get {
				return patientsDataGridView.SelectedRows[0].DataBoundItem as Patient;
			}
		}

		#endregion

		#endregion

		#region Construcotrs and Init

		public PatientSearchFormView() {
			InitializeComponent();
		}

		private void PatientSearchFormView_Load(object sender, EventArgs e) {
			patientSearchPresenter = new PatientSearchPresenter(this);
		}

		#endregion

		#region Methods

		private void searchButton_Click(object sender, EventArgs e) {
			patientSearchPresenter.SearchForPatient();
		}

		private void detailsButton_Click(object sender, EventArgs e) {
			PatientFormView patientFormView = new PatientFormView(SelectedPatient);
			patientFormView.ShowDialog();
		}

		private void surnameTextBox_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				if (surnameTextBox.Focused) {
					searchButton_Click(sender, null);
				}
			}
		}

		private void nameTextBox_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				if (nameTextBox.Focused) {
					searchButton_Click(sender, null);
				}
			}
		}

		private void addToWaitingRoomButton_Click(object sender, EventArgs e) {
			bool isDone = patientSearchPresenter.AddPatientToWaitingRoom();
			if (isDone) {
				DialogResult = DialogResult.OK;
				MessageBox.Show("Pacijent je uspješno dodan u čekaonicu.",
					"Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			} else {
				MessageBox.Show("Dogodila se greška..",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void openMedicalRecordButton_Click(object sender, EventArgs e) {
			MedicalRecordFormView medRecFormView = null;

			try {
				medRecFormView = new MedicalRecordFormView(SelectedPatient);
			} catch (NotDoctorException ex) {
				MessageBox.Show("Niste autorizirani za otvaranje kartona pacijenta. Samo doktori imaju navedenu autorizaciju.",
						"Nedovoljna autorizacija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			medRecFormView.MdiParent = this.MdiParent;
			medRecFormView.Show();
			
		}


		private void patientsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e) {
			addToWaitingRoomButton.Enabled = true;
			detailsButton.Enabled = true;
			openMedicalRecordButton.Enabled = true;
		}

		#endregion

	}
}
