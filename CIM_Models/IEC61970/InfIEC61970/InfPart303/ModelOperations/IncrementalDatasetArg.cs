﻿///////////////////////////////////////////////////////////
//  IncrementalDatasetArg.cs
//  Implementation of the Class IncrementalDatasetArg
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:04 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.InfIEC61970.InfPart303.ModelOperations;
using TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet;
namespace TC57CIM.IEC61970.InfIEC61970.InfPart303.ModelOperations {
	/// <summary>
	/// A generic model operation argument referencing an incremental change
	/// description.
	/// </summary>
	public class IncrementalDatasetArg : ModelOperationArg {

		public TC57CIM.IEC61970.InfIEC61970.InfPart303.ModelOperations.IncrementalDatasetArgDescription IncrementalDatasetArgDescription;
		public TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet.ChangeSet IncrementalDataset;

		public IncrementalDatasetArg(){

		}

		~IncrementalDatasetArg(){

		}

		public override void Dispose(){

		}

	}//end IncrementalDatasetArg

}//end namespace ModelOperations