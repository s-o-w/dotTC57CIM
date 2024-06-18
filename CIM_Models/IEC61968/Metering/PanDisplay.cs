///////////////////////////////////////////////////////////
//  PanDisplay.cs
//  Implementation of the Class PanDisplay
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:19 AM
//  Original author: T. Kostic
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.Metering;
namespace TC57CIM.IEC61968.Metering {
	/// <summary>
	/// PAN action/command used to issue the displaying of text messages on PAN devices.
	/// 
	/// </summary>
	public class PanDisplay : EndDeviceAction {

		/// <summary>
		/// If true, the requesting entity (e.g. retail electric provider) requires
		/// confirmation of the successful display of the text message.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean confirmationRequired;
		/// <summary>
		/// Priority associated with the text message to be displayed.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String priority;
		/// <summary>
		/// Text to be displayed by a PAN device.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String textMessage;
		/// <summary>
		/// Transmission mode to be used for this PAN display control.
		/// </summary>
		public TransmissionModeKind transmissionMode;

		public PanDisplay(){

		}

		~PanDisplay(){

		}

		public override void Dispose(){

		}

	}//end PanDisplay

}//end namespace Metering