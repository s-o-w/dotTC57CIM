﻿///////////////////////////////////////////////////////////
//  OldTransformerTankInfo.cs
//  Implementation of the Class OldTransformerTankInfo
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:17 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.InfIEC61968.InfAssetInfo;
using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.AssetInfo;
namespace TC57CIM.IEC61968.InfIEC61968.InfAssetInfo {
	public class OldTransformerTankInfo : TransformerTankInfo {

		/// <summary>
		/// Kind of construction for this transformer.
		/// </summary>
		public TransformerConstructionKind constructionKind;
		/// <summary>
		/// Weight of core and coils in transformer.
		/// </summary>
		public Mass coreCoilsWeight;
		/// <summary>
		/// Core kind of this transformer product.
		/// </summary>
		public TransformerCoreKind coreKind;
		/// <summary>
		/// Function of this transformer.
		/// </summary>
		public TransformerFunctionKind function;
		/// <summary>
		/// Basic insulation level of neutral.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage neutralBIL;
		/// <summary>
		/// Kind of oil preservation system.
		/// </summary>
		public OilPreservationKind oilPreservationKind;

		public OldTransformerTankInfo(){

		}

		~OldTransformerTankInfo(){

		}

		public override void Dispose(){

		}

	}//end OldTransformerTankInfo

}//end namespace InfAssetInfo