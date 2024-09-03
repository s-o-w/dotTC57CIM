﻿///////////////////////////////////////////////////////////
//  SwitchingAction.cs
//  Implementation of the Class SwitchingAction
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:26 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61968.Operations;
using TC57CIM.IEC61968.Common;
namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// Atomic switching action.
	/// </summary>
	public class SwitchingAction : IdentifiedObject {

		/// <summary>
		/// Actual date and time of this switching step.
		/// </summary>
		public System.DateTime executedDateTime;
		/// <summary>
		/// Date and time when the crew was given the instruction to execute the action;
		/// not applicable if the action is performed by operator remote control.
		/// </summary>
		public System.DateTime issuedDateTime;
		/// <summary>
		/// Phases of the Switching Action
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.PhaseCode phases;
		/// <summary>
		/// Planned date and time of this switching step.
		/// </summary>
		public System.DateTime plannedDateTime;
		/// <summary>
		/// The switching plan that is associated with the switching actions.
		/// </summary>
		public TC57CIM.IEC61968.Operations.SwitchingPlan SwitchingPlan;
		/// <summary>
		/// Operator responsible for this switching step.
		/// </summary>
		public TC57CIM.IEC61968.Common.Operator Operator;
		/// <summary>
		/// The crew that is assigned to the switching action.
		/// </summary>
		public TC57CIM.IEC61968.Common.Crew Crew;
		/// <summary>
		/// The switching event that the switching action is performed on
		/// </summary>
		public TC57CIM.IEC61968.Operations.SwitchingEvent SwitchingEvent;

		public SwitchingAction(){

		}

		~SwitchingAction(){

		}

		public override void Dispose(){

		}

	}//end SwitchingAction

}//end namespace Operations