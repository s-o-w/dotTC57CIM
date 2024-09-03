﻿///////////////////////////////////////////////////////////
//  BreakerInfo.cs
//  Implementation of the Class BreakerInfo
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:59 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.InfIEC61968.InfAssetInfo;
namespace TC57CIM.IEC61968.InfIEC61968.InfAssetInfo {
	/// <summary>
	/// Properties of breaker assets.
	/// </summary>
	public class BreakerInfo : OldSwitchInfo {

		/// <summary>
		/// Phase trip rating.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CurrentFlow phaseTrip;

		public BreakerInfo(){

		}

		~BreakerInfo(){

		}

		public override void Dispose(){

		}

	}//end BreakerInfo

}//end namespace InfAssetInfo