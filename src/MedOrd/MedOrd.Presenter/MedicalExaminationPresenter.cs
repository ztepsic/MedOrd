using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.ViewInterfaces;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.DomainModel;
using MedOrd.Infrastructure.DataAccessLayer;
using MedOrd.DomainModel.Services;

namespace MedOrd.Presenter {
	public class MedicalExaminationPresenter {

		#region Members

		private IMedicalExaminationView medicalExaminationView;
		private IMedicalRecordRepository medicalRecordRepository;
		private IDiagnosisRepository diagnosisRepository;

		private MedicalRecord medicalRecord;
		private MedicalExamination currentMedicalExamination;

		#endregion

		#region Constructors and Init


		public MedicalExaminationPresenter(Patient patient, IMedicalExaminationView medicalExaminationView) : this(patient, medicalExaminationView, MedicalRecordRepository.Instance, DiagnosisRepository.Instance) { }

		public MedicalExaminationPresenter(Patient patient, IMedicalExaminationView medicalExaminationView, IMedicalRecordRepository medicalRecordRepository, IDiagnosisRepository diagnosisRepository) {
			this.medicalExaminationView = medicalExaminationView;
			this.medicalRecordRepository = medicalRecordRepository;
			this.diagnosisRepository = diagnosisRepository;

			medicalRecord = medicalRecordRepository.GetMedicalRecordByPatient(patient);
			currentMedicalExamination = new MedicalExamination(AuthService.LoggedInEmployee);

			updateView();
		}

		public MedicalExaminationPresenter(MedicalExamination medicalExamination, IMedicalExaminationView medicalExaminationView) : this(medicalExamination, medicalExaminationView, MedicalRecordRepository.Instance, DiagnosisRepository.Instance) { }

		public MedicalExaminationPresenter(MedicalExamination medicalExamination, IMedicalExaminationView medicalExaminationView, IMedicalRecordRepository medicalRecordRepository, IDiagnosisRepository diagnosisRepository) {
			this.medicalExaminationView = medicalExaminationView;
			this.medicalRecordRepository = medicalRecordRepository;
			this.diagnosisRepository = diagnosisRepository;

			medicalRecord = null;
			currentMedicalExamination = medicalExamination;

			updateView();
			
		}

		#endregion

		#region Methods

		private void updateView() {
			medicalExaminationView.MedicalExamination = currentMedicalExamination;
			medicalExaminationView.Diagnoses = diagnosisRepository.GetAll();
		}

		public void AddMedicalReference() {
			currentMedicalExamination.AddMedicalReference(medicalExaminationView.MedicalReference);
			updateView();
		}

		public void RemoveMedicalReference() {
			currentMedicalExamination.RemoveTherapy(medicalExaminationView.Therapy);
			updateView();
		}

		public void AddTherapy() {
			currentMedicalExamination.AddTherapy(medicalExaminationView.Therapy);
			updateView();
		}

		public void RemoveTherapy() {
			currentMedicalExamination.RemoveMedicalReference(medicalExaminationView.MedicalReference);
			updateView();
		}

		public void SaveMedicalExamination() {
			MedicalCase medicalCase = new MedicalCase(medicalExaminationView.MedicalCaseTitle, medicalExaminationView.SelectedDiagnosis) {
				Id = Guid.NewGuid(),
				Date = currentMedicalExamination.Date
			};
			currentMedicalExamination.MedicalCase = medicalCase;
			medicalRecord.AddMedicalExamination(currentMedicalExamination);
			medicalRecordRepository.Save(medicalRecord);
		}

		#endregion

	}
}
