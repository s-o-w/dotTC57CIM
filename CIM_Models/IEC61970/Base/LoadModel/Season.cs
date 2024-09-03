﻿///////////////////////////////////////////////////////////
//  Season.cs
//  Implementation of the Class Season
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:20 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.LoadModel;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.LoadModel {
	/// <summary>
	/// A specified time period of the year.
	/// </summary>
	public class Season : IdentifiedObject {

		/// <summary>
		/// Date season ends.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.MonthDay endDate;
		/// <summary>
		/// Date season starts.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.MonthDay startDate;
		/// <summary>
		/// Schedules that use this Season.
		/// </summary>
		public TC57CIM.IEC61970.Base.LoadModel.SeasonDayTypeSchedule SeasonDayTypeSchedules;

		public Season(){

		}

		~Season(){

		}

		public override void Dispose(){

		}

	}//end Season

}//end namespace LoadModel