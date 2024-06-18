///////////////////////////////////////////////////////////
//  Facility.cs
//  Implementation of the Class Facility
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:11 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.AssetInfo.Assets;
namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// A facility may contain buildings, storage facilities, switching facilities,
	/// power generation, manufacturing facilities, maintenance facilities, etc.
	/// </summary>
	public class Facility : AssetContainer {

		/// <summary>
		/// Kind of this facility.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String kind;

		public Facility(){

		}

		~Facility(){

		}

		public override void Dispose(){

		}

	}//end Facility

}//end namespace Assets