﻿///////////////////////////////////////////////////////////
//  IOPoint.cs
//  Implementation of the Class IOPoint
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:05 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61970.Base.ICCPConfiguration;
namespace TC57CIM.IEC61970.Base.Meas {
	/// <summary>
	/// The class describe a measurement or control value. The purpose is to enable
	/// having attributes and associations common for measurement and control.
	/// </summary>
	public class IOPoint : IdentifiedObject {

		/// <summary>
		/// Bilateral ICCP point for the measurement or control.
		/// </summary>
		public TC57CIM.IEC61970.Base.ICCPConfiguration.ProvidedBilateralPoint BilateralToIOPoint;

		public IOPoint(){

		}

		~IOPoint(){

		}

		public override void Dispose(){

		}

	}//end IOPoint

}//end namespace Meas