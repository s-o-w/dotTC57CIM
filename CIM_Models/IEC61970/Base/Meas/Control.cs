///////////////////////////////////////////////////////////
//  Control.cs
//  Implementation of the Class Control
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:44 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Meas;
namespace TC57CIM.IEC61970.Base.Meas {
	/// <summary>
	/// Control is used for supervisory/device control. It represents control outputs
	/// that are used to change the state in a process, e.g. close or open breaker, a
	/// set point value or a raise lower command.
	/// </summary>
	public class Control : IOPoint {

		/// <summary>
		/// Specifies the type of Control. For example, this specifies if the Control
		/// represents BreakerOpen, BreakerClose, GeneratorVoltageSetPoint, GeneratorRaise,
		/// GeneratorLower, etc.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String controlType;
		/// <summary>
		/// Indicates that a client is currently sending control commands that has not
		/// completed.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean operationInProgress;
		/// <summary>
		/// The last time a control output was sent.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime timeStamp;
		/// <summary>
		/// The unit multiplier of the controlled quantity.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.UnitMultiplier unitMultiplier;
		/// <summary>
		/// The unit of measure of the controlled quantity.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.UnitSymbol unitSymbol;

		public Control(){

		}

		~Control(){

		}

		public override void Dispose(){

		}

	}//end Control

}//end namespace Meas