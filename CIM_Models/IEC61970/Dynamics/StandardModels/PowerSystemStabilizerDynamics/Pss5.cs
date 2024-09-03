﻿///////////////////////////////////////////////////////////
//  Pss5.cs
//  Implementation of the Class Pss5
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:05:17 AM
//  Original author: pcha006
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.PowerSystemStabilizerDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.PowerSystemStabilizerDynamics {
	/// <summary>
	/// Detailed Italian PSS.
	/// </summary>
	public class Pss5 : PowerSystemStabilizerDynamics {

		/// <summary>
		/// Selector for second washout enabling (<i>C</i><i><sub>TW2</sub></i>).
		/// true = second washout filter is bypassed
		/// false = second washout filter in use.
		/// Typical value = true.
		/// </summary>
		public bool ctw2;
		/// <summary>
		/// Stabilizer output deadband (<i>DEADBAND</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU deadband;
		/// <summary>
		/// Selector for frequency/shaft speed input (<i>isFreq</i>).
		/// true = speed (same meaning as InputSignaKind.rotorSpeed)
		/// false = frequency (same meaning as InputSignalKind.busFrequency).
		/// Typical value = true (same meaning as InputSignalKind.rotorSpeed).
		/// </summary>
		public bool isfreq;
		/// <summary>
		/// Frequency/shaft speed input gain (<i>K</i><i><sub>F</sub></i>).  Typical value
		/// = 5.
		/// </summary>
		public float kf;
		/// <summary>
		/// Electric power input gain (<i>K</i><i><sub>PE</sub></i>).  Typical value = 0,3.
		/// 
		/// </summary>
		public float kpe;
		/// <summary>
		/// PSS gain (<i>K</i><i><sub>PSS</sub></i>).  Typical value = 1.
		/// </summary>
		public float kpss;
		/// <summary>
		/// Minimum power PSS enabling (<i>Pmin</i>).  Typical value = 0,25.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU pmin;
		/// <summary>
		/// Lead/lag time constant (<i>T</i><i><sub>L1</sub></i>) (>= 0).  Typical value =
		/// 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tl1;
		/// <summary>
		/// Lead/lag time constant (<i>T</i><i><sub>L2</sub></i>) (>= 0).  If = 0, both
		/// blocks are bypassed.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tl2;
		/// <summary>
		/// Lead/lag time constant (<i>T</i><i><sub>L3</sub></i>) (>= 0).  Typical value =
		/// 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tl3;
		/// <summary>
		/// Lead/lag time constant (T<sub>L4</sub>) (>= 0).  If = 0, both blocks are
		/// bypassed.  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tl4;
		/// <summary>
		/// Electric power filter time constant (<i>T</i><i><sub>PE</sub></i>) (>= 0).
		/// Typical value = 0,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tpe;
		/// <summary>
		/// First washout (<i>T</i><i><sub>W1</sub></i>) (>= 0).  Typical value = 3,5.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tw1;
		/// <summary>
		/// Second washout (<i>T</i><i><sub>W2</sub></i>) (>= 0).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tw2;
		/// <summary>
		/// <font color="#0f0f0f">Signal selector (<i>V</i><i><sub>adAtt</sub></i>).
		/// </font>
		/// <font color="#0f0f0f">true = closed (generator power is greater than
		/// <i>Pmin</i>)</font>
		/// <font color="#0f0f0f">false = open (<i>Pe</i> is smaller than <i>Pmin</i>).
		/// </font>
		/// <font color="#0f0f0f">Typical value = true.</font>
		/// </summary>
		public bool vadat;
		/// <summary>
		/// Stabilizer output maximum limit (<i>V</i><i><sub>SMN</sub></i>).  Typical value
		/// = -0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vsmn;
		/// <summary>
		/// Stabilizer output minimum limit (<i>V</i><i><sub>SMX</sub></i>).  Typical value
		/// = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vsmx;

		public Pss5(){

		}

		~Pss5(){

		}

		public override void Dispose(){

		}

	}//end Pss5

}//end namespace PowerSystemStabilizerDynamics