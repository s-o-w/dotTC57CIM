﻿///////////////////////////////////////////////////////////
//  Version.cs
//  Implementation of the Class Version
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:31 AM
//  Original author: marga
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61968.Common {
	/// <summary>
	/// This is the version for a group of devices or objects.  This could be used to
	/// track the version for any group of objects or devices over time. For example,
	/// for a DERGroup, the requesting system may want to get the details of a specific
	/// version of a DERGroup.
	/// </summary>
	public class Version {

		/// <summary>
		/// date of this version
		/// </summary>
		public System.DateTime date;
		/// <summary>
		/// major release level for this version
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer major;
		/// <summary>
		/// minor release level for this version
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer minor;
		/// <summary>
		/// revision level for this version
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer revision;

		public Version(){

		}

		~Version(){

		}

		public virtual void Dispose(){

		}

	}//end Version

}//end namespace Common