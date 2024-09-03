﻿///////////////////////////////////////////////////////////
//  MaterialItem.cs
//  Implementation of the Class MaterialItem
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:15 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.Work {
	/// <summary>
	/// The physical consumable supply used for work and other purposes. It includes
	/// items such as nuts, bolts, brackets, glue, etc.
	/// </summary>
	public class MaterialItem : IdentifiedObject {

		/// <summary>
		/// Quantity of material used.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.IntegerQuantity quantity;

		public MaterialItem(){

		}

		~MaterialItem(){

		}

		public override void Dispose(){

		}

	}//end MaterialItem

}//end namespace Work