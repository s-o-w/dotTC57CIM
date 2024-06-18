///////////////////////////////////////////////////////////
//  Appointment.cs
//  Implementation of the Class Appointment
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:56 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61968.Work;
namespace TC57CIM.IEC61968.Common {
	/// <summary>
	/// Meeting time and location.
	/// </summary>
	public class Appointment : IdentifiedObject {

		/// <summary>
		/// True if requested to call customer when someone is about to arrive at their
		/// premises.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean callAhead;
		/// <summary>
		/// Date and time reserved for appointment.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTimeInterval meetingInterval;
		/// <summary>
		/// All works for this appointment.
		/// </summary>
		public TC57CIM.IEC61968.Work.Work Works;

		public Appointment(){

		}

		~Appointment(){

		}

		public override void Dispose(){

		}

	}//end Appointment

}//end namespace Common