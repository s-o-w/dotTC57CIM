﻿///////////////////////////////////////////////////////////
//  MeasurementCalculatorInput.cs
//  Implementation of the Class MeasurementCalculatorInput
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:07 AM
//  Original author: sveinols
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Meas;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.InfIEC61970.InfSIPS {
	/// <summary>
	/// Input to measurement calculation.  Support Analog, Discrete and Accumulator.
	/// </summary>
	public class MeasurementCalculatorInput : IdentifiedObject {

		/// <summary>
		/// If true, use the absolute value for the calculation.
		/// </summary>
		public bool absoluteValue;
		/// <summary>
		/// Positive number that defines the order of the operant in the calculation. 0 =
		/// default. The order is not relevant (e.g. summation).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer order;
		/// <summary>
		/// Measurement used as input to a calculation.
		/// </summary>
		public TC57CIM.IEC61970.Base.Meas.Measurement Measurement;

		public MeasurementCalculatorInput(){

		}

		~MeasurementCalculatorInput(){

		}

		public override void Dispose(){

		}

	}//end MeasurementCalculatorInput

}//end namespace InfSIPS