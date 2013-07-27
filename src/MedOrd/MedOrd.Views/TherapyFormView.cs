using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedOrd.Presenter;
using MedOrd.ViewInterfaces;
using MedOrd.DomainModel;

namespace MedOrd.Views {
	public partial class TherapyFormView : Form, ITherapyView {

		#region Members

		private TherapyPresenter therapyPresenter;

		#region ITherapyView Members

		public IList<MedOrd.DomainModel.Drug> Drugs {
			set { drugsBindingSource.DataSource = value; }
		}

		public MedOrd.DomainModel.Drug SelectedDrug {
			get {
				return drugsComboBox.SelectedItem as Drug;
			}
			set {
				if (value != null) {
					drugsComboBox.SelectedItem = value;
				}
				
			}
		}

		public MedOrd.DomainModel.Therapy Therapy {
			get {
				return therapyBindingSource.DataSource as Therapy;
			}
			set {
				therapyBindingSource.DataSource = value;
			}
		}

		#endregion

		#endregion

		#region Constructors and Init

		public TherapyFormView(Therapy therapy) {
			InitializeComponent();

			therapyPresenter = new TherapyPresenter(therapy, this);
			cancelButton.Text = "Zatvori";
			drugsComboBox.Enabled = false;
			dossageNumericUpDown.Enabled = false;
			intervalNumberNumericUpDown.Enabled = false;
			quantityBoxNumericUpDown.Enabled = false;
			titleTextBox.Enabled = false;
			descRichTextBox.Enabled = false;
		}

		public TherapyFormView() {
			InitializeComponent();

			therapyPresenter = new TherapyPresenter(this);
			saveButton.Enabled = true;
		}

		#endregion

		#region Methods

		private void saveButton_Click(object sender, EventArgs e) {
			bool isSaved = therapyPresenter.SaveTherapy();
			if (isSaved) {
				Therapy = therapyPresenter.Therapy;
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void cancelButton_Click(object sender, EventArgs e) {
			therapyPresenter.CancelTherapy();
			DialogResult = DialogResult.Cancel;
			Close();
		}

		#endregion
	}
}
