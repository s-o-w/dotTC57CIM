﻿///////////////////////////////////////////////////////////
//  ServiceCategory.cs
//  Implementation of the Class ServiceCategory
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:24 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.Customers;
using TC57CIM.IEC61968.Common;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.Customers {
	/// <summary>
	/// Category of service provided to the customer.
	/// </summary>
	public class ServiceCategory : IdentifiedObject {

		/// <summary>
		/// Kind of service.
		/// </summary>
		public ServiceKind kind;
		/// <summary>
		/// All configuration events created for this service category.
		/// </summary>
		public TC57CIM.IEC61968.Common.ConfigurationEvent ConfigurationEvents;
		/// <summary>
		/// All pricing structures applicable to this service category.
		/// </summary>
		public TC57CIM.IEC61968.Customers.PricingStructure PricingStructures;

		public ServiceCategory(){

		}

		~ServiceCategory(){

		}

		public override void Dispose(){

		}

	}//end ServiceCategory

}//end namespace Customers