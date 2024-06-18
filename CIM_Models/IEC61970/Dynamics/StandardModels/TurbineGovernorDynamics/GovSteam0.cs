///////////////////////////////////////////////////////////
//  GovSteam0.cs
//  Implementation of the Class GovSteam0
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
	/// A simplified steam turbine governor.
	/// </summary>
	public class GovSteam0 : TurbineGovernorDynamics {

		/// <summary>
		/// Turbine damping coefficient (<i>Dt</i>).  Unit = delta P / delta speed. Typical
		/// value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU dt;
		/// <summary>
		/// Base for power values (<i>MWbase</i>) (> 0).  Unit = MW.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower mwbase;
		/// <summary>
		/// Permanent droop (<i>R</i>).  Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU r;
		/// <summary>
		/// Steam bowl time constant (<i>T1</i>) (> 0).  Typical value = 0,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t1;
		/// <summary>
		/// Numerator time constant of <i>T2</i>/<i>T3</i> block (<i>T2</i>) (>= 0).
		/// Typical value = 3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t2;
		/// <summary>
		/// Reheater time constant (<i>T3</i>) (> 0).  Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t3;
		/// <summary>
		/// Maximum valve position, PU of <i>mwcap</i> (<i>Vmax</i>) (> GovSteam0.vmin).
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vmax;
		/// <summary>
		/// Minimum valve position, PU of <i>mwcap</i> (<i>Vmin</i>) (< GovSteam0.vmax).
		/// Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vmin;

		public GovSteam0(){

		}

		~GovSteam0(){

		}

		public override void Dispose(){

		}

	}//end GovSteam0

}//end namespace TurbineGovernorDynamics