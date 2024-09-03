﻿///////////////////////////////////////////////////////////
//  DisconnectingCircuitBreaker.cs
//  Implementation of the Class DisconnectingCircuitBreaker
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:48 AM
//  Original author: C56850
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Wires;
namespace TC57CIM.IEC61970.Base.Wires {
	/// <summary>
	/// A circuit breaking device including disconnecting function, eliminating the
	/// need for separate disconnectors.
	/// </summary>
	public class DisconnectingCircuitBreaker : Breaker {

		public DisconnectingCircuitBreaker(){

		}

		~DisconnectingCircuitBreaker(){

		}

		public override void Dispose(){

		}

	}//end DisconnectingCircuitBreaker

}//end namespace Wires