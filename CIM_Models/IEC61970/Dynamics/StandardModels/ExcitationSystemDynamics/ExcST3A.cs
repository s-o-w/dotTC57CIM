﻿///////////////////////////////////////////////////////////
//  ExcST3A.cs
//  Implementation of the Class ExcST3A
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
	/// Modified IEEE ST3A static excitation system with added speed multiplier.
	/// </summary>
	public class ExcST3A : ExcitationSystemDynamics {

		/// <summary>
		/// Maximum AVR output (<i>Efdmax</i>) (>= 0).  Typical value = 6,9.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efdmax;
		/// <summary>
		/// Rectifier loading factor proportional to commutating reactance (<i>Kc</i>) (>=
		/// 0). Typical value = 1,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kc;
		/// <summary>
		/// Feedback gain constant of the inner loop field regulator (<i>Kg</i>) (>= 0).
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kg;
		/// <summary>
		/// Potential circuit gain coefficient (<i>K</i><i><sub>i</sub></i>) (>= 0).
		/// Typical value = 4,83.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ki;
		/// <summary>
		/// AVR gain (<i>Kj</i>) (> 0).  Typical value = 200.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kj;
		/// <summary>
		/// Forward gain constant of the inner loop field regulator (<i>Km</i>) (> 0).
		/// Typical value = 7,04.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU km;
		/// <summary>
		/// Potential source gain (<i>K</i><i><sub>p</sub></i>) (> 0).  Typical value = 4,
		/// 37.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kp;
		/// <summary>
		/// Coefficient to allow different usage of the model-speed coefficient (<i>Ks</i>).
		///  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ks;
		/// <summary>
		/// Coefficient to allow different usage of the model-speed coefficient
		/// (<i>Ks1</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ks1;
		/// <summary>
		/// Voltage regulator time constant (<i>Tb</i>) (>= 0).  Typical value = 6,67.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tb;
		/// <summary>
		/// Voltage regulator time constant (<i>Tc</i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tc;
		/// <summary>
		/// Potential circuit phase angle (<i>theta</i><i><sub>p</sub></i>).  Typical value
		/// = 20.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.AngleDegrees thetap;
		/// <summary>
		/// Forward time constant of inner loop field regulator (<i>Tm</i>) (> 0).  Typical
		/// value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tm;
		/// <summary>
		/// Maximum excitation voltage (<i>Vbmax</i>) (> 0).  Typical value = 8,63.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vbmax;
		/// <summary>
		/// Maximum inner loop feedback voltage (<i>Vgmax</i>) (>= 0).  Typical value = 6,
		/// 53.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vgmax;
		/// <summary>
		/// Maximum voltage regulator input limit (<i>Vimax</i>) (> 0).  Typical value = 0,
		/// 2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vimax;
		/// <summary>
		/// Minimum voltage regulator input limit (<i>Vimin</i>) (< 0).  Typical value = -0,
		/// 2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vimin;
		/// <summary>
		/// Maximum voltage regulator output (<i>Vrmax</i>) (> 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmax;
		/// <summary>
		/// Minimum voltage regulator output (<i>Vrmin</i>) (< 0).  Typical value = -1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmin;
		/// <summary>
		/// Reactance associated with potential source (<i>Xl</i>) (>= 0).  Typical value =
		/// 0,09.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU xl;

		public ExcST3A(){

		}

		~ExcST3A(){

		}

		public override void Dispose(){

		}

	}//end ExcST3A

}//end namespace ExcitationSystemDynamics