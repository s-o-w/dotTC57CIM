﻿///////////////////////////////////////////////////////////
//  Hazard.cs
//  Implementation of the Class Hazard
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:12 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.Common;
using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61968.Customers;
using TC57CIM.IEC61968.Operations;
namespace TC57CIM.IEC61968.Common {
	/// <summary>
	/// An object or a condition that is a danger for causing loss or perils to an
	/// asset and/or people.
	/// </summary>
	public class Hazard : IdentifiedObject {

		/// <summary>
		/// Status of this hazard.
		/// </summary>
		public Status status;
		/// <summary>
		/// Type of this hazard.
		/// </summary>
		public string type;
		public TC57CIM.IEC61968.Customers.TroubleTicket TroubleTicket;
		public TC57CIM.IEC61968.Operations.Incident Incident;

		public Hazard(){

		}

		~Hazard(){

		}

		public override void Dispose(){

		}

	}//end Hazard

}//end namespace Common