﻿///////////////////////////////////////////////////////////
//  CULaborCode.cs
//  Implementation of the Class CULaborCode
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:03 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Common;
using TC57CIM.IEC61968.InfIEC61968.InfWork;
namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// Labor code associated with various compatible unit labor items.
	/// </summary>
	public class CULaborCode : WorkIdentifiedObject {

		/// <summary>
		/// Labor code.
		/// </summary>
		public string code;
		public TC57CIM.IEC61968.Common.Status status;

		public CULaborCode(){

		}

		~CULaborCode(){

		}

		public override void Dispose(){

		}

	}//end CULaborCode

}//end namespace InfWork