///////////////////////////////////////////////////////////
//  ServiceRequestKind.cs
//  Implementation of the Class ServiceRequestKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:24 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61968.Customers {
	/// <summary>
	/// Kinds of service requests
	/// </summary>
	public enum ServiceRequestKind : int {

		/// <summary>
		/// The construction work requested.
		/// </summary>
		construction,
		/// <summary>
		/// Inspection work.
		/// </summary>
		inspection,
		/// <summary>
		/// Repair work.
		/// </summary>
		repair,
		/// <summary>
		/// Test work.
		/// </summary>
		test,
		/// <summary>
		/// Physically disconnect the service.
		/// </summary>
		disconnect,
		/// <summary>
		/// Physically reconnect the service.
		/// </summary>
		reconnect,
		/// <summary>
		/// Physically connect the service.
		/// </summary>
		connect,
		/// <summary>
		/// Turn on the service.
		/// </summary>
		turnOn,
		/// <summary>
		/// Other kind of work.
		/// </summary>
		other,
		/// <summary>
		/// Temporarily turn off the service but leave the connection in place.
		/// </summary>
		turnOff,
		/// <summary>
		/// replace an asset
		/// </summary>
		replace,
		/// <summary>
		/// A new service is requested by the customer
		/// </summary>
		newservice

	}//end ServiceRequestKind

}//end namespace Customers