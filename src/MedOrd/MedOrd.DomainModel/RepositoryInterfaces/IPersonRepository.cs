using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel.RepositoryInterfaces {
	public interface IPersonRepository : IRepository<Person> {
		Person GetByFullName(string name, string surname);
	}
}
