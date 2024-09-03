﻿///////////////////////////////////////////////////////////
//  IPAddressKind.cs
//  Implementation of the Class IPAddressKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:05 AM
//  Original author: herb
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.Base.ICCPConfiguration {
	/// <summary>
	/// Indicates if the addressing of the IPAccessPoint, gateway, and subnet are per
	/// IPv4 or IPv6.
	/// </summary>
	public enum IPAddressKind : int {

		/// <summary>
		/// Indicates that IPv4 dotted decimal notation is in use.
		/// </summary>
		iPv4,
		/// <summary>
		/// Indicates that an IPv6 dotted decimal is in use.
		/// </summary>
		iPv6

	}//end IPAddressKind

}//end namespace ICCPConfiguration