using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.DomainModel;

namespace MedOrd.Infrastructure.DataAccessLayer {
	public class PatientRepository : IPatientRepository {

		#region Members

		private static readonly PatientRepository instance = new PatientRepository();

		public static PatientRepository Instance {
			get { return PatientRepository.instance; }
		}

		private IPersonRepository personRepository;

		private readonly IList<Patient> patients;

		#endregion

		#region Constructors and Init

		private PatientRepository() {
			this.personRepository = PersonRepository.Instance;
			patients = new List<Patient>();

			generatePatients();
		}

		private void generatePatients() {
			Patient patient = null;

			patient = new Patient(12345678, 123456789, personRepository.GetByFullName("Mato", "Lovrak")) {
				Id = Guid.NewGuid()
			};
			patients.Add(patient);

			patient = new Patient(12345678, 123456789, personRepository.GetByFullName("August", "Šenoa")) {
				Id = Guid.NewGuid()
			};
			patients.Add(patient);

		}

		#endregion

		#region Methods

		#region IRepository<Patient> Members

		public MedOrd.DomainModel.Patient GetById(Guid id) {
			var patient = (from p in patients
						   where p.Id == id
						   select p).SingleOrDefault<Patient>();
			return patient;
		}

		public void Save(MedOrd.DomainModel.Patient entity) {
			if (entity.Id == Guid.Empty) {
				entity.Id = Guid.NewGuid();
			} else {
				Delete(entity);
			}

			patients.Add(entity);
		}

		public IList<MedOrd.DomainModel.Patient> GetAll() {
			return patients;
		}

		public void Delete(MedOrd.DomainModel.Patient entity) {
			patients.Remove(entity);
		}

		#endregion

		#region IPatientRepository Members

		public IList<Patient> GetPatientsByFullName(string name, string surname) {
			var patientsResult = (from p in patients
								  where (p.Person.Name.ToLower().StartsWith(name.ToLower()) && p.Person.Surname.ToLower().StartsWith(surname.ToLower())) ||
								  (p.Person.Surname.ToLower().Contains(surname.ToLower()) && p.Person.Name == String.Empty)
								  select p);
			return patientsResult.ToList<Patient>();
		}

		#endregion

		#endregion

	}
}
