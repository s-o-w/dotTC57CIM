///////////////////////////////////////////////////////////
//  VoltagePerReactivePower.cs
//  Implementation of the Class VoltagePerReactivePower
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:29 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Voltage variation with reactive power.
	/// </summary>
	public class VoltagePerReactivePower {

		public UnitMultiplier multiplier;
		public static readonly UnitSymbol unit = UnitSymbol.VPerVAr;
		public Float value;

		public VoltagePerReactivePower(){

		}

		~VoltagePerReactivePower(){

		}

		public virtual void Dispose(){

		}

	}//end VoltagePerReactivePower

}//end namespace Domain