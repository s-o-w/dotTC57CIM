///////////////////////////////////////////////////////////
//  RightOfWay.cs
//  Implementation of the Class RightOfWay
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:23 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Common;
using TC57CIM.IEC61968.InfIEC61968.InfLocations;
namespace TC57CIM.IEC61968.InfIEC61968.InfLocations {
	/// <summary>
	/// A right-of-way (ROW) is for land where it is lawful to use for a public road,
	/// an electric power line, etc. Note that the association to Location, Asset,
	/// Organisation, etc. for the Grant is inherited from Agreement, a type of
	/// Document.
	/// </summary>
	public class RightOfWay : Agreement {

		/// <summary>
		/// Property related information that describes the ROW's land parcel. For example,
		/// it may be a deed book number, deed book page number, and parcel number.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String propertyData;
		/// <summary>
		/// All land properties this right of way applies to.
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfLocations.LandProperty LandProperties;

		public RightOfWay(){

		}

		~RightOfWay(){

		}

		public override void Dispose(){

		}

	}//end RightOfWay

}//end namespace InfLocations