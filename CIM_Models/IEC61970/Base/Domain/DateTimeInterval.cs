///////////////////////////////////////////////////////////
//  DateTimeInterval.cs
//  Implementation of the Class DateTimeInterval
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:46 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.Base.Domain {
	/// <summary>
	/// Interval between two date and time points, where the interval includes the
	/// start time but excludes end time.
	/// </summary>
	public class DateTimeInterval {

		/// <summary>
		/// End date and time of this interval.  The end date and time where the interval
		/// is defined up to, but excluded.
		/// </summary>
		public DateTime end;
		/// <summary>
		/// Start date and time of this interval.  The start date and time is included in
		/// the defined interval.
		/// </summary>
		public DateTime start;

		public DateTimeInterval(){

		}

		~DateTimeInterval(){

		}

		public virtual void Dispose(){

		}

	}//end DateTimeInterval

}//end namespace Domain