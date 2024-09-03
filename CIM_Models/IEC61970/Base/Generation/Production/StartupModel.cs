﻿///////////////////////////////////////////////////////////
//  StartupModel.cs
//  Implementation of the Class StartupModel
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:22 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Generation.Production;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Generation.Production {
	/// <summary>
	/// Unit start up characteristics depending on how long the unit has been off line.
	/// 
	/// </summary>
	public class StartupModel : IdentifiedObject {

		/// <summary>
		/// Fixed maintenance cost.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CostRate fixedMaintCost;
		/// <summary>
		/// The amount of heat input per time unit required for hot standby operation.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.HeatRate hotStandbyHeat;
		/// <summary>
		/// Incremental maintenance cost.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CostPerEnergyUnit incrementalMaintCost;
		/// <summary>
		/// The minimum number of hours the unit must be down before restart.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Hours minimumDownTime;
		/// <summary>
		/// The minimum number of hours the unit must be operating before being allowed to
		/// shut down.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Hours minimumRunTime;
		/// <summary>
		/// The opportunity cost associated with the return in monetary unit. This
		/// represents the restart's "share" of the unit depreciation and risk of an event
		/// which would damage the unit.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money riskFactorCost;
		/// <summary>
		/// Total miscellaneous start up costs.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money startupCost;
		/// <summary>
		/// The date and time of the most recent generating unit startup.
		/// </summary>
		public System.DateTime startupDate;
		/// <summary>
		/// Startup priority within control area where lower numbers indicate higher
		/// priorities.  More than one unit in an area may be assigned the same priority.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer startupPriority;
		/// <summary>
		/// The unit's auxiliary active power consumption to maintain standby mode.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower stbyAuxP;
		/// <summary>
		/// The unit's startup model may have a startup ramp curve.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.StartRampCurve StartRampCurve;
		/// <summary>
		/// The unit's startup model may have a startup ignition fuel curve.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.StartIgnFuelCurve StartIgnFuelCurve;
		/// <summary>
		/// The unit's startup model may have a startup main fuel curve.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.StartMainFuelCurve StartMainFuelCurve;

		public StartupModel(){

		}

		~StartupModel(){

		}

		public override void Dispose(){

		}

	}//end StartupModel

}//end namespace Production