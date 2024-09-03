﻿///////////////////////////////////////////////////////////
//  ErpJournal.cs
//  Implementation of the Class ErpJournal
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:09 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.InfIEC61968.InfERPSupport;
namespace TC57CIM.IEC61968.InfIEC61968.InfERPSupport {
	/// <summary>
	/// Book for recording accounting transactions as they occur. Transactions and
	/// adjustments are first recorded in a journal, which is like a diary of
	/// instructions, advising which account to be charged and by how much.
	/// A journal represents a change in the balances of a business's financial
	/// accounts. Many tasks or transactions throughout an enterprise will result in
	/// the creation of a journal. Some examples are creating a customer invoice,
	/// paying a vendor, transferring inventory, or paying employees.
	/// </summary>
	public class ErpJournal : ErpDocument {

		public TC57CIM.IEC61968.InfIEC61968.InfERPSupport.ErpJournalEntry ErpJournalEntries;

		public ErpJournal(){

		}

		~ErpJournal(){

		}

		public override void Dispose(){

		}

	}//end ErpJournal

}//end namespace InfERPSupport