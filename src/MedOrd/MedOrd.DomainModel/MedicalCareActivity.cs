using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	public class MedicalCareActivity : PersistentObject {

		#region Members

		/// <summary>
		/// Dohvaca ili postavlja naziv djelatnosti zdravstvene zastite
		/// </summary>
		public string Title { get; set; }

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="title">naziv djelatnosti zdravstvene zastite</param>
		public MedicalCareActivity(string title) {
			Title = title;
		}

		#endregion

		#region Methods

		public override string ToString() {
			return Title;
		}

		#endregion

	}
}
