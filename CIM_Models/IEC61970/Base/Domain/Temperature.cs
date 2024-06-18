///////////////////////////////////////////////////////////
//  Temperature.cs
//  Implementation of the Class Temperature
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:25 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Value of temperature in degrees Celsius.
	/// </summary>
	public class Temperature {

		public static readonly UnitMultiplier multiplier = UnitMultiplier.none;
		public static readonly UnitSymbol unit = UnitSymbol.degC;
		public Float value;

		public Temperature(){

		}

		~Temperature(){

		}

		public virtual void Dispose(){

		}

	}//end Temperature

}//end namespace Domain