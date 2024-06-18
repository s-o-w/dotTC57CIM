///////////////////////////////////////////////////////////
//  TransformerStarImpedance.cs
//  Implementation of the Class TransformerStarImpedance
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:26 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// Transformer star impedance (Pi-model) that accurately reflects impedance for
	/// transformers with 2 or 3 windings. For transformers with 4 or more windings,
	/// TransformerMeshImpedance class shall be used.
	/// For transmission networks use PowerTransformerEnd impedances (r, r0, x, x0, b,
	/// b0, g and g0).
	/// </summary>
	public class TransformerStarImpedance : IdentifiedObject {

		/// <summary>
		/// Resistance of the transformer end.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance r;
		/// <summary>
		/// Zero sequence series resistance of the transformer end.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Resistance r0;
		/// <summary>
		/// Positive sequence series reactance of the transformer end.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance x;
		/// <summary>
		/// Zero sequence series reactance of the transformer end.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Reactance x0;

		public TransformerStarImpedance(){

		}

		~TransformerStarImpedance(){

		}

		public override void Dispose(){

		}

	}//end TransformerStarImpedance

}//end namespace Wires