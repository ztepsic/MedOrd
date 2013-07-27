using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel;

namespace MedOrd.ViewInterfaces {
	public interface ITherapyView {
		IList<Drug> Drugs { set; }
		Drug SelectedDrug { get;  set; }
		Therapy Therapy { get; set; }
	}
}
