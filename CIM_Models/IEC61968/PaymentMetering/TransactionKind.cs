///////////////////////////////////////////////////////////
//  TransactionKind.cs
//  Implementation of the Class TransactionKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:28 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61968.PaymentMetering {
	/// <summary>
	/// Kind of transaction.
	/// </summary>
	public enum TransactionKind : int {

		/// <summary>
		/// Payment for a service.
		/// </summary>
		serviceChargePayment,
		/// <summary>
		/// Payment for a tax.
		/// </summary>
		taxChargePayment,
		/// <summary>
		/// Payment against a specified auxiliary account.
		/// </summary>
		auxiliaryChargePayment,
		/// <summary>
		/// Payment against a specified account.
		/// </summary>
		accountPayment,
		/// <summary>
		/// Payment against an item other than an account.
		/// </summary>
		diversePayment,
		/// <summary>
		/// Reversal of a previous transaction.
		/// </summary>
		transactionReversal,
		/// <summary>
		/// Payment for a credit token sale to a customer.
		/// </summary>
		tokenSalePayment,
		/// <summary>
		/// Issue of a free credit token where the donor is the supplier.
		/// </summary>
		tokenFreeIssue,
		/// <summary>
		/// Issue of a free credit token where the donor is a 3rd party.
		/// </summary>
		tokenGrant,
		/// <summary>
		/// Exchange of a previously issued token for a new token.
		/// </summary>
		tokenExchange,
		/// <summary>
		/// Cancellation of a previously issued token.
		/// </summary>
		tokenCancellation,
		/// <summary>
		/// Issue of token that will alter the meter configuration.
		/// </summary>
		meterConfigurationToken,
		/// <summary>
		/// Other kind of transaction.
		/// </summary>
		other

	}//end TransactionKind

}//end namespace PaymentMetering