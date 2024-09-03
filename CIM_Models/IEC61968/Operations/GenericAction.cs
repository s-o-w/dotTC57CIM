﻿///////////////////////////////////////////////////////////
//  GenericAction.cs
//  Implementation of the Class GenericAction
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:11 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61968.Operations;
namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// An arbitrary switching step.
	/// </summary>
	public class GenericAction : SwitchingAction {

		/// <summary>
		/// The power system resource that the generic action is performed on
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.PowerSystemResource PowerSystemResource;

		public GenericAction(){

		}

		~GenericAction(){

		}

		public override void Dispose(){

		}

	}//end GenericAction

}//end namespace Operations