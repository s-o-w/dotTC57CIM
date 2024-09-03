﻿///////////////////////////////////////////////////////////
//  TransformerTankEnd.cs
//  Implementation of the Class TransformerTankEnd
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:26 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61970.Base.Wires;
namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// Transformer tank end represents an individual winding for unbalanced models or
	/// for transformer tanks connected into a bank (and bank is modelled with the
	/// PowerTransformer).
	/// </summary>
	public class TransformerTankEnd : TransformerEnd {

		/// <summary>
		/// Describes the phases carried by a conducting equipment.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.PhaseCode phases;
		/// <summary>
		/// Transformer this winding belongs to.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.TransformerTank TransformerTank;

		public TransformerTankEnd(){

		}

		~TransformerTankEnd(){

		}

		public override void Dispose(){

		}

	}//end TransformerTankEnd

}//end namespace Wires