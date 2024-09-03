﻿///////////////////////////////////////////////////////////
//  PhaseTapChangerTablePoint.cs
//  Implementation of the Class PhaseTapChangerTablePoint
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:13 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Wires;
namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// Describes each tap step in the phase tap changer tabular curve.
	/// </summary>
	public class PhaseTapChangerTablePoint : TapChangerTablePoint {

		/// <summary>
		/// The angle difference in degrees. A positive value indicates a positive angle
		/// variation from the Terminal at the  PowerTransformerEnd,  where the TapChanger
		/// is located, into the transformer.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.AngleDegrees angle;
		/// <summary>
		/// The table of this point.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.PhaseTapChangerTable PhaseTapChangerTable;

		public PhaseTapChangerTablePoint(){

		}

		~PhaseTapChangerTablePoint(){

		}

		public override void Dispose(){

		}

	}//end PhaseTapChangerTablePoint

}//end namespace Wires