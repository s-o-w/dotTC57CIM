﻿///////////////////////////////////////////////////////////
//  CUContractorItem.cs
//  Implementation of the Class CUContractorItem
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:03 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Common;
using TC57CIM.IEC61968.InfIEC61968.InfWork;
namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// Compatible unit contractor item.
	/// </summary>
	public class CUContractorItem : WorkIdentifiedObject {

		/// <summary>
		/// Activity code identifies a specific and distinguishable unit of work.
		/// </summary>
		public string activityCode;
		/// <summary>
		/// The amount that a given contractor will charge for performing this unit of work.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money bidAmount;
		public TC57CIM.IEC61968.Common.Status status;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.CompatibleUnit CompatibleUnits;

		public CUContractorItem(){

		}

		~CUContractorItem(){

		}

		public override void Dispose(){

		}

	}//end CUContractorItem

}//end namespace InfWork