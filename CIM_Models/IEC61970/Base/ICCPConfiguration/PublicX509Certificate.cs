///////////////////////////////////////////////////////////
//  PublicX509Certificate.cs
//  Implementation of the Class PublicX509Certificate
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:18 AM
//  Original author: herb
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.ICCPConfiguration;
namespace TC57CIM.IEC61970.Base.ICCPConfiguration {
	/// <summary>
	/// Used to convey information that will allow matching in order to determine which
	/// certificate to use.  Actual certificates are exchanged externally to the CIM
	/// exchange.
	/// </summary>
	public class PublicX509Certificate {

		/// <summary>
		/// Represents the CA that issued the certificate.  Defined to be per X.509.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String issuerName;
		/// <summary>
		/// Is the serial number of the certificate per X.509 definition.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String serialNumber;
		/// <summary>
		/// The association allows a certificate to be bound for use by TLS.
		/// </summary>
		public TC57CIM.IEC61970.Base.ICCPConfiguration.TCPAccessPoint TCPAccessPoint;
		/// <summary>
		/// Application layer used with the certificate for mutual authentication.
		/// </summary>
		public TC57CIM.IEC61970.Base.ICCPConfiguration.ISOUpperLayer ISOUpperLayer;

		public PublicX509Certificate(){

		}

		~PublicX509Certificate(){

		}

		public virtual void Dispose(){

		}

	}//end PublicX509Certificate

}//end namespace ICCPConfiguration