﻿///////////////////////////////////////////////////////////
//  AltGeneratingUnitMeas.cs
//  Implementation of the Class AltGeneratingUnitMeas
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:39 AM
//  Original author: kdd
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Meas;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.ControlArea {
	/// <summary>
	/// A prioritized measurement to be used for the generating unit in the control
	/// area specification.
	/// </summary>
	public class AltGeneratingUnitMeas : IdentifiedObject {

		/// <summary>
		/// Priority of a measurement usage.   Lower numbers have first priority.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer priority;
		/// <summary>
		/// The specific analog value used as a source.
		/// </summary>
		public TC57CIM.IEC61970.Base.Meas.AnalogValue AnalogValue;

		public AltGeneratingUnitMeas(){

		}

		~AltGeneratingUnitMeas(){

		}

		public override void Dispose(){

		}

	}//end AltGeneratingUnitMeas

}//end namespace ControlArea