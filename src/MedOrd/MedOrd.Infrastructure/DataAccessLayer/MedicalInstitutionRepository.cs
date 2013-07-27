using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel;
using MedOrd.DomainModel.RepositoryInterfaces;

namespace MedOrd.Infrastructure.DataAccessLayer {
	public class MedicalInstitutionRepository : IMedicalInstitutionRepository {

		#region Members

		#region Singleton

		private static readonly MedicalInstitutionRepository instance = new MedicalInstitutionRepository();

		public static MedicalInstitutionRepository Instance {
			get { return MedicalInstitutionRepository.instance; }
		}

		#endregion

		private IList<MedicalInstitution> medicalInstituions;

		#endregion

		#region Constructors and Init

		private MedicalInstitutionRepository() {
			medicalInstituions = new List<MedicalInstitution>();

			generateMedicalInstitutions();
		}

		private void generateMedicalInstitutions() {
			MedicalInstitution mInst = new MedicalInstitution("Dom zdravlja Zagreb") {
				Id = Guid.NewGuid()
			};
			medicalInstituions.Add(mInst);

			mInst = new MedicalInstitution("Dom zdravlja Split") {
				Id = Guid.NewGuid()
			};
			medicalInstituions.Add(mInst);

			mInst = new MedicalInstitution("Dom zdravlja Rijeka") {
				Id = Guid.NewGuid()
			};
			medicalInstituions.Add(mInst);

			mInst = new MedicalInstitution("Dom zdravlja Osijek") {
				Id = Guid.NewGuid()
			};
			medicalInstituions.Add(mInst);

		}


		#endregion

		#region Methods

		#region IRepository<MedicalInstitution> Members

		public MedicalInstitution GetById(Guid id) {
			var medicalInstitution = (from m in medicalInstituions
									   where m.Id == id
									   select m).SingleOrDefault<MedicalInstitution>();
			return medicalInstitution;
		}

		public void Save(MedicalInstitution entity) {
			if (entity.Id == Guid.Empty) {
				entity.Id = Guid.NewGuid();
			} else {
				Delete(entity);
			}

			medicalInstituions.Add(entity);
		}

		public IList<MedicalInstitution> GetAll() {
			return medicalInstituions;
		}

		public void Delete(MedicalInstitution entity) {
			medicalInstituions.Remove(entity);
		}

		#endregion

		#endregion

		
	}
}
