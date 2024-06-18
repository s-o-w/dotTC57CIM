///////////////////////////////////////////////////////////
//  EnergyConsumerPhase.cs
//  Implementation of the Class EnergyConsumerPhase
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:50 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Wires;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// A single phase of an energy consumer.
	/// </summary>
	public class EnergyConsumerPhase : PowerSystemResource {

		/// <summary>
		/// Active power of the load. Load sign convention is used, i.e. positive sign
		/// means flow out from a node.
		/// For voltage dependent loads the value is at rated voltage.
		/// Starting value for a steady state solution.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower p;
		/// <summary>
		/// Active power of the load that is a fixed quantity. Load sign convention is used,
		/// i.e. positive sign means flow out from a node.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower pfixed;
		/// <summary>
		/// Fixed active power as per cent of load group fixed active power. Load sign
		/// convention is used, i.e. positive sign means flow out from a node.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PerCent pfixedPct;
		/// <summary>
		/// Phase of this energy consumer component.   If the energy consumer is wye
		/// connected, the connection is from the indicated phase to the central ground or
		/// neutral point.  If the energy consumer is delta connected, the phase indicates
		/// an energy consumer connected from the indicated phase to the next logical non-
		/// neutral phase.
		/// </summary>
		public SinglePhaseKind phase;
		/// <summary>
		/// Reactive power of the load. Load sign convention is used, i.e. positive sign
		/// means flow out from a node.
		/// For voltage dependent loads the value is at rated voltage.
		/// Starting value for a steady state solution.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ReactivePower q;
		/// <summary>
		/// Reactive power of the load that is a fixed quantity. Load sign convention is
		/// used, i.e. positive sign means flow out from a node.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ReactivePower qfixed;
		/// <summary>
		/// Fixed reactive power as per cent of load group fixed reactive power. Load sign
		/// convention is used, i.e. positive sign means flow out from a node.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PerCent qfixedPct;

		public EnergyConsumerPhase(){

		}

		~EnergyConsumerPhase(){

		}

		public override void Dispose(){

		}

	}//end EnergyConsumerPhase

}//end namespace Wires