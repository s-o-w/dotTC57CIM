///////////////////////////////////////////////////////////
//  AssetGroupKind.cs
//  Implementation of the Class AssetGroupKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:57 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Possible kinds of asset groups.
	/// </summary>
	public enum AssetGroupKind : int {

		/// <summary>
		/// Group is used for analysis purposes.
		/// </summary>
		analysisGroup,
		/// <summary>
		/// Group is used for inventory purposes.
		/// </summary>
		inventoryGroup,
		/// <summary>
		/// Group is used for compliance purposes.
		/// </summary>
		complianceGroup,
		/// <summary>
		/// Group is used for functional purposes, for example assets which are grouped
		/// together because they are part of a for a particular function - such as a group
		/// of feeders.
		/// </summary>
		functionalGroup,
		other

	}//end AssetGroupKind

}//end namespace Assets