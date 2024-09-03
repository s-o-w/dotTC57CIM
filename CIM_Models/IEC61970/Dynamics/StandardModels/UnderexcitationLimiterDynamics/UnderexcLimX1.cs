﻿///////////////////////////////////////////////////////////
//  UnderexcLimX1.cs
//  Implementation of the Class UnderexcLimX1
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:28 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.UnderexcitationLimiterDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.UnderexcitationLimiterDynamics {
	/// <summary>
	/// <font color="#0f0f0f">Allis-Chalmers minimum excitation limiter.</font>
	/// </summary>
	public class UnderexcLimX1 : UnderexcitationLimiterDynamics {

		/// <summary>
		/// Minimum excitation limit slope (<i>K</i>) (> 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k;
		/// <summary>
		/// Differential gain (<i>K</i><i><sub>F2</sub></i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kf2;
		/// <summary>
		/// Minimum excitation limit gain (<i>K</i><i><sub>M</sub></i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU km;
		/// <summary>
		/// Minimum excitation limit value (<i>MELMAX</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU melmax;
		/// <summary>
		/// Differential time constant (<i>T</i><i><sub>F2</sub></i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tf2;
		/// <summary>
		/// Minimum excitation limit time constant (<i>T</i><i><sub>M</sub></i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tm;

		public UnderexcLimX1(){

		}

		~UnderexcLimX1(){

		}

		public override void Dispose(){

		}

	}//end UnderexcLimX1

}//end namespace UnderexcitationLimiterDynamics