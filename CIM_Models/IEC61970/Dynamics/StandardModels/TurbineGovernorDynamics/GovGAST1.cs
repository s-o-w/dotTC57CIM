﻿///////////////////////////////////////////////////////////
//  GovGAST1.cs
//  Implementation of the Class GovGAST1
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:58 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.TurbineGovernorDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.TurbineGovernorDynamics {
	/// <summary>
	/// Modified single shaft gas turbine.
	/// </summary>
	public class GovGAST1 : TurbineGovernorDynamics {

		/// <summary>
		/// Turbine power time constant numerator scale factor (<i>a</i>).  Typical value =
		/// 0,8.
		/// </summary>
		public float a;
		/// <summary>
		/// Turbine power time constant denominator scale factor (<i>b</i>) (>0).  Typical
		/// value = 1.
		/// </summary>
		public float b;
		/// <summary>
		/// Intentional dead-band width (<i>db1</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency db1;
		/// <summary>
		/// Unintentional dead-band (<i>db2</i>).  Unit = MW.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower db2;
		/// <summary>
		/// Intentional db hysteresis (<i>eps</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency eps;
		/// <summary>
		/// Fuel flow at zero power output (<i>Fidle</i>).  Typical value = 0,18.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU fidle;
		/// <summary>
		/// Nonlinear gain point 1, PU gv (<i>Gv1</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU gv1;
		/// <summary>
		/// Nonlinear gain point 2,PU gv (<i>Gv2</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU gv2;
		/// <summary>
		/// Nonlinear gain point 3, PU gv (<i>Gv3</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU gv3;
		/// <summary>
		/// Nonlinear gain point 4, PU gv (<i>Gv4</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU gv4;
		/// <summary>
		/// Nonlinear gain point 5, PU gv (<i>Gv5</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU gv5;
		/// <summary>
		/// Nonlinear gain point 6, PU gv (<i>Gv6</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU gv6;
		/// <summary>
		/// Governor gain (<i>Ka</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ka;
		/// <summary>
		/// Temperature limiter gain (<i>Kt</i>).  Typical value = 3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kt;
		/// <summary>
		/// Ambient temperature load limit (<i>Lmax</i>).  <i>Lmax</i> is the turbine power
		/// output corresponding to the limiting exhaust gas temperature.  Typical value =
		/// 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU lmax;
		/// <summary>
		/// Valve position change allowed at fast rate (<i>Loadinc</i>).  Typical value = 0,
		/// 05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU loadinc;
		/// <summary>
		/// Maximum long term fuel valve opening rate (<i>Ltrate</i>).  Typical value = 0,
		/// 02.
		/// </summary>
		public float ltrate;
		/// <summary>
		/// Base for power values (<i>MWbase</i>) (> 0).  Unit = MW.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower mwbase;
		/// <summary>
		/// Nonlinear gain point 1, PU power (<i>Pgv1</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pgv1;
		/// <summary>
		/// Nonlinear gain point 2, PU power (<i>Pgv2</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pgv2;
		/// <summary>
		/// Nonlinear gain point 3, PU power (<i>Pgv3</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pgv3;
		/// <summary>
		/// Nonlinear gain point 4, PU power (<i>Pgv4</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pgv4;
		/// <summary>
		/// Nonlinear gain point 5, PU power (<i>Pgv5</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pgv5;
		/// <summary>
		/// Nonlinear gain point 6, PU power (<i>Pgv6</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pgv6;
		/// <summary>
		/// Permanent droop (<i>R</i>) (>0).  Typical value = 0,04.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU r;
		/// <summary>
		/// Maximum fuel valve opening rate (<i>Rmax</i>).  Unit = PU / s.  Typical value =
		/// 1.
		/// </summary>
		public float rmax;
		/// <summary>
		/// Governor mechanism time constant (<i>T1</i>) (>= 0).  <i>T1</i> represents the
		/// natural valve positioning time constant of the governor for small disturbances,
		/// as seen when rate limiting is not in effect.  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t1;
		/// <summary>
		/// Turbine power time constant (<i>T2</i>) (>= 0). <i>T2</i> represents delay due
		/// to internal energy storage of the gas turbine engine. <i>T2</i> can be used to
		/// give a rough approximation to the delay associated with acceleration of the
		/// compressor spool of a multi-shaft engine, or with the compressibility of gas in
		/// the plenum of the free power turbine of an aero-derivative unit, for example.
		/// Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t2;
		/// <summary>
		/// Turbine exhaust temperature time constant (<i>T3</i>) (>= 0).  <i>T3</i>
		/// represents delay in the exhaust temperature and load limiting system. Typical
		/// value = 3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t3;
		/// <summary>
		/// Governor lead time constant (<i>T4</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t4;
		/// <summary>
		/// Governor lag time constant (<i>T5</i>) (>= 0).  If = 0, entire gain and lead-
		/// lag block is bypassed.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t5;
		/// <summary>
		/// Valve position averaging time constant (<i>Tltr</i>) (>= 0).  Typical value =
		/// 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tltr;
		/// <summary>
		/// Maximum turbine power, PU of MWbase (<i>Vmax</i>) (> GovGAST1.vmin).  Typical
		/// value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vmax;
		/// <summary>
		/// Minimum turbine power, PU of MWbase (<i>Vmin</i>) (< GovGAST1.vmax).  Typical
		/// value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vmin;

		public GovGAST1(){

		}

		~GovGAST1(){

		}

		public override void Dispose(){

		}

	}//end GovGAST1

}//end namespace TurbineGovernorDynamics