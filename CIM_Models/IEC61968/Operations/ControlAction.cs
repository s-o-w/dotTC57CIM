///////////////////////////////////////////////////////////
//  ControlAction.cs
//  Implementation of the Class ControlAction
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:02 AM
//  Original author: marga
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Operations;
using TC57CIM.IEC61970.Base.Meas;
namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// Control executed as a switching step.
	/// </summary>
	public class ControlAction : SwitchingAction {

		/// <summary>
		/// The analog value used for the analog control, the raise/lower control and the
		/// set point control
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float analogValue;
		/// <summary>
		/// The integer value used for the command or the accumulator reset.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer discreteValue;
		/// <summary>
		/// The control that the control action is performed on.
		/// </summary>
		public TC57CIM.IEC61970.Base.Meas.Control Control;

		public ControlAction(){

		}

		~ControlAction(){

		}

		public override void Dispose(){

		}

	}//end ControlAction

}//end namespace Operations