#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.WIP_DeviceExamples.MillW_PER_SmoothG.Representation
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1634045367649_547336_746">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class WorkOffsetsClass : IClass
	{
		/// <summary>Constant value for <see cref="WorkOffsetsClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1634045367649_547336_746";
		/// <summary>Constant value for <see cref="WorkOffsetsClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1634045367649_547336_746";
		/// <summary>Constant value for <see cref="WorkOffsetsClass.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="WorkOffsetsClass.Name" /></summary>
		public const string NAME = "WorkOffsets";
		/// <summary>Constant value for <see cref="WorkOffsetsClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="WorkOffsetsClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="WorkOffsetsClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="WorkOffsetsClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1579566531115_47447_25730
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.EventClass);

		/// <inheritdoc />
		public new WorkOffsetsClassProperties Properties { get; } = new WorkOffsetsClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="WorkOffsetsClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.EventClass.EventClassProperties" />.
		/// </summary>
		public class WorkOffsetsClassProperties : Mtconnect.ObservationInformationModel.EventClass.EventClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Count,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="CountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Count</remarks>
			/// </summary>
			public new CountProperty Count { get; } = new CountProperty();
			
			/// <summary>﻿number of <see cref="Entry">Entry</see> elements for the <see cref="Observation">Observation</see>.<br /><br /><br />
			/// </summary>
			public new sealed class CountProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CountProperty.Name" /></summary>
				public const string NAME = "count";
				/// <summary>Constant value for <see cref="CountProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;number of {{block(Entry)}} elements for the {{block(Observation)}}.&#10;
";
				/// <summary>Constant value for <see cref="CountProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CountProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CountProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="CountProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CountProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CountProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CountProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CountProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Int32 </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
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