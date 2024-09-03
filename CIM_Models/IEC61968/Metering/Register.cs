﻿///////////////////////////////////////////////////////////
//  Register.cs
//  Implementation of the Class Register
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:22 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Metering;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// A device that indicates or records units of the commodity or other quantity
	/// measured.
	/// </summary>
	public class Register : IdentifiedObject {

		/// <summary>
		/// If true, the data it produces is  calculated or measured by a device other than
		/// a physical end device/meter. Otherwise, any data streams it produces are
		/// measured by the hardware of the end device/meter itself.
		/// </summary>
		public bool isVirtual;
		/// <summary>
		/// Number of digits (dials on a mechanical meter) to the left of the decimal place;
		/// default is normally 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer leftDigitCount;
		/// <summary>
		/// Number of digits (dials on a mechanical meter) to the right of the decimal
		/// place.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer rightDigitCount;
		/// <summary>
		/// Clock time interval for register to beging/cease accumulating time of usage (e.
		/// g., start at 8:00 am, stop at 5:00 pm).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.TimeInterval touTier;
		/// <summary>
		/// Name used for the time of use tier (also known as bin or bucket).  For example,
		/// "peak", "off-peak", "TOU Category A", etc.
		/// </summary>
		public string touTierName;
		/// <summary>
		/// All channels that collect/report values from this register.
		/// </summary>
		public TC57CIM.IEC61968.Metering.Channel Channels;
		/// <summary>
		/// End device function metering quantities displayed by this register.
		/// </summary>
		public TC57CIM.IEC61968.Metering.EndDeviceFunction EndDeviceFunction;

		public Register(){

		}

		~Register(){

		}

		public override void Dispose(){

		}

	}//end Register

}//end namespace Metering