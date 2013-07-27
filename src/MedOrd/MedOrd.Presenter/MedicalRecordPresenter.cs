using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.ViewInterfaces;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.Infrastructure.DataAccessLayer;
using MedOrd.DomainModel;
using MedOrd.DomainModel.Services;
using MedOrd.DomainModel.Enumerations;
using MedOrd.DomainModel.Exceptions;

namespace MedOrd.Presenter {
	public class MedicalRecordPresenter {

		#region Members

		private IMedicalRecordView medicalRecordView;
		private IMedicalRecordRepository medicalRecordRepository;

		private Patient patient = null;

		#endregion

		#region Constructors and Init

		public MedicalRecordPresenter(IMedicalRecordView medicalRecordView, Patient patient) : this(medicalRecordView, patient, MedicalRecordRepository.Instance) { }

		public MedicalRecordPresenter(IMedicalRecordView medicalRecordView, Patient patient, IMedicalRecordRepository medicalRecordRepository) {
			if (!AuthService.LoggedInEmployee.EmployeeRoles.Contains(EmployeeRole.Doctor)) {
				throw new NotDoctorException();
			}

			this.medicalRecordView = medicalRecordView;
			this.medicalRecordRepository = medicalRecordRepository;
			this.patient = patient;

			Update();
			
		}

		#endregion

		#region Methods

		public void Update() {
			MedicalRecord mRec = medicalRecordRepository.GetMedicalRecordByPatient(patient);
			medicalRecordView.MedicalRecord = mRec;
		}

		#endregion

	}
}
