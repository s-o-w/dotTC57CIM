///////////////////////////////////////////////////////////
//  CurrentLimit.cs
//  Implementation of the Class CurrentLimit
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:45 AM
//  Original author: kdd
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.OperationalLimits;
namespace TC57CIM.IEC61970.Base.OperationalLimits {
	/// <summary>
	/// Operational limit on current.
	/// </summary>
	public class CurrentLimit : OperationalLimit {

		/// <summary>
		/// The normal value for limit on current flow. The attribute shall be a positive
		/// value or zero.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CurrentFlow normalValue;
		/// <summary>
		/// Limit on current flow. The attribute shall be a positive value or zero.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CurrentFlow value;

		public CurrentLimit(){

		}

		~CurrentLimit(){

		}

		public override void Dispose(){

		}

	}//end CurrentLimit

}//end namespace OperationalLimits