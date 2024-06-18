///////////////////////////////////////////////////////////
//  AlternateModel.cs
//  Implementation of the Class AlternateModel
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:39 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61970.InfIEC61970.InfPart303.AlternateModels;
using TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet;
namespace TC57CIM.IEC61970.InfIEC61970.InfPart303.AlternateModels {
	public class AlternateModel : IdentifiedObject {

		/// <summary>
		/// The group of alternate models for which one alternate is used.
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.InfPart303.AlternateModels.AlternateModelGroup AlternateModelGroup;
		/// <summary>
		/// The data belonging to the alternate model.
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet.DataSet Dataset;

		public AlternateModel(){

		}

		~AlternateModel(){

		}

		public override void Dispose(){

		}

	}//end AlternateModel

}//end namespace AlternateModels