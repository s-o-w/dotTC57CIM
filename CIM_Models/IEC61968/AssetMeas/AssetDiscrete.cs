﻿///////////////////////////////////////////////////////////
//  AssetDiscrete.cs
//  Implementation of the Class AssetDiscrete
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:57 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.AssetInfo.Assets;
using TC57CIM.IEC61970.Base.Meas;
namespace TC57CIM.IEC61968.AssetMeas {
	/// <summary>
	/// Definition of type of discrete useful in asset domain.
	/// </summary>
	public class AssetDiscrete : Discrete {

		/// <summary>
		/// The lab test standard to which this asset health discrete is related.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.Assets.TestStandard TestStandard;

		public AssetDiscrete(){

		}

		~AssetDiscrete(){

		}

		public override void Dispose(){

		}

	}//end AssetDiscrete

}//end namespace AssetMeas