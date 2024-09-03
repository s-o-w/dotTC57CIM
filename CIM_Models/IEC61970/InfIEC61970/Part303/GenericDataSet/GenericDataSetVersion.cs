﻿///////////////////////////////////////////////////////////
//  GenericDataSetVersion.cs
//  Implementation of the Class GenericDataSetVersion
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:57 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet {
	public class GenericDataSetVersion {

		/// <summary>
		/// The universal CIM version name describing a consistent set of packages.
		/// </summary>
		public string majorVersion = "2016";
		/// <summary>
		/// Describe minor updates and error corrections.
		/// </summary>
		public string minorVersion = "01";
		/// <summary>
		/// The date when the complete CIM canonical model is published and made available
		/// for use,
		/// After the publication the major version and name space are updated.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Date published;

		public GenericDataSetVersion(){

		}

		~GenericDataSetVersion(){

		}

		public virtual void Dispose(){

		}

	}//end GenericDataSetVersion

}//end namespace GenericDataSet