///////////////////////////////////////////////////////////
//  MeasurementValue.cs
//  Implementation of the Class MeasurementValue
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:07 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.SCADA;
using TC57CIM.IEC61970.Base.Meas;
namespace TC57CIM.IEC61970.Base.Meas {
	/// <summary>
	/// The current state for a measurement. A state value is an instance of a
	/// measurement from a specific source. Measurements can be associated with many
	/// state values, each representing a different source for the measurement.
	/// </summary>
	public class MeasurementValue : IOPoint {

		/// <summary>
		/// The limit, expressed as a percentage of the sensor maximum, that errors will
		/// not exceed when the sensor is used under  reference conditions.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PerCent sensorAccuracy;
		/// <summary>
		/// The time when the value was last updated.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime timeStamp;
		/// <summary>
		/// Link to the physical telemetered point associated with this measurement.
		/// </summary>
		public TC57CIM.IEC61970.Base.SCADA.RemoteSource RemoteSource;
		/// <summary>
		/// A MeasurementValue has a MeasurementValueQuality associated with it.
		/// </summary>
		public TC57CIM.IEC61970.Base.Meas.MeasurementValueQuality MeasurementValueQuality;

		public MeasurementValue(){

		}

		~MeasurementValue(){

		}

		public override void Dispose(){

		}

	}//end MeasurementValue

}//end namespace Meas