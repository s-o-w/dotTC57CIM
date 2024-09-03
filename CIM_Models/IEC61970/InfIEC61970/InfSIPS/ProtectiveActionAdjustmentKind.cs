﻿///////////////////////////////////////////////////////////
//  ProtectiveActionAdjustmentKind.cs
//  Implementation of the Class ProtectiveActionAdjustmentKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:16 AM
//  Original author: sveinols
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.InfIEC61970.InfSIPS {
	/// <summary>
	/// Categorisation of different protective action adjustments that can be performed
	/// on equipment.
	/// </summary>
	public enum ProtectiveActionAdjustmentKind : int {

		/// <summary>
		/// The adjustment is in percentage of the active value.
		/// </summary>
		byPercentage,
		/// <summary>
		/// The adjustment is in given by a value that defined the changes that will be
		/// done to the active value.
		/// </summary>
		byValue,
		/// <summary>
		/// The equipment will operate on the new value.
		/// </summary>
		setValue,
		/// <summary>
		/// The equipment will operating on a value given by a measurement.
		/// </summary>
		measurement

	}//end ProtectiveActionAdjustmentKind

}//end namespace InfSIPS