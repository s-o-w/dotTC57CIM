﻿///////////////////////////////////////////////////////////
//  EstimatedRestorationTime.cs
//  Implementation of the Class EstimatedRestorationTime
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:10 AM
//  Original author: marga
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.Operations;
using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// The Estimated Restoration Time (ERT) for a single outage
	/// </summary>
	public class EstimatedRestorationTime {

		/// <summary>
		/// provides the confidence level that this ERT can be accomplished.  This may be
		/// changed/updated as needed.
		/// </summary>
		public ERTConfidenceKind confidenceKind;
		/// <summary>
		/// estimated time the outage will be restored
		/// </summary>
		public System.DateTime ert;
		/// <summary>
		/// defines the source that provided the ERT value.
		/// </summary>
		public string ertSource;
		/// <summary>
		/// The outage associated with the estimated time the power will be restored.
		/// </summary>
		public TC57CIM.IEC61968.Operations.Outage Outage;

		public EstimatedRestorationTime(){

		}

		~EstimatedRestorationTime(){

		}

		public virtual void Dispose(){

		}

	}//end EstimatedRestorationTime

}//end namespace Operations