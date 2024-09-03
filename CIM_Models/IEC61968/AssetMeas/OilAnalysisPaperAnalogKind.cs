﻿///////////////////////////////////////////////////////////
//  OilAnalysisPaperAnalogKind.cs
//  Implementation of the Class OilAnalysisPaperAnalogKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:16 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61968.AssetMeas {
	/// <summary>
	/// Analogs representing oil paper degradation analysis result.
	/// </summary>
	public enum OilAnalysisPaperAnalogKind : int {

		/// <summary>
		/// 5-hydroxymethyl-2-furaldehyde (5H2F) (in ppb). Also known as: 5-hydroxymethyl-2-
		/// furfural, 5-hydroxymethyl-2-furaldehyde, 5-hydroxymethylfurfuraldehyde, and 5-
		/// hydroxymethylfurfural.
		/// </summary>
		hydroxymethylfurfural,
		/// <summary>
		/// Furfuryl alcohol (2FOL) (in ppb). Also known as: 2-furyl alcohol, 2-furfurol, 2-
		/// furylmethanol, 2-hydroxymethylfuran, 2-furancarbinol, furancarbinol, 2-
		/// furanmethanol, furanmethanol, furfural alcohol, and alpha-furylcarbinol.
		/// </summary>
		furfurylAlcohol,
		/// <summary>
		/// 2-furaldehyde (2FAL) (in ppb). Also known as: 2-furfural, 2-furaldehyde, 2-
		/// furanaldehyde, fural, furfuraldehyde, furaldehyde, and 2-furancarboxaldehyde.
		/// </summary>
		furfural,
		/// <summary>
		/// 5-methyl-2-furaldehyde (5M2F) (in ppb). Also known as: 5-methyl-2-furfural, 5-
		/// methyl-2-furaldehyde, 5-methyl-2-furfuraldehyde, and 5-methylfurfural.
		/// </summary>
		methylfurfural,
		/// <summary>
		/// Total furan (in ppb). Is the total of the concentrations of 5-hydroxymethyl-2-
		/// furaldehyde (5H2F), furfuryl alcohol (2FOL), 2-furaldehyde (2FAL), 2-
		/// acetylfuran (2ACF), 5-methyl-2-furaldehyde (5M2F).
		/// </summary>
		totalFuran,
		/// <summary>
		/// Direct measurement of degree of polymerization (DP) (unitless).
		/// </summary>
		degreeOfPolymerization,
		/// <summary>
		/// Calculated degree of polymerization (DP) calculated using the Chendong equation
		/// (unitless).
		/// </summary>
		degreeOfPolymerizationCalculated,
		/// <summary>
		/// Concentration of methanol (in ppb, specifically microgram/kilogram).
		/// </summary>
		methanol,
		/// <summary>
		/// Concentration of ethanol (in ppb, specifically microgram/kilogram).
		/// </summary>
		ethanol,
		/// <summary>
		/// Tensile strength (in kilonewtons/metre).
		/// </summary>
		tensileStrength,
		/// <summary>
		/// Dielectric breakdown of solid electrical insulating materials (in kV).
		/// </summary>
		solidInsulationDielectricStrength,
		/// <summary>
		/// 2-acetylfuran (2ACF) (in ppb). Also known as: 2-acetylfuran, furyl methyl
		/// ketone, 2-furyl methyl ketone, methyl 2-furyl ketone, and 1-(2-furanyl)ethanone.
		/// 
		/// </summary>
		acetylfuran

	}//end OilAnalysisPaperAnalogKind

}//end namespace AssetMeas