﻿///////////////////////////////////////////////////////////
//  WindPlantReactiveControlIEC.cs
//  Implementation of the Class WindPlantReactiveControlIEC
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:32 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics {
	/// <summary>
	/// Simplified plant voltage and reactive power control model for use with type 3
	/// and type 4 wind turbine models.
	/// Reference: IEC 61400-27-1:2015, Annex D.
	/// </summary>
	public class WindPlantReactiveControlIEC : IdentifiedObject {

		/// <summary>
		/// Maximum positive ramp rate for wind turbine reactive power/voltage reference
		/// (<i>dx</i><i><sub>refmax</sub></i>) (> WindPlantReactiveControlIEC.dxrefmin).
		/// It is a project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU dxrefmax;
		/// <summary>
		/// Maximum negative ramp rate for wind turbine reactive power/voltage reference
		/// (<i>dx</i><i><sub>refmin</sub></i>) (< WindPlantReactiveControlIEC.dxrefmax).
		/// It is a project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU dxrefmin;
		/// <summary>
		/// Plant Q controller integral gain (<i>K</i><i><sub>IWPx</sub></i>). It is a
		/// project-dependent parameter.
		/// </summary>
		public float kiwpx;
		/// <summary>
		/// Maximum reactive power/voltage reference from integration
		/// (<i>K</i><i><sub>IWPxmax</sub></i>) (> WindPlantReactiveControlIEC.kiwpxmin).
		/// It is a project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kiwpxmax;
		/// <summary>
		/// Minimum reactive power/voltage reference from integration
		/// (<i>K</i><i><sub>IWPxmin</sub></i>) (< WindPlantReactiveControlIEC.kiwpxmax).
		/// It is a project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kiwpxmin;
		/// <summary>
		/// Plant Q controller proportional gain (<i>K</i><i><sub>PWPx</sub></i>). It is a
		/// project-dependent parameter.
		/// </summary>
		public float kpwpx;
		/// <summary>
		/// Reactive power reference gain (<i>K</i><i><sub>WPqref</sub></i>). It is a
		/// project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kwpqref;
		/// <summary>
		/// Plant voltage control droop (<i>K</i><i><sub>WPqu</sub></i>). It is a project-
		/// dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kwpqu;
		/// <summary>
		/// Filter time constant for voltage-dependent reactive power
		/// (<i>T</i><i><sub>uqfilt</sub></i>) (>= 0). It is a project-dependent parameter.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tuqfilt;
		/// <summary>
		/// Filter time constant for active power measurement
		/// (<i>T</i><i><sub>WPpfiltq</sub></i>) (>= 0). It is a project-dependent
		/// parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds twppfiltq;
		/// <summary>
		/// Filter time constant for reactive power measurement
		/// (<i>T</i><i><sub>WPqfiltq</sub></i>) (>= 0). It is a project-dependent
		/// parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds twpqfiltq;
		/// <summary>
		/// Filter time constant for voltage measurement
		/// (<i>T</i><i><sub>WPufiltq</sub></i>) (>= 0). It is a project-dependent
		/// parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds twpufiltq;
		/// <summary>
		/// Lead time constant in reference value transfer function
		/// (<i>T</i><i><sub>xft</sub></i>) (>= 0). It is a project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds txft;
		/// <summary>
		/// Lag time constant in reference value transfer function
		/// (<i>T</i><i><sub>xfv</sub></i>) (>= 0). It is a project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds txfv;
		/// <summary>
		/// Voltage threshold for UVRT detection in Q control
		/// (<i>u</i><i><sub>WPqdip</sub></i>). It is a project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU uwpqdip;
		/// <summary>
		/// Reactive power/voltage controller mode (<i>M</i><i><sub>WPqmode</sub></i>). It
		/// is a case-dependent parameter.
		/// </summary>
		public WindPlantQcontrolModeKind windPlantQcontrolModesType;
		/// <summary>
		/// Maximum <i>x</i><sub>WTref</sub> (<i>q</i><i><sub>WTref</sub></i> or delta<i>
		/// u</i><i><sub>WTref</sub></i>) request from the plant controller
		/// (<i>x</i><i><sub>refmax</sub></i>) (> WindPlantReactiveControlIEC.xrefmin). It
		/// is a case-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU xrefmax;
		/// <summary>
		/// Minimum <i>x</i><i><sub>WTref</sub></i> (<i>q</i><i><sub>WTref</sub></i> or
		/// delta <i>u</i><i><sub>WTref</sub></i>) request from the plant controller
		/// (<i>x</i><i><sub>refmin</sub></i>) (< WindPlantReactiveControlIEC.xrefmax). It
		/// is a project-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU xrefmin;

		public WindPlantReactiveControlIEC(){

		}

		~WindPlantReactiveControlIEC(){

		}

		public override void Dispose(){

		}

	}//end WindPlantReactiveControlIEC

}//end namespace WindDynamics