///////////////////////////////////////////////////////////
//  PerLengthSequenceImpedance.cs
//  Implementation of the Class PerLengthSequenceImpedance
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:12 AM
//  Original author: Tom
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Wires;
namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// Sequence impedance and admittance parameters per unit length, for transposed
	/// lines of 1, 2, or 3 phases. For 1-phase lines, define x=x0=xself. For 2-phase
	/// lines, define x=xs-xm and x0=xs+xm.
	/// </summary>
	public class PerLengthSequenceImpedance : PerLengthImpedance {

		/// <summary>
		/// Zero sequence shunt (charging) susceptance, per unit of length.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.SusceptancePerLength b0ch;
		/// <summary>
		/// Positive sequence shunt (charging) susceptance, per unit of length.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.SusceptancePerLength bch;
		/// <summary>
		/// Zero sequence shunt (charging) conductance, per unit of length.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ConductancePerLength g0ch;
		/// <summary>
		/// Positive sequence shunt (charging) conductance, per unit of length.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ConductancePerLength gch;
		/// <summary>
		/// Positive sequence series resistance, per unit of length.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ResistancePerLength r;
		/// <summary>
		/// Zero sequence series resistance, per unit of length.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ResistancePerLength r0;
		/// <summary>
		/// Positive sequence series reactance, per unit of length.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ReactancePerLength x;
		/// <summary>
		/// Zero sequence series reactance, per unit of length.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ReactancePerLength x0;

		public PerLengthSequenceImpedance(){

		}

		~PerLengthSequenceImpedance(){

		}

		public override void Dispose(){

		}

	}//end PerLengthSequenceImpedance

}//end namespace Wires