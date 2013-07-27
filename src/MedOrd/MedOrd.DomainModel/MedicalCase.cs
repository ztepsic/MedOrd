using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel.Enumerations;

namespace MedOrd.DomainModel {
	public class MedicalCase : PersistentObject {

		#region Members

		/// <summary>
		/// Dohvaca ili postavlja naziv medicinskog slucaja
		/// </summary>
		public string Title { get; set; }


		/// <summary>
		/// Dohvaca ili postavlja datum
		/// </summary>
		public DateTime Date { get; set; }


		/// <summary>
		/// Dijagnoza
		/// </summary>
		private readonly Diagnosis diagnosis;

		/// <summary>
		/// Dohvaca dijagnozu
		/// </summary>
		public Diagnosis Diagnosis {
			get { return diagnosis; }
		} 


		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="title">naziv medicinskog slucaja</param>
		/// /// <param name="diagnosis">dijagnoza</param>
		public MedicalCase(string title, Diagnosis diagnosis) {
			Title = title;
			this.diagnosis = diagnosis;
		}

		#endregion

		#region Methods

		public override string ToString() {
			return Title;
		}

		#endregion

	}
}
