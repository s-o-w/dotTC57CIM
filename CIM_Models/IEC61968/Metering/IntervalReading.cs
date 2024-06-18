///////////////////////////////////////////////////////////
//  IntervalReading.cs
//  Implementation of the Class IntervalReading
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:13 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.Metering;
namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// Data captured at regular intervals of time. Interval data could be captured as
	/// incremental data, absolute data, or relative data. The source for the data is
	/// usually a tariff quantity or an engineering quantity. Data is typically
	/// captured in time-tagged, uniform, fixed-length intervals of 5 min, 10 min, 15
	/// min, 30 min, or 60 min.
	/// Note: Interval Data is sometimes also called "Interval Data Readings" (IDR).
	/// </summary>
	public class IntervalReading : BaseReading {

		public IntervalReading(){

		}

		~IntervalReading(){

		}

		public override void Dispose(){

		}

	}//end IntervalReading

}//end namespace Metering