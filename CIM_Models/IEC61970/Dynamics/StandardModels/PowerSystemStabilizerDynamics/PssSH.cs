///////////////////////////////////////////////////////////
//  PssSH.cs
//  Implementation of the Class PssSH
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
	/// Siemens<sup>TM</sup> �H infinity� power system stabilizer with generator
	/// electrical power input.
	/// [Footnote: Siemens "H infinity" power system stabilizers are an example of
	/// suitable products available commercially. This information is given for the
	/// convenience of users of this document and does not constitute an endorsement by
	/// IEC of these products.]
	/// </summary>
	public class PssSH : PowerSystemStabilizerDynamics {

		/// <summary>
		/// Main gain (<i>K</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k;
		/// <summary>
		/// Gain 0 (<i>K0</i>).  Typical value = 0,012.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k0;
		/// <summary>
		/// Gain 1 (<i>K1</i>).  Typical value = 0,488.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k1;
		/// <summary>
		/// Gain 2 (<i>K2</i>).  Typical value = 0,064.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k2;
		/// <summary>
		/// Gain 3 (<i>K3</i>).  Typical value = 0,224.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k3;
		/// <summary>
		/// Gain 4 (<i>K4</i>).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k4;
		/// <summary>
		/// Time constant 1 (<i>T1</i>) (> 0).  Typical value = 0,076.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t1;
		/// <summary>
		/// Time constant 2 (<i>T2</i>) (> 0).  Typical value = 0,086.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t2;
		/// <summary>
		/// Time constant 3 (<i>T3</i>) (> 0).   Typical value = 1,068.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t3;
		/// <summary>
		/// Time constant 4 (<i>T4</i>) (> 0).  Typical value = 1,913.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t4;
		/// <summary>
		/// Input time constant (<i>T</i><i><sub>d</sub></i>) (>= 0).  Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds td;
		/// <summary>
		/// Output maximum limit (<i>Vsmax</i>) (> PssSH.vsmin).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vsmax;
		/// <summary>
		/// Output minimum limit (<i>Vsmin</i>) (< PssSH.vsmax).  Typical value = -0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vsmin;

		public PssSH(){

		}

		~PssSH(){

		}

		public override void Dispose(){

		}

	}//end PssSH

}//end namespace PowerSystemStabilizerDynamics