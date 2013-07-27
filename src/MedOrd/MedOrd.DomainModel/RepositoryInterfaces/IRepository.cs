using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel.RepositoryInterfaces {
	public interface IRepository<T> where T : PersistentObject {
		T GetById(Guid id);
		void Save(T entity);
		IList<T> GetAll();
		void Delete(T entity);
	}
}
