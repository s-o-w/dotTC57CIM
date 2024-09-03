﻿///////////////////////////////////////////////////////////
//  TroubleSymptoms.cs
//  Implementation of the Class TroubleSymptoms
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:29 AM
//  Original author: marga
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.Customers;
using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61968.Customers {
	/// <summary>
	/// Trouble symptoms reported by person reporting the trouble.  The symptoms
	/// provide clues to utility personnel analyzing the ticket to help identify the
	/// root cause of the problem.
	/// </summary>
	public class TroubleSymptoms {

		/// <summary>
		/// The extent of the problem being reported.
		/// </summary>
		public TroubleSymptomsExtentKind troubleSymptomsExtent;
		/// <summary>
		/// The extent of the problem being reported that does not fit any of the
		/// enumeration values.
		/// </summary>
		public string troubleSymptomsExtentOther;
		/// <summary>
		/// The problem with lights being reported.
		/// </summary>
		public TroubleSymptomsLightKind troubleSymptomsLight;
		/// <summary>
		/// The problem with lights being reported that does not fit any of the enumeration
		/// values
		/// </summary>
		public string troubleSymptomsLightOther;
		/// <summary>
		/// The problem with pole being reported.
		/// </summary>
		public TroubleSymptomsPoleKind troubleSymptomsPole;
		/// <summary>
		/// The problem with pole being reported that does not fit any of the enumeration
		/// values
		/// </summary>
		public string troubleSymptomsPoleOther;
		/// <summary>
		/// The problem with transformer being reported.
		/// </summary>
		public TroubleSymptomsTransformerKind troubleSymptomsTransformer;
		/// <summary>
		/// The problem with transformer being reported that does not fit any of the
		/// enumeration values
		/// </summary>
		public string troubleSymptomsTransformerOther;
		/// <summary>
		/// The problem with tree being reported that does not fit any of the enumeration
		/// values
		/// </summary>
		public string troubleSymptomsTreeOther;
		/// <summary>
		/// The problem with wire being reported.
		/// </summary>
		public TroubleSymptomsWireKind troubleSymptomsWire;
		/// <summary>
		/// The problem with wire being reported that does not fit any of the enumeration
		/// values
		/// </summary>
		public string troubleSymptomsWireOther;
		public TC57CIM.IEC61968.Customers.TroubleTicket TroubleTicket;

		public TroubleSymptoms(){

		}

		~TroubleSymptoms(){

		}

		public virtual void Dispose(){

		}

	}//end TroubleSymptoms

}//end namespace Customers