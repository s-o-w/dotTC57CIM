///////////////////////////////////////////////////////////
//  PropertyUnit.cs
//  Implementation of the Class PropertyUnit
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:21 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.InfIEC61968.InfWork;
using TC57CIM.IEC61968.Common;
namespace TC57CIM.IEC61968.InfIEC61968.InfWork {
	/// <summary>
	/// Unit of property for reporting purposes.
	/// </summary>
	public class PropertyUnit : WorkIdentifiedObject {

		/// <summary>
		/// A code that identifies appropriate type of property accounts such as
		/// distribution, streetlgihts, communications.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String accountingUsage;
		/// <summary>
		/// Activity code identifies a specific and distinguishable work action.
		/// </summary>
		public WorkActionKind activityCode;
		/// <summary>
		/// Used for property record accounting. For example, in the USA, this would be a
		/// FERC account.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String propertyAccount;
		public TC57CIM.IEC61968.Common.Status status;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.CompatibleUnit CompatibleUnits;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.CUMaterialItem CUMaterialItems;

		public PropertyUnit(){

		}

		~PropertyUnit(){

		}

		public override void Dispose(){

		}

	}//end PropertyUnit

}//end namespace InfWork