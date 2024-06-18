///////////////////////////////////////////////////////////
//  Tender.cs
//  Implementation of the Class Tender
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:27 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.PaymentMetering;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61968.PaymentMetering {
	/// <summary>
	/// Tender is what is "offered" by the customer towards making a payment and is
	/// often more than the required payment (hence the need for 'change'). The payment
	/// is thus that part of the Tender that goes towards settlement of a particular
	/// transaction.
	/// Tender is modelled as an aggregation of Cheque and Card. Both these tender
	/// types can exist in a single tender bid thus 'accountHolderName' has to exist
	/// separately in each of Cheque and Card as each could have a different account
	/// holder name.
	/// </summary>
	public class Tender : IdentifiedObject {

		/// <summary>
		/// Amount tendered by customer.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money amount;
		/// <summary>
		/// Difference between amount tendered by customer and the amount charged by point
		/// of sale.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money change;
		/// <summary>
		/// Kind of tender from customer.
		/// </summary>
		public TenderKind kind;
		/// <summary>
		/// Receipt that recorded this receiving of a payment in the form of tenders.
		/// </summary>
		public TC57CIM.IEC61968.PaymentMetering.Receipt Receipt;

		public Tender(){

		}

		~Tender(){

		}

		public override void Dispose(){

		}

	}//end Tender

}//end namespace PaymentMetering