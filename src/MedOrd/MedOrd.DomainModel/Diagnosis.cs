using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	public class Diagnosis : PersistentObject {

		#region Members

		/// <summary>
		/// Dohvaca ili postavlja naziv dijagnoze
		/// </summary>
		public string Title { get; set; }

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="title">naziv dijagnoze</param>
		public Diagnosis(string title) {
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
