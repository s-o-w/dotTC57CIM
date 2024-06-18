///////////////////////////////////////////////////////////
//  GovGASTWD.cs
//  Implementation of the Class GovGASTWD
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:58 AM
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
	/// Woodward� gas turbine governor.
	/// [Footnote: Woodward gas turbines are an example of suitable products available
	/// commercially. This information is given for the convenience of users of this
	/// document and does not constitute an endorsement by IEC of these products.]
	/// </summary>
	public class GovGASTWD : TurbineGovernorDynamics {

		/// <summary>
		/// Valve positioner (<i>A</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float a;
		/// <summary>
		/// Exhaust temperature parameter (<i>Af1</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU af1;
		/// <summary>
		/// Coefficient equal to 0,5(1-speed) (<i>Af2</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU af2;
		/// <summary>
		/// Valve positioner (<i>B</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float b;
		/// <summary>
		/// (<i>Bf1</i>).  <i>Bf1</i> = <i>E</i>(1-<i>w</i>) where <i>E</i> (speed
		/// sensitivity coefficient) is 0,55 to 0,65 x <i>Tr</i>.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU bf1;
		/// <summary>
		/// Turbine torque coefficient K<sub>hhv</sub> (depends on heating value of fuel
		/// stream in combustion chamber) (<i>Bf2</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU bf2;
		/// <summary>
		/// Valve positioner (<i>C</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float c;
		/// <summary>
		/// Coefficient defining fuel flow where power output is 0 % (<i>Cf2</i>).
		/// Synchronous but no output.  Typically 0,23 x K<sub>hhv </sub>(23 % fuel flow).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU cf2;
		/// <summary>
		/// Combustion reaction time delay (<i>Ecr</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ecr;
		/// <summary>
		/// Turbine and exhaust delay (<i>Etd</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds etd;
		/// <summary>
		/// Ratio of fuel adjustment (<i>K3</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k3;
		/// <summary>
		/// Gain of radiation shield (<i>K4</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k4;
		/// <summary>
		/// Gain of radiation shield (<i>K5</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k5;
		/// <summary>
		/// Minimum fuel flow (<i>K6</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k6;
		/// <summary>
		/// Drop governor gain (<i>Kd</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kd;
		/// <summary>
		/// (<i>Kdroop</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kdroop;
		/// <summary>
		/// Fuel system feedback (<i>Kf</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kf;
		/// <summary>
		/// Isochronous Governor Gain (<i>Ki</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ki;
		/// <summary>
		/// PID proportional gain (<i>Kp</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kp;
		/// <summary>
		/// Base for power values (<i>MWbase</i>) (> 0).  Unit = MW.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower mwbase;
		/// <summary>
		/// Fuel control time constant (<i>T</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t;
		/// <summary>
		/// Radiation shield time constant (<i>T3</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t3;
		/// <summary>
		/// Thermocouple time constant (<i>T4</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t4;
		/// <summary>
		/// Temperature control time constant (<i>T5</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t5;
		/// <summary>
		/// Temperature control (<i>Tc</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Temperature tc;
		/// <summary>
		/// Compressor discharge time constant (<i>Tcd</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tcd;
		/// <summary>
		/// Power transducer time constant (<i>Td</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds td;
		/// <summary>
		/// Fuel system time constant (<i>Tf</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tf;
		/// <summary>
		/// Maximum Turbine limit (<i>Tmax</i>) (> GovGASTWD.tmin).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU tmax;
		/// <summary>
		/// Minimum turbine limit (<i>Tmin</i>) (< GovGASTWD.tmax).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU tmin;
		/// <summary>
		/// Rated temperature (<i>Tr</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Temperature tr;
		/// <summary>
		/// Turbine rating (<i>Trate</i>).  Unit = MW.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower trate;
		/// <summary>
		/// Temperature controller integration rate (<i>Tt</i>) (>= 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tt;

		public GovGASTWD(){

		}

		~GovGASTWD(){

		}

		public override void Dispose(){

		}

	}//end GovGASTWD

}//end namespace TurbineGovernorDynamics