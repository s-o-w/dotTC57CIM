///////////////////////////////////////////////////////////
//  MechLoad1.cs
//  Implementation of the Class MechLoad1
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:07 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.MechanicalLoadDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.MechanicalLoadDynamics {
	/// <summary>
	/// Mechanical load model type 1.
	/// </summary>
	public class MechLoad1 : MechanicalLoadDynamics {

		/// <summary>
		/// Speed squared coefficient (<i>a</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float a;
		/// <summary>
		/// Speed coefficient (<i>b</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float b;
		/// <summary>
		/// Speed to the exponent coefficient (<i>d</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float d;
		/// <summary>
		/// Exponent (<i>e</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float e;

		public MechLoad1(){

		}

		~MechLoad1(){

		}

		public override void Dispose(){

		}

	}//end MechLoad1

}//end namespace MechanicalLoadDynamics