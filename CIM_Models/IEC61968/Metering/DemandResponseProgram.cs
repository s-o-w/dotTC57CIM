///////////////////////////////////////////////////////////
//  DemandResponseProgram.cs
//  Implementation of the Class DemandResponseProgram
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:04 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Metering;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61968.Customers;
namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Demand response program.
	/// </summary>
	public class DemandResponseProgram : IdentifiedObject {

		/// <summary>
		/// Type of demand response program; examples are CPP (critical-peak pricing), RTP
		/// (real-time pricing), DLC (direct load control), DBP (demand bidding program),
		/// BIP (base interruptible program). Note that possible types change a lot and it
		/// would be impossible to enumerate them all.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String type;
		/// <summary>
		/// Interval within which the program is valid.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTimeInterval validityInterval;
		/// <summary>
		/// All groups of end devices enrolled in this demand response program.
		/// </summary>
		public TC57CIM.IEC61968.Metering.EndDeviceGroup EndDeviceGroups;
		/// <summary>
		/// All usage point groups enrolled in this demand response program.
		/// </summary>
		public TC57CIM.IEC61968.Metering.UsagePointGroup UsagePointGroups;
		/// <summary>
		/// All customer agreements through which the customer is enrolled in this demand
		/// response program.
		/// </summary>
		public TC57CIM.IEC61968.Customers.CustomerAgreement CustomerAgreements;

		public DemandResponseProgram(){

		}

		~DemandResponseProgram(){

		}

		public override void Dispose(){

		}

	}//end DemandResponseProgram

}//end namespace Metering