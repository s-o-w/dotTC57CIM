///////////////////////////////////////////////////////////
//  CombinedCyclePlant.cs
//  Implementation of the Class CombinedCyclePlant
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:42 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Generation.Production;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Generation.Production {
	/// <summary>
	/// A set of combustion turbines and steam turbines where the exhaust heat from the
	/// combustion turbines is recovered to make steam for the steam turbines,
	/// resulting in greater overall plant efficiency.
	/// </summary>
	public class CombinedCyclePlant : PowerSystemResource {

		/// <summary>
		/// The combined cycle plant's active power output rating.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower combCyclePlantRating;
		/// <summary>
		/// A thermal generating unit may be a member of a combined cycle plant.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.ThermalGeneratingUnit ThermalGeneratingUnits;

		public CombinedCyclePlant(){

		}

		~CombinedCyclePlant(){

		}

		public override void Dispose(){

		}

	}//end CombinedCyclePlant

}//end namespace Production