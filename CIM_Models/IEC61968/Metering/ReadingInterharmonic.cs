///////////////////////////////////////////////////////////
//  ReadingInterharmonic.cs
//  Implementation of the Class ReadingInterharmonic
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:22 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Interharmonics are represented as a rational number 'numerator' / 'denominator',
	/// and harmonics are represented using the same mechanism and identified by
	/// 'denominator'=1.
	/// </summary>
	public class ReadingInterharmonic {

		/// <summary>
		/// Interharmonic denominator. Value 0 means not applicable. Value 2 is used in
		/// combination with 'numerator'=1 to represent interharmonic 1/2. Finally, value 1
		/// indicates the harmonic of the order specified with 'numerator'.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer denominator;
		/// <summary>
		/// Interharmonic numerator. Value 0 means not applicable. Value 1 is used in
		/// combination with 'denominator'=2 to represent interharmonic 1/2, and with
		/// 'denominator'=1 it represents fundamental frequency. Finally, values greater
		/// than 1 indicate the harmonic of that order (e.g., 'numerator'=5 is the fifth
		/// harmonic).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer numerator;

		public ReadingInterharmonic(){

		}

		~ReadingInterharmonic(){

		}

		public virtual void Dispose(){

		}

	}//end ReadingInterharmonic

}//end namespace Metering