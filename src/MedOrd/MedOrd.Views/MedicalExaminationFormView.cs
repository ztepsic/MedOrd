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
	public partial class MedicalExaminationFormView : Form, IMedicalExaminationView {

		#region Members

		private MedicalExaminationPresenter medicalExaminationPresenter;


		#region IMedicalExaminationView Members

		private MedicalExamination medicalExamination = null;

		public MedicalExamination MedicalExamination {
			get {
				return medicalExamination;
			}
			set {
				medicalExamination = value;
				medicalExaminationBindingSource.DataSource = value;
				therapiesBindingSource.DataSource = value.Therapies;
				medicalReferencesBindingSource.DataSource = value.MedicalReferences;
				medicalCaseBindingSource.DataSource = value.MedicalCase;
			}
		}

		public string MedicalCaseTitle {
			get {
				return medCaseTitleTextBox.Text;
			}
			set {
				medCaseTitleTextBox.Text = value;
			}
		}

		public IList<Diagnosis> Diagnoses {
			set { diagnosisBindingSource.DataSource = value;  }
		}

		private Patient patient = null;

		public Patient Patient {
			get { return patient; }
			set { patient = value; }
		}

		public Diagnosis SelectedDiagnosis {
			get { return diagnosisComboBox.SelectedItem as Diagnosis; }
			set { diagnosisComboBox.SelectedItem = value; }
		}

		private MedicalReference medicalReference = null;

		public MedicalReference MedicalReference {
			get { return medicalReference; }
			set { medicalReference = value; }
		}

		private Therapy therapy = null;

		public Therapy Therapy {
			get { return therapy; }
			set { therapy = value; }
		}

		#endregion

		#endregion

		#region Constructors and Init

		public MedicalExaminationFormView(Patient patient) : this(){
			medicalExaminationPresenter = new MedicalExaminationPresenter(patient, this);
			saveButton.Enabled = true;
		}

		public MedicalExaminationFormView(MedicalExamination medicalExamination) : this() {
			medicalExaminationPresenter = new MedicalExaminationPresenter(medicalExamination, this);
			cancelButton.Text = "Zatvori";
			anamnesisRichTextBox.Enabled = false;
			recommendationRichTextBox.Enabled = false;
			diagnosisComboBox.Enabled = false;
			medCaseTitleTextBox.Enabled = false;
			therapiesToolStrip.Enabled = false;
			medicalReferenceToolStrip.Enabled = false;
		}

		public MedicalExaminationFormView() {
			InitializeComponent();
		}

		#endregion

		#region Methods

		private void addTherapyToolStripButton_Click(object sender, EventArgs e) {
			if (SelectedDiagnosis == null || String.IsNullOrEmpty(medCaseTitleTextBox.Text)) {
				MessageBox.Show("Niste odredili dijagnozu i naziv medicinskog slučaja.",
					"Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			TherapyFormView therapyFormView = new TherapyFormView();
			DialogResult dialogResult = therapyFormView.ShowDialog();
			if (dialogResult == DialogResult.OK) {
				therapy = therapyFormView.Therapy;
				medicalExaminationPresenter.AddTherapy();
				therapiesBindingSource.CurrencyManager.Refresh();
				therapy = null;
			}
		}

		private void removeTherapyToolStripButton_Click(object sender, EventArgs e) {
			therapy = therapyDataGridView.CurrentRow.DataBoundItem as Therapy;
			if (therapy != null) {
				medicalExaminationPresenter.RemoveTherapy();
				therapiesBindingSource.CurrencyManager.Refresh();
				therapy = null;
			}
		}

		private void addMedRefToolStripButton_Click(object sender, EventArgs e) {
			if (SelectedDiagnosis == null || String.IsNullOrEmpty(medCaseTitleTextBox.Text)) {
				MessageBox.Show("Niste odredili dijagnozu i naziv medicinskog slučaja.",
					"Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			MedicalReferenceFormView medRefFormView = new MedicalReferenceFormView(patient, SelectedDiagnosis);
			DialogResult dialogResult = medRefFormView.ShowDialog();
			if (dialogResult == DialogResult.OK) {
				medicalReference = medRefFormView.MedicalReference;
				medicalExaminationPresenter.AddMedicalReference();
				medicalReferencesBindingSource.CurrencyManager.Refresh();
				medicalReference = null;
			}
		}

		private void deleteMedRegToolStripButton_Click(object sender, EventArgs e) {
			medicalReference = medicalReferencesDataGridView.SelectedRows[0].DataBoundItem as MedicalReference;
			if (medicalReference != null) {
				medicalExaminationPresenter.RemoveMedicalReference();
				medicalReferencesBindingSource.CurrencyManager.Refresh();
				medicalReference = null;
			}
		}

		private void medicalReferencesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			MedicalReference medicalReference = medicalReferencesDataGridView.SelectedRows[0].DataBoundItem as MedicalReference;
			MedicalReferenceFormView medRefFormView = new MedicalReferenceFormView(medicalReference);
			medRefFormView.ShowDialog();
		}

		private void therapyDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
			Therapy therapy = therapyDataGridView.SelectedRows[0].DataBoundItem as Therapy;
			TherapyFormView therapyFormView = new TherapyFormView(therapy);
			therapyFormView.ShowDialog();
		}

		private void saveButton_Click(object sender, EventArgs e) {
			medicalExaminationPresenter.SaveMedicalExamination();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}

		#endregion	

		


	}
}
