﻿///////////////////////////////////////////////////////////
//  SvVoltage.cs
//  Implementation of the Class SvVoltage
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:23 AM
//  Original author: kdd
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Wires;
using TC57CIM.IEC61970.Base.StateVariables;
using TC57CIM.IEC61970.Base.Topology;
namespace TC57CIM.IEC61970.Base.StateVariables {
	/// <summary>
	/// State variable for voltage.
	/// </summary>
	public class SvVoltage : StateVariable {

		/// <summary>
		/// The voltage angle of the topological node complex voltage with respect to
		/// system reference.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.AngleDegrees angle;
		/// <summary>
		/// If specified the voltage is the line to ground voltage of the individual phase.
		///  If unspecified, then the voltage is assumed balanced.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.SinglePhaseKind phase;
		/// <summary>
		/// The voltage magnitude at the topological node. The attribute shall be a
		/// positive value.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage v;
		/// <summary>
		/// The topological node associated with the voltage state.
		/// </summary>
		public TC57CIM.IEC61970.Base.Topology.TopologicalNode TopologicalNode;

		public SvVoltage(){

		}

		~SvVoltage(){

		}

		public override void Dispose(){

		}

	}//end SvVoltage

}//end namespace StateVariables