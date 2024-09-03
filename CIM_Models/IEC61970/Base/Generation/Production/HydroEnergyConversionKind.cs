﻿///////////////////////////////////////////////////////////
//  HydroEnergyConversionKind.cs
//  Implementation of the Class HydroEnergyConversionKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:01 AM
//  Original author: kdd
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.Base.Generation.Production {
	/// <summary>
	/// Specifies the capability of the hydro generating unit to convert energy as a
	/// generator or pump.
	/// </summary>
	public enum HydroEnergyConversionKind : int {

		/// <summary>
		/// Able to generate power, but not able to pump water for energy storage.
		/// </summary>
		generator,
		/// <summary>
		/// Able to both generate power and pump water for energy storage.
		/// </summary>
		pumpAndGenerator

	}//end HydroEnergyConversionKind

}//end namespace Production