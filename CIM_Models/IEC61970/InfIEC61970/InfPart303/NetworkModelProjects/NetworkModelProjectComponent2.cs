﻿///////////////////////////////////////////////////////////
//  NetworkModelProjectComponent2.cs
//  Implementation of the Class NetworkModelProjectComponent2
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:09 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects;
namespace TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects {
	public class NetworkModelProjectComponent2 : IdentifiedObject {

		public System.DateTime closed;
		public System.DateTime created;
		public System.DateTime updated;
		public TC57CIM.IEC61970.Base.Domain.Integer version;
		public TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects.CurrentState m_CurrentState;
		public TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects.NetworkModelProject2 Parent;

		public NetworkModelProjectComponent2(){

		}

		~NetworkModelProjectComponent2(){

		}

		public override void Dispose(){

		}

	}//end NetworkModelProjectComponent2

}//end namespace NetworkModelProjects