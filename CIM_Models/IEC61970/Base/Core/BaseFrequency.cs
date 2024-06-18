///////////////////////////////////////////////////////////
//  BaseFrequency.cs
//  Implementation of the Class BaseFrequency
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:40 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// The BaseFrequency class describes a base frequency for a power system network.
	/// In case of multiple power networks with different frequencies, e.g. 50 Hz or 60
	/// Hz each network will have its own base frequency class. Hence it is assumed
	/// that power system objects having different base frequencies appear in separate
	/// documents where each document has a single base frequency instance.
	/// </summary>
	public class BaseFrequency : IdentifiedObject {

		/// <summary>
		/// The base frequency.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency frequency;

		public BaseFrequency(){

		}

		~BaseFrequency(){

		}

		public override void Dispose(){

		}

	}//end BaseFrequency

}//end namespace Core