﻿///////////////////////////////////////////////////////////
//  AirCompressor.cs
//  Implementation of the Class AirCompressor
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:39 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Generation.Production {
	/// <summary>
	/// Combustion turbine air compressor which is an integral part of a compressed air
	/// energy storage (CAES) plant.
	/// </summary>
	public class AirCompressor : PowerSystemResource {

		/// <summary>
		/// Rating of the CAES air compressor.
		/// </summary>
		public float airCompressorRating;

		public AirCompressor(){

		}

		~AirCompressor(){

		}

		public override void Dispose(){

		}

	}//end AirCompressor

}//end namespace Production