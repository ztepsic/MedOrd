using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel;
using MedOrd.DomainModel.RepositoryInterfaces;

namespace MedOrd.Infrastructure.DataAccessLayer {
	public class DrugRepository : IDrugRepository {

		#region Members

		#region Singleton

		private static readonly DrugRepository instance = new DrugRepository();

		public static DrugRepository Instance {
			get { return DrugRepository.instance; }
		}

		#endregion

		private IList<Drug> drugs;

		#endregion

		#region Constructors and Init

		private DrugRepository() {
			drugs = new List<Drug>();

			generateDrugs();
		}

		private void generateDrugs() {
			Drug drug = new Drug("Klavocin", "AMOKSICILIN+ KLAVOLUNSKA KISELINA", "Pliva", 30) {
				Id = Guid.NewGuid(),
				Description = "Klavocin je kombinacija baktericidnog penicilinskog antibiotika amoksicilina i klavulanske kiseline poznata pod nazivom koamoksiklav."
			};
			drugs.Add(drug);

			drug = new Drug("Aminophyllin", "Aminofilin", "Lek", 10) {
				Id = Guid.NewGuid(),
				Description = "Aminofilin je smjesa teofilina i etilendiamina. Terapijsko djelovanje aminofilina potječe od teofilina, dok etilendiamin poboljšava rastvorljivost teofilina"
			};
			drugs.Add(drug);

			drug = new Drug("Amoxil", "Amoksicilin", "Pliva", 30) {
				Id = Guid.NewGuid(),
				Description = "Amoksicilin je aminopenicilinski antibiotik široka spektra djelovanja."
			};
			drugs.Add(drug);

		}

		#endregion

		#region Methods

		#region IDrugRepository Members

		public IList<Drug> GetDrugsByManufacturer() {
			throw new NotImplementedException();
		}

		#endregion

		#region IRepository<Drug> Members

		public Drug GetById(Guid id) {
			var drug = (from d in drugs
							 where d.Id == id
							 select d).SingleOrDefault<Drug>();
			return drug;
		}

		public void Save(Drug entity) {
			Delete(entity);
			drugs.Add(entity);
		}

		public IList<Drug> GetAll() {
			return drugs;
		}

		public void Delete(Drug entity) {
			drugs.Remove(entity);
		}

		#endregion

		#endregion
	}
}
