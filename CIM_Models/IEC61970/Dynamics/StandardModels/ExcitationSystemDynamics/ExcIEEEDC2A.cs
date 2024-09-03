﻿///////////////////////////////////////////////////////////
//  ExcIEEEDC2A.cs
//  Implementation of the Class ExcIEEEDC2A
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:53 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// IEEE 421.5-2005 type DC2A model. This model represents field-controlled DC
	/// commutator exciters with continuously acting voltage regulators having supplies
	/// obtained from the generator or auxiliary bus.  It differs from the type DC1A
	/// model only in the voltage regulator output limits, which are now proportional
	/// to terminal voltage <i>V</i><i><sub>T</sub></i>.
	/// It is representative of solid-state replacements for various forms of older
	/// mechanical and rotating amplifier regulating equipment connected to DC
	/// commutator exciters.
	/// Reference: IEEE 421.5-2005, 5.2.
	/// </summary>
	public class ExcIEEEDC2A : ExcitationSystemDynamics {

		/// <summary>
		/// Exciter voltage at which exciter saturation is defined
		/// (<i>E</i><i><sub>FD1</sub></i>) (> 0).  Typical value = 3,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efd1;
		/// <summary>
		/// Exciter voltage at which exciter saturation is defined
		/// (<i>E</i><i><sub>FD2</sub></i>) (> 0).  Typical value = 2,29.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efd2;
		/// <summary>
		/// (<i>exclim</i>).  IEEE standard is ambiguous about lower limit on exciter
		/// output. Typical value = - 999  which means that there is no limit applied.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU exclim;
		/// <summary>
		/// Voltage regulator gain (<i>K</i><i><sub>A</sub></i>) (> 0).  Typical value =
		/// 300.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ka;
		/// <summary>
		/// Exciter constant related to self-excited field (<i>K</i><i><sub>E</sub></i>).
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ke;
		/// <summary>
		/// Excitation control system stabilizer gain (<i>K</i><i><sub>F</sub></i>) (>= 0).
		/// Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kf;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>E</i><i><sub>FD1</sub></i>
		/// (<i>S</i><i><sub>E</sub></i><i>[E</i><i><sub>FD1</sub></i><i>]</i>) (>= 0).
		/// Typical value = 0,279.
		/// </summary>
		public float seefd1;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>E</i><i><sub>FD2</sub></i>
		/// (<i>S</i><i><sub>E</sub></i><i>[E</i><i><sub>FD2</sub></i><i>]</i>) (>= 0).
		/// Typical value = 0,117.
		/// </summary>
		public float seefd2;
		/// <summary>
		/// Voltage regulator time constant (<i>T</i><i><sub>A</sub></i>) (> 0).  Typical
		/// value = 0,01.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ta;
		/// <summary>
		/// Voltage regulator time constant (<i>T</i><i><sub>B</sub></i>) (>= 0).  Typical
		/// value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tb;
		/// <summary>
		/// Voltage regulator time constant (<i>T</i><i><sub>C</sub></i>) (>= 0).  Typical
		/// value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tc;
		/// <summary>
		/// Exciter time constant, integration rate associated with exciter control
		/// (<i>T</i><i><sub>E</sub></i>) (> 0).  Typical value = 1,33.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds te;
		/// <summary>
		/// Excitation control system stabilizer time constant
		/// (<i>T</i><i><sub>F</sub></i>) (> 0).  Typical value = 0,675.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tf;
		/// <summary>
		/// UEL input (<i>uelin</i>).
		/// true = input is connected to the HV gate
		/// false = input connects to the error signal.
		/// Typical value = true.
		/// </summary>
		public bool uelin;
		/// <summary>
		/// Maximum voltage regulator output (<i>V</i><i><sub>RMAX</sub></i>)(> ExcIEEEDC2A.
		/// vrmin).  Typical value = 4,95.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmax;
		/// <summary>
		/// Minimum voltage regulator output (<i>V</i><i><sub>RMIN</sub></i>) (< 0 and <
		/// ExcIEEEDC2A.vrmax).  Typical value = -4,9.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmin;

		public ExcIEEEDC2A(){

		}

		~ExcIEEEDC2A(){

		}

		public override void Dispose(){

		}

	}//end ExcIEEEDC2A

}//end namespace ExcitationSystemDynamics