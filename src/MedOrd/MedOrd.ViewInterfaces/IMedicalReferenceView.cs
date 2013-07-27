using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel;

namespace MedOrd.ViewInterfaces {
	public interface IMedicalReferenceView {
		IList<MedicalCareActivity> MedicalCareActivities { set; }
		MedicalCareActivity SelectedMedicalCareActivitiy { get; set; }
		IList<MedicalInstitution> MedicalInstitutions { set; }
		MedicalInstitution SelectedMedicalInstitution { get; set; }
		String Diagnosis { set; }
		String WantedFor { get; set; }
	}
}
