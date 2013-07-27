using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.ViewInterfaces;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.Infrastructure.DataAccessLayer;
using MedOrd.DomainModel;

namespace MedOrd.Presenter {
	public class PatientPresenter {

		#region Members

		private readonly IPatientView patientView;
		private IPatientRepository patientRepository;
		private ICityRepository cityRepository;
		private IMedicalRecordRepository medicalRecordRepository;

		#endregion

		#region Constructors and Init

		public PatientPresenter(IPatientView patientView) : this(patientView, PatientRepository.Instance, CityRepository.Instance, MedicalRecordRepository.Instance) { }

		public PatientPresenter(IPatientView patientView, IPatientRepository patientRepository, ICityRepository cityRepository, IMedicalRecordRepository medicalRecordRepository) {
			this.patientView = patientView;
			this.patientRepository = patientRepository;
			this.cityRepository = cityRepository;
			this.medicalRecordRepository = medicalRecordRepository;
		}

		#endregion

		#region Methods

		public void GeneralInit() {
			patientView.Cities = cityRepository.GetAll();
		}

		public void InitForNewPatientView() {
			patientView.PersonName = string.Empty;
			patientView.PersonSurname = string.Empty;
			patientView.Jmbg = string.Empty;
			patientView.BirthDate = DateTime.Now;
			patientView.CardNumber = 0;
			patientView.NumberOfInsuredPerson = 0;
			patientView.PatientId = Guid.Empty;
			patientView.PersonId = Guid.Empty;
		}

		public bool SavePatient() {
			Person person = new Person(patientView.PersonName, patientView.PersonSurname, patientView.Jmbg);
			person.BirthDate = patientView.BirthDate;
			Address address = new Address(patientView.Street, patientView.StreetNumber, patientView.SelectedCity);
			person.Address = address;

			Patient patient = new Patient(patientView.NumberOfInsuredPerson, patientView.CardNumber, person);

			if (patientView.PersonId != null) {
				patient.Id = patientView.PersonId;
				patient.Person.Id = patientView.PatientId;
			}

			patientRepository.Save(patient);

			MedicalRecord medRecord = new MedicalRecord(patient, EmployeeRepository.Instance.GetByUsername("ztepsic"), DateTime.Now);
			medicalRecordRepository.Save(medRecord);

			return true;
		}

		#endregion

	}
}
