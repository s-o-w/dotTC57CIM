///////////////////////////////////////////////////////////
//  ExcNI.cs
//  Implementation of the Class ExcNI
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:54 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Bus or solid fed SCR (silicon-controlled rectifier) bridge excitation system
	/// model type NI (NVE).
	/// </summary>
	public class ExcNI : ExcitationSystemDynamics {

		/// <summary>
		/// Fed by selector (<i>BusFedSelector</i>).
		/// true = bus fed (switch is closed)
		/// false = solid fed (switch is open).
		/// Typical value = true.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean busFedSelector;
		/// <summary>
		/// Voltage regulator gain (<i>Ka</i>) (> 0).  Typical value = 210.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU ka;
		/// <summary>
		/// Excitation control system stabilizer gain (<i>Kf</i>) (> 0).  Typical value 0,
		/// 01.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kf;
		/// <summary>
		/// <i>rc</i> / <i>rfd</i> (<i>R</i>) (>= 0).
		/// 0 means exciter has negative current capability
		/// > 0 means exciter does not have negative current capability.
		/// Typical value = 5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU r;
		/// <summary>
		/// Voltage regulator time constant (<i>Ta</i>) (> 0).  Typical value = 0,02.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ta;
		/// <summary>
		/// Excitation control system stabilizer time constant (<i>Tf1</i>) (> 0). Typical
		/// value = 1,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tf1;
		/// <summary>
		/// Excitation control system stabilizer time constant (<i>Tf2</i>) (> 0). Typical
		/// value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tf2;
		/// <summary>
		/// Time constant (<i>Tr</i>) (>= 0). Typical value = 0,02.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tr;
		/// <summary>
		/// Maximum voltage regulator ouput (<i>Vrmax</i>) (> ExcNI.vrmin). Typical value =
		/// 5,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmax;
		/// <summary>
		/// Minimum voltage regulator ouput (<i>Vrmin</i>) (< ExcNI.vrmax). Typical value =
		/// -2,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vrmin;

		public ExcNI(){

		}

		~ExcNI(){

		}

		public override void Dispose(){

		}

	}//end ExcNI

}//end namespace ExcitationSystemDynamics