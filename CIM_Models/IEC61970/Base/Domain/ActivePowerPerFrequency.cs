﻿///////////////////////////////////////////////////////////
//  ActivePowerPerFrequency.cs
//  Implementation of the Class ActivePowerPerFrequency
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:39 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Active power variation with frequency.
	/// </summary>
	public class ActivePowerPerFrequency {

		public UnitMultiplier multiplier;
		public static readonly UnitSymbol unit = UnitSymbol.WPers;
		public Float value;

		public ActivePowerPerFrequency(){

		}

		~ActivePowerPerFrequency(){

		}

		public virtual void Dispose(){

		}

	}//end ActivePowerPerFrequency

}//end namespace Domain