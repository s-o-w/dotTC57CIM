﻿///////////////////////////////////////////////////////////
//  Impedance.cs
//  Implementation of the Class Impedance
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:04 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Ratio of voltage to current.
	/// </summary>
	public class Impedance {

		public UnitMultiplier multiplier;
		public static readonly UnitSymbol unit = UnitSymbol.ohm;
		public Float value;

		public Impedance(){

		}

		~Impedance(){

		}

		public virtual void Dispose(){

		}

	}//end Impedance

}//end namespace Domain