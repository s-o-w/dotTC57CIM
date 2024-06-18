///////////////////////////////////////////////////////////
//  ExcDC2A.cs
//  Implementation of the Class ExcDC2A
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:52 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Modified IEEE DC2A direct current commutator exciter with speed input, one more
	/// leg block in feedback loop and without underexcitation limiters (UEL) inputs.
	/// DC type 2 excitation system model with added speed multiplier, added lead-lag,
	/// and voltage-dependent limits.
	/// </summary>
	public class ExcDC2A : ExcitationSystemDynamics {

		/// <summary>
		/// Exciter voltage at which exciter saturation is defined
		/// (<i>Efd</i><i><sub>1</sub></i>) (> 0).  Typical value = 3,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efd1;
		/// <summary>
		/// Exciter voltage at which exciter saturation is defined
		/// (<i>Efd</i><i><sub>2</sub></i>) (> 0).  Typical value = 2,29.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efd2;
		/// <summary>
		/// (<i>exclim</i>).  IEEE standard is ambiguous about lower limit on exciter
		/// output.
		/// true = a lower limit of zero is applied to integrator output
		/// false = a lower limit of zero is not applied to integrator output.
		/// Typical value = true.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean exclim;
		/// <summary>
		/// Voltage regulator gain (<i>Ka</i>) (> 0).  Typical value = 300.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ka;
		/// <summary>
		/// Exciter constant related to self-excited field (<i>Ke</i>).  If <i>Ke</i> is
		/// entered as zero, the model calculates an effective value of <i>Ke</i> such that
		/// the initial condition value of <i>Vr</i> is zero. The zero value of <i>Ke</i>
		/// is not changed.  If <i>Ke</i> is entered as non-zero, its value is used
		/// directly, without change.  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ke;
		/// <summary>
		/// Excitation control system stabilizer gain (<i>Kf</i>) (>= 0).  Typical value =
		/// 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kf;
		/// <summary>
		/// Coefficient to allow different usage of the model-speed coefficient (<i>Ks</i>).
		///  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ks;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>Efd</i><i><sub>1</sub></i> (<i>Se[Efd</i><i><sub>1</sub></i><i>]</i>) (>= 0).
		///  Typical value = 0,279.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float seefd1;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>Efd</i><i><sub>2</sub></i> (<i>Se[Efd</i><i><sub>2</sub></i><i>]</i>) (>= 0).
		///  Typical value = 0,117.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float seefd2;
		/// <summary>
		/// Voltage regulator time constant (<i>Ta</i>) (> 0).  Typical value = 0,01.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ta;
		/// <summary>
		/// Voltage regulator time constant (<i>Tb</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tb;
		/// <summary>
		/// Voltage regulator time constant (<i>Tc</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tc;
		/// <summary>
		/// Exciter time constant, integration rate associated with exciter control
		/// (<i>Te</i>) (> 0).  Typical value = 1,33.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds te;
		/// <summary>
		/// Excitation control system stabilizer time constant (<i>Tf</i>) (> 0).  Typical
		/// value = 0,675.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tf;
		/// <summary>
		/// Excitation control system stabilizer time constant (<i>Tf1</i>) (>= 0).
		/// Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tf1;
		/// <summary>
		/// Maximum voltage regulator output (<i>Vrmax</i>) (> ExcDC2A.vrmin).  Typical
		/// value = 4,95.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmax;
		/// <summary>
		/// Minimum voltage regulator output (<i>Vrmin</i>) (< 0 and < ExcDC2A.vrmax).
		/// Typical value = -4,9.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmin;
		/// <summary>
		/// (<i>Vtlim</i>).
		/// true = limiter at the block (<i>Ka / [1 + sTa]</i>) is dependent on <i>Vt </i>
		/// false = limiter at the block is not dependent on <i>Vt</i>.
		/// Typical value = true.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean vtlim;

		public ExcDC2A(){

		}

		~ExcDC2A(){

		}

		public override void Dispose(){

		}

	}//end ExcDC2A

}//end namespace ExcitationSystemDynamics