///////////////////////////////////////////////////////////
//  SwitchOperationSummary.cs
//  Implementation of the Class SwitchOperationSummary
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:27 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61968.AssetInfo.Assets;
namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Up-to-date, of-record summary of switch operation information, distilled from a
	/// variety of sources (real-time data or real-time data historian, field
	/// inspections, etc.) of use to asset health analytics.
	/// </summary>
	public class SwitchOperationSummary : IdentifiedObject {

		/// <summary>
		/// Total breaker fault operations to date.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer lifetimeFaultOperations;
		/// <summary>
		/// Total motor starts to date.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer lifetimeMotorStarts;
		/// <summary>
		/// Total breaker operations to date (including fault and non-fault).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer lifetimeTotalOperations;
		/// <summary>
		/// Date of most recent breaker fault operation.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Date mostRecentFaultOperationDate;
		/// <summary>
		/// Date of most recent motor start.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Date mostRecentMotorStartDate;
		/// <summary>
		/// Date of most recent breaker operation (fault or non-fault).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Date mostRecentOperationDate;
		/// <summary>
		/// Breaker asset to which this operation information applies.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.Assets.Asset Breaker;

		public SwitchOperationSummary(){

		}

		~SwitchOperationSummary(){

		}

		public override void Dispose(){

		}

	}//end SwitchOperationSummary

}//end namespace Assets