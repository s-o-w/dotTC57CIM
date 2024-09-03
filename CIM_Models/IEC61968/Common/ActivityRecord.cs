﻿///////////////////////////////////////////////////////////
//  ActivityRecord.cs
//  Implementation of the Class ActivityRecord
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:55 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Common;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.Common {
	/// <summary>
	/// Records activity for an entity at a point in time; activity may be for an event
	/// that has already occurred or for a planned activity.
	/// </summary>
	public class ActivityRecord : IdentifiedObject {

		/// <summary>
		/// Date and time this activity record has been created (different from the 'status.
		/// dateTime', which is the time of a status change of the associated object, if
		/// applicable).
		/// </summary>
		public System.DateTime createdDateTime;
		/// <summary>
		/// Reason for event resulting in this activity record, typically supplied when
		/// user initiated.
		/// </summary>
		public string reason;
		/// <summary>
		/// Severity level of event resulting in this activity record.
		/// </summary>
		public string severity;
		/// <summary>
		/// Information on consequence of event resulting in this activity record.
		/// </summary>
		public Status status;
		/// <summary>
		/// Type of event resulting in this activity record.
		/// </summary>
		public string type;

		public ActivityRecord(){

		}

		~ActivityRecord(){

		}

		public override void Dispose(){

		}

	}//end ActivityRecord

}//end namespace Common