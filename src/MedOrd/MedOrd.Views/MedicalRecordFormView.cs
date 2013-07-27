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
	public partial class MedicalRecordFormView : Form, IMedicalRecordView {

		#region Members

		private MedicalRecordPresenter medicalRecordPresenter;

		private Patient patient = null;

		#region IMedicalRecordView Members

		public MedicalRecord MedicalRecord {
			set {
				patient = value.Patient;
				patientBindingSource.DataSource = value.Patient;
				doctorBindingSource.DataSource = value.Doctor;
				medicalRecordBindingSource.DataSource = value;
				therapiesBindingSource.DataSource = value.GetAllTherapies();
				medRefBindingSource.DataSource = value.GetAllMedicalReferences();
				medicalExaminationsBindingSource.DataSource = value.MedicalExaminations;
			}
		}

		#endregion

		#endregion

		#region Constructors and Init

		public MedicalRecordFormView(Patient patient) {
			InitializeComponent();

			medicalRecordPresenter = new MedicalRecordPresenter(this, patient);
		}


		private void MedicalRecordFormView_Load(object sender, EventArgs e) {
			
		}

		#endregion

		#region Methods

		private void newExaminationButton_Click(object sender, EventArgs e) {
			MedicalExaminationFormView medExamFormView = new MedicalExaminationFormView(patient);
			DialogResult dialogResult = medExamFormView.ShowDialog();
			if (dialogResult == DialogResult.OK) {
				medicalRecordPresenter.Update();
				medicalExaminationsBindingSource.CurrencyManager.Refresh();
				
			}
		}


		private void closeButton_Click(object sender, EventArgs e) {
			Close();
		}


		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			MedicalExamination medExam = dataGridView1.SelectedRows[0].DataBoundItem as MedicalExamination;
			MedicalExaminationFormView medExamFormView = new MedicalExaminationFormView(medExam);
			medExamFormView.ShowDialog();
		}

		private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			Therapy therapy = dataGridView2.SelectedRows[0].DataBoundItem as Therapy;
			TherapyFormView therapyFormView = new TherapyFormView(therapy);
			therapyFormView.ShowDialog();
		}

		private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			MedicalReference medicalReference = dataGridView3.SelectedRows[0].DataBoundItem as MedicalReference;
			MedicalReferenceFormView medRefFormView = new MedicalReferenceFormView(medicalReference);
			medRefFormView.ShowDialog();
		}


		#endregion



	

	}
}
