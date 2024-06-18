///////////////////////////////////////////////////////////
//  EmissionAccount.cs
//  Implementation of the Class EmissionAccount
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:49 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Generation.Production;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Generation.Production {
	/// <summary>
	/// Accounts for tracking emissions usage and credits for thermal generating units.
	/// A unit may have zero or more emission accounts, and will typically have one for
	/// tracking usage and one for tracking credits.
	/// </summary>
	public class EmissionAccount : Curve {

		/// <summary>
		/// The type of emission, for example sulfur dioxide (SO2). The y1AxisUnits of the
		/// curve contains the unit of measure (e.g. kg) and the emissionType is the type
		/// of emission (e.g. sulfur dioxide).
		/// </summary>
		public EmissionType emissionType;
		/// <summary>
		/// The source of the emission value.
		/// </summary>
		public EmissionValueSource emissionValueSource;

		public EmissionAccount(){

		}

		~EmissionAccount(){

		}

		public override void Dispose(){

		}

	}//end EmissionAccount

}//end namespace Production