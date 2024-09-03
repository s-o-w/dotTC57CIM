﻿///////////////////////////////////////////////////////////
//  Design.cs
//  Implementation of the Class Design
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:05 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.InfIEC61968.InfWork;
using TC57CIM.IEC61968.InfIEC61968.InfERPSupport;
using TC57CIM.IEC61968.Work;
namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// A design for consideration by customers, potential customers, or internal work.
	/// 
	/// Note that the Version of design is the revision attribute that is inherited
	/// from Document.
	/// </summary>
	public class Design : WorkDocument {

		/// <summary>
		/// Estimated cost (not price) of design.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money costEstimate;
		/// <summary>
		/// Kind of this design.
		/// </summary>
		public DesignKind kind;
		/// <summary>
		/// Price to customer for implementing design.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money price;
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpBOM ErpBOMs;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.WorkCostDetail WorkCostDetails;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.OldWorkTask WorkTasks;
		public TC57CIM.IEC61968.Work.Work Work;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.ConditionFactor ConditionFactors;

		public Design(){

		}

		~Design(){

		}

		public override void Dispose(){

		}

	}//end Design

}//end namespace InfWork