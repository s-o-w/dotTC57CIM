﻿///////////////////////////////////////////////////////////
//  TopologicalIsland.cs
//  Implementation of the Class TopologicalIsland
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:26 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Topology;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.Topology {
	/// <summary>
	/// An electrically connected subset of the network. Topological islands can change
	/// as the current network state changes, e.g. due to:
	/// - disconnect switches or breakers changing state in a SCADA/EMS.
	/// - manual creation, change or deletion of topological nodes in a planning tool.
	/// Only energised TopologicalNode-s shall be part of the topological island.
	/// </summary>
	public class TopologicalIsland : IdentifiedObject {

		/// <summary>
		/// A topological node belongs to a topological island.
		/// </summary>
		public TC57CIM.IEC61970.Base.Topology.TopologicalNode TopologicalNodes;
		/// <summary>
		/// The angle reference for the island.   Normally there is one TopologicalNode
		/// that is selected as the angle reference for each island.   Other reference
		/// schemes exist, so the association is typically optional.
		/// </summary>
		public TC57CIM.IEC61970.Base.Topology.TopologicalNode AngleRefTopologicalNode;

		public TopologicalIsland(){

		}

		~TopologicalIsland(){

		}

		public override void Dispose(){

		}

	}//end TopologicalIsland

}//end namespace Topology