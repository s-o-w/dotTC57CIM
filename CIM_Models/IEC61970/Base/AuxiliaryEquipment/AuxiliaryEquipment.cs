﻿///////////////////////////////////////////////////////////
//  AuxiliaryEquipment.cs
//  Implementation of the Class AuxiliaryEquipment
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:40 AM
//  Original author: selaost1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.AuxiliaryEquipment {
	/// <summary>
	/// AuxiliaryEquipment describe equipment that is not performing any primary
	/// functions but support for the equipment performing the primary function.
	/// AuxiliaryEquipment is attached to primary equipment via an association with
	/// Terminal.
	/// </summary>
	public class AuxiliaryEquipment : Equipment {

		/// <summary>
		/// The Terminal at the equipment where the AuxiliaryEquipment is attached.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.Terminal Terminal;

		public AuxiliaryEquipment(){

		}

		~AuxiliaryEquipment(){

		}

		public override void Dispose(){

		}

	}//end AuxiliaryEquipment

}//end namespace AuxiliaryEquipment