///////////////////////////////////////////////////////////
//  ExcELIN2.cs
//  Implementation of the Class ExcELIN2
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
	/// Detailed excitation system ELIN (VATECH).  This model represents an all-static
	/// excitation system. A PI voltage controller establishes a desired field current
	/// set point for a proportional current controller. The integrator of the PI
	/// controller has a follow-up input to match its signal to the present field
	/// current.  Power system stabilizer models used in conjunction with this
	/// excitation system model: PssELIN2, PssIEEE2B, Pss2B.
	/// </summary>
	public class ExcELIN2 : ExcitationSystemDynamics {

		/// <summary>
		/// Gain (<i>Efdbas</i>).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efdbas;
		/// <summary>
		/// Limiter (<i>I</i><i><sub>efmax</sub></i>) (> ExcELIN2.iefmin).  Typical value =
		/// 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU iefmax;
		/// <summary>
		/// Minimum open circuit excitation voltage (<i>I</i><i><sub>efmax2</sub></i>).
		/// Typical value = -5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU iefmax2;
		/// <summary>
		/// Limiter (<i>I</i><i><sub>efmin</sub></i>) (< ExcELIN2.iefmax).  Typical value =
		/// 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU iefmin;
		/// <summary>
		/// Voltage regulator input gain (<i>K1</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k1;
		/// <summary>
		/// Voltage regulator input limit (<i>K1ec</i>).  Typical value = 2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k1ec;
		/// <summary>
		/// Gain (<i>K2</i>).  Typical value = 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k2;
		/// <summary>
		/// Gain (<i>K3</i>).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k3;
		/// <summary>
		/// Gain (<i>K4</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k4;
		/// <summary>
		/// Voltage controller derivative gain (<i>Kd1</i>).  Typical value = 34,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kd1;
		/// <summary>
		/// Gain (<i>Ke2</i>).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ke2;
		/// <summary>
		/// Gain (<i>Ketb</i>).  Typical value = 0,06.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ketb;
		/// <summary>
		/// Controller follow up gain (<i>PID1max</i>).  Typical value = 2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pid1max;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>Ve</i><i><sub>1</sub></i>, back of commutating reactance
		/// (<i>Se[Ve</i><i><sub>1</sub></i><i>]</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU seve1;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>Ve</i><i><sub>2</sub></i>, back of commutating reactance
		/// (<i>Se[Ve</i><i><sub>2</sub></i><i>]</i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU seve2;
		/// <summary>
		/// Voltage controller derivative washout time constant (<i>Tb1</i>) (>= 0).
		/// Typical value = 12,45.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tb1;
		/// <summary>
		/// Time constant (<i>Te</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds te;
		/// <summary>
		/// Time Constant (<i>T</i><i><sub>e2</sub></i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds te2;
		/// <summary>
		/// Controller follow up deadband (<i>Ti1</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ti1;
		/// <summary>
		/// Time constant (<i>T</i><i><sub>i3</sub></i>) (>= 0).  Typical value = 3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ti3;
		/// <summary>
		/// Time constant (<i>T</i><i><sub>i4</sub></i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ti4;
		/// <summary>
		/// Time constant (<i>T</i><i><sub>r4</sub></i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tr4;
		/// <summary>
		/// Limiter (<i>Upmax</i>) (> ExcELIN2.upmin).  Typical value = 3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU upmax;
		/// <summary>
		/// Limiter (<i>Upmin</i>) (< ExcELIN2.upmax).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU upmin;
		/// <summary>
		/// Exciter alternator output voltages back of commutating reactance at which
		/// saturation is defined (<i>Ve</i><i><sub>1</sub></i>) (> 0).  Typical value = 3.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ve1;
		/// <summary>
		/// Exciter alternator output voltages back of commutating reactance at which
		/// saturation is defined (<i>Ve</i><i><sub>2</sub></i>) (> 0).  Typical value = 0.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ve2;
		/// <summary>
		/// Excitation transformer effective reactance (<i>Xp</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU xp;

		public ExcELIN2(){

		}

		~ExcELIN2(){

		}

		public override void Dispose(){

		}

	}//end ExcELIN2

}//end namespace ExcitationSystemDynamics