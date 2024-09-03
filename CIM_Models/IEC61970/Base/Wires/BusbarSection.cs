﻿///////////////////////////////////////////////////////////
//  BusbarSection.cs
//  Implementation of the Class BusbarSection
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:42 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Wires;
namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// A conductor, or group of conductors, with negligible impedance, that serve to
	/// connect other conducting equipment within a single substation.
	/// Voltage measurements are typically obtained from voltage transformers that are
	/// connected to busbar sections. A bus bar section may have many physical
	/// terminals but for analysis is modelled with exactly one logical terminal.
	/// </summary>
	public class BusbarSection : Connector {

		/// <summary>
		/// Maximum allowable peak short-circuit current of busbar (Ipmax in IEC 60909-0).
		/// 
		/// Mechanical limit of the busbar in the substation itself. Used for short circuit
		/// data exchange according to IEC 60909.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CurrentFlow ipMax;
		/// <summary>
		/// A VoltageControlZone is controlled by a designated BusbarSection.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.VoltageControlZone VoltageControlZone;

		public BusbarSection(){

		}

		~BusbarSection(){

		}

		public override void Dispose(){

		}

	}//end BusbarSection

}//end namespace Wires