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

namespace MedOrd.Views {
	public partial class LoginFormView : Form, ILoginView {

		#region Members

		private LoginPresenter loginPresenter;

		#region ILoginView Members

		public string Username {
			get {
				return usernameTextBox.Text;
			}
			set {
				usernameTextBox.Text = value;
			}
		}

		public string Password {
			get {
				return passwordTextBox.Text;
			}
			set {
				passwordTextBox.Text = value;
			}
		}

		#endregion

		#endregion

		#region Constructors and Init

		public LoginFormView() {
			InitializeComponent();
		}


		private void LoginFormView_Load(object sender, EventArgs e) {
			loginPresenter = new LoginPresenter(this);
		}

		#endregion

		private void loginButton_Click(object sender, EventArgs e) {
			if (loginPresenter.Authenticate()) {
				DialogResult = DialogResult.OK;
				Close();
			} else {
				MessageBox.Show("Unjeli ste pogrešne podatke za prijavu ili korisnik ne postoji.", 
					"Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void usernameTextBox_TextChanged(object sender, EventArgs e) {
			enableLoginButton();
		}

		private void passwordTextBox_TextChanged(object sender, EventArgs e) {
			enableLoginButton();
		}

		private void enableLoginButton() {
			if (!String.IsNullOrEmpty(usernameTextBox.Text) && !String.IsNullOrEmpty(passwordTextBox.Text)) {
				loginButton.Enabled = true;
			} else {
				loginButton.Enabled = false;
			}
		}

		#region Methods

		#endregion
	}
}
