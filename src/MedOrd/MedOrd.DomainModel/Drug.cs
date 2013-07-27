using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	public class Drug : PersistentObject {

		#region Members

		/// <summary>
		/// Dohvaca ili postavlja naziv lijeka
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Dohvaca ili postavlja genericko ime lijeka
		/// </summary>
		public string GenericName { get; set; }

		/// <summary>
		/// Dohvaca ili postavlja opis lijeka
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Dohvaca ili postavlja proizvodjaca lijeka
		/// </summary>
		public string Manufacturer { get; set; }

		/// <summary>
		/// Dohvaca ili postavlja kolicinu lijekova u kutiji
		/// </summary>
		public int QuantityInBox { get; set; }

		#endregion

		#region Construcotrs and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="name">naziv lijeka</param>
		/// <param name="genericName">genericki naziv lijeka</param>
		/// <param name="manufacturer">proizvodjac lijeka</param>
		/// <param name="quantityInBox">kolicina lijekova u kutiji</param>
		public Drug(string name, string genericName, string manufacturer, int quantityInBox) {
			Name = name;
			GenericName = genericName;
			Manufacturer = manufacturer;
			QuantityInBox = quantityInBox;
		}

		#endregion

		#region Methods

		public override string ToString() {
			return Name; 
		}

		#endregion
	}
}
