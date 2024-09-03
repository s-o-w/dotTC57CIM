﻿///////////////////////////////////////////////////////////
//  ReadingQualityType.cs
//  Implementation of the Class ReadingQualityType
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:22 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Detailed description for a quality of a reading value, produced by an end
	/// device or a system. Values in attributes allow for creation of the recommended
	/// codes to be used for identifying reading value quality codes as follows:
	/// <systemId>.<category>.<subCategory>.
	/// </summary>
	public class ReadingQualityType : IdentifiedObject {

		/// <summary>
		/// High-level nature of the reading value quality.
		/// </summary>
		public string category;
		/// <summary>
		/// More specific nature of the reading value quality, as a further sub-
		/// categorisation of 'category'.
		/// </summary>
		public string subCategory;
		/// <summary>
		/// Identification of the system which has declared the issue with the data or
		/// provided commentary on the data.
		/// </summary>
		public string systemId;

		public ReadingQualityType(){

		}

		~ReadingQualityType(){

		}

		public override void Dispose(){

		}

	}//end ReadingQualityType

}//end namespace Metering