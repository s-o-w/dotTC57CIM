///////////////////////////////////////////////////////////
//  ReactancePerLength.cs
//  Implementation of the Class ReactancePerLength
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:18 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Reactance (imaginary part of impedance) per unit of length, at rated frequency.
	/// 
	/// </summary>
	public class ReactancePerLength {

		public static readonly UnitMultiplier multiplier = UnitMultiplier.none;
		public static readonly UnitSymbol unit = UnitSymbol.ohmPerm;
		public Float value;

		public ReactancePerLength(){

		}

		~ReactancePerLength(){

		}

		public virtual void Dispose(){

		}

	}//end ReactancePerLength

}//end namespace Domain