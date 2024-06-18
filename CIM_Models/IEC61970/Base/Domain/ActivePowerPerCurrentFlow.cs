///////////////////////////////////////////////////////////
//  ActivePowerPerCurrentFlow.cs
//  Implementation of the Class ActivePowerPerCurrentFlow
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:39 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Active power variation with current flow.
	/// </summary>
	public class ActivePowerPerCurrentFlow {

		public UnitMultiplier multiplier;
		public static readonly UnitSymbol unit = UnitSymbol.WPerA;
		public Float value;

		public ActivePowerPerCurrentFlow(){

		}

		~ActivePowerPerCurrentFlow(){

		}

		public virtual void Dispose(){

		}

	}//end ActivePowerPerCurrentFlow

}//end namespace Domain