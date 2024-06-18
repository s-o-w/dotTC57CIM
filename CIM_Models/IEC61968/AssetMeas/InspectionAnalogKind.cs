///////////////////////////////////////////////////////////
//  InspectionAnalogKind.cs
//  Implementation of the Class InspectionAnalogKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:12 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61968.AssetMeas {
	/// <summary>
	/// Analogs typically recorded during a field inspection.
	/// </summary>
	public enum InspectionAnalogKind : int {

		/// <summary>
		/// Analog value represents SF6 gas pressure.
		/// </summary>
		sF6PressureReading,
		/// <summary>
		/// Analog value represents air pressure.
		/// </summary>
		airPressureReading,
		/// <summary>
		/// Analog value represents High Pressure system air pressure.
		/// </summary>
		airPressureHPSystemReading,
		/// <summary>
		/// Analog value represents reading from compressor hour meter.
		/// </summary>
		compressorHourMeterReading,
		/// <summary>
		/// Analog value represents Low Pressure system air pressure.
		/// </summary>
		airPressureLPSystemReading

	}//end InspectionAnalogKind

}//end namespace AssetMeas