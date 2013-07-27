using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.ViewInterfaces;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.Infrastructure.DataAccessLayer;
using MedOrd.DomainModel;

namespace MedOrd.Presenter {
	public class TherapyPresenter {

		#region Members

		private ITherapyView therapyView;
		private IDrugRepository drugRepository;

		private Therapy therapy = null;

		public Therapy Therapy {
			get { return therapy; }
		}

		#endregion

		#region Constructors and Init

		public TherapyPresenter(ITherapyView therapyView) : this(therapyView, DrugRepository.Instance) { }

		public TherapyPresenter(ITherapyView therapyView, IDrugRepository drugRepository) {
			this.therapyView = therapyView;
			this.drugRepository = drugRepository;

			therapy = new Therapy(string.Empty, string.Empty) {
				Id = Guid.NewGuid()
			};

			initView();
		}

		public TherapyPresenter(Therapy therapy, ITherapyView therapyView) : this(therapy, therapyView, DrugRepository.Instance) { }

		public TherapyPresenter(Therapy therapy, ITherapyView therapyView, IDrugRepository drugRepository) {
			this.therapyView = therapyView;
			this.drugRepository = drugRepository;

			this.therapy = therapy;

			initView();
		}

		#endregion

		#region Methods

		private void initView() {
			therapyView.Drugs = drugRepository.GetAll();
			therapyView.Therapy = therapy;
			therapyView.SelectedDrug = therapy.TherapyDrug;
		}

		public bool SaveTherapy() {
			therapy = therapyView.Therapy;
			therapy.TherapyDrug = therapyView.SelectedDrug;
			return true;
		}

		public void CancelTherapy() {
			therapy = null;
		}

		#endregion

	}
}
