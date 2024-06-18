///////////////////////////////////////////////////////////
//  GovHydroR.cs
//  Implementation of the Class GovHydroR
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:59 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.TurbineGovernorDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.TurbineGovernorDynamics {
	/// <summary>
	/// Fourth order lead-lag governor and hydro turbine.
	/// </summary>
	public class GovHydroR : TurbineGovernorDynamics {

		/// <summary>
		/// Turbine gain (<i>At</i>).  Typical value = 1,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU at;
		/// <summary>
		/// Intentional dead-band width (<i>db1</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency db1;
		/// <summary>
		/// Unintentional dead-band (<i>db2</i>).  Unit = MW.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower db2;
		/// <summary>
		/// Turbine damping factor (<i>Dturb</i>).  Typical value = 0,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU dturb;
		/// <summary>
		/// Intentional db hysteresis (<i>eps</i>).  Unit = Hz.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency eps;
		/// <summary>
		/// Maximum governor output (<i>Gmax</i>) (> GovHydroR.gmin).  Typical value = 1,05.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU gmax;
		/// <summary>
		/// Minimum governor output (<i>Gmin</i>) (< GovHydroR.gmax).  Typical value = -0,
		/// 05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU gmin;
		/// <summary>
		/// Nonlinear gain point 1, PU gv (<i>Gv1</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU gv1;
		/// <summary>
		/// Nonlinear gain point 2, PU gv (<i>Gv2</i>).  Typical value = 0.
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
		/// Turbine nominal head (<i>H0</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU h0;
		/// <summary>
		/// Input signal switch (<i>Flag</i>).
		/// true = <i>Pe</i> input is used
		/// false = feedback is received from <i>CV</i>.
		/// <i>Flag</i> is normally dependent on <i>Tt</i>.  If <i>Tt </i>is zero,
		/// <i>Flag</i> is set to false. If <i>Tt</i> is not zero, <i>Flag</i> is set to
		/// true.
		/// Typical value = true.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean inputSignal;
		/// <summary>
		/// Gate servo gain (<i>Kg</i>).  Typical value = 2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kg;
		/// <summary>
		/// Integral gain (<i>Ki</i>).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ki;
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
		/// Maximum gate opening, PU of <i>MWbase</i> (<i>Pmax</i>) (> GovHydroR.pmin).
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pmax;
		/// <summary>
		/// Minimum gate opening, PU of <i>MWbase</i> (<i>Pmin</i>) (< GovHydroR.pmax).
		/// Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pmin;
		/// <summary>
		/// No-load turbine flow at nominal head (<i>Qnl</i>).  Typical value = 0,08.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU qnl;
		/// <summary>
		/// Steady-state droop (<i>R</i>).  Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU r;
		/// <summary>
		/// Lead time constant 1 (<i>T1</i>) (>= 0).  Typical value = 1,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t1;
		/// <summary>
		/// Lag time constant 1 (<i>T2</i>) (>= 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t2;
		/// <summary>
		/// Lead time constant 2 (<i>T3</i>) (>= 0).  Typical value = 1,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t3;
		/// <summary>
		/// Lag time constant 2 (<i>T4</i>) (>= 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t4;
		/// <summary>
		/// Lead time constant 3 (<i>T5</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t5;
		/// <summary>
		/// Lag time constant 3 (<i>T6</i>) (>= 0).  Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t6;
		/// <summary>
		/// Lead time constant 4 (<i>T7</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t7;
		/// <summary>
		/// Lag time constant 4 (<i>T8</i>) (>= 0).  Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t8;
		/// <summary>
		/// Input filter time constant (<i>Td</i>) (>= 0).  Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds td;
		/// <summary>
		/// Gate servo time constant (<i>Tp</i>) (>= 0).  Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tp;
		/// <summary>
		/// Power feedback time constant (<i>Tt</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tt;
		/// <summary>
		/// Water inertia time constant (<i>Tw</i>) (> 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tw;
		/// <summary>
		/// Maximum gate closing velocity (<i>Velcl</i>).  Unit = PU / s.  Typical value = -
		/// 0,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float velcl;
		/// <summary>
		/// Maximum gate opening velocity (<i>Velop</i>).  Unit = PU / s.  Typical value =
		/// 0,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float velop;

		public GovHydroR(){

		}

		~GovHydroR(){

		}

		public override void Dispose(){

		}

	}//end GovHydroR

}//end namespace TurbineGovernorDynamics