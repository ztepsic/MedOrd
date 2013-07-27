using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel.RepositoryInterfaces {
	public interface IEmployeeRepository : IRepository<Employee> {
		/// <summary>
		/// Dohvaca zapolsenika prema podacima za prijavu na sustav
		/// </summary>
		/// <param name="username">korisnicko ime</param>
		/// <param name="endcodedPassword">kodirana lozinka</param>
		/// <returns>zaposlenik</returns>
		Employee GetByLoginCredentials(string username, string endcodedPassword);
		Employee GetByUsername(string username);
	}
}
