﻿///////////////////////////////////////////////////////////
//  OilAnalysisPCBAnalogKind.cs
//  Implementation of the Class OilAnalysisPCBAnalogKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:17 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61968.AssetMeas {
	/// <summary>
	/// Analogs representing oil PCB analysis result.
	/// </summary>
	public enum OilAnalysisPCBAnalogKind : int {

		/// <summary>
		/// Concentration of Aroclor 1221 (in ppm, specifically in mg/kg).
		/// </summary>
		aroclor1221,
		/// <summary>
		/// Concentration of Aroclor 1242 (in ppm, specifically in mg/kg).
		/// </summary>
		aroclor1242,
		/// <summary>
		/// Concentration of Aroclor 1254 (in ppm, specifically in mg/kg).
		/// </summary>
		aroclor1254,
		/// <summary>
		/// Concentration of Aroclor 1260 (in ppm, specifically in mg/kg).
		/// </summary>
		aroclor1260,
		/// <summary>
		/// Concentration of Aroclor 1016 (in ppm, specifically in mg/kg).
		/// </summary>
		aroclor1016,
		/// <summary>
		/// Total arochlor (PCB) content (in ppm, specifically in mg/kg). Is the sum of
		/// Aroclor 1221, Aroclor 1242, Aroclor 1254, Aroclor 1260, Aroclor 1016.
		/// </summary>
		totalPCB

	}//end OilAnalysisPCBAnalogKind

}//end namespace AssetMeas