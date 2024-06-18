///////////////////////////////////////////////////////////
//  VoltageLevel.cs
//  Implementation of the Class VoltageLevel
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:29 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// A collection of equipment at one common system voltage forming a switchgear.
	/// The equipment typically consists of breakers, busbars, instrumentation, control,
	/// regulation and protection devices as well as assemblies of all these.
	/// </summary>
	public class VoltageLevel : EquipmentContainer {

		/// <summary>
		/// The bus bar's high voltage limit.
		/// The limit applies to all equipment and nodes contained in a given VoltageLevel.
		/// It is not required that it is exchanged in pair with lowVoltageLimit. It is
		/// preferable to use operational VoltageLimit, which prevails, if present.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage highVoltageLimit;
		/// <summary>
		/// The bus bar's low voltage limit.
		/// The limit applies to all equipment and nodes contained in a given VoltageLevel.
		/// It is not required that it is exchanged in pair with highVoltageLimit. It is
		/// preferable to use operational VoltageLimit, which prevails, if present.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage lowVoltageLimit;
		/// <summary>
		/// The bays within this voltage level.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.Bay Bays;
		/// <summary>
		/// The base voltage used for all equipment within the voltage level.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.BaseVoltage BaseVoltage;

		public VoltageLevel(){

		}

		~VoltageLevel(){

		}

		public override void Dispose(){

		}

	}//end VoltageLevel

}//end namespace Core