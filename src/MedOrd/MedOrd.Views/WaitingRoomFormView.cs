using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedOrd.ViewInterfaces;
using MedOrd.DomainModel;
using MedOrd.Presenter;
using MedOrd.DomainModel.Exceptions;

namespace MedOrd.Views {
	public partial class WaitingRoomFormView : Form, IWaitingRoomView {

		#region Members

		private WaitingRoomPresenter waitingRoomPresenter;

		#region IWaitingRoomView Members

		public IList<MedOrd.DomainModel.Patient> Patients {
			set { patientBindingSource.DataSource = value; }
		}

		public MedOrd.DomainModel.Patient SelectedPatient {
			get {
				if (waitingRoomDataGridView.Rows.Count > 0) {
					return waitingRoomDataGridView.CurrentRow.DataBoundItem as Patient;
				} else {
					return null;
				}
				
			}
			set {
				if (waitingRoomDataGridView.Rows.Count > 0) {
					waitingRoomDataGridView.Rows[0].Selected = true;
				}
				
			}
		}

		#endregion

		#endregion

		#region Constructors and Init

		public WaitingRoomFormView() {
			InitializeComponent();
		}


		private void WaitingRoomFormView_Load(object sender, EventArgs e) {
			waitingRoomPresenter = new WaitingRoomPresenter(this);	
		}


		#endregion


		#region Methods


		private void addPatientToolStripButton_Click(object sender, EventArgs e) {
			PatientSearchFormView patientSearchFormView = new PatientSearchFormView();
			patientSearchFormView.ShowDialog();
		}

		private void waitingRoomDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			MedicalRecordFormView medRecFormView = null;

			try {
				medRecFormView = new MedicalRecordFormView(SelectedPatient);
			} catch (NotDoctorException ex) {
				MessageBox.Show("Niste autorizirani za otvaranje kartona pacijenta. Samo doktori imaju navedenu autorizaciju.",
						"Nedovoljna autorizacija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			medRecFormView.MdiParent = this.MdiParent;
			medRecFormView.Show();
			waitingRoomPresenter.GetNextPatient();
		}

		#endregion
		
	}
}
