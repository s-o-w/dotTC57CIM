﻿///////////////////////////////////////////////////////////
//  DiagramStyle.cs
//  Implementation of the Class DiagramStyle
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:48 AM
//  Original author: SELAOST1
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61970.Base.DiagramLayout;
namespace TC57CIM.IEC61970.Base.DiagramLayout {
	/// <summary>
	/// The diagram style refers to a style used by the originating system for a
	/// diagram.  A diagram style describes information such as schematic, geographic,
	/// etc.
	/// </summary>
	public class DiagramStyle : IdentifiedObject {

		/// <summary>
		/// A DiagramStyle can be used by many Diagrams.
		/// </summary>
		public TC57CIM.IEC61970.Base.DiagramLayout.Diagram Diagram;

		public DiagramStyle(){

		}

		~DiagramStyle(){

		}

		public override void Dispose(){

		}

	}//end DiagramStyle

}//end namespace DiagramLayout