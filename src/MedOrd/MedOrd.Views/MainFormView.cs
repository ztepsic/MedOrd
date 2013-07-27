using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedOrd.ViewInterfaces;
using MedOrd.Presenter;
using MedOrd.DomainModel;

namespace MedOrd.Views {
	public partial class MainFormView : Form, IMainView {

		#region Members

		private MainPresenter mainPresenter;

		#endregion

		#region Constructors and Init

		public MainFormView() {
			InitializeComponent();
		}

		private void MainFormView_Load(object sender, EventArgs e) {
			mainPresenter = new MainPresenter(this);
				
		}

		#endregion

		#region Methods

		private void noviPacijentToolStripMenuItem_Click(object sender, EventArgs e) {
			PatientFormView newPatientFormView = new PatientFormView();
			newPatientFormView.ShowDialog();
		}

		private void otvoriKartonPacijentaToolStripMenuItem_Click(object sender, EventArgs e) {
			PatientSearchFormView patientSearchFormView = new PatientSearchFormView();
			patientSearchFormView.MdiParent = this;
			patientSearchFormView.Show();
		}

		private void izlazToolStripMenuItem1_Click(object sender, EventArgs e) {
			Close();
		}

		private void pregledToolStripMenuItem_Click(object sender, EventArgs e) {
			MedicalExaminationFormView medicalExaminationFormView = new MedicalExaminationFormView();
			medicalExaminationFormView.MdiParent = this;
			medicalExaminationFormView.Show();

		}

		private void cekaonicaToolStripMenuItem_Click(object sender, EventArgs e) {
			WaitingRoomFormView waitingRoomFormView = new WaitingRoomFormView();
			waitingRoomFormView.MdiParent = this;
			waitingRoomFormView.Show();
		}

		#endregion

	}
}
