///////////////////////////////////////////////////////////
//  CAESPlant.cs
//  Implementation of the Class CAESPlant
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
	/// Compressed air energy storage plant.
	/// </summary>
	public class CAESPlant : PowerSystemResource {

		/// <summary>
		/// The rated energy storage capacity. The attribute shall be a positive value.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.RealEnergy energyStorageCapacity;
		/// <summary>
		/// The CAES plant's gross rated generating capacity. The attribute shall be a
		/// positive value.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower ratedCapacityP;
		/// <summary>
		/// A thermal generating unit may be a member of a compressed air energy storage
		/// plant.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.ThermalGeneratingUnit ThermalGeneratingUnit;
		/// <summary>
		/// An air compressor may be a member of a compressed air energy storage plant.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.AirCompressor AirCompressor;

		public CAESPlant(){

		}

		~CAESPlant(){

		}

		public override void Dispose(){

		}

	}//end CAESPlant

}//end namespace Production