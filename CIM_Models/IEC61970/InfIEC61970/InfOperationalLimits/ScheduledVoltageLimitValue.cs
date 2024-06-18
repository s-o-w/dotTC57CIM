///////////////////////////////////////////////////////////
//  ScheduledVoltageLimitValue.cs
//  Implementation of the Class ScheduledVoltageLimitValue
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:20 AM
//  Original author: kdemaree
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.InfIEC61970.InfOperationalLimits;
namespace TC57CIM.IEC61970.InfIEC61970.InfOperationalLimits {
	/// <summary>
	/// A voltage limit value for a scheduled time.
	/// </summary>
	public class ScheduledVoltageLimitValue : ScheduledLimitValue {

		/// <summary>
		/// The voltage limit value for the scheduled time.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage value;

		public ScheduledVoltageLimitValue(){

		}

		~ScheduledVoltageLimitValue(){

		}

		public override void Dispose(){

		}

	}//end ScheduledVoltageLimitValue

}//end namespace InfOperationalLimits