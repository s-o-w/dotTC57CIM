﻿///////////////////////////////////////////////////////////
//  PotentialTransformerKind.cs
//  Implementation of the Class PotentialTransformerKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:14 AM
//  Original author: kdemaree
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.Base.AuxiliaryEquipment {
	/// <summary>
	/// The construction kind of the potential transformer.
	/// </summary>
	public enum PotentialTransformerKind : int {

		/// <summary>
		/// The potential transformer is using induction coils to create secondary voltage.
		/// 
		/// </summary>
		inductive,
		/// <summary>
		/// The potential transformer is using capacitive coupling to create secondary
		/// voltage.
		/// </summary>
		capacitiveCoupling

	}//end PotentialTransformerKind

}//end namespace AuxiliaryEquipment