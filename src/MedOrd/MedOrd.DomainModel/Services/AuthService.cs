using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel.RepositoryInterfaces;
using System.Security.Cryptography;

namespace MedOrd.DomainModel.Services {
	public class AuthService {

		#region Members

		private static Employee loggedInEmployee = null;

		public static Employee LoggedInEmployee {
			get { return AuthService.loggedInEmployee; }
		}

		private IEmployeeRepository employeeRepository;

		#endregion

		#region Constructors and Init

		public AuthService(IEmployeeRepository employeeRepository) {
			this.employeeRepository = employeeRepository;
		}

		#endregion

		#region Members

		public bool Login(string username, string password) {
			Employee employee = employeeRepository.GetByLoginCredentials(username, AuthService.EncodePassword(password));
			if (employee != null) {
				loggedInEmployee = employee;
				return true;
			} else {
				loggedInEmployee = null;
				return false;
			}
		}

		public static void Logout() {
			loggedInEmployee = null;
		}

		/// <summary>
		/// Racuna kodiranu lozinku SHA1 Hashem
		/// </summary>
		/// <param name="password">lozinka</param>
		/// <returns>kodirana lozinka</returns>
		public static string EncodePassword(string password) {
			string formatted = string.Empty;
			using (SHA1Managed sha1 = new SHA1Managed()) {
				byte[] passwordByteArray = Encoding.UTF8.GetBytes(password);
				byte[] hash = sha1.ComputeHash(passwordByteArray);
				foreach (byte b in hash) {
					formatted += b.ToString("X2");
				}
			}

			return formatted;
		}

		#endregion

	}
}
