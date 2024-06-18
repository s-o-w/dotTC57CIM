///////////////////////////////////////////////////////////
//  ValueAliasSet.cs
//  Implementation of the Class ValueAliasSet
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:28 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Meas;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Meas {
	/// <summary>
	/// Describes the translation of a set of values into a name and is intendend to
	/// facilitate custom translations. Each ValueAliasSet has a name, description etc.
	/// A specific Measurement may represent a discrete state like Open, Closed,
	/// Intermediate etc. This requires a translation from the MeasurementValue.value
	/// number to a string, e.g. 0->"Invalid", 1->"Open", 2->"Closed", 3-
	/// >"Intermediate". Each ValueToAlias member in ValueAliasSet.Value describe a
	/// mapping for one particular value to a name.
	/// </summary>
	public class ValueAliasSet : IdentifiedObject {

		/// <summary>
		/// The ValueToAlias mappings included in the set.
		/// </summary>
		public TC57CIM.IEC61970.Base.Meas.ValueToAlias Values;
		/// <summary>
		/// The Measurements using the set for translation.
		/// </summary>
		public TC57CIM.IEC61970.Base.Meas.Discrete Discretes;

		public ValueAliasSet(){

		}

		~ValueAliasSet(){

		}

		public override void Dispose(){

		}

	}//end ValueAliasSet

}//end namespace Meas