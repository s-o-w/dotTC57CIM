﻿///////////////////////////////////////////////////////////
//  TenderKind.cs
//  Implementation of the Class TenderKind
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:27 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace TC57CIM.IEC61968.PaymentMetering {
	/// <summary>
	/// Kind of tender.
	/// </summary>
	public enum TenderKind : int {

		/// <summary>
		/// Payment method by means of a cheque.
		/// </summary>
		cheque,
		/// <summary>
		/// Payment method by means of a credit or debit card.
		/// </summary>
		card,
		/// <summary>
		/// Payment method by means of cash.
		/// </summary>
		cash,
		/// <summary>
		/// Payment method is not known.
		/// </summary>
		unspecified,
		/// <summary>
		/// Other payment method such as electronic finds transfer.
		/// </summary>
		other

	}//end TenderKind

}//end namespace PaymentMetering