///////////////////////////////////////////////////////////
//  ExcitationSystemDynamics.cs
//  Implementation of the Class ExcitationSystemDynamics
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:54 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Dynamics.StandardModels;
using TC57CIM.IEC61970.Dynamics.StandardModels.SynchronousMachineDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Excitation system function block whose behaviour is described by reference to a
	/// standard model <font color="#0f0f0f">or by definition of a user-defined model.
	/// </font>
	/// </summary>
	public class ExcitationSystemDynamics : DynamicsFunctionBlock {

		/// <summary>
		/// Synchronous machine model with which this excitation system model is associated.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.SynchronousMachineDynamics.SynchronousMachineDynamics SynchronousMachineDynamics;

		public ExcitationSystemDynamics(){

		}

		~ExcitationSystemDynamics(){

		}

		public override void Dispose(){

		}

	}//end ExcitationSystemDynamics

}//end namespace ExcitationSystemDynamics