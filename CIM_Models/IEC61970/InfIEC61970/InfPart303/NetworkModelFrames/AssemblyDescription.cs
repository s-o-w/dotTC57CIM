///////////////////////////////////////////////////////////
//  AssemblyDescription.cs
//  Implementation of the Class AssemblyDescription
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:40 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelFrames;
namespace TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelFrames {
	/// <summary>
	/// A description for how to assemble model parts for a specific purpose.
	/// </summary>
	public class AssemblyDescription : IdentifiedObject {

		/// <summary>
		/// The models that are part of the assembly descrption.
		/// </summary>
		private TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelFrames.ModelPartSpecification ModelSpecification;

		public AssemblyDescription(){

		}

		~AssemblyDescription(){

		}

		public override void Dispose(){

		}

	}//end AssemblyDescription

}//end namespace NetworkModelFrames