///////////////////////////////////////////////////////////
//  TAPPIStandard.cs
//  Implementation of the Class TAPPIStandard
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:27 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.AssetInfo.Assets;
namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Standard published by TAPPI.
	/// </summary>
	public class TAPPIStandard {

		/// <summary>
		/// Edition of TAPPI standard.
		/// </summary>
		//public TAPPIStandardEditionKind standardEdition;
		/// <summary>
		/// TAPPI standard number.
		/// </summary>
		public TAPPIStandardKind standardNumber;

		public TAPPIStandard(){

		}

		~TAPPIStandard(){

		}

		public virtual void Dispose(){

		}

	}//end TAPPIStandard

}//end namespace Assets