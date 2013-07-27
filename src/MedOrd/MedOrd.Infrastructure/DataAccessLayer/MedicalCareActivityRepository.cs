using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.DomainModel;

namespace MedOrd.Infrastructure.DataAccessLayer {
	public class MedicalCareActivityRepository : IMedicalCareActivityRepository {

		#region Members

		#region Singleton

		private static readonly MedicalCareActivityRepository instance = new MedicalCareActivityRepository();

		public static MedicalCareActivityRepository Instance {
			get { return MedicalCareActivityRepository.instance; }
		}

		#endregion

		private IList<MedicalCareActivity> medicalCareActivities;

		#endregion

		#region Constructors and Init

		private MedicalCareActivityRepository() {
			medicalCareActivities = new List<MedicalCareActivity>();

			generateMedicalCareActivities();
		}

		private void generateMedicalCareActivities() {
			MedicalCareActivity mCA = new MedicalCareActivity("Specijalistički pregled") {
				Id = Guid.NewGuid()
			};
			medicalCareActivities.Add(mCA);

			mCA = new MedicalCareActivity("Bloničko liječenje") {
				Id = Guid.NewGuid()
			};
			medicalCareActivities.Add(mCA);

			mCA = new MedicalCareActivity("Dijagnostička pretraga") {
				Id = Guid.NewGuid()
			};
			medicalCareActivities.Add(mCA);

			mCA = new MedicalCareActivity("Ambulantno liječenje") {
				Id = Guid.NewGuid()
			};
			medicalCareActivities.Add(mCA);

		}

		#endregion

		#region Methods

		#region IRepository<MedicalCareActivity> Members

		public MedOrd.DomainModel.MedicalCareActivity GetById(Guid id) {
			var medicalCareActivity = (from m in medicalCareActivities
									   where m.Id == id
									   select m).SingleOrDefault<MedicalCareActivity>();
			return medicalCareActivity;
		}

		public void Save(MedOrd.DomainModel.MedicalCareActivity entity) {
			if (entity.Id == Guid.Empty) {
				entity.Id = Guid.NewGuid();
			} else {
				Delete(entity);
			}

			medicalCareActivities.Add(entity);
		}

		public IList<MedOrd.DomainModel.MedicalCareActivity> GetAll() {
			return medicalCareActivities;
		}

		public void Delete(MedOrd.DomainModel.MedicalCareActivity entity) {
			medicalCareActivities.Remove(entity);
		}

		#endregion

		#endregion
	}
}
