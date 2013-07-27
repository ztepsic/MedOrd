using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	public class MedicalInstitution : PersistentObject {

		#region Members

		/// <summary>
		/// Dohvaca ili postavlja naziv medicinske ustanove
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Popis djelatnosti medicinske ustanove
		/// </summary>
		private IList<MedicalCareActivity> medicalCareActivities;

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="name">naziv medicinske ustanove</param>
		public MedicalInstitution(string name) {
			Name = name;

			medicalCareActivities = new List<MedicalCareActivity>();
		}

		#endregion

		#region Methods

		/// <summary>
		/// Dodaje djelatnost ustanovi
		/// </summary>
		/// <param name="medicalCareActivity"></param>
		public void AddMedicalCareActivity(MedicalCareActivity medicalCareActivity) {
			medicalCareActivities.Add(medicalCareActivity);
		}

		/// <summary>
		/// Brise djelatnost ustanove
		/// </summary>
		/// <param name="medicalCareActivity"></param>
		public void RemoveMedicalCareActivity(MedicalCareActivity medicalCareActivity) {
			medicalCareActivities.Remove(medicalCareActivity);
		}

		/// <summary>
		/// Dohvaca djelatnosti ustanove
		/// </summary>
		/// <returns></returns>
		public MedicalCareActivity[] GetMedicalCareActivities() {
			return medicalCareActivities.ToArray<MedicalCareActivity>();
		}

		public override string ToString() {
			return Name;
		}

		#endregion

	}
}
