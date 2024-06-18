///////////////////////////////////////////////////////////
//  AccountMovement.cs
//  Implementation of the Class AccountMovement
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:32:55 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61968.PaymentMetering {
	/// <summary>
	/// Credit/debit movements for an account.
	/// </summary>
	public class AccountMovement {

		/// <summary>
		/// Amount that was credited to/debited from an account. For example: payment
		/// received/interest charge on arrears.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money amount;
		/// <summary>
		/// Date and time when the credit/debit transaction was performed.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime dateTime;
		/// <summary>
		/// Reason for credit/debit transaction on an account. Example: payment
		/// received/arrears interest levied.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String reason;

		public AccountMovement(){

		}

		~AccountMovement(){

		}

		public virtual void Dispose(){

		}

	}//end AccountMovement

}//end namespace PaymentMetering