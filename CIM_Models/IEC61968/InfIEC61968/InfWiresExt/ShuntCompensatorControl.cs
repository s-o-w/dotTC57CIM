﻿///////////////////////////////////////////////////////////
//  ShuntCompensatorControl.cs
//  Implementation of the Class ShuntCompensatorControl
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:24 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.InfIEC61968.InfAssetInfo;
using TC57CIM.IEC61970.Base.Core;
using TC57CIM.IEC61970.Base.Wires;
namespace TC57CIM.IEC61968.InfIEC61968.InfWiresExt {
	/// <summary>
	/// Distribution capacitor bank control settings.
	/// </summary>
	public class ShuntCompensatorControl : RegulatingControl {

		/// <summary>
		/// For VAR, amp, or power factor locally controlled shunt impedances, the flow
		/// direction: in, out.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer branchDirect;
		/// <summary>
		/// The size of the individual units that make up the bank.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.ReactivePower cellSize;
		/// <summary>
		/// Kind of control (if any).
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfAssetInfo.ShuntImpedanceControlKind controlKind;
		/// <summary>
		/// For locally controlled shunt impedances which have a voltage override feature,
		/// the high voltage override value. If the voltage is above this value, the shunt
		/// impedance will be turned off regardless of the other local controller settings.
		/// 
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU highVoltageOverride;
		/// <summary>
		/// Kind of local controller.
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfAssetInfo.ShuntImpedanceLocalControlKind localControlKind;
		/// <summary>
		/// Upper control setting.
		/// </summary>
		public string localOffLevel;
		/// <summary>
		/// Lower control setting.
		/// </summary>
		public string localOnLevel;
		/// <summary>
		/// True if the locally controlled capacitor has voltage override capability.
		/// </summary>
		public bool localOverride;
		/// <summary>
		/// For locally controlled shunt impedances which have a voltage override feature,
		/// the low voltage override value. If the voltage is below this value, the shunt
		/// impedance will be turned on regardless of the other local controller settings.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.PU lowVoltageOverride;
		/// <summary>
		/// IdmsShuntImpedanceData.maxNumSwitchOps.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer maxSwitchOperationCount;
		/// <summary>
		/// True if open is normal status for a fixed capacitor bank, otherwise normal
		/// status is closed.
		/// </summary>
		public bool normalOpen;
		/// <summary>
		/// For VAR, amp, or power factor locally controlled shunt impedances, the index of
		/// the regulation branch.
		/// </summary>
		public string regBranch;
		/// <summary>
		/// For VAR, amp, or power factor locally controlled shunt impedances, the end of
		/// the branch that is regulated. The field has the following values: from side, to
		/// side, and tertiary (only if the branch is a transformer).
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Integer regBranchEnd;
		/// <summary>
		/// (For VAR, amp, or power factor locally controlled shunt impedances) Kind of
		/// regulation branch.
		/// </summary>
		public TC57CIM.IEC61968.InfIEC61968.InfAssetInfo.RegulationBranchKind regBranchKind;
		/// <summary>
		/// Phases that are measured for controlling the device.
		/// </summary>
		public TC57CIM.IEC61970.Base.Core.PhaseCode sensingPhaseCode;
		/// <summary>
		/// Time interval between consecutive switching operations.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.Hours switchOperationCycle;
		/// <summary>
		/// True if regulated voltages are measured line to line, otherwise they are
		/// measured line to ground.
		/// </summary>
		public bool vRegLineLine;

		public ShuntCompensatorControl(){

		}

		~ShuntCompensatorControl(){

		}

		public override void Dispose(){

		}

	}//end ShuntCompensatorControl

}//end namespace InfWiresExt