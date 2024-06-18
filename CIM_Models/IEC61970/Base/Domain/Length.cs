///////////////////////////////////////////////////////////
//  Length.cs
//  Implementation of the Class Length
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:05 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Unit of length. It shall be a positive value or zero.
	/// </summary>
	public class Length {

		public UnitMultiplier multiplier;
		public static readonly UnitSymbol unit = UnitSymbol.m;
		public Float value;

		public Length(){

		}

		~Length(){

		}

		public virtual void Dispose(){

		}

	}//end Length

}//end namespace Domain