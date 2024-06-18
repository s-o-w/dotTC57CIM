///////////////////////////////////////////////////////////
//  PowerSystemProjectLifecycleToBeDeleted.cs
//  Implementation of the Class PowerSystemProjectLifecycleToBeDeleted
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:14 AM
//  Original author: sveinols
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelProjects {
	/// <summary>
	/// Represent the base lifecycle of a functional model change that could be a
	/// construction of new elements.
	/// </summary>
	public class PowerSystemProjectLifecycleToBeDeleted {

		/// <summary>
		/// The date the Power System Project is in cancelled stage.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Date cancelled;
		/// <summary>
		/// The date Power System Project is in committed stage.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Date committed;
		/// <summary>
		/// The date Power System Project is in build stage.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Date inBuild;
		/// <summary>
		/// The date Power System Project is in planning stage.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Date inPlan;

		public PowerSystemProjectLifecycleToBeDeleted(){

		}

		~PowerSystemProjectLifecycleToBeDeleted(){

		}

		public virtual void Dispose(){

		}

	}//end PowerSystemProjectLifecycleToBeDeleted

}//end namespace NetworkModelProjects