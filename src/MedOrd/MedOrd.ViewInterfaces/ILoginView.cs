using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.ViewInterfaces {
	public interface ILoginView {
		string Username { get; set; }
		string Password { get; set; }
	}
}
