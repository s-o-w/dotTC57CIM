///////////////////////////////////////////////////////////
//  BranchGroup.cs
//  Implementation of the Class BranchGroup
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:41 AM
//  Original author: kdd
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.OperationalLimits;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.OperationalLimits {
	/// <summary>
	/// A group of branch terminals whose directed flow summation is to be monitored. A
	/// branch group need not form a cutset of the network.
	/// </summary>
	public class BranchGroup : IdentifiedObject {

		/// <summary>
		/// The maximum active power flow.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower maximumActivePower;
		/// <summary>
		/// The maximum reactive power flow.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ReactivePower maximumReactivePower;
		/// <summary>
		/// The minimum active power flow.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ActivePower minimumActivePower;
		/// <summary>
		/// The minimum reactive power flow.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ReactivePower minimumReactivePower;
		/// <summary>
		/// Monitor the active power flow.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean monitorActivePower;
		/// <summary>
		/// Monitor the reactive power flow.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean monitorReactivePower;
		/// <summary>
		/// The directed branch group terminals to be summed.
		/// </summary>
		public TC57CIM.IEC61970.Base.OperationalLimits.BranchGroupTerminal BranchGroupTerminal;

		public BranchGroup(){

		}

		~BranchGroup(){

		}

		public override void Dispose(){

		}

	}//end BranchGroup

}//end namespace OperationalLimits