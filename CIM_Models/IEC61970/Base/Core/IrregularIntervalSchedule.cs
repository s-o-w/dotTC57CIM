///////////////////////////////////////////////////////////
//  IrregularIntervalSchedule.cs
//  Implementation of the Class IrregularIntervalSchedule
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:05 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// The schedule has time points where the time between them varies.
	/// </summary>
	public class IrregularIntervalSchedule : BasicIntervalSchedule {

		/// <summary>
		/// The point data values that define a curve.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.IrregularTimePoint TimePoints;

		public IrregularIntervalSchedule(){

		}

		~IrregularIntervalSchedule(){

		}

		public override void Dispose(){

		}

	}//end IrregularIntervalSchedule

}//end namespace Core