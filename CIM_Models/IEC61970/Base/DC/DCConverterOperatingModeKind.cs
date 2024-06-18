///////////////////////////////////////////////////////////
//  DCConverterOperatingModeKind.cs
//  Implementation of the Class DCConverterOperatingModeKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:46 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.Base.DC {
	/// <summary>
	/// The operating mode of an HVDC bipole.
	/// </summary>
	public enum DCConverterOperatingModeKind : int {

		/// <summary>
		/// Bipolar operation.
		/// </summary>
		bipolar,
		/// <summary>
		/// Monopolar operation with metallic return.
		/// </summary>
		monopolarMetallicReturn,
		/// <summary>
		/// Monopolar operation with ground return.
		/// </summary>
		monopolarGroundReturn

	}//end DCConverterOperatingModeKind

}//end namespace DC