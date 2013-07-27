using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	public abstract class PersonRole : PersistentObject {

		#region Members

		/// <summary>
		/// Osoba
		/// </summary>
		private readonly Person person;

		/// <summary>
		/// Dohvaca osobu
		/// </summary>
		public Person Person {
			get { return person; }
		}

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="person">osoba</param>
		public PersonRole(Person person) {
			this.person = person;
		}

		#endregion

		#region Methods
		#endregion

	}
}
