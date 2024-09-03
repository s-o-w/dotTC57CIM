﻿///////////////////////////////////////////////////////////
//  GovSteamBB.cs
//  Implementation of the Class GovSteamBB
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:00 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.TurbineGovernorDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.TurbineGovernorDynamics {
	/// <summary>
	/// European governor model.
	/// </summary>
	public class GovSteamBB : TurbineGovernorDynamics {

		/// <summary>
		/// Frequency deadband (<i>f</i><i><sub>cut</sub></i>) (>= 0).  Typical value = 0,
		/// 002.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU fcut;
		/// <summary>
		/// Gain (<i>K2</i>).  Typical value = 0,75.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k2;
		/// <summary>
		/// Gain (<i>K3</i>).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k3;
		/// <summary>
		/// Gain (<i>Kd</i>).  Typical value = 1,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kd;
		/// <summary>
		/// Gain (<i>Kg</i>).  Typical value = 1,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kg;
		/// <summary>
		/// Gain (<i>Kls</i>) (> 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kls;
		/// <summary>
		/// Gain (<i>Kp</i>).  Typical value = 1,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kp;
		/// <summary>
		/// Gain (<i>Ks</i>).  Typical value = 21,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ks;
		/// <summary>
		/// Electric power input selection (Peflag).
		/// true = electric power input
		/// false = feedback signal.
		/// Typical value = false.
		/// </summary>
		public bool peflag;
		/// <summary>
		/// High power limit (<i>Pmax</i>) (> GovSteamBB.pmin).  Typical value = 1,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pmax;
		/// <summary>
		/// Low power limit (<i>Pmin</i>) (< GovSteamBB.pmax).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pmin;
		/// <summary>
		/// Time constant (<i>T1</i>).  Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t1;
		/// <summary>
		/// Time constant (<i>T4</i>).  Typical value = 0,15.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t4;
		/// <summary>
		/// Time constant (<i>T5</i>).  Typical value = 12,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t5;
		/// <summary>
		/// Time constant (<i>T6</i>).  Typical value = 0,75.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t6;
		/// <summary>
		/// Time constant (<i>Td</i>) (> 0).  Typical value = 1,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds td;
		/// <summary>
		/// Time constant (<i>Tn</i>) (> 0).  Typical value = 1,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tn;

		public GovSteamBB(){

		}

		~GovSteamBB(){

		}

		public override void Dispose(){

		}

	}//end GovSteamBB

}//end namespace TurbineGovernorDynamics