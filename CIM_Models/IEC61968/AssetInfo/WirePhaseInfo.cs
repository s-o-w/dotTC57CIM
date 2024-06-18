///////////////////////////////////////////////////////////
//  WirePhaseInfo.cs
//  Implementation of the Class WirePhaseInfo
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:32 AM
//  Original author: marga
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Wires;
using TC57CIM.IEC61968.AssetInfo;
namespace TC57CIM.IEC61968.AssetInfo {
	/// <summary>
	/// Information on a wire carrying a single phase.
	/// </summary>
	public class WirePhaseInfo {

		/// <summary>
		/// Phase information.
		/// </summary>
		public TC57CIM.IEC61970.Base.Wires.SinglePhaseKind phaseInfo;
		/// <summary>
		/// Wire assembly information using this wire phase information.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.WireAssemblyInfo WireAssemblyInfo;

		public WirePhaseInfo(){

		}

		~WirePhaseInfo(){

		}

		public virtual void Dispose(){

		}

	}//end WirePhaseInfo

}//end namespace AssetInfo