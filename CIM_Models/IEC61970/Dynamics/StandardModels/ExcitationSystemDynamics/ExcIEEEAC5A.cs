﻿///////////////////////////////////////////////////////////
//  ExcIEEEAC5A.cs
//  Implementation of the Class ExcIEEEAC5A
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
	/// IEEE 421.5-2005 type AC5A model. The model represents a simplified model for
	/// brushless excitation systems. The regulator is supplied from a source, such as
	/// a permanent magnet generator, which is not affected by system disturbances.
	/// Unlike other AC models, this model uses loaded rather than open circuit exciter
	/// saturation data in the same way as it is used for the DC models.  Because the
	/// model has been widely implemented by the industry, it is sometimes used to
	/// represent other types of systems when either detailed data for them are not
	/// available or simplified models are required.
	/// Reference: IEEE 421.5-2005, 6.5.
	/// </summary>
	public class ExcIEEEAC5A : ExcitationSystemDynamics {

		/// <summary>
		/// Exciter voltage at which exciter saturation is defined
		/// (<i>E</i><i><sub>FD1</sub></i>) (> 0).  Typical value = 5,6.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efd1;
		/// <summary>
		/// Exciter voltage at which exciter saturation is defined
		/// (<i>E</i><i><sub>FD2</sub></i>) (> 0).  Typical value = 4,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efd2;
		/// <summary>
		/// Voltage regulator gain (<i>K</i><i><sub>A</sub></i>) (> 0).  Typical value =
		/// 400.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ka;
		/// <summary>
		/// Exciter constant related to self-excited field (<i>K</i><i><sub>E</sub></i>).
		/// Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ke;
		/// <summary>
		/// Excitation control system stabilizer gains (<i>K</i><i><sub>F</sub></i>) (>= 0).
		///  Typical value = 0,03.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kf;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>E</i><i><sub>FD1</sub></i>
		/// (<i>S</i><i><sub>E</sub></i><i>[E</i><i><sub>FD1</sub></i><i>]</i>) (>= 0).
		/// Typical value = 0,86.
		/// </summary>
		public float seefd1;
		/// <summary>
		/// Exciter saturation function value at the corresponding exciter voltage,
		/// <i>E</i><i><sub>FD2</sub></i>
		/// (<i>S</i><i><sub>E</sub></i><i>[E</i><i><sub>FD2</sub></i><i>]</i>) (>= 0).
		/// Typical value = 0,5.
		/// </summary>
		public float seefd2;
		/// <summary>
		/// Voltage regulator time constant (<i>T</i><i><sub>A</sub></i>) (> 0).  Typical
		/// value = 0,02.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ta;
		/// <summary>
		/// Exciter time constant, integration rate associated with exciter control
		/// (<i>T</i><i><sub>E</sub></i>) (> 0).  Typical value = 0,8.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds te;
		/// <summary>
		/// Excitation control system stabilizer time constant
		/// (<i>T</i><i><sub>F1</sub></i>) (> 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tf1;
		/// <summary>
		/// Excitation control system stabilizer time constant
		/// (<i>T</i><i><sub>F2</sub></i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tf2;
		/// <summary>
		/// Excitation control system stabilizer time constant
		/// (<i>T</i><i><sub>F3</sub></i>) (>= 0).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tf3;
		/// <summary>
		/// Maximum voltage regulator output (<i>V</i><i><sub>RMAX</sub></i>) (> 0).
		/// Typical value = 7,3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmax;
		/// <summary>
		/// Minimum voltage regulator output (<i>V</i><i><sub>RMIN</sub></i>) (< 0).
		/// Typical value = -7,3.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmin;

		public ExcIEEEAC5A(){

		}

		~ExcIEEEAC5A(){

		}

		public override void Dispose(){

		}

	}//end ExcIEEEAC5A

}//end namespace ExcitationSystemDynamics