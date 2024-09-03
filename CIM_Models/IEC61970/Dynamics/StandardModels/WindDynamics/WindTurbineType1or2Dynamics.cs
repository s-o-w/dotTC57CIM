﻿///////////////////////////////////////////////////////////
//  WindTurbineType1or2Dynamics.cs
//  Implementation of the Class WindTurbineType1or2Dynamics
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:32 AM
//  Original author: civanov
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Dynamics.StandardModels;
using TC57CIM.IEC61970.Dynamics.StandardModels.AsynchronousMachineDynamics;
using TC57CIM.IEC61970.Dynamics.StandardInterconnections;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.WindDynamics {
	/// <summary>
	/// Parent class supporting relationships to wind turbines type 1 and type 2 and
	/// their control models.  Generator model for wind turbine of type 1 or type 2 is
	/// a standard asynchronous generator model.
	/// </summary>
	public class WindTurbineType1or2Dynamics : DynamicsFunctionBlock {

		/// <summary>
		/// Asynchronous machine model with which this wind generator type 1 or type 2
		/// model is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardModels.AsynchronousMachineDynamics.AsynchronousMachineDynamics AsynchronousMachineDynamics;
		/// <summary>
		/// Remote input signal used by this wind generator type 1 or type 2 model.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.StandardInterconnections.RemoteInputSignal RemoteInputSignal;

		public WindTurbineType1or2Dynamics(){

		}

		~WindTurbineType1or2Dynamics(){

		}

		public override void Dispose(){

		}

	}//end WindTurbineType1or2Dynamics

}//end namespace WindDynamics