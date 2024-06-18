///////////////////////////////////////////////////////////
//  Project.cs
//  Implementation of the Class Project
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:21 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.InfIEC61968.InfWork;
namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// A collection of related work. For construction projects and maintenance
	/// projects, multiple phases may be performed.
	/// </summary>
	public class Project : WorkDocument {

		/// <summary>
		/// Overall project budget.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money budget;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.Project SubProjects;

		public Project(){

		}

		~Project(){

		}

		public override void Dispose(){

		}

	}//end Project

}//end namespace InfWork