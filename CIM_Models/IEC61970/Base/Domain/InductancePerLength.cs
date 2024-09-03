﻿///////////////////////////////////////////////////////////
//  InductancePerLength.cs
//  Implementation of the Class InductancePerLength
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:05 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Inductance per unit of length.
	/// </summary>
	public class InductancePerLength {

		public static readonly UnitMultiplier multiplier = UnitMultiplier.none;
		public static readonly UnitSymbol unit = UnitSymbol.HPerm;
		public Float value;

		public InductancePerLength(){

		}

		~InductancePerLength(){

		}

		public virtual void Dispose(){

		}

	}//end InductancePerLength

}//end namespace Domain