using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.ViewInterfaces;
using MedOrd.DomainModel.Services;
using MedOrd.DomainModel.RepositoryInterfaces;
using MedOrd.Infrastructure.DataAccessLayer;
using MedOrd.DomainModel;

namespace MedOrd.Presenter {
	public class MainPresenter {

		#region Members

		private IMainView mainView;

		private AuthService authService;
		private IEmployeeRepository employeeRepository;

		#endregion

		#region Constructors and Init

		public MainPresenter(IMainView mainView) : this(mainView, EmployeeRepository.Instance) { }

		public MainPresenter(IMainView mainView, IEmployeeRepository employeeRepository) {
			this.mainView = mainView;
			this.employeeRepository = employeeRepository;

			authService = new AuthService(employeeRepository);
		}

		#endregion

		#region Methods

		#endregion
		
	}
}
