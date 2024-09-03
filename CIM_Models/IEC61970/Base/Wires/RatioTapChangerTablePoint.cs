﻿///////////////////////////////////////////////////////////
//  RatioTapChangerTablePoint.cs
//  Implementation of the Class RatioTapChangerTablePoint
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:18 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Wires;
namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// Describes each tap step in the ratio tap changer tabular curve.
	/// </summary>
	public class RatioTapChangerTablePoint : TapChangerTablePoint {

		/// <summary>
		/// Table of this point.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.RatioTapChangerTable RatioTapChangerTable;

		public RatioTapChangerTablePoint(){

		}

		~RatioTapChangerTablePoint(){

		}

		public override void Dispose(){

		}

	}//end RatioTapChangerTablePoint

}//end namespace Wires