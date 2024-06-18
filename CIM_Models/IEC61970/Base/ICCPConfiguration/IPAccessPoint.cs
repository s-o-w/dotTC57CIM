///////////////////////////////////////////////////////////
//  IPAccessPoint.cs
//  Implementation of the Class IPAccessPoint
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:05 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.ICCPConfiguration;
using TC57CIM.IEC61970.Base.SCADA;
namespace TC57CIM.IEC61970.Base.ICCPConfiguration {
	/// <summary>
	/// Internet Protocol Access Point � used to represent an addressing structure is
	/// based upon an Internet Protocol (IP) address.
	/// </summary>
	public class IPAccessPoint : CommunicationLink {

		/// <summary>
		/// Is the dotted decimal IP Address resolve the IP address. The format is
		/// controlled by the value of the addressType.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String address;
		/// <summary>
		/// IP address type.
		/// </summary>
		public IPAddressKind addressType;
		/// <summary>
		/// Is the dotted decimal IPAddress of the first hop router.  Format is controlled
		/// by the addressType.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String gateway;
		/// <summary>
		/// This is the IP subnet mask which controls the local vs non-local routing.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String subnet;

		public IPAccessPoint(){

		}

		~IPAccessPoint(){

		}

		public override void Dispose(){

		}

	}//end IPAccessPoint

}//end namespace ICCPConfiguration