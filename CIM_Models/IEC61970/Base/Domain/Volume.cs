﻿///////////////////////////////////////////////////////////
//  Volume.cs
//  Implementation of the Class Volume
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
	/// Volume.
	/// </summary>
	public class Volume {

		public UnitMultiplier multiplier;
		public static readonly UnitSymbol unit = UnitSymbol.m3;
		public Float value;

		public Volume(){

		}

		~Volume(){

		}

		public virtual void Dispose(){

		}

	}//end Volume

}//end namespace Domain