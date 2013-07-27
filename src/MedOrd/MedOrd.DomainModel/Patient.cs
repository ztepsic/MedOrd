using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	public class Patient : PersonRole {

		#region Members

		/// <summary>
		/// Dohvaca ili postavlja broj osigurane osobe
		/// </summary>
		public int NumberOfInsuredPerson { get; set; }

		/// <summary>
		/// Dohvaca ili postavlja broj zdravstvene iskaznice
		/// </summary>
		public int CardNumber { get; set; }

		public string FullName {
			get { return Person.FullName; }
		}

		public string Jmbg {
			get { return Person.Jmbg; }
		}
		

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="numberOfInsuredPerson">broj osigurane osobe</param>
		/// <param name="cardNumber">broj zdravstvene iskaznice</param>
		/// <param name="person">soba</param>
		public Patient(int numberOfInsuredPerson, int cardNumber, Person person) : base(person){
			NumberOfInsuredPerson = numberOfInsuredPerson;
			CardNumber = cardNumber;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Provjerava da li su dva objekta jednaka
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj) {
			Patient patient = obj as Patient;
			if (this.NumberOfInsuredPerson.Equals(patient.NumberOfInsuredPerson) ||
				this.CardNumber.Equals(patient.CardNumber)) {
				return true;
			} else {
				return false;
			}
		}

		public override string ToString() {
			return FullName;
		}

		#endregion
	}
}
