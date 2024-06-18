///////////////////////////////////////////////////////////
//  Bushing.cs
//  Implementation of the Class Bushing
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:59 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61968.InfIEC61968.InfAssets;
using TC57CIM.IEC61968.AssetInfo.Assets;
namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Bushing asset.
	/// </summary>
	public class Bushing : Asset {

		/// <summary>
		/// Terminal to which this bushing is attached.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.Terminal Terminal;
		public TC57CIM.IEC61968.InfIEC61968.InfAssets.BushingInsulationPF BushingInsulationPFs;

		public Bushing(){

		}

		~Bushing(){

		}

		public override void Dispose(){

		}

	}//end Bushing

}//end namespace Assets