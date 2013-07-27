using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	public class MedicalReference : PersistentObject {

		#region Members


		/// <summary>
		/// Dohvaca ili postavlja djelatnost zdravstvene zastite
		/// </summary>
		public MedicalCareActivity MedicalCareActivity { get; set; }

		public string MedicalCareActivityTitle {
			get { return MedicalCareActivity.Title; }
		}

		/// <summary>
		/// Postavlja ili dohvaca ustanovu za provodjenje djelatnosti zdravstvene
		/// zastite
		/// </summary>
		public MedicalInstitution MedicalInstitution { get; set; }

		public string MedicalInstitutionName {
			get { return MedicalInstitution.Name; }
		}


		/// <summary>
		/// Dohvaca ili postavlja dijagnozu za koju se upucuje pacijenta
		/// </summary>
		public Diagnosis Diagnosis { get; set; }

		public string DiagnosisTitle {
			get { return Diagnosis.Title; }
		}

		/// <summary>
		/// Dohvaca ili postavlja pacijenta koji se upucuje
		/// </summary>
		public Patient Patient { get; set; }

		/// <summary>
		/// Dohvaca ili postavlja svrhu upucivanja pacijenta
		/// </summary>
		public string Wanted { get; set; }

		#endregion

		#region Constructors and Init

		public MedicalReference(Patient patient, MedicalInstitution medicalInstitution,
			MedicalCareActivity medicalCareActivity, Diagnosis diagnosis) {
			Patient = patient;
			MedicalInstitution = medicalInstitution;
			MedicalCareActivity = medicalCareActivity;
			Diagnosis = diagnosis;

			Wanted = string.Empty;
		}

		#endregion

		#region Methods
		#endregion

	}
}
