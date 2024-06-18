///////////////////////////////////////////////////////////
//  HeatRecoveryBoiler.cs
//  Implementation of the Class HeatRecoveryBoiler
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:01 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Generation.GenerationTrainingSimulation;
namespace TC57CIM.IEC61970.Base.Generation.GenerationTrainingSimulation {
	/// <summary>
	/// The heat recovery system associated with combustion turbines in order to
	/// produce steam for combined cycle plants.
	/// </summary>
	public class HeatRecoveryBoiler : FossilSteamSupply {

		/// <summary>
		/// The steam supply rating in kilopounds per hour, if dual pressure boiler.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float steamSupplyRating2;
		/// <summary>
		/// A combustion turbine may have a heat recovery boiler for making steam.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.GenerationTrainingSimulation.CombustionTurbine CombustionTurbines;

		public HeatRecoveryBoiler(){

		}

		~HeatRecoveryBoiler(){

		}

		public override void Dispose(){

		}

	}//end HeatRecoveryBoiler

}//end namespace GenerationTrainingSimulation