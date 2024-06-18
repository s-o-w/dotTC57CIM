///////////////////////////////////////////////////////////
//  DERCurveData.cs
//  Implementation of the Class DERCurveData
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:04 AM
//  Original author: marga
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.DER;
namespace TC57CIM.IEC61968.DER {
	/// <summary>
	/// The DER curve data class provides the nominal, maximum and minimum values for a
	/// DER Monitorable parameter for a series of time intervals defined by the DER
	/// DispatchSchedule.
	/// </summary>
	public class DERCurveData {

		/// <summary>
		/// The sequence number of a time interval defined by the DispatchSchedule.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer intervalNumber;
		/// <summary>
		/// The maximum value of the DERMonitorableParameter during the time interval.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float maxYValue;
		/// <summary>
		/// The minimum value of the DERMonitorableParameter during the time interval.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float minYValue;
		/// <summary>
		/// The nominal value of the DERMonitorableParameter during the time interval.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float nominalYValue;
		/// <summary>
		/// The start time of the interval
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime timeStamp;
		/// <summary>
		/// The DER monitorable parameter for which a time dependent curve has been created.
		/// 
		/// </summary>
		public TC57CIM.IEC61968.DER.DERMonitorableParameter DERMonitorableParameter;
		/// <summary>
		/// The schedule used for dispatching or forecasting the values of DER monitorable
		/// parameters over time.
		/// </summary>
		public TC57CIM.IEC61968.DER.DispatchSchedule DispatchSchedule;

		public DERCurveData(){

		}

		~DERCurveData(){

		}

		public virtual void Dispose(){

		}

	}//end DERCurveData

}//end namespace DER