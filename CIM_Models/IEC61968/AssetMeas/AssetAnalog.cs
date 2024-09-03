﻿///////////////////////////////////////////////////////////
//  AssetAnalog.cs
//  Implementation of the Class AssetAnalog
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:56 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.AssetInfo.Assets;
using TC57CIM.IEC61970.Base.Meas;
namespace TC57CIM.IEC61968.AssetMeas {
	/// <summary>
	/// Definition of type of analog useful in asset domain.
	/// </summary>
	public class AssetAnalog : Analog {

		/// <summary>
		/// Detection limit of related analog value if different from detection limit of
		/// test standard or if there is no test standard. The detection limit (also known
		/// as lower limit of detection or limit of detection (LOD), is the lowest quantity
		/// of a substance that can be distinguished from the absence of that substance (a
		/// blank value) within a stated confidence limit (generally 1%).
		/// </summary>
		public float detectionLimit;
		/// <summary>
		/// Precision of related analog value if different from precision of test standard
		/// or if there is no test standard. Precision is a measure of how closely
		/// individual measurements agree with one another. Expressed as 'plus or minus'
		/// the value of this attribute.
		/// </summary>
		public float precision;
		/// <summary>
		/// Reporting temperature of related analog value if different from reporting
		/// temperature of test standard or if there is no test standard. Reporting
		/// temperature is what gas volumes are normalized to. Different reporting
		/// temperatures are used by different sources. For example, ASTM specifies 0�C,
		/// whereas IEC specifies 20�C. Online monitors often have their own unique
		/// reporting temperatures.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Temperature reportingTemperature;
		/// <summary>
		/// The lab test standard to which this asset health analog is related.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.Assets.TestStandard TestStandard;

		public AssetAnalog(){

		}

		~AssetAnalog(){

		}

		public override void Dispose(){

		}

	}//end AssetAnalog

}//end namespace AssetMeas