﻿///////////////////////////////////////////////////////////
//  ProtectionEquipment.cs
//  Implementation of the Class ProtectionEquipment
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:16 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Wires;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61970.InfIEC61970.InfSIPS;
namespace TC57CIM.IEC61970.Base.Protection {
	/// <summary>
	/// An electrical device designed to respond to input conditions in a prescribed
	/// manner and after specified conditions are met to cause contact operation or
	/// similar abrupt change in associated electric control circuits, or simply to
	/// display the detected condition. Protection equipment is associated with
	/// conducting equipment and usually operate circuit breakers.
	/// </summary>
	public class ProtectionEquipment : Equipment {

		/// <summary>
		/// The maximum allowable value.
		/// </summary>
		public float highLimit;
		/// <summary>
		/// The minimum allowable value.
		/// </summary>
		public float lowLimit;
		/// <summary>
		/// Direction same as positive active power flow value.
		/// </summary>
		public bool powerDirectionFlag;
		/// <summary>
		/// The time delay from detection of abnormal conditions to relay operation.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds relayDelayTime;
		/// <summary>
		/// The unit multiplier of the value.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.UnitMultiplier unitMultiplier;
		/// <summary>
		/// The unit of measure of the value.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.UnitSymbol unitSymbol;
		/// <summary>
		/// Protected switches operated by this ProtectionEquipment.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.ProtectedSwitch ProtectedSwitches;
		/// <summary>
		/// Protection equipment may be used to protect specific conducting equipment.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.ConductingEquipment ConductingEquipments;
		/// <summary>
		/// Protective action can emulate the action done by one or more protection
		/// equipment. In a node breaker model were protective equipment is model this
		/// association will be used.
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.InfSIPS.ProtectiveAction ProtectiveAction;

		public ProtectionEquipment(){

		}

		~ProtectionEquipment(){

		}

		public override void Dispose(){

		}

	}//end ProtectionEquipment

}//end namespace Protection