﻿///////////////////////////////////////////////////////////
//  BusbarConfiguration.cs
//  Implementation of the Class BusbarConfiguration
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:41 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// Busbar layout for bay.
	/// </summary>
	public enum BusbarConfiguration : int {

		/// <summary>
		/// Single bus.
		/// </summary>
		singleBus,
		/// <summary>
		/// Double bus.
		/// </summary>
		doubleBus,
		/// <summary>
		/// Main bus with transfer bus.
		/// </summary>
		mainWithTransfer,
		/// <summary>
		/// Ring bus.
		/// </summary>
		ringBus

	}//end BusbarConfiguration

}//end namespace Core