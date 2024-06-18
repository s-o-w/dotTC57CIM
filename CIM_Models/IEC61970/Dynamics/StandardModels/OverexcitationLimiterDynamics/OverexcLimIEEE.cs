///////////////////////////////////////////////////////////
//  OverexcLimIEEE.cs
//  Implementation of the Class OverexcLimIEEE
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:11 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.OverexcitationLimiterDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.OverexcitationLimiterDynamics {
	/// <summary>
	/// The over excitation limiter model is intended to represent the significant
	/// features of OELs necessary for some large-scale system studies. It is the
	/// result of a pragmatic approach to obtain a model that can be widely applied
	/// with attainable data from generator owners. An attempt to include all
	/// variations in the functionality of OELs and duplicate how they interact with
	/// the rest of the excitation systems would likely result in a level of
	/// application insufficient for the studies for which they are intended.
	/// Reference: IEEE OEL 421.5-2005, 9.
	/// </summary>
	public class OverexcLimIEEE : OverexcitationLimiterDynamics {

		/// <summary>
		/// OEL pickup/drop-out hysteresis (<i>HYST</i>).  Typical value = 0,03.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU hyst;
		/// <summary>
		/// OEL timed field current limit (<i>I</i><i><sub>FDLIM</sub></i>).  Typical value
		/// = 1,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ifdlim;
		/// <summary>
		/// OEL instantaneous field current limit (<i>I</i><i><sub>FDMAX</sub></i>).
		/// Typical value = 1,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ifdmax;
		/// <summary>
		/// OEL timed field current limiter pickup level (<i>I</i><i><sub>TFPU</sub></i>).
		/// Typical value = 1,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU itfpu;
		/// <summary>
		/// OEL cooldown gain (<i>K</i><i><sub>CD</sub></i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kcd;
		/// <summary>
		/// OEL ramped limit rate (<i>K</i><i><sub>RAMP</sub></i>).  Unit = PU / s.
		/// Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float kramp;

		public OverexcLimIEEE(){

		}

		~OverexcLimIEEE(){

		}

		public override void Dispose(){

		}

	}//end OverexcLimIEEE

}//end namespace OverexcitationLimiterDynamics