///////////////////////////////////////////////////////////
//  CostType.cs
//  Implementation of the Class CostType
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:02 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Common;
using TC57CIM.IEC61968.InfIEC61968.InfWork;
using TC57CIM.IEC61968.InfIEC61968.InfERPSupport;
namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// A categorization for resources, often costs, in accounting transactions.
	/// Examples include: material components, building in service, coal sales,
	/// overhead, etc.
	/// </summary>
	public class CostType : WorkIdentifiedObject {

		/// <summary>
		/// True if an amount can be assigned to the resource element (e.g., building in
		/// service, transmission plant, software development capital); false otherwise (e.
		/// g., internal labor, material components).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean amountAssignable;
		/// <summary>
		/// A codified representation of the resource element.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String code;
		/// <summary>
		/// The level of the resource element in the hierarchy of resource elements
		/// (recursive relationship).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String level;
		/// <summary>
		/// The stage for which this costType applies: estimated design, estimated actual
		/// or actual actual.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String stage;
		public TC57CIM.IEC61968.Common.Status status;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.CompatibleUnit CompatibleUnits;
		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpJournalEntry ErpJournalEntries;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.WorkCostDetail WorkCostDetails;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.CostType ChildCostTypes;

		public CostType(){

		}

		~CostType(){

		}

		public override void Dispose(){

		}

	}//end CostType

}//end namespace InfWork