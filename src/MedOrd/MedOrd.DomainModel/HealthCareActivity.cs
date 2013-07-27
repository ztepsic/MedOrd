using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	public class HealthCareActivity {

		#region Members

		/// <summary>
		/// Identifikator djelatnosti zdravstvene zastite
		/// </summary>
		private int id;

		/// <summary>
		/// Dohvaca ili postavlja identifikator djelaznosti zdravstvene zastite
		/// </summary>
		public int Id {
			get { return id; }
			set { id = value; }
		}


		/// <summary>
		/// Naziv djelatnosti zdravstvene zastite
		/// </summary>
		private string title;

		/// <summary>
		/// Dohvaca ili postavlja naziv djelatnosti zdravstvene zastite
		/// </summary>
		public string Title {
			get { return title; }
			set { title = value; }
		}

		#endregion

		#region Constructors and Init
		#endregion

		#region Methods
		#endregion

	}
}
