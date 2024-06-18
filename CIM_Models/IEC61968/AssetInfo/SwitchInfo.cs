///////////////////////////////////////////////////////////
//  SwitchInfo.cs
//  Implementation of the Class SwitchInfo
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:26 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.AssetInfo.Assets;
namespace TC57CIM.IEC61968.AssetInfo {
	/// <summary>
	/// <was Switch data.>
	/// Switch datasheet information.
	/// </summary>
	public class SwitchInfo : Assets.AssetInfo {

		/// <summary>
		/// The maximum fault current a breaking device can break safely under prescribed
		/// conditions of use.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CurrentFlow breakingCapacity;
		/// <summary>
		/// Weight of gas in each tank of SF6 dead tank breaker.
		/// </summary>
		public Mass gasWeightPerTank;
		/// <summary>
		/// If true, it is a single phase switch.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean isSinglePhase;
		/// <summary>
		/// If true, the switch is not ganged (i.e., a switch phase may be operated
		/// separately from other phases).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean isUnganged;
		/// <summary>
		/// Gas or air pressure at or below which a low pressure alarm is generated.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Pressure lowPressureAlarm;
		/// <summary>
		/// Gas or air pressure below which the breaker will not open.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Pressure lowPressureLockOut;
		/// <summary>
		/// Volume of oil in each tank of bulk oil breaker.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Volume oilVolumePerTank;
		/// <summary>
		/// Rated current.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CurrentFlow ratedCurrent;
		/// <summary>
		/// Frequency for which switch is rated.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Frequency ratedFrequency;
		/// <summary>
		/// Rated impulse withstand voltage, also known as BIL (Basic Impulse Level).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage ratedImpulseWithstandVoltage;
		/// <summary>
		/// Switch rated interrupting time in seconds.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ratedInterruptingTime;
		/// <summary>
		/// Rated voltage.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage ratedVoltage;

		public SwitchInfo(){

		}

		~SwitchInfo(){

		}

		public override void Dispose(){

		}

	}//end SwitchInfo

}//end namespace AssetInfo