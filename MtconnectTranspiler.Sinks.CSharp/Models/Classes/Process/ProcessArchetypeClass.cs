#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.Process
{
	/// <summary>﻿<see cref="Asset">Asset</see> that defines common data for all derived <see cref="Process">Process</see>es.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1758717935057_987852_746">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class ProcessArchetypeClass : IClass
	{
		/// <summary>Constant value for <see cref="ProcessArchetypeClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1758717935057_987852_746";
		/// <summary>Constant value for <see cref="ProcessArchetypeClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1758717935057_987852_746";
		/// <summary>Constant value for <see cref="ProcessArchetypeClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Asset)}} that defines common data for all derived {{block(Process)}}es.&#10;
";
		/// <summary>Constant value for <see cref="ProcessArchetypeClass.Name" /></summary>
		public const string NAME = "ProcessArchetype";
		/// <summary>Constant value for <see cref="ProcessArchetypeClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ProcessArchetypeClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ProcessArchetypeClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.7";
		/// <summary>Constant value for <see cref="ProcessArchetypeClass.DeprecatedVersion" /></summary>
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
		/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.AssetClass);

		/// <inheritdoc />
		public new ProcessArchetypeClassProperties Properties { get; } = new ProcessArchetypeClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ProcessArchetypeClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties" />.
		/// </summary>
		public class ProcessArchetypeClassProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Revision,
				HasRoutingPart,
				HasTargetPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="RevisionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Revision</remarks>
			/// </summary>
			public new RevisionProperty Revision { get; } = new RevisionProperty();
			
			/// <summary>﻿identifier assigned to a process archetype version that reflects a change<br /><br /><br />
			/// </summary>
			public new sealed class RevisionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="RevisionProperty.Name" /></summary>
				public const string NAME = "revision";
				/// <summary>Constant value for <see cref="RevisionProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier assigned to a process archetype version that reflects a change&#10;
";
				/// <summary>Constant value for <see cref="RevisionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="RevisionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="RevisionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.7";
				/// <summary>Constant value for <see cref="RevisionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="RevisionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="RevisionProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x;MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="RevisionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="RevisionProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="RevisionProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
			/// <summary>
			/// <inheritdoc cref="HasRoutingPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasRouting</remarks>
			/// </summary>
			public new HasRoutingPartProperty HasRoutingPart { get; } = new HasRoutingPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasRoutingPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasRoutingPartProperty.Name" /></summary>
				public const string NAME = "hasRouting";
				/// <summary>Constant value for <see cref="HasRoutingPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasRoutingPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasRoutingPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasRoutingPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasRoutingPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasRoutingPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasRoutingPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="HasRoutingPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Routings";
				/// <summary>Constant value for <see cref="HasRoutingPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasRoutingPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1..*";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: RoutingClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Process.RoutingClass);
				
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

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
			/// <summary>
			/// <inheritdoc cref="HasTargetPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasTarget</remarks>
			/// </summary>
			public new HasTargetPartProperty HasTargetPart { get; } = new HasTargetPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasTargetPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Name" /></summary>
				public const string NAME = "hasTarget";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Targets";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..*";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: TargetClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Process.Target.TargetClass);
				
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

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="ProcessArchetypeClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
