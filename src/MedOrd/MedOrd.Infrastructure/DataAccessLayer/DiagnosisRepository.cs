using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel;
using MedOrd.DomainModel.RepositoryInterfaces;

namespace MedOrd.Infrastructure.DataAccessLayer {
	public class DiagnosisRepository : IDiagnosisRepository {

		#region Members

		#region Singleton

		private static readonly DiagnosisRepository instance = new DiagnosisRepository();

		public static DiagnosisRepository Instance {
			get { return DiagnosisRepository.instance; }
		}

		#endregion

		private IList<Diagnosis> diagnoses;

		#endregion

		#region Constructors and Init

		private DiagnosisRepository() {
			diagnoses = new List<Diagnosis>();

			generateDiagnoses();
		}

		private void generateDiagnoses() {
			Diagnosis diag = new Diagnosis("Određene infekcijske i parazitske bolesti") {
				Id = Guid.NewGuid()
			};
			diagnoses.Add(diag);

			diag = new Diagnosis("Bolesti krvi i krvotvornih organa i određeni poremećaji imunološkog sustava") {
				Id = Guid.NewGuid()
			};
			diagnoses.Add(diag);

			diag = new Diagnosis("Endokrine, nutricijske i metaboličke bolesti") {
				Id = Guid.NewGuid()
			};
			diagnoses.Add(diag);

			diag = new Diagnosis("Mentalni poremećaji i poremećaji ponašanja") {
				Id = Guid.NewGuid()
			};
			diagnoses.Add(diag);

		}

		#endregion

		#region Methods
		#endregion


		#region IRepository<Diagnosis> Members

		public Diagnosis GetById(Guid id) {
			var diagnosis = (from d in diagnoses
									  where d.Id == id
									  select d).SingleOrDefault<Diagnosis>();
			return diagnosis;
		}

		public void Save(Diagnosis entity) {
			if (entity.Id == Guid.Empty) {
				entity.Id = Guid.NewGuid();
			} else {
				Delete(entity);
			}

			diagnoses.Add(entity);
		}

		public IList<Diagnosis> GetAll() {
			return diagnoses;
		}

		public void Delete(Diagnosis entity) {
			diagnoses.Remove(entity);
		}

		#endregion
	}
}
