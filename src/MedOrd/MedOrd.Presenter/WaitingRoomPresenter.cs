using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel;
using MedOrd.ViewInterfaces;

namespace MedOrd.Presenter {
	public class WaitingRoomPresenter {

		#region Members

		private IWaitingRoomView waitingRoomView;

		private WaitingRoom waitingRoom;

		#endregion

		#region Construcotrs and Init

		public WaitingRoomPresenter(IWaitingRoomView waitingRoomView) {
			this.waitingRoomView = waitingRoomView;

			waitingRoom = WaitingRoom.Instance;
			waitingRoom.Notify += new WaitingRoom.Callback(updateWaitingRoom);

			updateWaitingRoom();
		}

		#endregion

		#region Methods

		private void updateWaitingRoom() {
			waitingRoomView.Patients = waitingRoom.PatientsQueue;
		}

		public void GetNextPatient() {
			waitingRoomView.SelectedPatient = waitingRoom.GetNextPatient();
		}

		#endregion

	}
}
