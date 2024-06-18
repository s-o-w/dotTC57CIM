///////////////////////////////////////////////////////////
//  Delay.cs
//  Implementation of the Class Delay
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:04:47 AM
//  Original author: civanov
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.CSC;
using TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.VSC;
namespace TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics {
	/// <summary>
	/// All the measurements are filtered by a first lag element with a time constant
	/// TM.
	/// </summary>
	public class Delay {

		/// <summary>
		/// Time constant.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Seconds tm;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.CSC.IdcInverterControl m_IdcInverterControl;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.CSC.VDCOL m_VDCOL;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.CSC.CCAinverter m_CCAinverter;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.VSC.Pcontrol Pcontrol;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.VSC.Qregulator Qregulator;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.CSC.CCArectifierControl m_CCArectifierControl;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.VSC.DCvoltageControl DCvoltageControl;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.VSC.Umode Umode;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.VSC.Qlimiter Qlimiter;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.VSC.BlockingFunction BlockingFunction;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.VSC.Qmode Qmode;
		public TC57CIM.IEC61970.Dynamics.StandardModels.InfHVDCDynamics.VSC.PFmode PFmode;

		public Delay(){

		}

		~Delay(){

		}

		public virtual void Dispose(){

		}

	}//end Delay

}//end namespace InfHVDCDynamics