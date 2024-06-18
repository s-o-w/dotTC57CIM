///////////////////////////////////////////////////////////
//  Time.cs
//  Implementation of the Class Time
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:26 AM
//  Original author: kdemaree
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Time as "hh:mm:ss.sss", which conforms with ISO 8601. UTC time zone is
	/// specified as "hh:mm:ss.sssZ". A local timezone relative UTC is specified as "hh:
	/// mm:ss.sss�hh:mm". The second component (shown here as "ss.sss") could have any
	/// number of digits in its fractional part to allow any kind of precision beyond
	/// seconds.
	/// </summary>
	public class Time {

		public Time(){

		}

		~Time(){

		}

		public virtual void Dispose(){

		}

	}//end Time

}//end namespace Domain