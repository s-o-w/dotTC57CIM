﻿///////////////////////////////////////////////////////////
//  ClearanceDocument.cs
//  Implementation of the Class ClearanceDocument
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:01 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61968.Operations;
namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// Safety document used to authorise work on conducting equipment in the field.
	/// Tagged equipment is not allowed to be operated.
	/// </summary>
	public class ClearanceDocument : SafetyDocument {

		/// <summary>
		/// If true, the equipment must be deenergised.
		/// </summary>
		public bool mustBeDeenergised;
		/// <summary>
		/// If true, the equipment must be grounded.
		/// </summary>
		public bool mustBeGrounded;
		/// <summary>
		/// All power system resources tagged through this clearance.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.PowerSystemResource TaggedPSRs;

		public ClearanceDocument(){

		}

		~ClearanceDocument(){

		}

		public override void Dispose(){

		}

	}//end ClearanceDocument

}//end namespace Operations