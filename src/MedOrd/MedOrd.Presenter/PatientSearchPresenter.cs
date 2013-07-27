using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.ViewInterfaces;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.Infrastructure.DataAccessLayer;
using MedOrd.DomainModel;

namespace MedOrd.Presenter {
	public class PatientSearchPresenter {

		#region Members

		private IPatientSearchView patientSearchView;
		private IPatientRepository patientRepository;

		private WaitingRoom waitingRoom;

		#endregion

		#region Constructors and Init

		public PatientSearchPresenter(IPatientSearchView patientSearchView) : this(patientSearchView, PatientRepository.Instance) { }

		public PatientSearchPresenter(IPatientSearchView patientSearchView, IPatientRepository patientRepository) {
			this.patientSearchView = patientSearchView;
			this.patientRepository = patientRepository;

			waitingRoom = WaitingRoom.Instance;
		}

		#endregion

		#region Methods

		public void SearchForPatient() {
			string name = patientSearchView.PatientName;
			string surname = patientSearchView.PatientSurname;
			patientSearchView.Patients = patientRepository.GetPatientsByFullName(name, surname);
		}

		public bool AddPatientToWaitingRoom() {
			waitingRoom.AddPatientInWaitingRoom(patientSearchView.SelectedPatient);
			return true;
		}

		#endregion

	}
}
