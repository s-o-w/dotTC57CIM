﻿///////////////////////////////////////////////////////////
//  MeterWorkTask.cs
//  Implementation of the Class MeterWorkTask
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:16 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.Metering;
using TC57CIM.IEC61968.Work;
namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Work task involving meters.
	/// </summary>
	public class MeterWorkTask : WorkTask {

		/// <summary>
		/// Old meter replaced by this work task.
		/// </summary>
		public TC57CIM.IEC61968.Metering.Meter OldMeter;
		/// <summary>
		/// Usage point to which this meter service work task applies.
		/// </summary>
		public TC57CIM.IEC61968.Metering.UsagePoint UsagePoint;
		/// <summary>
		/// Meter on which this non-replacement work task is performed.
		/// </summary>
		public TC57CIM.IEC61968.Metering.Meter Meter;

		public MeterWorkTask(){

		}

		~MeterWorkTask(){

		}

		public override void Dispose(){

		}

	}//end MeterWorkTask

}//end namespace Metering