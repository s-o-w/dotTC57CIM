﻿///////////////////////////////////////////////////////////
//  TransformerEndInfo.cs
//  Implementation of the Class TransformerEndInfo
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:29 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Wires;
using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.AssetInfo.Assets;
namespace TC57CIM.IEC61968.AssetInfo {
	/// <summary>
	/// Transformer end data.
	/// </summary>
	public class TransformerEndInfo : Assets.AssetInfo {

		/// <summary>
		/// Kind of connection.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.WindingConnection connectionKind;
		/// <summary>
		/// Apparent power that the winding can carry under emergency conditions (also
		/// called long-term emergency power).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ApparentPower emergencyS;
		/// <summary>
		/// Number for this transformer end, corresponding to the end's order in the
		/// PowerTransformer.vectorGroup attribute. Highest voltage winding should be 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer endNumber;
		/// <summary>
		/// Basic insulation level voltage rating.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage insulationU;
		/// <summary>
		/// Winding phase angle where 360 degrees are represented with clock hours, so the
		/// valid values are {0, ..., 11}. For example, to express the second winding in
		/// code 'Dyn11', set attributes as follows: 'endNumber'=2, 'connectionKind' = Yn
		/// and 'phaseAngleClock' = 11.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer phaseAngleClock;
		/// <summary>
		/// DC resistance.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance r;
		/// <summary>
		/// Normal apparent power rating.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ApparentPower ratedS;
		/// <summary>
		/// Rated voltage: phase-phase for three-phase windings, and either phase-phase or
		/// phase-neutral for single-phase windings.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage ratedU;
		/// <summary>
		/// Apparent power that this winding can carry for a short period of time (in
		/// emergency).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ApparentPower shortTermS;
		/// <summary>
		/// All mesh impedances between this 'from' and other 'to' transformer ends.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.TransformerMeshImpedance ToMeshImpedances;
		/// <summary>
		/// Transformer star impedance calculated from this transformer end datasheet.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.TransformerStarImpedance TransformerStarImpedance;
		/// <summary>
		/// All mesh impedances between this 'to' and other 'from' transformer ends.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.TransformerMeshImpedance FromMeshImpedances;
		/// <summary>
		/// Core admittance calculated from this transformer end datasheet, representing
		/// magnetising current and core losses. The full values of the transformer should
		/// be supplied for one transformer end info only.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.TransformerCoreAdmittance CoreAdmittance;

		public TransformerEndInfo(){

		}

		~TransformerEndInfo(){

		}

		public override void Dispose(){

		}

	}//end TransformerEndInfo

}//end namespace AssetInfo