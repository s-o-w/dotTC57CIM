﻿///////////////////////////////////////////////////////////
//  PhaseTapChangerNonLinear.cs
//  Implementation of the Class PhaseTapChangerNonLinear
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
	/// The non-linear phase tap changer describes the non-linear behaviour of a phase
	/// tap changer. This is a base class for the symmetrical and asymmetrical phase
	/// tap changer models. The details of these models can be found in IEC 61970-301.
	/// </summary>
	public class PhaseTapChangerNonLinear : PhaseTapChanger {

		/// <summary>
		/// The voltage step increment on the out of phase winding (the PowerTransformerEnd
		/// where the TapChanger is located) specified in percent of rated voltage of the
		/// PowerTransformerEnd. A positive value means a positive voltage variation from
		/// the Terminal at the PowerTransformerEnd, where the TapChanger is located, into
		/// the transformer.
		/// When the increment is negative, the voltage decreases when the tap step
		/// increases.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PerCent voltageStepIncrement;
		/// <summary>
		/// The reactance depends on the tap position according to a "u" shaped curve. The
		/// maximum reactance (xMax) appears at the low and high tap positions. Depending
		/// on the �u� curve the attribute can be either higher or lower than
		/// PowerTransformerEnd.x.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance xMax;
		/// <summary>
		/// The reactance depend on the tap position according to a "u" shaped curve. The
		/// minimum reactance (xMin) appear at the mid tap position.   PowerTransformerEnd.
		/// x shall be consistent with PhaseTapChangerLinear.xMin and
		/// PhaseTapChangerNonLinear.xMin. In case of inconsistency, PowerTransformerEnd.x
		/// shall be used.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance xMin;

		public PhaseTapChangerNonLinear(){

		}

		~PhaseTapChangerNonLinear(){

		}

		public override void Dispose(){

		}

	}//end PhaseTapChangerNonLinear

}//end namespace Wires