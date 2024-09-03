﻿///////////////////////////////////////////////////////////
//  DCPolarityKind.cs
//  Implementation of the Class DCPolarityKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:47 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.Base.DC {
	/// <summary>
	/// Polarity for DC circuits.
	/// </summary>
	public enum DCPolarityKind : int {

		/// <summary>
		/// Positive pole. The converter terminal is intended to operate at a positive
		/// voltage relative the midpoint or negative terminal.
		/// </summary>
		positive,
		/// <summary>
		/// Middle pole. The converter terminal is the midpoint in a bipolar or symmetric
		/// monopole configuration. The midpoint can be grounded and/or have a metallic
		/// return.
		/// </summary>
		middle,
		/// <summary>
		/// Negative pole. The converter terminal is intended to operate at a negative
		/// voltage relative the midpoint or positive terminal.
		/// </summary>
		negative

	}//end DCPolarityKind

}//end namespace DC