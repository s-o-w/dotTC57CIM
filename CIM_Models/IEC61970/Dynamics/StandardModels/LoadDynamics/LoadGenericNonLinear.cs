///////////////////////////////////////////////////////////
//  LoadGenericNonLinear.cs
//  Implementation of the Class LoadGenericNonLinear
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:06 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.LoadDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.LoadDynamics {
	/// <summary>
	/// Generic non-linear dynamic (GNLD) load. This model can be used in mid-term and
	/// long-term voltage stability simulations (i.e., to study voltage collapse), as
	/// it can replace a more detailed representation of aggregate load, including
	/// induction motors, thermostatically controlled and static loads.
	/// </summary>
	public class LoadGenericNonLinear : LoadDynamics {

		/// <summary>
		/// Steady state voltage index for reactive power (<i>BS</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float bs;
		/// <summary>
		/// Transient voltage index for reactive power (<i>BT</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float bt;
		/// <summary>
		/// Type of generic non-linear load model.
		/// </summary>
		public GenericNonLinearLoadModelKind genericNonLinearLoadModelType;
		/// <summary>
		/// Steady state voltage index for active power (<i>LS</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float ls;
		/// <summary>
		/// Transient voltage index for active power (<i>LT</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float lt;
		/// <summary>
		/// Time constant of lag function of active power (<i>T</i><i><sub>P</sub></i>) (>
		/// 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tp;
		/// <summary>
		/// Time constant of lag function of reactive power (<i>T</i><i><sub>Q</sub></i>)
		/// (> 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tq;

		public LoadGenericNonLinear(){

		}

		~LoadGenericNonLinear(){

		}

		public override void Dispose(){

		}

	}//end LoadGenericNonLinear

}//end namespace LoadDynamics