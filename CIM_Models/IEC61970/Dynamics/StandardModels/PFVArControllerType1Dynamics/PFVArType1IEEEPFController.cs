﻿///////////////////////////////////////////////////////////
//  PFVArType1IEEEPFController.cs
//  Implementation of the Class PFVArType1IEEEPFController
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:12 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.PFVArControllerType1Dynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.PFVArControllerType1Dynamics {
	/// <summary>
	/// IEEE PF controller type 1 which operates by moving the voltage reference
	/// directly.
	/// Reference: IEEE 421.5-2005, 11.2.
	/// </summary>
	public class PFVArType1IEEEPFController : PFVArControllerType1Dynamics {

		/// <summary>
		/// Overexcitation Flag (<i>OVEX</i>)
		/// true = overexcited
		/// false = underexcited.
		/// </summary>
		public bool ovex;
		/// <summary>
		/// PF controller time delay (<i>T</i><i><sub>PFC</sub></i>) (>= 0).  Typical value
		/// = 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tpfc;
		/// <summary>
		/// Minimum machine terminal current needed to enable pf/var controller
		/// (<i>V</i><i><sub>ITMIN</sub></i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vitmin;
		/// <summary>
		/// Synchronous machine power factor (<i>V</i><i><sub>PF</sub></i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vpf;
		/// <summary>
		/// PF controller deadband (<i>V</i><i><sub>PFC_BW</sub></i>).  Typical value = 0,
		/// 05.
		/// </summary>
		public float vpfcbw;
		/// <summary>
		/// PF controller reference (<i>V</i><i><sub>PFREF</sub></i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vpfref;
		/// <summary>
		/// Maximum machine terminal voltage needed for pf/var controller to be enabled
		/// (<i>V</i><i><sub>VTMAX</sub></i>) (> PFVArType1IEEEPFController.vvtmin).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vvtmax;
		/// <summary>
		/// Minimum machine terminal voltage needed to enable pf/var controller
		/// (<i>V</i><i><sub>VTMIN</sub></i>) (< PFVArType1IEEEPFController.vvtmax).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vvtmin;

		public PFVArType1IEEEPFController(){

		}

		~PFVArType1IEEEPFController(){

		}

		public override void Dispose(){

		}

	}//end PFVArType1IEEEPFController

}//end namespace PFVArControllerType1Dynamics