using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.ViewInterfaces;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.DomainModel;
using MedOrd.Infrastructure.DataAccessLayer;

namespace MedOrd.Presenter {
	public class MedicalReferencePresenter {

		#region Members

		private IMedicalReferenceView medicalReferenceView;
		private IMedicalCareActivityRepository medicalCareActivityRepository;
		private IMedicalInstitutionRepository medicalInstitutionRepository;

		private MedicalReference medicalReference = null;

		public MedicalReference MedicalReference {
			get { return medicalReference; }
		}

		private Diagnosis diagnosis = null;
		private Patient patient = null;

		#endregion

		#region Constructors and Init

		public MedicalReferencePresenter(Patient patient, Diagnosis diagnosis, IMedicalReferenceView medicalReferenceView) : 
			this(patient, diagnosis, medicalReferenceView, MedicalCareActivityRepository.Instance, MedicalInstitutionRepository.Instance) { }

		public MedicalReferencePresenter(Patient patient, Diagnosis diagnosis, IMedicalReferenceView medicalReferenceView, IMedicalCareActivityRepository medicalCareActivityRepository, IMedicalInstitutionRepository medicalInstitutionRepository) {
			this.medicalReferenceView = medicalReferenceView;
			this.medicalCareActivityRepository = medicalCareActivityRepository;
			this.medicalInstitutionRepository = medicalInstitutionRepository;
			this.diagnosis = diagnosis;
			this.patient = patient;

			initView();
		}

		public MedicalReferencePresenter(MedicalReference medicalReference, IMedicalReferenceView medicalReferenceView) : this(medicalReference, medicalReferenceView, MedicalCareActivityRepository.Instance, MedicalInstitutionRepository.Instance) { }

		public MedicalReferencePresenter(MedicalReference medicalReference, IMedicalReferenceView medicalReferenceView, IMedicalCareActivityRepository medicalCareActivityRepository, IMedicalInstitutionRepository medicalInstitutionRepository) {
			this.medicalReferenceView = medicalReferenceView;
			this.medicalCareActivityRepository = medicalCareActivityRepository;
			this.medicalInstitutionRepository = medicalInstitutionRepository;
			this.diagnosis = medicalReference.Diagnosis;

			this.medicalReference = medicalReference;
			populateViewWithExistingData();
		}

		#endregion

		#region Methods

		private void initView() {
			medicalReferenceView.MedicalCareActivities = medicalCareActivityRepository.GetAll();
			medicalReferenceView.MedicalInstitutions = medicalInstitutionRepository.GetAll();
			medicalReferenceView.Diagnosis = diagnosis.Title;
		}

		private void populateViewWithExistingData(){
			initView();

			medicalReferenceView.SelectedMedicalInstitution = medicalReference.MedicalInstitution;
			medicalReferenceView.SelectedMedicalCareActivitiy = medicalReference.MedicalCareActivity;
			medicalReferenceView.Diagnosis = diagnosis.Title;
			medicalReferenceView.WantedFor = medicalReference.Wanted;

		}

		public bool SaveMedicalReference() {
			medicalReference = new MedicalReference(patient, medicalReferenceView.SelectedMedicalInstitution, medicalReferenceView.SelectedMedicalCareActivitiy, diagnosis) {
				Wanted = medicalReferenceView.WantedFor
			};
			return true;
		}

		public void CancelMedicalReference() {
			medicalReference = null;
		}

		#endregion

	}
}
