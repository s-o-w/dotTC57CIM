///////////////////////////////////////////////////////////
//  AccumulatorLimitSet.cs
//  Implementation of the Class AccumulatorLimitSet
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:38 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Meas;
namespace TC57CIM.IEC61970.Base.Meas {
	/// <summary>
	/// An AccumulatorLimitSet specifies a set of Limits that are associated with an
	/// Accumulator measurement.
	/// </summary>
	public class AccumulatorLimitSet : LimitSet {

		/// <summary>
		/// The limit values used for supervision of Measurements.
		/// </summary>
		public TC57CIM.IEC61970.Base.Meas.AccumulatorLimit Limits;

		public AccumulatorLimitSet(){

		}

		~AccumulatorLimitSet(){

		}

		public override void Dispose(){

		}

	}//end AccumulatorLimitSet

}//end namespace Meas