///////////////////////////////////////////////////////////
//  Name.cs
//  Implementation of the Class Name
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:08 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// The Name class provides the means to define any number of human readable  names
	/// for an object. A name is <b>not</b> to be used for defining inter-object
	/// relationships. For inter-object relationships instead use the object
	/// identification 'mRID'.
	/// </summary>
	public class Name {

		/// <summary>
		/// Any free text that name the object.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String name;
		/// <summary>
		/// Type of this name.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.NameType NameType;
		/// <summary>
		/// Identified object that this name designates.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.IdentifiedObject IdentifiedObject;

		public Name(){

		}

		~Name(){

		}

		public virtual void Dispose(){

		}

	}//end Name

}//end namespace Core