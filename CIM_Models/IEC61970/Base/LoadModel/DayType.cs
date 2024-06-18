///////////////////////////////////////////////////////////
//  DayType.cs
//  Implementation of the Class DayType
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:46 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.LoadModel;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.LoadModel {
	/// <summary>
	/// Group of similar days.   For example it could be used to represent weekdays,
	/// weekend, or holidays.
	/// </summary>
	public class DayType : IdentifiedObject {

		/// <summary>
		/// Schedules that use this DayType.
		/// </summary>
		public TC57CIM.IEC61970.Base.LoadModel.SeasonDayTypeSchedule SeasonDayTypeSchedules;

		public DayType(){

		}

		~DayType(){

		}

		public override void Dispose(){

		}

	}//end DayType

}//end namespace LoadModel