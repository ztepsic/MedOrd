using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel;

namespace MedOrd.ViewInterfaces {
	public interface IMedicalExaminationView {
		MedicalExamination MedicalExamination { get; set; }
		IList<Diagnosis> Diagnoses { set; }
		Diagnosis SelectedDiagnosis { get; set; }
		Patient Patient { get; set; }
		MedicalReference MedicalReference { get; set; }
		Therapy Therapy { get; set; }
		string MedicalCaseTitle { get; set; }
	}
}
