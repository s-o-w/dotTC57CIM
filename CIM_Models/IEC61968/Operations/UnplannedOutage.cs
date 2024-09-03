﻿///////////////////////////////////////////////////////////
//  UnplannedOutage.cs
//  Implementation of the Class UnplannedOutage
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:30 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Operations;
using TC57CIM.IEC61968.Customers;
namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// Document describing the consequence of an unplanned outage in a part of the
	/// electrical network. For the purposes of this model, an unplanned outage refers
	/// to a state where energy is not delivered; such as, customers out of service, a
	/// street light is not served, etc.
	/// A unplanned outage may be created upon:
	/// - impacts the SAIDI calculation
	/// - a breaker trip,
	/// - a fault indicator status change,
	/// - a meter event indicating customer outage,
	/// - a reception of one or more customer trouble calls, or
	/// - an operator command, reflecting information obtained from the field crew.
	/// Outage restoration may be performed using a switching plan which complements
	/// the outage information with detailed switching activities, including the
	/// relationship to the crew and work.
	/// </summary>
	public class UnplannedOutage : Outage {

		/// <summary>
		/// The cause of this outage.  This is the cause that is used to present to
		/// external entities.  That is, the cause is weather, equipment failure, etc.
		/// Note: At present, this is a free string text; it could be replaced with an
		/// enumeration in the future.
		/// </summary>
		public string cause;
		/// <summary>
		/// The possible cause that could be associated with this unplanned outage.
		/// </summary>
		public OutageCauseKind causeKind;
		/// <summary>
		/// The earliest start time of the Outage - as reported by some system or
		/// individual
		/// </summary>
		public System.DateTime reportedStartTime;
		/// <summary>
		/// The ticket called in by the customer that describes the trouble
		/// </summary>
		public TC57CIM.IEC61968.Customers.TroubleTicket TroubleTicket;
		/// <summary>
		/// The trouble order that is associated to the unplanned outage.
		/// </summary>
		public TC57CIM.IEC61968.Operations.TroubleOrder TroubleOrder;

		public UnplannedOutage(){

		}

		~UnplannedOutage(){

		}

		public override void Dispose(){

		}

	}//end UnplannedOutage

}//end namespace Operations