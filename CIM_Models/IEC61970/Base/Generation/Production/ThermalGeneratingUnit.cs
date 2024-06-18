///////////////////////////////////////////////////////////
//  ThermalGeneratingUnit.cs
//  Implementation of the Class ThermalGeneratingUnit
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:26 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Generation.Production;
namespace TC57CIM.IEC61970.Base.Generation.Production {
	/// <summary>
	/// A generating unit whose prime mover could be a steam turbine, combustion
	/// turbine, or diesel engine.
	/// </summary>
	public class ThermalGeneratingUnit : GeneratingUnit {

		/// <summary>
		/// Operating and maintenance cost for the thermal unit.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CostPerHeatUnit oMCost;
		/// <summary>
		/// A thermal generating unit may have a heat rate curve.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.HeatRateCurve HeatRateCurve;
		/// <summary>
		/// A thermal generating unit may have one or more fuel allocation schedules.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.FuelAllocationSchedule FuelAllocationSchedules;
		/// <summary>
		/// A thermal generating unit may have a startup model.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.StartupModel StartupModel;
		/// <summary>
		/// A thermal generating unit may have  one or more emission curves.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.EmissionCurve EmissionCurves;
		/// <summary>
		/// A thermal generating unit may have a shutdown curve.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.ShutdownCurve ShutdownCurve;
		/// <summary>
		/// A thermal generating unit may have an incremental heat rate curve.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.IncrementalHeatRateCurve IncrementalHeatRateCurve;
		/// <summary>
		/// A thermal generating unit may have one or more emission allowance accounts.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.EmissionAccount EmmissionAccounts;
		/// <summary>
		/// A thermal generating unit may have a heat input curve.
		/// </summary>
		public TC57CIM.IEC61970.Base.Generation.Production.HeatInputCurve HeatInputCurve;

		public ThermalGeneratingUnit(){

		}

		~ThermalGeneratingUnit(){

		}

		public override void Dispose(){

		}

	}//end ThermalGeneratingUnit

}//end namespace Production