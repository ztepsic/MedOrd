using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	public class WaitingRoom {

		#region Members

		#region Singleton

		private static readonly WaitingRoom instance = new WaitingRoom();

		public static WaitingRoom Instance {
			get { return WaitingRoom.instance; }
		}

		#endregion

		#region Observer

		public delegate void Callback();

		public event Callback Notify;

		#endregion

		/// <summary>
		/// Red pacijenata
		/// </summary>
		private Queue<Patient> patientsQueue;

		/// <summary>
		/// Dohvat svih pacijenata u redu
		/// </summary>
		public IList<Patient> PatientsQueue {
			get { return patientsQueue.ToArray<Patient>(); }
		}

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		private WaitingRoom() {
			patientsQueue = new Queue<Patient>();
		}

		#endregion

		#region Methods

		/// <summary>
		/// Dodaje pacijenta u sobu za cekanje
		/// </summary>
		/// <param name="patient"></param>
		public void AddPatientInWaitingRoom(Patient patient) {
			patientsQueue.Enqueue(patient);
			if (Notify != null) {
				Notify();
			}

		}

		/// <summary>
		/// Dohvaca slijedeceg pacijenta na redu
		/// </summary>
		/// <returns></returns>
		public Patient GetNextPatient() {
			Patient patient = patientsQueue.Dequeue();
			Notify();
			return patient;
		}

		#endregion

	}
}
