﻿///////////////////////////////////////////////////////////
//  ProprietaryParameterDynamics.cs
//  Implementation of the Class ProprietaryParameterDynamics
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:15 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.UserDefinedModels;
namespace TC57CIM.IEC61970.Dynamics.UserDefinedModels {
	/// <summary>
	/// Supports definition of one or more parameters of several different datatypes
	/// for use by proprietary user-defined models.
	/// This class does not inherit from IdentifiedObject since it is not intended that
	/// a single instance of it be referenced by more than one proprietary user-defined
	/// model instance.
	/// </summary>
	public class ProprietaryParameterDynamics {

		/// <summary>
		/// Boolean parameter value. If this attribute is populated, integerParameterValue
		/// and floatParameterValue will not be.
		/// </summary>
		public bool booleanParameterValue;
		/// <summary>
		/// Floating point parameter value.  If this attribute is populated,
		/// booleanParameterValue and integerParameterValue will not be.
		/// </summary>
		public float floatParameterValue;
		/// <summary>
		/// Integer parameter value.  If this attribute is populated, booleanParameterValue
		/// and floatParameterValue will not be.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer integerParameterValue;
		/// <summary>
		/// Sequence number of the parameter among the set of parameters associated with
		/// the related proprietary user-defined model.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer parameterNumber;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.LoadUserDefined LoadUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		//public TC57CIM.IEC61970.Dynamics.UserDefinedModels.VoltageCompensatorUserDefined VoltageCompensatorUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.PFVArControllerType2UserDefined PFVArControllerType2UserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.VoltageAdjusterUserDefined VoltageAdjusterUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.PFVArControllerType1UserDefined PFVArControllerType1UserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.DiscontinuousExcitationControlUserDefined DiscontinuousExcitationControlUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.PowerSystemStabilizerUserDefined PowerSystemStabilizerUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.UnderexcitationLimiterUserDefined UnderexcitationLimiterUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.OverexcitationLimiterUserDefined OverexcitationLimiterUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.ExcitationSystemUserDefined ExcitationSystemUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.MechanicalLoadUserDefined MechanicalLoadUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.TurbineLoadControllerUserDefined TurbineLoadControllerUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.TurbineGovernorUserDefined TurbineGovernorUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.AsynchronousMachineUserDefined AsynchronousMachineUserDefined;
		/// <summary>
		/// Proprietary user-defined model with which this parameter is associated.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.SynchronousMachineUserDefined SynchronousMachineUserDefined;

		public ProprietaryParameterDynamics(){

		}

		~ProprietaryParameterDynamics(){

		}

		public virtual void Dispose(){

		}

	}//end ProprietaryParameterDynamics

}//end namespace UserDefinedModels