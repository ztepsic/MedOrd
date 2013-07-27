using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel.Enumerations;

namespace MedOrd.DomainModel {
	public class Therapy : PersistentObject {

		#region Members

		/// <summary>
		/// Datum propisivanja terapije
		/// </summary>
		private DateTime date;

		/// <summary>
		/// Dohvaca datum propisivanja terapije
		/// </summary>
		public DateTime Date {
			get { return date; }
		}

		/// <summary>
		/// Naziv terapije
		/// </summary>
		private string title;

		/// <summary>
		/// Dohvaca ili postavlja naziv terapije
		/// </summary>
		public string Title {
			get { return title; }
			set { title = value; }
		}

		/// <summary>
		/// Opis terapije
		/// </summary>
		private string description;

		/// <summary>
		/// Dohvaca ili postavlja opis terapije
		/// </summary>
		public string Description {
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Lijek za terapiju
		/// </summary>
		private Drug therapyDrug;

		/// <summary>
		/// Dohvaca ili postavlja lijek za terapiju
		/// </summary>
		public Drug TherapyDrug {
			get { return therapyDrug; }
			set { therapyDrug = value; }
		}

		public string TherapyDrugName {
			get { return therapyDrug.Name; }
		}

		/// <summary>
		/// Doza lijeka za terapiju
		/// </summary>
		private int dosage;

		/// <summary>
		/// Dohvaca ili postavlja dozu lijeka za terapiju
		/// </summary>
		public int Dosage {
			get { return dosage; }
			set { dosage = value; }
		}

		/// <summary>
		/// Broj uzimanja terapija dnevno
		/// </summary>
		private int perDay;

		/// <summary>
		/// Dohvaca ili postavlja broj uzimanja terapija dnevno
		/// </summary>
		public int PerDay {
			get { return perDay; }
			set { perDay = value; }
		}


		/// <summary>
		/// Broj kutija lijekova potrebnih za terapiju
		/// </summary>
		private int boxQuantity;

		/// <summary>
		/// Dohvaca ili postavlja broj kutija lijekova potrebnih za terapiju
		/// </summary>
		public int BoxQuantity {
			get { return boxQuantity; }
			set { boxQuantity = value; }
		}

		public decimal TherapyProgress {
			get { return getTherapyProgress(); }
		}

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="doctor">lijecnik koji je propisao terapiju</param>
		/// <param name="patient">pacijent kojemu se propisuje terapija</param>
		/// <param name="title">naziv terapije</param>
		/// <param name="description">opis terapije</param>
		public Therapy(string title, string description) {
			this.title = title;
			this.description = description;
			date = DateTime.Now;

			dosage = 1;
			perDay = 1;
			boxQuantity = 1;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Dohvaca postotak iskoristenja terapije
		/// </summary>
		/// <returns></returns>
		private decimal getTherapyProgress() {
			int drugItems = boxQuantity * therapyDrug.QuantityInBox;
			TimeSpan interval = DateTime.Now.Subtract(date);
			int daysElapsed = interval.Days;

			if (daysElapsed > drugItems) {
				return 100;
			} else {
				decimal usedTherapy = ((daysElapsed * perDay) / drugItems) * 100;

				return usedTherapy;
			}
		}

		public override string ToString() {
			return Title;
		}

		#endregion

	}
}
