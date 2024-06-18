///////////////////////////////////////////////////////////
//  StreetAddress.cs
//  Implementation of the Class StreetAddress
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:25 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Common;
namespace TC57CIM.IEC61968.Common {
	/// <summary>
	/// General purpose street and postal address information.
	/// </summary>
	public class StreetAddress {

		/// <summary>
		/// The language in which the address is specified, using ISO 639-1 two digit
		/// language code.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String language;
		/// <summary>
		/// Post office box.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String poBox;
		/// <summary>
		/// Postal code for the address.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String postalCode;
		/// <summary>
		/// Status of this address.
		/// </summary>
		public Status status;
		/// <summary>
		/// Street detail.
		/// </summary>
		public StreetDetail streetDetail;
		/// <summary>
		/// Town detail.
		/// </summary>
		public TownDetail townDetail;

		public StreetAddress(){

		}

		~StreetAddress(){

		}

		public virtual void Dispose(){

		}

	}//end StreetAddress

}//end namespace Common