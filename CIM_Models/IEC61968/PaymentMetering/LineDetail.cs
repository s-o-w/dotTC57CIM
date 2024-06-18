///////////////////////////////////////////////////////////
//  LineDetail.cs
//  Implementation of the Class LineDetail
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:14 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61968.PaymentMetering {
	/// <summary>
	/// Details on an amount line, with rounding, date and note.
	/// </summary>
	public class LineDetail {

		/// <summary>
		/// Amount for this line item.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money amount;
		/// <summary>
		/// Date and time when this line was created in the application process.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime dateTime;
		/// <summary>
		/// Free format note relevant to this line.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String note;
		/// <summary>
		/// Totalised monetary value of all errors due to process rounding or truncating
		/// that is not reflected in 'amount'.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Money rounding;

		public LineDetail(){

		}

		~LineDetail(){

		}

		public virtual void Dispose(){

		}

	}//end LineDetail

}//end namespace PaymentMetering