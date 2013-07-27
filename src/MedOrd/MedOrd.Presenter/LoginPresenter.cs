using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.ViewInterfaces;
using MedOrd.DomainModel.Services;
using MedOrd.Infrastructure.DataAccessLayer;
using MedOrd.DomainModel.RepositoryInterfaces;

namespace MedOrd.Presenter {
	public class LoginPresenter {

		#region Members

		private readonly ILoginView loginView;

		private AuthService authService;
		private IEmployeeRepository employeeRepository;

		#endregion

		#region Constructors and Init

		public LoginPresenter(ILoginView loginView) : this(loginView, EmployeeRepository.Instance) { }

		public LoginPresenter(ILoginView loginView, IEmployeeRepository employeeRepository) {
			this.loginView = loginView;
			this.employeeRepository = employeeRepository;

			authService = new AuthService(employeeRepository);
		}

		#endregion

		#region Methods

		public bool Authenticate() {
			bool isLoggedIn = false;
			if (!String.IsNullOrEmpty(loginView.Username) && !String.IsNullOrEmpty(loginView.Password)) {
				isLoggedIn = authService.Login(loginView.Username, loginView.Password);
			}
			
			return isLoggedIn;
		}

		#endregion

	}
}
