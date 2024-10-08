﻿///////////////////////////////////////////////////////////
//  OperatingShare.cs
//  Implementation of the Class OperatingShare
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:10 AM
//  Original author: kdd
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// Specifies the operations contract relationship between a power system resource
	/// and a contract participant.
	/// </summary>
	public class OperatingShare {

		/// <summary>
		/// Percentage operational ownership between the pair (power system resource and
		/// operating participant) associated with this share. The total percentage
		/// ownership for a power system resource should add to 100%.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PerCent percentage;
		/// <summary>
		/// The operating participant having this share with the associated power system
		/// resource.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.OperatingParticipant OperatingParticipant;
		/// <summary>
		/// The power system resource to which the share applies.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.PowerSystemResource PowerSystemResource;

		public OperatingShare(){

		}

		~OperatingShare(){

		}

		public virtual void Dispose(){

		}

	}//end OperatingShare

}//end namespace Core