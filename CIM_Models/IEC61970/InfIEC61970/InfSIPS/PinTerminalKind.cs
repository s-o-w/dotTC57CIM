///////////////////////////////////////////////////////////
//  PinTerminalKind.cs
//  Implementation of the Class PinTerminalKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:13 AM
//  Original author: sveinols
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.InfIEC61970.InfSIPS {
	/// <summary>
	/// Categorisation of type of compare done on Terminal.
	/// </summary>
	public enum PinTerminalKind : int {

		/// <summary>
		/// Active Power on the Terminal.
		/// </summary>
		activePower,
		/// <summary>
		/// Apparent Power on the Terminal.
		/// </summary>
		apparentPower,
		/// <summary>
		/// Reactive Power on the Terminal.
		/// </summary>
		reactivePower,
		/// <summary>
		/// Voltage on the Terminal.
		/// </summary>
		voltage

	}//end PinTerminalKind

}//end namespace InfSIPS