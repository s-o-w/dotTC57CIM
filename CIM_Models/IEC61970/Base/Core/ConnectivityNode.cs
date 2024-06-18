///////////////////////////////////////////////////////////
//  ConnectivityNode.cs
//  Implementation of the Class ConnectivityNode
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:43 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// Connectivity nodes are points where terminals of AC conducting equipment are
	/// connected together with zero impedance.
	/// </summary>
	public class ConnectivityNode : IdentifiedObject {

		/// <summary>
		/// Container of this connectivity node.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.ConnectivityNodeContainer ConnectivityNodeContainer;

		public ConnectivityNode(){

		}

		~ConnectivityNode(){

		}

		public override void Dispose(){

		}

	}//end ConnectivityNode

}//end namespace Core