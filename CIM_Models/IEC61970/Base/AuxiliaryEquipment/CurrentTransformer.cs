﻿///////////////////////////////////////////////////////////
//  CurrentTransformer.cs
//  Implementation of the Class CurrentTransformer
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:45 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.AuxiliaryEquipment;
namespace TC57CIM.IEC61970.Base.AuxiliaryEquipment {
	/// <summary>
	/// Instrument transformer used to measure electrical qualities of the circuit that
	/// is being protected and/or monitored. Typically used as current transducer for
	/// the purpose of metering or protection. A typical secondary current rating would
	/// be 5A.
	/// </summary>
	public class CurrentTransformer : Sensor {

		/// <summary>
		/// CT accuracy classification.
		/// </summary>
		public string accuracyClass;
		/// <summary>
		/// Percent of rated current for which the CT remains accurate within specified
		/// limits.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PerCent accuracyLimit;
		/// <summary>
		/// Power burden of the CT core.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower coreBurden;
		/// <summary>
		/// CT classification; i.e. class 10P.
		/// </summary>
		public string ctClass;
		/// <summary>
		/// Intended usage of the CT; i.e. metering, protection.
		/// </summary>
		public string usage;

		public CurrentTransformer(){

		}

		~CurrentTransformer(){

		}

		public override void Dispose(){

		}

	}//end CurrentTransformer

}//end namespace AuxiliaryEquipment