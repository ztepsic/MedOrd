using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	public abstract class PersistentObject {

		#region Members

		private Guid id;

		/// <summary>
		/// Identifikator
		/// </summary>
		public Guid Id {
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// Dohvava informaciju da li je objekt perzistentan
		/// </summary>
		public bool IsPersistent {
			get { return isPersistentObject(); }
		}

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		public PersistentObject() {
			id = Guid.Empty;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Provjerava da li je objekt perzistentan
		/// </summary>
		/// <returns></returns>
		private bool isPersistentObject() {
			return (Id != Guid.Empty);
		}

		/// <summary>
		/// Provjerava da li su dva objekta jednaka
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj) {
			if (IsPersistent) {
				PersistentObject persistentObject = obj as PersistentObject;
				return ((persistentObject.IsPersistent) && (Id == persistentObject.Id));
			} else {
				return base.Equals(obj);
			}
		}

		public override int GetHashCode() {
			return (IsPersistent ? Id.GetHashCode() : base.GetHashCode());
		}

		#endregion

	}
}