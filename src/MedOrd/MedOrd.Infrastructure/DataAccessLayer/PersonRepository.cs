using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel;
using MedOrd.DomainModel.RepositoryInterfaces;

namespace MedOrd.Infrastructure.DataAccessLayer {
	public class PersonRepository : IPersonRepository {

		#region Members

		private static readonly PersonRepository instance = new PersonRepository(CityRepository.Instance);

		public static PersonRepository Instance {
			get { return PersonRepository.instance; }
		}

		private ICityRepository cityRepository;

		private readonly IList<Person> persons;

		private IList<Person> Persons {
			get { return persons; }
		} 


		#endregion

		#region Constructors and Init

		/// <summary>
		/// Konstruktor
		/// </summary>
		private PersonRepository(ICityRepository cityRepository) {
			this.cityRepository = cityRepository;
			persons = new List<Person>();

			generatePersons();
		}

		private void generatePersons() {
			Person person = new Person("Željko", "Tepšić", "1234567890123") {
				Id = Guid.NewGuid(),
				BirthDate = new DateTime(1985, 12, 11),
				Address = new Address("M. Matošeca", "2", cityRepository.GetByPostalCode(10000))
			};
			persons.Add(person);

			person = new Person("Marko", "Markić", "1234567890124") {
				Id = Guid.NewGuid(),
				BirthDate = new DateTime(1980, 9, 11),
				Address = new Address("Ulica", "2", cityRepository.GetByPostalCode(31000))
			};
			persons.Add(person);

			person = new Person("Ivo", "Ivić", "1234567890125") {
				Id = Guid.NewGuid(),
				BirthDate = new DateTime(1981, 5, 13),
				Address = new Address("Ulica", "3", cityRepository.GetByPostalCode(10000))
			};
			persons.Add(person);

			person = new Person("Pero", "Perić", "1234567890126") {
				Id = Guid.NewGuid(),
				BirthDate = new DateTime(1982, 4, 8),
				Address = new Address("Ulica", "4", cityRepository.GetByPostalCode(21000))
			};
			persons.Add(person);

			person = new Person("Mato", "Lovrak", "1234567890127") {
				Id = Guid.NewGuid(),
				BirthDate = new DateTime(1986, 3, 8),
				Address = new Address("Ulica", "5", cityRepository.GetByPostalCode(10000))
			};
			persons.Add(person);

			person = new Person("August", "Šenoa", "1234567890128") {
				Id = Guid.NewGuid(),
				BirthDate = new DateTime(1989, 4, 9),
				Address = new Address("Ulica", "6", cityRepository.GetByPostalCode(10000))
			};
			persons.Add(person);
		}

		#endregion

		#region Methods

		#region IRepository<Person> Members

		public Person GetById(Guid id) {
			var person = (from p in persons
						where p.Id == id
						select p).SingleOrDefault<Person>();
			return person;
		}

		public void Save(Person entity) {
			if (entity.Id == Guid.Empty) {
				entity.Id = Guid.NewGuid();
			} else {
				Delete(entity);
			}

			persons.Add(entity);
		}

		public IList<Person> GetAll() {
			return persons;
		}

		public void Delete(Person entity) {
			persons.Remove(entity);
		}

		#endregion


		#region IPersonRepository Members

		public Person GetByFullName(string name, string surname) {
			var person = (from p in persons
						  where p.Name.Equals(name) && p.Surname.Equals(surname)
						  select p).SingleOrDefault<Person>();
			return person;
		}

		#endregion

		#endregion
	}
}
