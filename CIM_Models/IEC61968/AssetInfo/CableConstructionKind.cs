﻿///////////////////////////////////////////////////////////
//  CableConstructionKind.cs
//  Implementation of the Class CableConstructionKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:59 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61968.AssetInfo {
	/// <summary>
	/// Kind of cable construction.
	/// </summary>
	public enum CableConstructionKind : int {

		/// <summary>
		/// Compacted cable.
		/// </summary>
		compacted,
		/// <summary>
		/// Compressed cable.
		/// </summary>
		compressed,
		/// <summary>
		/// Sector cable.
		/// </summary>
		sector,
		/// <summary>
		/// Segmental cable.
		/// </summary>
		segmental,
		/// <summary>
		/// Solid cable.
		/// </summary>
		solid,
		/// <summary>
		/// Stranded cable.
		/// </summary>
		stranded,
		/// <summary>
		/// Other kind of cable construction.
		/// </summary>
		other

	}//end CableConstructionKind

}//end namespace AssetInfo