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

namespace MedOrd.Views {
	public partial class MedicalReferenceFormView : Form, IMedicalReferenceView {

		#region Members

		private MedicalReferencePresenter medicalReferencePresenter;

		private MedicalReference medicalReference = null;

		public MedicalReference MedicalReference {
			get { return medicalReference; }
		}
		

		#region IMedicalReferenceView Members

		public IList<MedOrd.DomainModel.MedicalCareActivity> MedicalCareActivities {
			set { medicalCareActivitiesBindingSource.DataSource = value; }
		}

		public MedOrd.DomainModel.MedicalCareActivity SelectedMedicalCareActivitiy {
			get {
				return medCareActivityComboBox.SelectedItem as MedicalCareActivity;
			}
			set {
				medCareActivityComboBox.SelectedItem = value;
			}
		}

		public IList<MedOrd.DomainModel.MedicalInstitution> MedicalInstitutions {
			set { medicalInstitutionsBindingSource.DataSource = value; }
		}

		public MedOrd.DomainModel.MedicalInstitution SelectedMedicalInstitution {
			get {
				return medInstitutionComboBox.SelectedItem as MedicalInstitution;
			}
			set {
				medInstitutionComboBox.SelectedItem = value;
			}
		}


		public string Diagnosis {
			set { diagnosisValueLabel.Text = value; }
		}

		public string WantedFor {
			get {
				return wantedRichTextBox.Text;
			}
			set {
				wantedRichTextBox.Text = value;
			}
		}

		#endregion

		#endregion

		#region Constructors and Init

		public MedicalReferenceFormView(Patient patient, Diagnosis diagnosis) : this() {
			medicalReferencePresenter = new MedicalReferencePresenter(patient, diagnosis, this);
			saveButton.Enabled = true;
		}

		public MedicalReferenceFormView(MedicalReference medicalReference) : this() {
			medicalReferencePresenter = new MedicalReferencePresenter(medicalReference, this);
			cancelButton.Text = "Zatvori";
			medCareActivityComboBox.Enabled = false;
			medInstitutionComboBox.Enabled = false;
			wantedRichTextBox.Enabled = false;
		}

		private MedicalReferenceFormView() {
			InitializeComponent();
		}

		#endregion

		#region Methods

		private void saveButton_Click(object sender, EventArgs e) {
			bool isSaved = medicalReferencePresenter.SaveMedicalReference();
			if (isSaved) {
				medicalReference = medicalReferencePresenter.MedicalReference;
				DialogResult = DialogResult.OK;
				Close();
			}
			
		}

		private void cancelButton_Click(object sender, EventArgs e) {
			medicalReferencePresenter.CancelMedicalReference();
			DialogResult = DialogResult.Cancel;
			Close();
		}

		#endregion

		

	}
}
