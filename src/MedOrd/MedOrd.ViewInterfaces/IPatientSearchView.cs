using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel;

namespace MedOrd.ViewInterfaces {
	public interface IPatientSearchView {
		string PatientName { get; }
		string PatientSurname { get; }
		IList<Patient> Patients { set; }
		Patient SelectedPatient { get; }
	}
}
