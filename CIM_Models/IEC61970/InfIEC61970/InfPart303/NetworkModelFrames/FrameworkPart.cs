﻿///////////////////////////////////////////////////////////
//  FrameworkPart.cs
//  Implementation of the Class FrameworkPart
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:56 AM
//  Original author: 222206
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelFrames.unused;
using TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelFrames;
namespace TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelFrames {
	/// <summary>
	/// The type of alternate model frame.  For example, it could be generator group
	/// used to represent generators in state estimator, planning, planning dynamics,
	/// short circuit, or real-time dynamics etc., but does not specifically represent
	/// any one alternative model. This need to know what objects to be removed in the
	/// realization of any one alternate model.
	/// </summary>
	public class FrameworkPart : ModelAuthoritySet {

		/// <summary>
		/// Model frame type of the model frame.
		/// </summary>
		public TC57CIM.IEC61970.InfIEC61970.InfPart303.NetworkModelFrames.unused.ModelFrameType ModelFrameType;

		public FrameworkPart(){

		}

		~FrameworkPart(){

		}

		public override void Dispose(){

		}

	}//end FrameworkPart

}//end namespace NetworkModelFrames