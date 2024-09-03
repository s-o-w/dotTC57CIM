﻿///////////////////////////////////////////////////////////
//  EndDeviceEvent.cs
//  Implementation of the Class EndDeviceEvent
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:07 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Common;
using TC57CIM.IEC61968.Metering;
namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Event detected by a device function associated with the end device.
	/// </summary>
	public class EndDeviceEvent : ActivityRecord {

		/// <summary>
		/// Unique identifier of the business entity originating an end device control.
		/// </summary>
		public string issuerID;
		/// <summary>
		/// Identifier assigned by the initiator (e.g. retail electric provider) of an end
		/// device control action to uniquely identify the demand response event, text
		/// message, or other subject of the control action. Can be used when cancelling an
		/// event or text message request or to identify the originating event or text
		/// message in a consequential end device event.
		/// </summary>
		public string issuerTrackingID;
		/// <summary>
		/// (if user initiated) ID of user who initiated this end device event.
		/// </summary>
		public string userID;
		/// <summary>
		/// End device that reported this end device event.
		/// </summary>
		public TC57CIM.IEC61968.Metering.EndDevice EndDevice;
		/// <summary>
		/// All details of this end device event.
		/// </summary>
		public TC57CIM.IEC61968.Metering.EndDeviceEventDetail EndDeviceEventDetails;
		/// <summary>
		/// Type of this end device event.
		/// </summary>
		public TC57CIM.IEC61968.Metering.EndDeviceEventType EndDeviceEventType;
		/// <summary>
		/// Usage point for which this end device event is reported.
		/// </summary>
		public TC57CIM.IEC61968.Metering.UsagePoint UsagePoint;

		public EndDeviceEvent(){

		}

		~EndDeviceEvent(){

		}

		public override void Dispose(){

		}

	}//end EndDeviceEvent

}//end namespace Metering