﻿///////////////////////////////////////////////////////////
//  LineFault.cs
//  Implementation of the Class LineFault
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:06 AM
//  Original author: kdemaree
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Wires;
using TC57CIM.IEC61970.Base.Faults;
namespace TC57CIM.IEC61970.Base.Faults {
	/// <summary>
	/// A fault that occurs on an AC line segment at some point along the length.
	/// </summary>
	public class LineFault : Fault {

		/// <summary>
		/// The length to the place where the fault is located starting from terminal with
		/// sequence number 1 of the faulted line segment.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Length lengthFromTerminal1;
		/// <summary>
		/// The line segment of this line fault.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.ACLineSegment ACLineSegment;

		public LineFault(){

		}

		~LineFault(){

		}

		public override void Dispose(){

		}

	}//end LineFault

}//end namespace Faults