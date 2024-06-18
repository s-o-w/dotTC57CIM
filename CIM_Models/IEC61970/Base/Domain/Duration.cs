///////////////////////////////////////////////////////////
//  Duration.cs
//  Implementation of the Class Duration
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:49 AM
//  Original author: kdemaree
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Duration as "PnYnMnDTnHnMnS" which conforms to ISO 8601, where nY expresses a
	/// number of years, nM a number of months, nD a number of days. The letter T
	/// separates the date expression from the time expression and, after it, nH
	/// identifies a number of hours, nM a number of minutes and nS a number of seconds.
	/// The number of seconds could be expressed as a decimal number, but all other
	/// numbers are integers.
	/// </summary>
	public class Duration {

		public Duration(){

		}

		~Duration(){

		}

		public virtual void Dispose(){

		}

	}//end Duration

}//end namespace Domain