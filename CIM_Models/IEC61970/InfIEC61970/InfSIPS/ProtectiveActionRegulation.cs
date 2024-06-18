///////////////////////////////////////////////////////////
//  ProtectiveActionRegulation.cs
//  Implementation of the Class ProtectiveActionRegulation
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:16 AM
//  Original author: sveinols
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Wires;
using TC57CIM.IEC61970.InfIEC61970.InfSIPS;
namespace TC57CIM.IEC61970.InfIEC61970.InfSIPS {
	/// <summary>
	/// Protective action to change regulation to Equipment.
	/// </summary>
	public class ProtectiveActionRegulation : ProtectiveAction {

		/// <summary>
		/// If true the regulator is put in-service, otherwise out-of-service (no
		/// regulation).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean isRegulating;
		/// <summary>
		/// The target value specified the new case input for the regulator.  The value has
		/// the units appropriate to the mode attribute. The protective action does not
		/// change the mode attribute.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float targetValue;
		public TC57CIM.IEC61970.Base.Wires.RegulatingControl RegulatingControl;

		public ProtectiveActionRegulation(){

		}

		~ProtectiveActionRegulation(){

		}

		public override void Dispose(){

		}

	}//end ProtectiveActionRegulation

}//end namespace InfSIPS