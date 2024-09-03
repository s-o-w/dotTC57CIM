﻿///////////////////////////////////////////////////////////
//  BusinessCase.cs
//  Implementation of the Class BusinessCase
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:59 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.InfIEC61968.InfWork;
using TC57CIM.IEC61968.Work;
namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// Business justification for capital expenditures, usually addressing operations
	/// and maintenance costs as well.
	/// </summary>
	public class BusinessCase : WorkDocument {

		/// <summary>
		/// A codified representation of the business case (i.e., codes for highway
		/// relocation, replace substation transformers, etc.).
		/// </summary>
		public string corporateCode;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.Project Projects;
		public TC57CIM.IEC61968.Work.Work Works;

		public BusinessCase(){

		}

		~BusinessCase(){

		}

		public override void Dispose(){

		}

	}//end BusinessCase

}//end namespace InfWork