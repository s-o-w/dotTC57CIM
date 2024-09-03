﻿///////////////////////////////////////////////////////////
//  ComplianceEvent.cs
//  Implementation of the Class ComplianceEvent
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:01 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Common;
namespace TC57CIM.IEC61968.InfIEC61968.InfCustomers {
	/// <summary>
	/// Compliance events are used for reporting regulatory or contract compliance
	/// issues and/or variances. These might be created as a consequence of local
	/// business processes and associated rules. It is anticipated that this class will
	/// be customised extensively to meet local implementation needs.
	/// Use inherited 'type' to indicate that, for example, expected performance will
	/// not be met or reported as mandated.
	/// </summary>
	public class ComplianceEvent : ActivityRecord {

		/// <summary>
		/// The deadline for compliance.
		/// </summary>
		public System.DateTime deadline;

		public ComplianceEvent(){

		}

		~ComplianceEvent(){

		}

		public override void Dispose(){

		}

	}//end ComplianceEvent

}//end namespace InfCustomers