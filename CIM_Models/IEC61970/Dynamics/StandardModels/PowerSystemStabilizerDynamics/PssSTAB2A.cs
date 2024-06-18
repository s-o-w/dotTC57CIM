///////////////////////////////////////////////////////////
//  PssSTAB2A.cs
//  Implementation of the Class PssSTAB2A
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:17 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.PowerSystemStabilizerDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.PowerSystemStabilizerDynamics {
	/// <summary>
	/// Power system stabilizer part of an ABB excitation system.
	/// [Footnote: ABB excitation systems are an example of suitable products available
	/// commercially. This information is given for the convenience of users of this
	/// document and does not constitute an endorsement by IEC of these products.]
	/// </summary>
	public class PssSTAB2A : PowerSystemStabilizerDynamics {

		/// <summary>
		/// Stabilizer output limiter (<i>H</i><i><sub>LIM</sub></i>).  Typical value = 0,5.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU hlim;
		/// <summary>
		/// Gain (<i>K2</i>).  Typical value = 1,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k2;
		/// <summary>
		/// Gain (<i>K3</i>).  Typical value = 0,25.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k3;
		/// <summary>
		/// Gain (<i>K4</i>).  Typical value = 0,075.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k4;
		/// <summary>
		/// Gain (<i>K5</i>).  Typical value = 2,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k5;
		/// <summary>
		/// Time constant (<i>T2</i>).  Typical value = 4,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t2;
		/// <summary>
		/// Time constant (<i>T3</i>).  Typical value = 2,0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t3;
		/// <summary>
		/// Time constant (<i>T5</i>).  Typical value = 4,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t5;

		public PssSTAB2A(){

		}

		~PssSTAB2A(){

		}

		public override void Dispose(){

		}

	}//end PssSTAB2A

}//end namespace PowerSystemStabilizerDynamics