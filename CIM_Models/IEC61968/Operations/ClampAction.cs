///////////////////////////////////////////////////////////
//  ClampAction.cs
//  Implementation of the Class ClampAction
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:01 AM
//  Original author: marga
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.Operations;
namespace TC57CIM.IEC61968.Operations {
	/// <summary>
	/// Action on Clamp as a switching step
	/// </summary>
	public class ClampAction : SwitchingAction {

		/// <summary>
		/// Switching action to perform
		/// </summary>
		public TempEquipActionKind kind;

		public ClampAction(){

		}

		~ClampAction(){

		}

		public override void Dispose(){

		}

	}//end ClampAction

}//end namespace Operations