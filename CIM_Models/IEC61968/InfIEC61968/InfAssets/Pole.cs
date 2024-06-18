///////////////////////////////////////////////////////////
//  Pole.cs
//  Implementation of the Class Pole
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:20 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61968.InfIEC61968.InfAssets;
using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.AssetInfo.Assets;
namespace TC57CIM.IEC61968.InfIEC61968.InfAssets {
	/// <summary>
	/// Pole asset.
	/// </summary>
	public class Pole : Structure {

		/// <summary>
		/// Kind of base for this pole.
		/// </summary>
		public PoleBaseKind baseKind;
		/// <summary>
		/// True if a block of material has been attached to base of pole in ground for
		/// stability. This technique is used primarily when anchors can not be used.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean breastBlock;
		/// <summary>
		/// Pole class: 1, 2, 3, 4, 5, 6, 7, H1, H2, Other, Unknown.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String classification;
		/// <summary>
		/// The framing structure mounted on the pole.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String construction;
		/// <summary>
		/// Diameter of the pole.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Length diameter;
		/// <summary>
		/// Joint pole agreement reference number.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String jpaReference;
		/// <summary>
		/// Length of the pole (inclusive of any section of the pole that may be
		/// underground post-installation).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Length length;
		/// <summary>
		/// Kind of preservative for this pole.
		/// </summary>
		public PolePreservativeKind preservativeKind;
		/// <summary>
		/// Pole species. Aluminum, Aluminum Davit, Concrete, Fiberglass, Galvanized Davit,
		/// Galvanized, Steel Davit Primed, Steel Davit, Steel Standard Primed, Steel,
		/// Truncated, Wood-Treated, Wood-Hard, Wood-Salt Treated, Wood-Soft, Wood, Other,
		/// Unknown.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.String speciesType;
		/// <summary>
		/// Date and time pole was last treated with preservative.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime treatedDateTime;
		/// <summary>
		/// Kind of treatment for this pole.
		/// </summary>
		public PoleTreatmentKind treatmentKind;
		/// <summary>
		/// All streetlights attached to this pole.
		/// </summary>
		public TC57CIM.IEC61968.AssetInfo.Assets.Streetlight Streetlights;

		public Pole(){

		}

		~Pole(){

		}

		public override void Dispose(){

		}

	}//end Pole

}//end namespace InfAssets