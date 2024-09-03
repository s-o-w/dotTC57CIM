﻿///////////////////////////////////////////////////////////
//  SynchronousMachineTimeConstantReactance.cs
//  Implementation of the Class SynchronousMachineTimeConstantReactance
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:24 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.SynchronousMachineDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.SynchronousMachineDynamics {
	/// <summary>
	/// Synchronous machine detailed modelling types are defined by the combination of
	/// the attributes SynchronousMachineTimeConstantReactance.modelType and
	/// SynchronousMachineTimeConstantReactance.rotorType.
	/// Parameter details:
	/// <ol>
	/// 	<li>The �p� in the time-related attribute names is a substitution for a
	/// �prime� in the usual parameter notation, e.g. tpdo refers to <i>T'do</i>.</li>
	/// 	<li>The parameters used for models expressed in time constant reactance form
	/// include:</li>
	/// </ol>
	/// - RotatingMachine.ratedS (<i>MVAbase</i>);
	/// - RotatingMachineDynamics.damping (<i>D</i>);
	/// - RotatingMachineDynamics.inertia (<i>H</i>);
	/// - RotatingMachineDynamics.saturationFactor (<i>S1</i>);
	/// - RotatingMachineDynamics.saturationFactor120 (<i>S12</i>);
	/// - RotatingMachineDynamics.statorLeakageReactance (<i>Xl</i>);
	/// - RotatingMachineDynamics.statorResistance (<i>Rs</i>);
	/// - SynchronousMachineTimeConstantReactance.ks (<i>Ks</i>);
	/// - SynchronousMachineDetailed.saturationFactorQAxis (<i>S1q</i>);
	/// - SynchronousMachineDetailed.saturationFactor120QAxis (<i>S12q</i>);
	/// - SynchronousMachineDetailed.efdBaseRatio;
	/// - SynchronousMachineDetailed.ifdBaseType;
	/// - .xDirectSync (<i>Xd</i>);
	/// - .xDirectTrans (<i>X'd</i>);
	/// - .xDirectSubtrans (<i>X''d</i>);
	/// - .xQuadSync (<i>Xq</i>);
	/// - .xQuadTrans (<i>X'q</i>);
	/// - .xQuadSubtrans (<i>X''q</i>);
	/// - .tpdo (<i>T'do</i>);
	/// - .tppdo (<i>T''do</i>);
	/// - .tpqo (<i>T'qo</i>);
	/// - .tppqo (<i>T''qo</i>);
	/// - .tc.
	/// </summary>
	public class SynchronousMachineTimeConstantReactance : SynchronousMachineDetailed {

		/// <summary>
		/// Saturation loading correction factor (<i>Ks</i>) (>= 0).  Used only by type J
		/// model.  Typical value = 0.
		/// </summary>
		public float ks;
		/// <summary>
		/// Type of synchronous machine model used in dynamic simulation applications.
		/// </summary>
		public SynchronousMachineModelKind modelType;
		/// <summary>
		/// Type of rotor on physical machine.
		/// </summary>
		public RotorKind rotorType;
		/// <summary>
		/// Damping time constant for �Canay� reactance (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tc;
		/// <summary>
		/// Direct-axis transient rotor time constant (<i>T'do</i>) (>
		/// SynchronousMachineTimeConstantReactance.tppdo).  Typical value = 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tpdo;
		/// <summary>
		/// Direct-axis subtransient rotor time constant (<i>T''do</i>) (> 0).  Typical
		/// value = 0,03.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tppdo;
		/// <summary>
		/// Quadrature-axis subtransient rotor time constant (<i>T''qo</i>) (> 0). Typical
		/// value = 0,03.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tppqo;
		/// <summary>
		/// Quadrature-axis transient rotor time constant (<i>T'qo</i>) (>
		/// SynchronousMachineTimeConstantReactance.tppqo). Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tpqo;
		/// <summary>
		/// Direct-axis subtransient reactance (unsaturated) (<i>X''d</i>) (>
		/// RotatingMachineDynamics.statorLeakageReactance).  Typical value = 0,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU xDirectSubtrans;
		/// <summary>
		/// Direct-axis synchronous reactance (<i>Xd</i>) (>=
		/// SynchronousMachineTimeConstantReactance.xDirectTrans). The quotient of a
		/// sustained value of that AC component of armature voltage that is produced by
		/// the total direct-axis flux due to direct-axis armature current and the value of
		/// the AC component of this current, the machine running at rated speed.  Typical
		/// value = 1,8.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU xDirectSync;
		/// <summary>
		/// Direct-axis transient reactance (unsaturated) (<i>X'd</i>) (>=
		/// SynchronousMachineTimeConstantReactance.xDirectSubtrans).  Typical value = 0,5.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU xDirectTrans;
		/// <summary>
		/// Quadrature-axis subtransient reactance (<i>X''q</i>) (> RotatingMachineDynamics.
		/// statorLeakageReactance).  Typical value = 0,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU xQuadSubtrans;
		/// <summary>
		/// Quadrature-axis synchronous reactance (<i>Xq</i>) (>=
		/// SynchronousMachineTimeConstantReactance.xQuadTrans).
		/// The ratio of the component of reactive armature voltage, due to the quadrature-
		/// axis component of armature current, to this component of current, under steady
		/// state conditions and at rated frequency.  Typical value = 1,6.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU xQuadSync;
		/// <summary>
		/// Quadrature-axis transient reactance (<i>X'q</i>) (>=
		/// SynchronousMachineTimeConstantReactance.xQuadSubtrans).  Typical value = 0,3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU xQuadTrans;

		public SynchronousMachineTimeConstantReactance(){

		}

		~SynchronousMachineTimeConstantReactance(){

		}

		public override void Dispose(){

		}

	}//end SynchronousMachineTimeConstantReactance

}//end namespace SynchronousMachineDynamics