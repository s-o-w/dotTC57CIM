﻿///////////////////////////////////////////////////////////
//  Structure.cs
//  Implementation of the Class Structure
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:25 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.InfIEC61968.InfAssets;
using TC57CIM.IEC61968.AssetInfo.Assets;
namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Construction holding assets such as conductors, transformers, switchgear, etc.
	/// Where applicable, number of conductors can be derived from the number of
	/// associated wire spacing instances.
	/// </summary>
	public class Structure : AssetContainer {

		/// <summary>
		/// Date fumigant was last applied.
		/// </summary>
		public System.DateOnly fumigantAppliedDate;
		/// <summary>
		/// Name of fumigant.
		/// </summary>
		public System.String fumigantName;
		/// <summary>
		/// Visible height of structure above ground level for overhead construction (e.g.,
		/// Pole or Tower) or below ground level for an underground vault, manhole, etc.
		/// Refer to associated DimensionPropertiesInfo for other types of dimensions.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Length height;
		/// <summary>
		/// Material this structure is made of.
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfAssets.StructureMaterialKind materialKind;
		/// <summary>
		/// Maximum rated voltage of the equipment that can be mounted on/contained within
		/// the structure.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Voltage ratedVoltage;
		/// <summary>
		/// True if weeds are to be removed around asset.
		/// </summary>
		public System.Boolean removeWeed;
		/// <summary>
		/// Date weed were last removed.
		/// </summary>
		public System.DateOnly weedRemovedDate;
		/// <summary>
		/// Structure support for this structure.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.Assets.StructureSupport StructureSupports;

		public Structure(){

		}

		~Structure(){

		}

		public override void Dispose(){

		}

	}//end Structure

}//end namespace Assets