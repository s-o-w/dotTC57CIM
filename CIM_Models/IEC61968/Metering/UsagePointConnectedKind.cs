///////////////////////////////////////////////////////////
//  UsagePointConnectedKind.cs
//  Implementation of the Class UsagePointConnectedKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:30 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// State of the usage point with respect to connection to the network.
	/// </summary>
	public enum UsagePointConnectedKind : int {

		/// <summary>
		/// The usage point is connected to the network and able to receive or send the
		/// applicable commodity (electricity, gas, water, etc.).
		/// </summary>
		connected,
		/// <summary>
		/// The usage point has been disconnected from the network at a point upstream of
		/// the meter. The usage point is unable to receive or send the applicable
		/// commodity (electricity, gas, water, etc.). A physical disconnect is often
		/// achieved by utilising a field crew.
		/// </summary>
		physicallyDisconnected,
		/// <summary>
		/// The usage point has been disconnected through operation of a disconnect
		/// function within the meter present at the usage point.  The usage point is
		/// unable to receive or send the applicable commodity (electricity, gas, water,
		/// etc.)  A logical disconnect can often be achieved without utilising a field
		/// crew.
		/// </summary>
		logicallyDisconnected

	}//end UsagePointConnectedKind

}//end namespace Metering