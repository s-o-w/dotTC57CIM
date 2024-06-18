///////////////////////////////////////////////////////////
//  CashierShift.cs
//  Implementation of the Class CashierShift
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:00 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.PaymentMetering;
namespace TC57CIM.IEC61968.PaymentMetering {
	/// <summary>
	/// The operating shift for a cashier, during which the cashier may transact
	/// against the cashier shift, subject to vendor shift being open.
	/// </summary>
	public class CashierShift : Shift {

		/// <summary>
		/// The amount of cash that the cashier brings to start the shift and that will be
		/// taken away at the end of the shift; i.e. the cash float does not get banked.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money cashFloat;
		/// <summary>
		/// All transactions recorded during this cashier shift.
		/// </summary>
		public TC57CIM.IEC61968.PaymentMetering.Transaction Transactions;
		/// <summary>
		/// All Receipts recorded for this Shift.
		/// </summary>
		public TC57CIM.IEC61968.PaymentMetering.Receipt Receipts;
		/// <summary>
		/// Point of sale that is in operation during this shift.
		/// </summary>
		public TC57CIM.IEC61968.PaymentMetering.PointOfSale PointOfSale;

		public CashierShift(){

		}

		~CashierShift(){

		}

		public override void Dispose(){

		}

	}//end CashierShift

}//end namespace PaymentMetering