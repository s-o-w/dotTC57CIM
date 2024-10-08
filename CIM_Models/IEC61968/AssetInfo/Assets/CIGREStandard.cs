﻿///////////////////////////////////////////////////////////
//  CIGREStandard.cs
//  Implementation of the Class CIGREStandard
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:01 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.AssetInfo.Assets;
namespace TC57CIM.IEC61968.AssetInfo.Assets {
	/// <summary>
	/// Standard published by CIGRE (Council on Large Electric Systems).
	/// </summary>
	public class CIGREStandard {

		/// <summary>
		/// Edition of CIGRE standard.
		/// </summary>
		public CIGREStandardEditionKind standardEdition;
		/// <summary>
		/// CIGRE standard number.
		/// </summary>
		public CIGREStandardKind standardNumber;

		public CIGREStandard(){

		}

		~CIGREStandard(){

		}

		public virtual void Dispose(){

		}

	}//end CIGREStandard

}//end namespace Assets