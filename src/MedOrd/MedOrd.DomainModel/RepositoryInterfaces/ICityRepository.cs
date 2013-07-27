using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel.RepositoryInterfaces {
	public interface ICityRepository : IRepository<City> {
		City GetByPostalCode(int postalCode);
	}
}
