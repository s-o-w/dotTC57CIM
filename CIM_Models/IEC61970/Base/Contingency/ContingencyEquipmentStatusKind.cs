///////////////////////////////////////////////////////////
//  ContingencyEquipmentStatusKind.cs
//  Implementation of the Class ContingencyEquipmentStatusKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:44 AM
//  Original author: kdd
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.Base.Contingency {
	/// <summary>
	/// Indicates the state which the contingency equipment is to be in when the
	/// contingency is applied.
	/// </summary>
	public enum ContingencyEquipmentStatusKind : int {

		/// <summary>
		/// The equipment is to be put into service.
		/// </summary>
		inService,
		/// <summary>
		/// The equipment is to be taken out of service.
		/// </summary>
		outOfService

	}//end ContingencyEquipmentStatusKind

}//end namespace Contingency