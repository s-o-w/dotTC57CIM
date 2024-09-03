﻿///////////////////////////////////////////////////////////
//  GovSteamEU.cs
//  Implementation of the Class GovSteamEU
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:00 AM
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
	/// Simplified boiler and steam turbine with PID governor.
	/// </summary>
	public class GovSteamEU : TurbineGovernorDynamics {

		/// <summary>
		/// Control valves rate closing limit (<i>Chc</i>).  Unit = PU / s.  Typical value
		/// = -3,3.
		/// </summary>
		public float chc;
		/// <summary>
		/// Control valves rate opening limit (<i>Cho</i>).  Unit = PU / s.  Typical value
		/// = 0,17.
		/// </summary>
		public float cho;
		/// <summary>
		/// Intercept valves rate closing limit (<i>Cic</i>).  Typical value = -2,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU cic;
		/// <summary>
		/// Intercept valves rate opening limit (<i>Cio</i>).  Typical value = 0,123.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU cio;
		/// <summary>
		/// Deadband of the frequency corrector (<i>db1</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU db1;
		/// <summary>
		/// Deadband of the speed governor (<i>db2</i>).  Typical value = 0,0004.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU db2;
		/// <summary>
		/// Maximum control valve position (<i>Hhpmax</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU hhpmax;
		/// <summary>
		/// Gain of the power controller (<i>Ke</i>).  Typical value = 0,65.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ke;
		/// <summary>
		/// Gain of the frequency corrector (<i>Kfcor</i>).  Typical value = 20.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kfcor;
		/// <summary>
		/// Fraction of total turbine output generated by HP part (<i>Khp</i>).  Typical
		/// value = 0,277.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU khp;
		/// <summary>
		/// Fraction of total turbine output generated by HP part (<i>Klp</i>).  Typical
		/// value = 0,723.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU klp;
		/// <summary>
		/// Gain of the speed governor (<i>Kwcor</i>).  Typical value = 20.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU komegacor;
		/// <summary>
		/// Base for power values (<i>MWbase</i>) (> 0).  Unit = MW.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower mwbase;
		/// <summary>
		/// Maximal active power of the turbine (<i>Pmax</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pmax;
		/// <summary>
		/// Maximum low pressure limit (<i>Prhmax</i>).  Typical value = 1,4.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU prhmax;
		/// <summary>
		/// Intercept valves transfer limit (<i>Simx</i>).  Typical value = 0,425.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU simx;
		/// <summary>
		/// Boiler time constant (<i>Tb</i>) (>= 0).  Typical value = 100.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tb;
		/// <summary>
		/// Derivative time constant of the power controller (<i>Tdp</i>) (>= 0).  Typical
		/// value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tdp;
		/// <summary>
		/// Electro hydraulic transducer (<i>Ten</i>) (>= 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ten;
		/// <summary>
		/// Frequency transducer time constant (<i>Tf</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tf;
		/// <summary>
		/// Time constant of the power controller (<i>Tfp</i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tfp;
		/// <summary>
		/// High pressure (HP) time constant of the turbine (<i>Thp</i>) (>= 0).  Typical
		/// value = 0,31.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds thp;
		/// <summary>
		/// Integral time constant of the power controller (<i>Tip</i>) (>= 0).  Typical
		/// value = 2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tip;
		/// <summary>
		/// Low pressure (LP) time constant of the turbine (<i>Tlp</i>) (>= 0).  Typical
		/// value = 0,45.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tlp;
		/// <summary>
		/// Power transducer time constant (<i>Tp</i>) (>= 0).  Typical value = 0,07.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tp;
		/// <summary>
		/// Reheater  time constant of the turbine (<i>Trh</i>) (>= 0).  Typical value = 8.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds trh;
		/// <summary>
		/// Control valves servo time constant (<i>Tvhp</i>) (>= 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tvhp;
		/// <summary>
		/// Intercept valves servo time constant (<i>Tvip</i>) (>= 0).  Typical value = 0,
		/// 15.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tvip;
		/// <summary>
		/// Speed transducer time constant (<i>Tw</i>) (>= 0).  Typical value = 0,02.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tw;
		/// <summary>
		/// Upper limit for frequency correction (<i>Wfmax</i>) (> GovSteamEU.wfmin).
		/// Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU wfmax;
		/// <summary>
		/// Lower limit for frequency correction (<i>Wfmin</i>) (< GovSteamEU.wfmax).
		/// Typical value = -0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU wfmin;
		/// <summary>
		/// Emergency speed control lower limit (<i>wmax1</i>).  Typical value = 1,025.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU wmax1;
		/// <summary>
		/// Emergency speed control upper limit (<i>wmax2</i>).  Typical value = 1,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU wmax2;
		/// <summary>
		/// Upper limit for the speed governor (<i>Wwmax</i>) (> GovSteamEU.wwmin).
		/// Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU wwmax;
		/// <summary>
		/// Lower limit for the speed governor frequency correction (<i>Wwmin</i>) (<
		/// GovSteamEU.wwmax).  Typical value = -1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU wwmin;

		public GovSteamEU(){

		}

		~GovSteamEU(){

		}

		public override void Dispose(){

		}

	}//end GovSteamEU

}//end namespace TurbineGovernorDynamics