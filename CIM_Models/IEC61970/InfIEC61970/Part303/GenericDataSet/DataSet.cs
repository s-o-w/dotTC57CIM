﻿///////////////////////////////////////////////////////////
//  DataSet.cs
//  Implementation of the Class DataSet
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:46 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet;
namespace TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet {
	/// <summary>
	/// A generic container of a version of instance data. The MRID can be used in an
	/// audit trail, not in reusable script intended to work with new versions of data.
	/// 
	/// A dataset could be serialized multiple times and in multiple technologies, yet
	/// retain the same identity.
	/// </summary>
	public class DataSet {

		/// <summary>
		/// The description is a free human readable text describing or naming the object.
		/// It may be non unique and may not correlate to a naming hierarchy.
		/// </summary>
		public string description;
		/// <summary>
		/// Master resource identifier issued by a model authority. The mRID is unique
		/// within an exchange context. Global uniqueness is easily achieved by using a
		/// UUID,  as specified in RFC 4122, for the mRID. The use of UUID is strongly
		/// recommended.
		/// For CIMXML data files in RDF syntax conforming to IEC 61970-552 Edition 1, the
		/// mRID is mapped to rdf:ID or rdf:about attributes that identify CIM object
		/// elements.
		/// </summary>
		public string mRID;
		/// <summary>
		/// The name is any free human readable and possibly non unique text naming the
		/// object.
		/// </summary>
		public string name;
		/// <summary>
		/// The profiles that describe the contents of the data set and the rules governing
		/// the contents of the data set.
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet.Profile Profile;

		public DataSet(){

		}

		~DataSet(){

		}

		public virtual void Dispose(){

		}

	}//end DataSet

}//end namespace GenericDataSet