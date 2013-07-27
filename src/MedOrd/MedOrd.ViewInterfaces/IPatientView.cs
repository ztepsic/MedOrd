using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel;

namespace MedOrd.ViewInterfaces {
	public interface IPatientView {
		Guid PatientId { get; set; }
		Guid PersonId { get; set; }
		string PersonName { get; set; }
		string PersonSurname { get; set; }
		string Jmbg { get; set; }
		City SelectedCity { get; set; }
		string Street { get; set; }
		string StreetNumber { get; set; }
		DateTime BirthDate { get; set; }
		int NumberOfInsuredPerson { get; set; }
		int CardNumber { get; set; }
		IList<City> Cities { set; }
	}
}
