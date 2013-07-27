using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel.Enumerations;
using MedOrd.DomainModel.Exceptions;

namespace MedOrd.DomainModel {
	public class MedicalRecord : PersistentObject {

		#region Members

		/// <summary>
		/// Pacijent ciji je zdravstveni karton
		/// </summary>
		private Patient patient;

		/// <summary>
		/// Dohvaca pacijenta ciji je karton
		/// </summary>
		public Patient Patient {
			get { return patient; }
		}

		/// <summary>
		/// Datum otvaranja kartona
		/// </summary>
		private readonly DateTime creationDate;

		/// <summary>
		/// Dohvaca datum otvaranja kartona
		/// </summary>
		public DateTime CreationDate {
			get { return creationDate; }
		}

		/// <summary>
		/// Lijecnik pacijenta
		/// </summary>
		private Employee doctor;

		/// <summary>
		/// Dohvaca ili postavlja lijecnika pacijenta
		/// </summary>
		public Employee Doctor {
			get {
				return doctor;
			}
			set {
				if (value.HasEmployeeRole(EmployeeRole.Doctor)) {
					doctor = value;
				} else {
					throw new NotDoctorException();
				}
			}
		}

		/// <summary>
		/// Medicnski pregledi
		/// </summary>
		private IList<MedicalExamination> medicalExaminations;

		/// <summary>
		/// Dohvaca medicinske preglede pacijenta
		/// </summary>
		public IList<MedicalExamination> MedicalExaminations {
			get { return medicalExaminations; }
		}

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor - stvara novi karton pacijenta
		/// </summary>
		/// <param name="patient">pacijent - vlasnik kartona</param>
		/// <param name="creationDate">datum stvaranja kartona</param>
		public MedicalRecord(Patient patient, Employee doctor, DateTime creationDate) {
			this.patient = patient;
			medicalExaminations = new List<MedicalExamination>();
			this.creationDate = creationDate;
			this.doctor = doctor;
		}

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="patient">pacijent - vlasnik kartona</param>
		/// <param name="medicalExaminations">pregledi pacijenta</param>
		public MedicalRecord(Patient patient, Employee doctor, List<MedicalExamination> medicalExaminations) {
			this.patient = patient;
			this.medicalExaminations = medicalExaminations;
			this.doctor = doctor;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Dodaje pregled pacijenta u karton
		/// </summary>
		/// <param name="medicalExamination"></param>
		public void AddMedicalExamination(MedicalExamination medicalExamination) {
			medicalExamination.Id = Guid.NewGuid();
			medicalExaminations.Add(medicalExamination);
		}

		/// <summary>
		/// Dohvaca sve izdane uputnice pacijenta
		/// </summary>
		/// <returns></returns>
		public IList<MedicalReference> GetAllMedicalReferences() {
			List<MedicalReference> medicalReferences = new List<MedicalReference>();
			foreach (MedicalExamination medicalExamination in medicalExaminations) {
				foreach (MedicalReference medicalReference in medicalExamination.MedicalReferences) {
					medicalReferences.Add(medicalReference);
				}
			}

			return medicalReferences;
		}

		/// <summary>
		/// Dohvaca sve terapije pacijenta
		/// </summary>
		/// <returns></returns>
		public IList<Therapy> GetAllTherapies() {
			List<Therapy> therapies = new List<Therapy>();
			foreach (MedicalExamination medicalExamination in medicalExaminations) {
				foreach (Therapy therapy in medicalExamination.Therapies) {
					therapies.Add(therapy);
				}
			}

			return therapies;
		}

		#endregion

	}
}
