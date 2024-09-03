﻿///////////////////////////////////////////////////////////
//  QualificationRequirement.cs
//  Implementation of the Class QualificationRequirement
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:21 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.InfIEC61968.InfAssets;
using TC57CIM.IEC61968.InfIEC61968.InfWork;
namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// Certain skills are required and must be certified in order for a person
	/// (typically a member of a crew) to be qualified to work on types of equipment.
	/// </summary>
	public class QualificationRequirement : WorkIdentifiedObject {

		/// <summary>
		/// Qualification identifier.
		/// </summary>
		public string qualificationID;
		public TC57CIM.IEC61968.InfIEC61968.InfAssets.Specification Specifications;

		public QualificationRequirement(){

		}

		~QualificationRequirement(){

		}

		public override void Dispose(){

		}

	}//end QualificationRequirement

}//end namespace InfWork