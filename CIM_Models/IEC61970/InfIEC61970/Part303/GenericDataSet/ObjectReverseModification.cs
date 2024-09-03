﻿///////////////////////////////////////////////////////////
//  ObjectReverseModification.cs
//  Implementation of the Class ObjectReverseModification
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:10 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet;
namespace TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet {
	/// <summary>
	/// Used to specify precondition properties for a preconditioned update.
	/// </summary>
	public class ObjectReverseModification : ChangeSetMember {

		/// <summary>
		/// The associated data object representing the update. Normally the associaiton is
		/// specifed, but in the case of a proxy object where the association is removed,
		/// we might not reference any data object as it would only reference a proxy data
		/// object with no associations.
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.Part303.GenericDataSet.ObjectModification ObjectModification;

		public ObjectReverseModification(){

		}

		~ObjectReverseModification(){

		}

		public override void Dispose(){

		}

	}//end ObjectReverseModification

}//end namespace GenericDataSet