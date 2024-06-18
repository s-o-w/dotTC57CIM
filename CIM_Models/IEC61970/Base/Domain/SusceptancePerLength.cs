///////////////////////////////////////////////////////////
//  SusceptancePerLength.cs
//  Implementation of the Class SusceptancePerLength
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:23 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Imaginary part of admittance per unit of length.
	/// </summary>
	public class SusceptancePerLength {

		public static readonly UnitMultiplier multiplier = UnitMultiplier.none;
		public static readonly UnitSymbol unit = UnitSymbol.SPerm;
		public Float value;

		public SusceptancePerLength(){

		}

		~SusceptancePerLength(){

		}

		public virtual void Dispose(){

		}

	}//end SusceptancePerLength

}//end namespace Domain