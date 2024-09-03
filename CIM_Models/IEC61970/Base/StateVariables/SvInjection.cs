﻿///////////////////////////////////////////////////////////
//  SvInjection.cs
//  Implementation of the Class SvInjection
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
using TC57CIM.IEC61970.Base.Topology;
namespace TC57CIM.IEC61970.Base.StateVariables {
	/// <summary>
	/// The SvInjection reports the calculated bus injection minus the sum of the
	/// terminal flows. The terminal flow is positive out from the bus (load sign
	/// convention) and bus injection has positive flow into the bus. SvInjection may
	/// have the remainder after state estimation or slack after power flow calculation.
	/// 
	/// </summary>
	public class SvInjection : StateVariable {

		/// <summary>
		/// The terminal phase at which the connection is applied.   If missing, the
		/// injection is assumed to be balanced among non-neutral phases.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.SinglePhaseKind phase;
		/// <summary>
		/// The active power mismatch between calculated injection and initial injection.
		/// Positive sign means injection into the TopologicalNode (bus).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower pInjection;
		/// <summary>
		/// The reactive power mismatch between calculated injection and initial injection.
		/// Positive sign means injection into the TopologicalNode (bus).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ReactivePower qInjection;
		/// <summary>
		/// The topological node associated with the flow injection state variable.
		/// </summary>
		public TC57CIM.IEC61970.Base.Topology.TopologicalNode TopologicalNode;

		public SvInjection(){

		}

		~SvInjection(){

		}

		public override void Dispose(){

		}

	}//end SvInjection

}//end namespace StateVariables