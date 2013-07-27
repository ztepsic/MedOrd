using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel.RepositoryInterfaces {
	public interface IPatientRepository : IRepository<Patient> {
		IList<Patient> GetPatientsByFullName(string name, string surname);
	}
}
