﻿///////////////////////////////////////////////////////////
//  InspectionDataSet.cs
//  Implementation of the Class InspectionDataSet
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:12 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.AssetInfo.Assets;
namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Documents the result of one inspection, for a given attribute of an asset.
	/// </summary>
	public class InspectionDataSet : ProcedureDataSet {

		/// <summary>
		/// Description of the conditions of the location where the asset resides.
		/// </summary>
		public string locationCondition;

		public InspectionDataSet(){

		}

		~InspectionDataSet(){

		}

		public override void Dispose(){

		}

	}//end InspectionDataSet

}//end namespace Assets