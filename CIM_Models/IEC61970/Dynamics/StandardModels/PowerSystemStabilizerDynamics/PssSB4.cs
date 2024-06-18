///////////////////////////////////////////////////////////
//  PssSB4.cs
//  Implementation of the Class PssSB4
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:17 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.PowerSystemStabilizerDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.PowerSystemStabilizerDynamics {
	/// <summary>
	/// Power sensitive stabilizer model.
	/// </summary>
	public class PssSB4 : PowerSystemStabilizerDynamics {

		/// <summary>
		/// Gain (<i>Kx</i>).  Typical value = 2,7.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kx;
		/// <summary>
		/// Time constant (<i>Ta</i>) (>= 0).  Typical value = 0,37.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ta;
		/// <summary>
		/// Time constant (<i>Tb</i>) (>= 0).  Typical value = 0,37.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tb;
		/// <summary>
		/// Time constant (<i>Tc</i>) (>= 0).  Typical value = 0,035.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tc;
		/// <summary>
		/// Time constant (<i>Td</i>) (>= 0).  Typical value = 0,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds td;
		/// <summary>
		/// Time constant (<i>Te</i>) (>= 0).  Typical value = 0,0169.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds te;
		/// <summary>
		/// Time constant (<i>Tt</i>) (>= 0).  Typical value = 0,18.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tt;
		/// <summary>
		/// Reset time constant (<i>Tx1</i>) (>= 0).  Typical value = 0,035.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tx1;
		/// <summary>
		/// Time constant (<i>Tx2</i>) (>= 0).  Typical value = 5,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tx2;
		/// <summary>
		/// Limiter (<i>Vsmax</i>) (> PssSB4.vsmin).  Typical value = 0,062.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vsmax;
		/// <summary>
		/// Limiter (<i>Vsmin</i>) (< PssSB4.vsmax).  Typical value = -0,062.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vsmin;

		public PssSB4(){

		}

		~PssSB4(){

		}

		public override void Dispose(){

		}

	}//end PssSB4

}//end namespace PowerSystemStabilizerDynamics