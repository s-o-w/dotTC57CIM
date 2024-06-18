///////////////////////////////////////////////////////////
//  VSCUserDefined.cs
//  Implementation of the Class VSCUserDefined
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:29 AM
//  Original author: civanov
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.UserDefinedModels;
using TC57CIM.IEC61970.Dynamics.StandardModels.HVDCDynamics;
namespace TC57CIM.IEC61970.Dynamics.UserDefinedModels {
	/// <summary>
	/// Voltage source converter (VSC) function block whose dynamic behaviour is
	/// described by <font color="#0f0f0f">a user-defined model.</font>
	/// </summary>
	public class VSCUserDefined : VSCDynamics {

		/// <summary>
		/// Behaviour is based on a proprietary model as opposed to a detailed model.
		/// true = user-defined model is proprietary with behaviour mutually understood by
		/// sending and receiving applications and parameters passed as general attributes
		/// false = user-defined model is explicitly defined in terms of control blocks and
		/// their input and output signals.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean proprietary;
		/// <summary>
		/// Parameter of this proprietary user-defined model.
		/// </summary>
		public TC57CIM.IEC61970.Dynamics.UserDefinedModels.ProprietaryParameterDynamics ProprietaryParameterDynamics;

		public VSCUserDefined(){

		}

		~VSCUserDefined(){

		}

		public override void Dispose(){

		}

	}//end VSCUserDefined

}//end namespace UserDefinedModels