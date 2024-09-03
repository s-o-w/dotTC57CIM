﻿///////////////////////////////////////////////////////////
//  TurbLCFB1.cs
//  Implementation of the Class TurbLCFB1
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:27 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.TurbineLoadControllerDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.TurbineLoadControllerDynamics {
	/// <summary>
	/// Turbine load controller model developed by WECC.  This model represents a
	/// supervisory turbine load controller that acts to maintain turbine power at a
	/// set value by continuous adjustment of the turbine governor speed-load reference.
	/// This model is intended to represent slow reset 'outer loop' controllers
	/// managing the action of the turbine governor.
	/// </summary>
	public class TurbLCFB1 : TurbineLoadControllerDynamics {

		/// <summary>
		/// Controller deadband (<i>db</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU db;
		/// <summary>
		/// Maximum control error (<i>Emax</i>) (see parameter detail 4).  Typical value =
		/// 0,02.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU emax;
		/// <summary>
		/// Frequency bias gain (<i>Fb</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU fb;
		/// <summary>
		/// Frequency bias flag (<i>Fbf</i>).
		/// true = enable frequency bias
		/// false = disable frequency bias.
		/// Typical value = false.
		/// </summary>
		public bool fbf;
		/// <summary>
		/// Maximum turbine speed/load reference bias (<i>Irmax</i>) (see parameter detail
		/// 3).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU irmax;
		/// <summary>
		/// Integral gain (<i>Ki</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ki;
		/// <summary>
		/// Proportional gain (<i>Kp</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kp;
		/// <summary>
		/// Base for power values (<i>MWbase</i>) (> 0).  Unit = MW.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower mwbase;
		/// <summary>
		/// Power controller flag (<i>Pbf</i>).
		/// true = enable load controller
		/// false = disable load controller.
		/// Typical value = false.
		/// </summary>
		public bool pbf;
		/// <summary>
		/// Power controller setpoint (<i>Pmwset</i>) (see parameter detail 1).  Unit = MW.
		/// Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower pmwset;
		/// <summary>
		/// Type of turbine governor reference (<i>Type</i>).
		/// true = speed reference governor
		/// false = load reference governor.
		/// Typical value = true.
		/// </summary>
		public bool speedReferenceGovernor;
		/// <summary>
		/// Power transducer time constant (<i>Tpelec</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tpelec;

		public TurbLCFB1(){

		}

		~TurbLCFB1(){

		}

		public override void Dispose(){

		}

	}//end TurbLCFB1

}//end namespace TurbineLoadControllerDynamics