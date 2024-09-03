﻿///////////////////////////////////////////////////////////
//  BreakerFailureReasonKind.cs
//  Implementation of the Class BreakerFailureReasonKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:59 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Reason for breaker failure.
	/// Note: This enumeration provides essential information to asset health analytics.
	/// The existing list is a starting point and is anticipated to be fleshed out
	/// further as requirements are better understood (PAB 2016/01/09).
	/// </summary>
	public enum BreakerFailureReasonKind : int {

		/// <summary>
		/// Blast valve failure.
		/// </summary>
		blastValveFailure,
		/// <summary>
		/// Bushing failure.
		/// </summary>
		bushingFailure,
		/// <summary>
		/// Close coil open shorted failure.
		/// </summary>
		closeCoilOpenShortedFailed,
		/// <summary>
		/// Contaminated air.
		/// </summary>
		contaminatedAir,
		/// <summary>
		/// Contaminated arc chutes.
		/// </summary>
		contaminatedArcChutes,
		/// <summary>
		/// Contaminated gas.
		/// </summary>
		contaminatedGas,
		/// <summary>
		/// Contaminated gas or air.
		/// </summary>
		contaminatedGasAir,
		/// <summary>
		/// Control circuit failure.
		/// </summary>
		controlCircuitFailure,
		/// <summary>
		/// Degraded lubrication.
		/// </summary>
		degradedLubrication,
		/// <summary>
		/// External or internal contamination.
		/// </summary>
		externalOrInternalContamination,
		/// <summary>
		/// High pressure air plant.
		/// </summary>
		highPressureAirPlant,
		/// <summary>
		/// High resistance load path.
		/// </summary>
		highResistanceLoadPath,
		/// <summary>
		/// High resistance path.
		/// </summary>
		highResistancePath,
		/// <summary>
		/// Interrupter contact failure.
		/// </summary>
		interrupterContactFailure,
		/// <summary>
		/// Interrupter failure.
		/// </summary>
		interrupterFailure,
		/// <summary>
		/// Linkage failure.
		/// </summary>
		linkageFailure,
		/// <summary>
		/// Loss of oil.
		/// </summary>
		lossOfOil,
		/// <summary>
		/// Loss of vacuum.
		/// </summary>
		lossOfVacuum,
		/// <summary>
		/// Low gas pressure.
		/// </summary>
		lowGasPressure,
		/// <summary>
		/// Blast valve failure.
		/// </summary>
		mechanismFailure,
		/// <summary>
		/// Mechanism or linkage failure.
		/// </summary>
		mechanismOrLinkageFailure,
		/// <summary>
		/// Oil-related failure.
		/// </summary>
		oilRelatedFailure,
		/// <summary>
		/// Poor oil quality.
		/// </summary>
		poorOilQuality,
		/// <summary>
		/// Racking mechanism failure.
		/// </summary>
		rackingMechanismFailure,
		/// <summary>
		/// Resistor failure.
		/// </summary>
		resistorFailure,
		/// <summary>
		/// Resistor grading capacitor failure.
		/// </summary>
		resistorGradingCapacitorFailure,
		/// <summary>
		/// SF6 blast valve failure.
		/// </summary>
		SF6BlastValveFailure,
		/// <summary>
		/// SF6 puffer valve failure.
		/// </summary>
		SF6PufferFailure,
		/// <summary>
		/// Solid dielectric failure.
		/// </summary>
		solidDielectricFailure,
		/// <summary>
		/// Stored energy failure.
		/// </summary>
		storedEnergyFailure,
		/// <summary>
		/// Trip coil open shorted failure.
		/// </summary>
		tripCoilOpenShortedFailed

	}//end BreakerFailureReasonKind

}//end namespace Assets