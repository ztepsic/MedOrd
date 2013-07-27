using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel.Enumerations;
using MedOrd.DomainModel.Services;

namespace MedOrd.DomainModel {
	public class Employee : PersonRole {

		#region Members

		/// <summary>
		/// Korisnicko ime zaposlenika
		/// </summary>
		private string username;

		/// <summary>
		/// Dohvaca ili postavlja ime zaposlenika
		/// </summary>
		public string Username {
			get {
				return username;
			}
			set {
				username = value;
			}
		}

		/// <summary>
		/// Lozinka zaposlenika
		/// </summary>
		private string encodedPassword;

		/// <summary>
		/// Dohvaca ili postavlja lozinku zaposlenika
		/// </summary>
		public string EncodedPassword {
			get {
				return encodedPassword;
			}
			set {
				encodedPassword = value;
			}
		}

		public string Password {
			set { encodedPassword = AuthService.EncodePassword(value); }
		}

		public string FullName {
			get { return Person.Name + " " + Person.Surname; }
		}

		/// <summary>
		/// Uloge zaposlenika
		/// </summary>
		private readonly HashSet<EmployeeRole> employeeRoles = new HashSet<EmployeeRole>();

		/// <summary>
		/// Dohvaca uloge zaposlenika
		/// </summary>
		public HashSet<EmployeeRole> EmployeeRoles {
			get { return employeeRoles; }
		}

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="username">korisnicko ime</param>
		/// <param name="password">kodirana lozinka</param>
		/// <param name="person">osoba</param>
		public Employee(string username, string password, Person person) : base(person){
			this.username = username;
			Password = password;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Dodaj ulogu zaposlenika
		/// </summary>
		/// <param name="employeeRole">uloga zaposlenika</param>
		public void AddEmployeeRole(EmployeeRole employeeRole) {
			employeeRoles.Add(employeeRole);
		}

		/// <summary>
		/// Brise ulogu zaposlenika
		/// </summary>
		/// <param name="employeeRole"></param>
		public void RemoveEmployeeRole(EmployeeRole employeeRole) {
			employeeRoles.Remove(employeeRole);
		}

		/// <summary>
		/// Da li zaposlenik ima odredenu ulogu zaposlenika
		/// </summary>
		/// <param name="employeeRole"></param>
		/// <returns></returns>
		public bool HasEmployeeRole(EmployeeRole employeeRole) {
			return employeeRoles.Contains(employeeRole);
		}


		public override string ToString() {
			return FullName;
		}

		#endregion
	}
}
