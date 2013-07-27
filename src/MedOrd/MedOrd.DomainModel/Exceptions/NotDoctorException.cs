using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel.Exceptions {
	/// <summary>
	/// Razred koji predstavlja nepostojanje doktora
	/// </summary>
	public class NotDoctorException : Exception {

		#region Members

		public override string Message {
			get {
				return "Navedeni objekt nema ulogu doktora.";
			}
		}

		#endregion

		#region Constructors and Init
		#endregion

		#region Methods
		#endregion

	}
}
