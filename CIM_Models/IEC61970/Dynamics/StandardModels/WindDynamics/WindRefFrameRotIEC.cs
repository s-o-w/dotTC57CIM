///////////////////////////////////////////////////////////
//  WindRefFrameRotIEC.cs
//  Implementation of the Class WindRefFrameRotIEC
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:32 AM
//  Original author: civanov
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics {
	/// <summary>
	/// Reference frame rotation model.
	/// Reference: IEC 61400-27-1:2015, 5.6.3.5.
	/// </summary>
	public class WindRefFrameRotIEC : IdentifiedObject {

		/// <summary>
		/// Time constant for PLL first order filter model (<i>T</i><i><sub>PLL</sub></i>)
		/// (>= 0). It is a type-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tpll;
		/// <summary>
		/// Voltage below which the angle of the voltage is filtered and possibly also
		/// frozen (<i>u</i><i><sub>PLL1</sub></i>). It is a type-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU upll1;
		/// <summary>
		/// Voltage (<i>u</i><i><sub>PLL2</sub></i>) below which the angle of the voltage
		/// is frozen if <i>u</i><i><sub>PLL2</sub></i><sub> </sub>is smaller or equal to
		/// <i>u</i><i><sub>PLL1</sub></i> . It is a type-dependent parameter.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU upll2;
		/// <summary>
		/// Wind turbine type 3 or type 4 model with which this reference frame rotation
		/// model is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics.WindTurbineType3or4IEC WindTurbineType3or4IEC;

		public WindRefFrameRotIEC(){

		}

		~WindRefFrameRotIEC(){

		}

		public override void Dispose(){

		}

	}//end WindRefFrameRotIEC

}//end namespace WindDynamics