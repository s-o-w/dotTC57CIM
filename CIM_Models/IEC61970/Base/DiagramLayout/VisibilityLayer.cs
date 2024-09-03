﻿///////////////////////////////////////////////////////////
//  VisibilityLayer.cs
//  Implementation of the Class VisibilityLayer
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:28 AM
//  Original author: mcmorran
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Base.Core;
namespace TC57CIM.IEC61970.Base.DiagramLayout {
	/// <summary>
	/// Layers are typically used for grouping diagram objects according to themes and
	/// scales. Themes are used to display or hide certain information (e.g., lakes,
	/// borders), while scales are used for hiding or displaying information depending
	/// on the current zoom level (hide text when it is too small to be read, or when
	/// it exceeds the screen size). This is also called de-cluttering.
	/// CIM based graphics exchange supports an m:n relationship between diagram
	/// objects and layers. The importing system shall convert an m:n case into an
	/// appropriate 1:n representation if the importing system does not support m:n.
	/// </summary>
	public class VisibilityLayer : IdentifiedObject {

		/// <summary>
		/// The drawing order for this layer.  The higher the number, the later the layer
		/// and the objects within it are rendered.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer drawingOrder;

		public VisibilityLayer(){

		}

		~VisibilityLayer(){

		}

		public override void Dispose(){

		}

	}//end VisibilityLayer

}//end namespace DiagramLayout