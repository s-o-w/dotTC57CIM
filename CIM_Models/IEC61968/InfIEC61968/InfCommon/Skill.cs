///////////////////////////////////////////////////////////
//  Skill.cs
//  Implementation of the Class Skill
//  Generated by Enterprise Architect
//  Created on:      15-Jun-2024 10:33:25 AM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using TC57CIM.IEC61970.Base.Domain;
using TC57CIM.IEC61968.InfIEC61968.InfCommon;
using TC57CIM.IEC61968.InfIEC61968.InfWork;
using TC57CIM.IEC61968.Common;
namespace TC57CIM.IEC61968.InfIEC61968.InfCommon {
	/// <summary>
	/// Proficiency level of a craft, which is required to operate or maintain a
	/// particular type of asset and/or perform certain types of work.
	/// </summary>
	public class Skill : Document {

		/// <summary>
		/// Interval between the certification and its expiry.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTimeInterval certificationPeriod;
		/// <summary>
		/// Date and time the skill became effective.
		/// </summary>
		public TC57CIM.IEC61970.Base.Domain.DateTime effectiveDateTime;
		/// <summary>
		/// Level of skill for a Craft.
		/// </summary>
		public SkillLevelKind level;
		public TC57CIM.IEC61968.InfIEC61968.InfWork.QualificationRequirement QualificationRequirements;
		public TC57CIM.IEC61968.InfIEC61968.InfCommon.Craft Crafts;

		public Skill(){

		}

		~Skill(){

		}

		public override void Dispose(){

		}

	}//end Skill

}//end namespace InfCommon