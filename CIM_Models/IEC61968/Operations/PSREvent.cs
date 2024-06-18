///////////////////////////////////////////////////////////
//  PSREvent.cs
//  Implementation of the Class PSREvent
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:21 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.Operations;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61968.Common;
namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// Event recording the change in operational status of a power system resource
	/// (PSR); may be for an event that has already occurred or for a planned activity.
	/// 
	/// </summary>
	public class PSREvent : ActivityRecord {

		/// <summary>
		/// Kind of event.
		/// </summary>
		public PSREventKind kind;
		/// <summary>
		/// Power system resource that generated this event.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.PowerSystemResource PowerSystemResource;

		public PSREvent(){

		}

		~PSREvent(){

		}

		public override void Dispose(){

		}

	}//end PSREvent

}//end namespace Operations