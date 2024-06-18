///////////////////////////////////////////////////////////
//  RemoteInputSignal.cs
//  Implementation of the Class RemoteInputSignal
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:19 AM
//  Original author: ppbr003
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Dynamics.StandardInterconnections;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Dynamics.StandardInterconnections {
	/// <summary>
	/// Supports connection to a terminal associated with a remote bus from which an
	/// input signal of a specific type is coming.
	/// </summary>
	public class RemoteInputSignal : IdentifiedObject {

		/// <summary>
		/// Type of input signal.
		/// </summary>
		public RemoteSignalKind remoteSignalType;
		/// <summary>
		/// Remote terminal with which this input signal is associated.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.Terminal Terminal;

		public RemoteInputSignal(){

		}

		~RemoteInputSignal(){

		}

		public override void Dispose(){

		}

	}//end RemoteInputSignal

}//end namespace StandardInterconnections