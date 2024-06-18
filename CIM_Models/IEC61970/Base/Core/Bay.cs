///////////////////////////////////////////////////////////
//  Bay.cs
//  Implementation of the Class Bay
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:41 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// A collection of power system resources (within a given substation) including
	/// conducting equipment, protection relays, measurements, and telemetry.  A bay
	/// typically represents a physical grouping related to modularization of equipment.
	/// 
	/// </summary>
	public class Bay : EquipmentContainer {

		/// <summary>
		/// Indicates the presence/absence of energy measurements.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean bayEnergyMeasFlag;
		/// <summary>
		/// Indicates the presence/absence of active/reactive power measurements.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean bayPowerMeasFlag;
		/// <summary>
		/// Breaker configuration.
		/// </summary>
		public BreakerConfiguration breakerConfiguration;
		/// <summary>
		/// Busbar configuration.
		/// </summary>
		public BusbarConfiguration busBarConfiguration;

		public Bay(){

		}

		~Bay(){

		}

		public override void Dispose(){

		}

	}//end Bay

}//end namespace Core