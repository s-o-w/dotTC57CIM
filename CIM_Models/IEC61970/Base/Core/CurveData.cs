///////////////////////////////////////////////////////////
//  CurveData.cs
//  Implementation of the Class CurveData
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:45 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
namespace TC57CIM.IEC61970.Base.Core {
	/// <summary>
	/// Multi-purpose data points for defining a curve.  The use of this generic class
	/// is discouraged if a more specific class can be used to specify the X and Y axis
	/// values along with their specific data types.
	/// </summary>
	public class CurveData {

		/// <summary>
		/// The data value of the X-axis variable,  depending on the X-axis units.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float xvalue;
		/// <summary>
		/// The data value of the  first Y-axis variable, depending on the Y-axis units.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float y1value;
		/// <summary>
		/// The data value of the second Y-axis variable (if present), depending on the Y-
		/// axis units.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float y2value;
		/// <summary>
		/// The data value of the third Y-axis variable (if present), depending on the Y-
		/// axis units.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Float y3value;

		public CurveData(){

		}

		~CurveData(){

		}

		public virtual void Dispose(){

		}

	}//end CurveData

}//end namespace Core