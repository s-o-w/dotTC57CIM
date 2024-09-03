﻿///////////////////////////////////////////////////////////
//  ShortCircuitRotorKind.cs
//  Implementation of the Class ShortCircuitRotorKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:21 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// Type of rotor, used by short circuit applications.
	/// </summary>
	public enum ShortCircuitRotorKind : int {

		/// <summary>
		/// Salient pole 1 in IEC 60909.
		/// </summary>
		salientPole1,
		/// <summary>
		/// Salient pole 2 in IEC 60909.
		/// </summary>
		salientPole2,
		/// <summary>
		/// Turbo Series 1 in IEC 60909.
		/// </summary>
		turboSeries1,
		/// <summary>
		/// Turbo series 2 in IEC 60909.
		/// </summary>
		turboSeries2

	}//end ShortCircuitRotorKind

}//end namespace Wires