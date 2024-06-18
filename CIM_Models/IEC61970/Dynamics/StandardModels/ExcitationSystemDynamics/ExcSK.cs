///////////////////////////////////////////////////////////
//  ExcSK.cs
//  Implementation of the Class ExcSK
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:55 AM
//  Original author: tsaxton
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.ExcitationSystemDynamics {
	/// <summary>
	/// Slovakian excitation system.  UEL and secondary voltage control are included in
	/// this model. When this model is used, there cannot be a separate underexcitation
	/// limiter or VAr controller model.
	/// </summary>
	public class ExcSK : ExcitationSystemDynamics {

		/// <summary>
		/// Field voltage clipping upper level limit (<i>Efdmax</i>) (> ExcSK.efdmin).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efdmax;
		/// <summary>
		/// Field voltage clipping lower level limit (<i>Efdmin</i>) (< ExcSK.efdmax).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU efdmin;
		/// <summary>
		/// Maximum field voltage output (<i>Emax</i>) (> ExcSK.emin).  Typical value = 20.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU emax;
		/// <summary>
		/// Minimum field voltage output (<i>Emin</i>) (< ExcSK.emax).  Typical value = -20.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU emin;
		/// <summary>
		/// Gain (<i>K</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k;
		/// <summary>
		/// Parameter of underexcitation limit (<i>K1</i>).  Typical value = 0,1364.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k1;
		/// <summary>
		/// Parameter of underexcitation limit (<i>K2</i>).  Typical value = -0,3861.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU k2;
		/// <summary>
		/// PI controller gain (<i>Kc</i>).  Typical value = 70.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kc;
		/// <summary>
		/// Rectifier regulation factor (<i>Kce</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kce;
		/// <summary>
		/// Exciter internal reactance (<i>Kd</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kd;
		/// <summary>
		/// P controller gain (<i>Kgob</i>).  Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kgob;
		/// <summary>
		/// PI controller gain (<i>Kp</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kp;
		/// <summary>
		/// PI controller gain of integral component (<i>Kqi</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kqi;
		/// <summary>
		/// Rate of rise of the reactive power (<i>Kqob</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kqob;
		/// <summary>
		/// PI controller gain (<i>Kqp</i>).  Typical value = 0.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU kqp;
		/// <summary>
		/// Deadband of reactive power (<i>nq</i>).  Determines the range of sensitivity.
		/// Typical value = 0,001.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU nq;
		/// <summary>
		/// Secondary voltage control state (<i>Qc_on_off</i>).
		/// true = secondary voltage control is on
		/// false = secondary voltage control is off.
		/// Typical value = false.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean qconoff;
		/// <summary>
		/// Desired value (setpoint) of reactive power, manual setting (<i>Qz</i>).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU qz;
		/// <summary>
		/// Selector to apply automatic calculation in secondary controller model
		/// (<i>remote</i>).
		/// true = automatic calculation is activated
		/// false = manual set is active; the use of desired value of reactive power
		/// (<i>Qz</i>) is required.
		/// Typical value = true.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Boolean remote;
		/// <summary>
		/// Apparent power of the unit (<i>Sbase</i>) (> 0).  Unit = MVA.  Typical value =
		/// 259.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ApparentPower sbase;
		/// <summary>
		/// PI controller phase lead time constant (<i>Tc</i>) (>= 0).  Typical value = 8.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tc;
		/// <summary>
		/// Time constant of gain block (<i>Te</i>) (>= 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds te;
		/// <summary>
		/// PI controller phase lead time constant (<i>Ti</i>) (>= 0).  Typical value = 2.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds ti;
		/// <summary>
		/// Time constant (<i>Tp</i>) (>= 0).  Typical value = 0,1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tp;
		/// <summary>
		/// Voltage transducer time constant (<i>Tr</i>) (>= 0).  Typical value = 0,01.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tr;
		/// <summary>
		/// Maximum error (<i>UImax</i>) (> ExcSK.uimin).  Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU uimax;
		/// <summary>
		/// Minimum error (<i>UImin</i>) (< ExcSK.uimax).  Typical value = -10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU uimin;
		/// <summary>
		/// Maximum controller output (<i>URmax</i>) (> ExcSK.urmin).  Typical value = 10.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU urmax;
		/// <summary>
		/// Minimum controller output (<i>URmin</i>) (< ExcSK.urmax).  Typical value = -10.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU urmin;
		/// <summary>
		/// Maximum terminal voltage input (<i>Vtmax</i>) (> ExcSK.vtmin).  Determines the
		/// range of voltage deadband.  Typical value = 1,05.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vtmax;
		/// <summary>
		/// Minimum terminal voltage input (<i>Vtmin</i>) (< ExcSK.vtmax).  Determines the
		/// range of voltage deadband.  Typical value = 0,95.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU vtmin;
		/// <summary>
		/// Maximum output (<i>Yp</i>).  Typical value = 1.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU yp;

		public ExcSK(){

		}

		~ExcSK(){

		}

		public override void Dispose(){

		}

	}//end ExcSK

}//end namespace ExcitationSystemDynamics