﻿///////////////////////////////////////////////////////////
//  SvStatus.cs
//  Implementation of the Class SvStatus
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:23 AM
//  Original author: kdd
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Wires;
using TC57CIM.IEC61970.Base.StateVariables;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.StateVariables {
	/// <summary>
	/// State variable for status.
	/// </summary>
	public class SvStatus : StateVariable {

		/// <summary>
		/// The in service status as a result of topology processing.  It indicates if the
		/// equipment is considered as energized by the power flow. It reflects if the
		/// equipment is connected within a solvable island.  It does not necessarily
		/// reflect whether or not the island was solved by the power flow.
		/// </summary>
		public bool inService;
		/// <summary>
		/// The individual phase status.    If the attribute is unspecified, then three
		/// phase model is assumed.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.SinglePhaseKind phase;
		/// <summary>
		/// The conducting equipment associated with the status state variable.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.ConductingEquipment ConductingEquipment;

		public SvStatus(){

		}

		~SvStatus(){

		}

		public override void Dispose(){

		}

	}//end SvStatus

}//end namespace StateVariables