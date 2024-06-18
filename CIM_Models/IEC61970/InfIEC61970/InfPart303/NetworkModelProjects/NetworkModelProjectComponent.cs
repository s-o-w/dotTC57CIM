///////////////////////////////////////////////////////////
//  NetworkModelProjectComponent.cs
//  Implementation of the Class NetworkModelProjectComponent
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:09 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects;
namespace TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects {
	/// <summary>
	/// Abstract class for both a network model project and network model change.
	/// </summary>
	public class NetworkModelProjectComponent : IdentifiedObject {

		public TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects.NetworkModelProjectDocument m_NetworkModelProjectDocument;
		/// <summary>
		/// The parent project of this project.
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects.NetworkModelProject ContainingProject;

		public NetworkModelProjectComponent(){

		}

		~NetworkModelProjectComponent(){

		}

		public override void Dispose(){

		}

	}//end NetworkModelProjectComponent

}//end namespace NetworkModelProjects