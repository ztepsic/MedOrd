using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MedOrd.Views;

namespace MedOrd.AppStarter {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			LoginFormView loginFormView = new LoginFormView();
			if (loginFormView.ShowDialog() != DialogResult.OK) {
				return;
			}

			Application.Run(new MainFormView());
		}
	}
}
