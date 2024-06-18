///////////////////////////////////////////////////////////
//  OverexcLimX2.cs
//  Implementation of the Class OverexcLimX2
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:11 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.OverexcitationLimiterDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.OverexcitationLimiterDynamics {
	/// <summary>
	/// Field voltage or current overexcitation limiter designed to protect the
	/// generator field of an AC machine with automatic excitation control from
	/// overheating due to prolonged overexcitation.
	/// </summary>
	public class OverexcLimX2 : OverexcitationLimiterDynamics {

		/// <summary>
		/// Low voltage or current point on the inverse time characteristic
		/// (<i>EFD</i><i><sub>1</sub></i>).  Typical value = 1,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efd1;
		/// <summary>
		/// Mid voltage or current point on the inverse time characteristic
		/// (<i>EFD</i><i><sub>2</sub></i>).  Typical value = 1,2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efd2;
		/// <summary>
		/// High voltage or current point on the inverse time characteristic
		/// (<i>EFD</i><i><sub>3</sub></i>).  Typical value = 1,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efd3;
		/// <summary>
		/// Desired field voltage if <i>m</i> = false or desired field current if <i>m
		/// </i>= true (<i>EFD</i><i><sub>DES</sub></i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efddes;
		/// <summary>
		/// Rated field voltage if m = false or rated field current if m = true
		/// (<i>EFD</i><i><sub>RATED</sub></i>).  Typical value = 1,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efdrated;
		/// <summary>
		/// Gain (<i>K</i><i><sub>MX</sub></i>).  Typical value = 0,002.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kmx;
		/// <summary>
		/// (<i>m</i>).
		/// true = IFD limiting
		/// false = EFD limiting.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean m;
		/// <summary>
		/// Time to trip the exciter at the low voltage or current point on the inverse
		/// time characteristic (<i>TIME</i><i><sub>1</sub></i>) (>= 0).  Typical value =
		/// 120.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t1;
		/// <summary>
		/// Time to trip the exciter at the mid voltage or current point on the inverse
		/// time characteristic (<i>TIME</i><i><sub>2</sub></i>) (>= 0).  Typical value =
		/// 40.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t2;
		/// <summary>
		/// Time to trip the exciter at the high voltage or current point on the inverse
		/// time characteristic (<i>TIME</i><i><sub>3</sub></i>) (>= 0).  Typical value =
		/// 15.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds t3;
		/// <summary>
		/// Low voltage limit (<i>V</i><i><sub>LOW</sub></i>) (> 0).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vlow;

		public OverexcLimX2(){

		}

		~OverexcLimX2(){

		}

		public override void Dispose(){

		}

	}//end OverexcLimX2

}//end namespace OverexcitationLimiterDynamics