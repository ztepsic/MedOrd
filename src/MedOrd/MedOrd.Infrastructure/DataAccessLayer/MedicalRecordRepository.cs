using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.DomainModel;

namespace MedOrd.Infrastructure.DataAccessLayer {
	public class MedicalRecordRepository : IMedicalRecordRepository {

		#region Members

		#region Singleton

		private static readonly MedicalRecordRepository instance = new MedicalRecordRepository();

		public static MedicalRecordRepository Instance {
			get { return MedicalRecordRepository.instance; }
		}

		#endregion

		IList<MedicalRecord> medicalRecords;

		#endregion

		#region Constructors and Init

		private MedicalRecordRepository() {
			medicalRecords = new List<MedicalRecord>();

			generateMedicalRecord();
		}

		private void generateMedicalRecord() {
			EmployeeRepository employeeRepo = EmployeeRepository.Instance;
			Employee doctor = employeeRepo.GetByUsername("ztepsic");

			PatientRepository patientRepo = PatientRepository.Instance;
			Patient patient = patientRepo.GetPatientsByFullName("Mato", "Lovrak")[0];

			MedicalRecord medicalRecord = new MedicalRecord(patient, doctor, DateTime.Now) {
				Id = Guid.NewGuid()
			};

			medicalRecords.Add(medicalRecord);


			patient = patientRepo.GetPatientsByFullName("August", "Šenoa")[0];

			medicalRecord = new MedicalRecord(patient, doctor, DateTime.Now) {
				Id = Guid.NewGuid()
			};

			medicalRecords.Add(medicalRecord);

		}

		#endregion

		#region Methods

		#region IMedicalRecordRepository Members

		public MedicalRecord GetMedicalRecordByPatient(Patient patient) {
			var medicalRecord = (from m in medicalRecords
								 where m.Patient == patient
								 select m).SingleOrDefault<MedicalRecord>();
			return medicalRecord;
		}

		#endregion

		#region IRepository<MedicalRecord> Members

		public MedOrd.DomainModel.MedicalRecord GetById(Guid id) {
			var medicalRecord = (from m in medicalRecords
									  where m.Id == id
									  select m).SingleOrDefault<MedicalRecord>();
			return medicalRecord;
		}

		public void Save(MedOrd.DomainModel.MedicalRecord entity) {
			if (entity.Id == Guid.Empty) {
				entity.Id = Guid.NewGuid();
			} else {
				Delete(entity);
			}

			medicalRecords.Add(entity);
		}

		public IList<MedOrd.DomainModel.MedicalRecord> GetAll() {
			return medicalRecords;
		}

		public void Delete(MedOrd.DomainModel.MedicalRecord entity) {
			medicalRecords.Remove(entity);
		}


		#endregion

		#endregion
	}
}
