#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>﻿setting or operator selection that changes the behavior of the controller on a piece of equipment.  <br /><br />Program execution is paused when a command is executed requesting a cutting tool to be changed. <br /><br /><see cref="Execution">Execution</see> <b>MUST</b> change to <c>INTERRUPTED</c> after completion of the command requesting a cutting tool to be changed and <c>TOOL_CHANGE_STOP</c> is <c>ON</c>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580378218244_835736_1674">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ControllerModeOverrideToolChangeStopClass : IClass
	{
		/// <summary>Constant value for <see cref="ControllerModeOverrideToolChangeStopClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378218244_835736_1674";
		/// <summary>Constant value for <see cref="ControllerModeOverrideToolChangeStopClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580378218244_835736_1674";
		/// <summary>Constant value for <see cref="ControllerModeOverrideToolChangeStopClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;setting or operator selection that changes the behavior of the controller on a piece of equipment.  

Program execution is paused when a command is executed requesting a cutting tool to be changed. 

{{block(Execution)}} **MUST** change to `INTERRUPTED` after completion of the command requesting a cutting tool to be changed and `TOOL_CHANGE_STOP` is `ON`.&#10;
";
		/// <summary>Constant value for <see cref="ControllerModeOverrideToolChangeStopClass.Name" /></summary>
		public const string NAME = "ControllerModeOverride.ToolChangeStop";
		/// <summary>Constant value for <see cref="ControllerModeOverrideToolChangeStopClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ControllerModeOverrideToolChangeStopClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ControllerModeOverrideToolChangeStopClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.4";
		/// <summary>Constant value for <see cref="ControllerModeOverrideToolChangeStopClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1580378218236_117661_1659
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ControllerModeOverrideClass);

		/// <inheritdoc />
		public new ControllerModeOverrideToolChangeStopClassProperties Properties { get; } = new ControllerModeOverrideToolChangeStopClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ControllerModeOverrideToolChangeStopClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ControllerModeOverrideClass.ControllerModeOverrideClassProperties" />.
		/// </summary>
		public class ControllerModeOverrideToolChangeStopClassProperties : Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ControllerModeOverrideClass.ControllerModeOverrideClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				SubType,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public new SubTypeProperty SubType { get; } = new SubTypeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class SubTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SubTypeProperty.Name" /></summary>
				public const string NAME = "subType";
				/// <summary>Constant value for <see cref="SubTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="SubTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SubTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="SubTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="SubTypeProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DataItemSubTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
		};

	}
}