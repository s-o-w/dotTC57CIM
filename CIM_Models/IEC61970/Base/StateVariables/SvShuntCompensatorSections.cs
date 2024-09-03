﻿///////////////////////////////////////////////////////////
//  SvShuntCompensatorSections.cs
//  Implementation of the Class SvShuntCompensatorSections
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:23 AM
//  Original author: kdd
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Wires;
using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.StateVariables;
namespace TC57CIM.IEC61970.Base.StateVariables {
	/// <summary>
	/// State variable for the number of sections in service for a shunt compensator.
	/// </summary>
	public class SvShuntCompensatorSections : StateVariable {

		/// <summary>
		/// The terminal phase at which the connection is applied.   If missing, the
		/// injection is assumed to be balanced among non-neutral phases.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.SinglePhaseKind phase;
		/// <summary>
		/// The number of sections in service as a continuous variable. The attribute shall
		/// be a positive value or zero. To get integer value scale with ShuntCompensator.
		/// bPerSection.
		/// </summary>
		public float sections;
		/// <summary>
		/// The shunt compensator for which the state applies.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.ShuntCompensator ShuntCompensator;

		public SvShuntCompensatorSections(){

		}

		~SvShuntCompensatorSections(){

		}

		public override void Dispose(){

		}

	}//end SvShuntCompensatorSections

}//end namespace StateVariables