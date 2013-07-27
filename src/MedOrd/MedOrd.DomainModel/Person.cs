using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	public class Person : PersistentObject {

		#region Members

		/// <summary>
		/// Dohvaca ili postavlja ime osobe
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Dohvaca ili postavlja prezime osobe
		/// </summary>
		public string Surname { get; set; }

		public string FullName {
			get { return Name + " " + Surname; }
		}

		/// <summary>
		/// Dohvaca ili postavlja datum rodenja osobe
		/// </summary>
		public DateTime BirthDate { get; set; }


		/// <summary>
		/// Postavlja ili dohvaca jmbg osobe
		/// </summary>
		public String Jmbg { get; set; }

		/// <summary>
		/// Dohvaca ili postavlja adresu osobe
		/// </summary>
		public Address Address { get; set; }

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="name">ime sobe</param>
		/// <param name="surname">prezime osobe</param>
		/// <param name="jmbg">jmbg osobe</param>
		public Person(string name, string surname, string jmbg) {
			Name = name;
			Surname = surname;
			Jmbg = jmbg;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Provjerava da li su dva objekta jednaka
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj) {
			Person person = obj as Person;
			if (this.Jmbg.Equals(person.Jmbg)) {
				return true;
			} else {
				return false;
			}
		}

		#endregion
		
	}
}
