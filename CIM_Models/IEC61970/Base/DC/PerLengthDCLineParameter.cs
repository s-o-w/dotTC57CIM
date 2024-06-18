///////////////////////////////////////////////////////////
//  PerLengthDCLineParameter.cs
//  Implementation of the Class PerLengthDCLineParameter
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:11 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.DC;
using TC57CIM.IEC61970.Base.Wires;
namespace TC57CIM.IEC61970.Base.DC {
	/// <summary>
	/// Common type for per-length electrical catalogues describing DC line parameters.
	/// 
	/// </summary>
	public class PerLengthDCLineParameter : PerLengthLineParameter {

		/// <summary>
		/// Capacitance per unit of length of the DC line segment; significant for cables
		/// only.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.CapacitancePerLength capacitance;
		/// <summary>
		/// Inductance per unit of length of the DC line segment.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.InductancePerLength inductance;
		/// <summary>
		/// Resistance per length of the DC line segment.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ResistancePerLength resistance;
		/// <summary>
		/// All line segments described by this set of per-length parameters.
		/// </summary>
		public TC57CIM.IEC61970.Base.DC.DCLineSegment DCLineSegments;

		public PerLengthDCLineParameter(){

		}

		~PerLengthDCLineParameter(){

		}

		public override void Dispose(){

		}

	}//end PerLengthDCLineParameter

}//end namespace DC