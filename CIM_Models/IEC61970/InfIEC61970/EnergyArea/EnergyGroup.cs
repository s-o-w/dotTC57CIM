﻿///////////////////////////////////////////////////////////
//  EnergyGroup.cs
//  Implementation of the Class EnergyGroup
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:50 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.InfIEC61970.EnergyArea;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61970.Base.ControlArea;
namespace TC57CIM.IEC61970.InfIEC61970.EnergyArea {
	public class EnergyGroup : PowerSystemResource {

		public bool isSlack;
		public TC57CIM.IEC61970.Base.Domain.ActivePower p;
		public TC57CIM.IEC61970.InfIEC61970.EnergyArea.EnergyTypeReference m_EnergyTypeReference;
		public TC57CIM.IEC61970.Base.ControlArea.ControlArea m_ControlArea;

		public EnergyGroup(){

		}

		~EnergyGroup(){

		}

		public override void Dispose(){

		}

	}//end EnergyGroup

}//end namespace EnergyArea