﻿///////////////////////////////////////////////////////////
//  TapeShieldCableInfo.cs
//  Implementation of the Class TapeShieldCableInfo
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:27 AM
//  Original author: Tom
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.AssetInfo;
namespace TC57CIM.IEC61968.AssetInfo {
	/// <summary>
	/// Tape shield cable data.
	/// </summary>
	public class TapeShieldCableInfo : CableInfo {

		/// <summary>
		/// Percentage of the tape shield width that overlaps in each wrap, typically 10%
		/// to 25%.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PerCent tapeLap;
		/// <summary>
		/// Thickness of the tape shield, before wrapping.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Length tapeThickness;

		public TapeShieldCableInfo(){

		}

		~TapeShieldCableInfo(){

		}

		public override void Dispose(){

		}

	}//end TapeShieldCableInfo

}//end namespace AssetInfo