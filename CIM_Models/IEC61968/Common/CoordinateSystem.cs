///////////////////////////////////////////////////////////
//  CoordinateSystem.cs
//  Implementation of the Class CoordinateSystem
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:02 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.Common {
	/// <summary>
	/// Coordinate reference system.
	/// </summary>
	public class CoordinateSystem : IdentifiedObject {

		/// <summary>
		/// A Uniform Resource Name (URN) for the coordinate reference system (crs) used to
		/// define 'Location.PositionPoints'.
		/// An example would be the European Petroleum Survey Group (EPSG) code for a
		/// coordinate reference system, defined in URN under the Open Geospatial
		/// Consortium (OGC) namespace as: urn:ogc:def:crs:EPSG::XXXX, where XXXX is an
		/// EPSG code (a full list of codes can be found at the EPSG Registry web site http:
		/// //www.epsg-registry.org/). To define the coordinate system as being WGS84
		/// (latitude, longitude) using an EPSG OGC, this attribute would be urn:ogc:def:
		/// crs:EPSG::4.3.2.6
		/// A profile should limit this code to a set of allowed URNs agreed to by all
		/// sending and receiving parties.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String crsUrn;

		public CoordinateSystem(){

		}

		~CoordinateSystem(){

		}

		public override void Dispose(){

		}

	}//end CoordinateSystem

}//end namespace Common