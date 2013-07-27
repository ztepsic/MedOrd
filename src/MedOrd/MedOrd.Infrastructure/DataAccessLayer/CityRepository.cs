using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.DomainModel;

namespace MedOrd.Infrastructure.DataAccessLayer {
	public class CityRepository : ICityRepository {

		#region Members

		private static readonly CityRepository instance = new CityRepository();

		public static CityRepository Instance {
			get { return CityRepository.instance; }
		}


		/// <summary>
		/// Gradovi
		/// </summary>
		private readonly IList<City> cities;

		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		private CityRepository() {
			cities = new List<City>();

			generateCities();
		}

		private void generateCities(){
			City city = new City(10000, "Zagreb") {
				Id = Guid.NewGuid()
			};
			cities.Add(city);

			city = new City(21000, "Split") {
				Id = Guid.NewGuid()
			};
			cities.Add(city);

			city = new City(51000, "Rijeka") {
				Id = Guid.NewGuid()
			};
			cities.Add(city);

			city = new City(31000, "Osijek") {
				Id = Guid.NewGuid()
			};
			cities.Add(city);

		}

		#endregion

		#region Methods

		#region ICityRepository Members

		public MedOrd.DomainModel.City GetByPostalCode(int postalCode) {
			var city = (from c in cities
					   where c.PostalCode == postalCode
					   select c).SingleOrDefault<City>();
			return city;
		}

		#endregion

		#region IRepository<City> Members

		public MedOrd.DomainModel.City GetById(Guid id) {
			var city = (from c in cities
						where c.Id == id
						select c).SingleOrDefault<City>();
			return city;
		}

		public void Save(MedOrd.DomainModel.City entity) {
			if (entity.Id == Guid.Empty) {
				entity.Id = Guid.NewGuid();
			} else {
				Delete(entity);
			}

			cities.Add(entity);
		}

		public IList<MedOrd.DomainModel.City> GetAll() {
			return cities;
		}

		public void Delete(MedOrd.DomainModel.City entity) {
			cities.Remove(entity);
		}

		#endregion

		#endregion
	}
}
