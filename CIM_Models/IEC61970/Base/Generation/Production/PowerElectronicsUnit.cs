///////////////////////////////////////////////////////////
//  PowerElectronicsUnit.cs
//  Implementation of the Class PowerElectronicsUnit
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:14 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Generation.Production {
	/// <summary>
	/// A generating unit or battery or aggregation that connects to the AC network
	/// using power electronics rather than rotating machines.
	/// </summary>
	public class PowerElectronicsUnit : Equipment {

		/// <summary>
		/// Maximum active power limit. This is the maximum (nameplate) limit for the unit.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower maxP;
		/// <summary>
		/// Minimum active power limit. This is the minimum (nameplate) limit for the unit.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower minP;

		public PowerElectronicsUnit(){

		}

		~PowerElectronicsUnit(){

		}

		public override void Dispose(){

		}

	}//end PowerElectronicsUnit

}//end namespace Production