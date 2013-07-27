using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.DomainModel;
using MedOrd.DomainModel.Enumerations;

namespace MedOrd.Infrastructure.DataAccessLayer {
	public class EmployeeRepository : IEmployeeRepository {

		#region Members

		private static readonly EmployeeRepository instance = new EmployeeRepository();

		public static EmployeeRepository Instance {
			get { return EmployeeRepository.instance; }
		}

		private IPersonRepository personRepository;

		private readonly IList<Employee> employees;

		#endregion

		#region Constructors and Init

		private EmployeeRepository() {
			this.personRepository = PersonRepository.Instance;
			employees = new List<Employee>();

			generateEmployees();
		}

		private void generateEmployees() {
			Employee employee = null;

			employee = new Employee("ztepsic", "123456", personRepository.GetByFullName("Željko", "Tepšić")) {
				Id = Guid.NewGuid()
			};
			employee.AddEmployeeRole(EmployeeRole.Doctor);
			employees.Add(employee);


			employee = new Employee("iivic", "123456", personRepository.GetByFullName("Iva", "Ivić")) {
				Id = Guid.NewGuid()
			};
			employee.AddEmployeeRole(EmployeeRole.Nurse);
			employees.Add(employee);

		}

		#endregion

		#region Methods

		#region IEmployeeRepository Members

		public MedOrd.DomainModel.Employee GetByLoginCredentials(string username, string endcodedPassword) {
			var employee = (from e in employees
							where e.Username.Equals(username) && e.EncodedPassword.Equals(endcodedPassword)
							select e).SingleOrDefault<Employee>();
			return employee;
		}

		public Employee GetByUsername(string username) {
			var employee = (from e in employees
							where e.Username.Equals(username)
							select e).SingleOrDefault<Employee>();
			return employee;
		}

		#endregion


		#region IRepository<Employee> Members

		public MedOrd.DomainModel.Employee GetById(Guid id) {
			var employee = (from e in employees
							where e.Id == id
							select e).SingleOrDefault<Employee>();
			return employee;
		}

		public void Save(MedOrd.DomainModel.Employee entity) {
			if (entity.Id == Guid.Empty) {
				entity.Id = Guid.NewGuid();
			} else {
				Delete(entity);
			}

			employees.Add(entity);
		}

		public IList<MedOrd.DomainModel.Employee> GetAll() {
			return employees;
		}

		public void Delete(MedOrd.DomainModel.Employee entity) {
			employees.Remove(entity);
		}

		#endregion

		#endregion

	}
}
