using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel.Enumerations;
using MedOrd.DomainModel.Exceptions;

namespace MedOrd.DomainModel {
	public class MedicalExamination : PersistentObject {

		#region Members

		/// <summary>
		/// Dohvaca ili postavlja datum pregleda
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// Doktor koji obavlja pregled pacijenta
		/// </summary>
		private Employee doctor = null;

		/// <summary>
		/// Dohvaca ili postavlja doktora koji obavlja pregled pacijenta
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
		/// Dohvaca ili postavlja anamnezu pacijenta
		/// </summary>
		public string Anamnesis { get; set; }

		/// <summary>
		/// Dohvaca ili postavlja preporuku lijecnika
		/// </summary>
		public string Recommendation { get; set; }

		/// <summary>
		/// Terapije koje su propisane u ovome pregledu
		/// </summary>
		private IList<Therapy> therapies;

		/// <summary>
		/// Dohvaca terapije koje su propisane u ovome pregledu
		/// </summary>
		public IList<Therapy> Therapies {
			get { return therapies; }
		}

		/// <summary>
		/// Uputnice propisane u ovome pregledu
		/// </summary>
		private IList<MedicalReference> medicalReferences;

		/// <summary>
		/// Dohvaca uputnice propisane u ovome pregledu
		/// </summary>
		public IList<MedicalReference> MedicalReferences {
			get { return medicalReferences; }
		}


		/// <summary>
		/// Dohvaca ili postavlja medicinski slucaj
		/// </summary>
		public MedicalCase MedicalCase { get; set; }

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="doctor">doktor koji pregledava pacijenta</param>
		public MedicalExamination(Employee doctor) {
			Doctor = doctor;
			Date = DateTime.Now;

			therapies = new List<Therapy>();
			medicalReferences = new List<MedicalReference>();
			MedicalCase = new MedicalCase(string.Empty, null);

			Anamnesis = string.Empty;
			Recommendation = string.Empty;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Dodaje terapiju pacijentu
		/// </summary>
		/// <param name="therapy"></param>
		public void AddTherapy(Therapy therapy) {
			therapies.Add(therapy);
		}

		/// <summary>
		/// Brise terapiju iz liste terapija
		/// </summary>
		/// <param name="therapy">terapija koja se brise</param>
		public void RemoveTherapy(Therapy therapy) {
			therapies.Remove(therapy);
		}

		/// <summary>
		/// Dodaje uputnicu pacijentu
		/// </summary>
		/// <param name="medicalReference">uputnica koja se daje pacijentu</param>
		public void AddMedicalReference(MedicalReference medicalReference) {
			medicalReference.Id = Guid.NewGuid();
			medicalReferences.Add(medicalReference);
		}

		/// <summary>
		/// Brise uputicnu pacijenta
		/// </summary>
		/// <param name="medicalReference"></param>
		public void RemoveMedicalReference(MedicalReference medicalReference) {
			medicalReferences.Remove(medicalReference);
		}

		#endregion

	}
}
