﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedOrd.DomainModel;

namespace MedOrd.ViewInterfaces {
	public interface IWaitingRoomView {
		IList<Patient> Patients { set; }
		Patient SelectedPatient { get; set; }
	}
}
