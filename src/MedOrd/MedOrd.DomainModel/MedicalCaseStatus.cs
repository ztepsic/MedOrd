using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedOrd.DomainModel {
	/// <summary>
	/// Enumerator statusa medicinskog slucaja
	/// </summary>
	public enum MedicalCaseStatus {
		UObradi,
		AkutniSlucaj,
		KronicniIAktivniSlucaj,
		UtvrdenIRijesenSlucaj,
		KomplikacijaDeugogSlucaja,
		KorekcijaDefinicijeDrugogSlucaja
	}	
}
