///////////////////////////////////////////////////////////
//  DeploymentDate.cs
//  Implementation of the Class DeploymentDate
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:04 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Dates for deployment events of an asset.  May have multiple deployment type
	/// dates for this device and a compound type allows a query to return multiple
	/// dates.
	/// </summary>
	public class DeploymentDate {

		/// <summary>
		/// Date and time asset most recently put in service.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime inServiceDate;
		/// <summary>
		/// Date and time asset most recently installed.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime installedDate;
		/// <summary>
		/// Date and time of asset deployment transition to not yet installed.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime notYetInstalledDate;
		/// <summary>
		/// Date and time asset most recently taken out of service.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime outOfServiceDate;
		/// <summary>
		/// Date and time asset most recently removed.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime removedDate;

		public DeploymentDate(){

		}

		~DeploymentDate(){

		}

		public virtual void Dispose(){

		}

	}//end DeploymentDate

}//end namespace Assets