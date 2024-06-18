///////////////////////////////////////////////////////////
//  ExcST6B.cs
//  Implementation of the Class ExcST6B
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:55 AM
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
	/// Modified IEEE ST6B static excitation system with PID controller and optional
	/// inner feedback loop.
	/// </summary>
	public class ExcST6B : ExcitationSystemDynamics {

		/// <summary>
		/// Exciter output current limit reference (<i>Ilr</i>) (> 0).  Typical value = 4,
		/// 164.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ilr;
		/// <summary>
		/// Selector (<i>K1</i>).
		/// true = feedback is from <i>Ifd</i>
		/// false = feedback is not from <i>Ifd</i>.
		/// Typical value = true.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean k1;
		/// <summary>
		/// Exciter output current limit adjustment (<i>Kcl</i>) (> 0).  Typical value = 1,
		/// 0577.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kcl;
		/// <summary>
		/// Pre-control gain constant of the inner loop field regulator (<i>Kff</i>).
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kff;
		/// <summary>
		/// Feedback gain constant of the inner loop field regulator (<i>Kg</i>) (>= 0).
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kg;
		/// <summary>
		/// Voltage regulator integral gain (<i>Kia</i>) (> 0).  Typical value = 45,094.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kia;
		/// <summary>
		/// Exciter output current limit adjustment (<i>Kcl</i>) (> 0).  Typical value = 17,
		/// 33.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU klr;
		/// <summary>
		/// Forward gain constant of the inner loop field regulator (<i>Km</i>).  Typical
		/// value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU km;
		/// <summary>
		/// Voltage regulator proportional gain (<i>Kpa</i>) (> 0).  Typical value = 18,038.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kpa;
		/// <summary>
		/// Voltage regulator derivative gain (<i>Kvd</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kvd;
		/// <summary>
		/// OEL input selector (<i>OELin</i>).  Typical value = noOELinput (corresponds to
		/// <i>OELin</i> = 0 on diagram).
		/// </summary>
		public ExcST6BOELselectorKind oelin;
		/// <summary>
		/// Feedback time constant of inner loop field voltage regulator (<i>Tg</i>) (>= 0).
		///  Typical value = 0,02.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tg;
		/// <summary>
		/// Rectifier firing time constant (<i>Ts</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ts;
		/// <summary>
		/// Voltage regulator derivative gain (<i>Tvd</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tvd;
		/// <summary>
		/// Maximum voltage regulator output (<i>Vamax</i>) (> 0).  Typical value = 4,81.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vamax;
		/// <summary>
		/// Minimum voltage regulator output (<i>Vamin</i>) (< 0).  Typical value = -3,85.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vamin;
		/// <summary>
		/// Selector (<i>Vilim</i>).
		/// true = <i>Vimin</i>-<i>Vimax</i> limiter is active
		/// false = <i>Vimin</i>-<i>Vimax</i> limiter is not active.
		/// Typical value = true.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean vilim;
		/// <summary>
		/// Maximum voltage regulator input limit (<i>Vimax</i>) (> ExcST6B.vimin).
		/// Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vimax;
		/// <summary>
		/// Minimum voltage regulator input limit (<i>Vimin</i>) (< ExcST6B.vimax).
		/// Typical value = -10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vimin;
		/// <summary>
		/// Selector (<i>vmult</i>).
		/// true = multiply regulator output by terminal voltage
		/// false = do not multiply regulator output by terminal voltage.
		/// Typical value = true.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean vmult;
		/// <summary>
		/// Maximum voltage regulator output (<i>Vrmax</i>) (> 0).  Typical value = 4,81.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmax;
		/// <summary>
		/// Minimum voltage regulator output (<i>Vrmin</i>) (< 0).  Typical value = -3,85.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmin;
		/// <summary>
		/// Excitation source reactance (<i>Xc</i>).  Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU xc;

		public ExcST6B(){

		}

		~ExcST6B(){

		}

		public override void Dispose(){

		}

	}//end ExcST6B

}//end namespace ExcitationSystemDynamics