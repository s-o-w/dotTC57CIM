///////////////////////////////////////////////////////////
//  RandomisationKind.cs
//  Implementation of the Class RandomisationKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:21 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Kind of randomisation to be applied to control the timing of end device control
	/// commands and/or the definition of demand response and load control events.
	/// Value other than 'none' is typically used to mitigate potential deleterious
	/// effects of simultaneous operation of multiple devices.
	/// </summary>
	public enum RandomisationKind : int {

		/// <summary>
		/// Start time of an event or control action affecting one or more multiple devices
		/// is randomised.
		/// </summary>
		start,
		/// <summary>
		/// End time of an event or control action affecting one or more devices is
		/// randomised to prevent simultaneous operation.
		/// </summary>
		end,
		/// <summary>
		/// Both the start time and the end time of an event or control action affecting
		/// one or more devices are randomised to prevent simultaneous operation.
		/// </summary>
		startAndEnd,
		/// <summary>
		/// Randomisation of start and/or end times involving the operation of one or more
		/// devices is controlled by default settings for the device(s).
		/// </summary>
		default_,
		/// <summary>
		/// Neither the start time nor the end time of an event or control action affecting
		/// one or more devices is randomised.
		/// </summary>
		none

	}//end RandomisationKind

}//end namespace Metering