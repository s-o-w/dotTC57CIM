﻿///////////////////////////////////////////////////////////
//  OneCallRequest.cs
//  Implementation of the Class OneCallRequest
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:17 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.InfIEC61968.InfWork;
namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// A request for other utilities to mark their underground facilities prior to
	/// commencement of construction and/or maintenance.
	/// </summary>
	public class OneCallRequest : WorkDocument {

		/// <summary>
		/// True if explosives have been or are planned to be used.
		/// </summary>
		public bool explosivesUsed;
		/// <summary>
		/// True if work location has been marked, for example for a dig area.
		/// </summary>
		public bool markedIndicator;
		/// <summary>
		/// Instructions for marking a dig area, if applicable.
		/// </summary>
		public string markingInstruction;

		public OneCallRequest(){

		}

		~OneCallRequest(){

		}

		public override void Dispose(){

		}

	}//end OneCallRequest

}//end namespace InfWork