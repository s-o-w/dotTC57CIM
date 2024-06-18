///////////////////////////////////////////////////////////
//  StatisticalCalculation.cs
//  Implementation of the Class StatisticalCalculation
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:25 AM
//  Original author: herb
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.AssetMeas;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.AssetMeas {
	/// <summary>
	/// Description of statistical calculation performed.
	/// </summary>
	public class StatisticalCalculation : IdentifiedObject {

		/// <summary>
		/// Calculation mode.
		/// </summary>
		public CalculationModeKind calculationMode;
		/// <summary>
		/// Kind of statistical calculation, specifying how the measurement value is
		/// calculated.
		/// </summary>
		public CalculationTechniqueKind calculationTechnique;
		/// <summary>
		/// The order in which this statistical calculation is done.
		/// </summary>
		public TC57CIM.IEC61968.AssetMeas.CalculationMethodOrder CalculationMethodOrder;

		public StatisticalCalculation(){

		}

		~StatisticalCalculation(){

		}

		public override void Dispose(){

		}

	}//end StatisticalCalculation

}//end namespace AssetMeas