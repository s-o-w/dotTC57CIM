﻿///////////////////////////////////////////////////////////
//  BaseReading.cs
//  Implementation of the Class BaseReading
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:59 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Meas;
namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Common representation for reading values. Note that a reading value may have
	/// multiple qualities, as produced by various systems ('ReadingQuality.source').
	/// </summary>
	public class BaseReading : MeasurementValue {

		/// <summary>
		/// (used only when there are detailed auditing requirements) Date and time at
		/// which the reading was first delivered to the metering system.
		/// </summary>
		public System.DateTime reportedDateTime;
		/// <summary>
		/// System that originally supplied the reading (e.g., customer, AMI system,
		/// handheld reading system, another enterprise system, etc.).
		/// </summary>
		public string source;
		/// <summary>
		/// Start and end of the period for those readings whose type has a time attribute
		/// such as 'billing', seasonal' or 'forTheSpecifiedPeriod'.
		/// </summary>
		public DateTimeInterval timePeriod;
		/// <summary>
		/// Value of this reading.
		/// </summary>
		public string value;

		public BaseReading(){

		}

		~BaseReading(){

		}

		public override void Dispose(){

		}

	}//end BaseReading

}//end namespace Metering