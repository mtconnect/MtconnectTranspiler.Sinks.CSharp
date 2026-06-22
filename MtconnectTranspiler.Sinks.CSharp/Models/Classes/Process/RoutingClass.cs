#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.Process
{
	/// <summary>﻿optimal sequence of process steps<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1758718018543_226333_786">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class RoutingClass : IClass
	{
		/// <summary>Constant value for <see cref="RoutingClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1758718018543_226333_786";
		/// <summary>Constant value for <see cref="RoutingClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1758718018543_226333_786";
		/// <summary>Constant value for <see cref="RoutingClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;optimal sequence of process steps&#10;
";
		/// <summary>Constant value for <see cref="RoutingClass.Name" /></summary>
		public const string NAME = "Routing";
		/// <summary>Constant value for <see cref="RoutingClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="RoutingClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="RoutingClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.7";
		/// <summary>Constant value for <see cref="RoutingClass.DeprecatedVersion" /></summary>
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
		public Type Generalization => null;

		/// <inheritdoc />
		public new RoutingClassProperties Properties { get; } = new RoutingClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="RoutingClass" />.
		/// </summary>
		public class RoutingClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Precedence,
				RoutingId,
				HasProcessStep,
			};
			/// <summary>
			/// <inheritdoc cref="PrecedenceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Precedence</remarks>
			/// </summary>
			public PrecedenceProperty Precedence { get; } = new PrecedenceProperty();
			
			/// <summary>﻿priority order in which multiple routings are applied or considered for a process<br /><br /><br />
			/// </summary>
			public sealed class PrecedenceProperty : IProperty
			{
				/// <summary>Constant value for <see cref="PrecedenceProperty.Name" /></summary>
				public const string NAME = "precedence";
				/// <summary>Constant value for <see cref="PrecedenceProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;priority order in which multiple routings are applied or considered for a process&#10;
";
				/// <summary>Constant value for <see cref="PrecedenceProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="PrecedenceProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="PrecedenceProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.7";
				/// <summary>Constant value for <see cref="PrecedenceProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="PrecedenceProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="PrecedenceProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="PrecedenceProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="PrecedenceProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="PrecedenceProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..1";

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

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
			/// <summary>
			/// <inheritdoc cref="RoutingIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: RoutingId</remarks>
			/// </summary>
			public RoutingIdProperty RoutingId { get; } = new RoutingIdProperty();
			
			/// <summary>﻿identifier for the routing<br /><br /><br />
			/// </summary>
			public sealed class RoutingIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="RoutingIdProperty.Name" /></summary>
				public const string NAME = "routingId";
				/// <summary>Constant value for <see cref="RoutingIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier for the routing&#10;
";
				/// <summary>Constant value for <see cref="RoutingIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="RoutingIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="RoutingIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.7";
				/// <summary>Constant value for <see cref="RoutingIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="RoutingIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="RoutingIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x;MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="RoutingIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="RoutingIdProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="RoutingIdProperty.Multiplicity" /></summary>
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
			/// <inheritdoc cref="HasProcessStepProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasProcessStep</remarks>
			/// </summary>
			public HasProcessStepProperty HasProcessStep { get; } = new HasProcessStepProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasProcessStepProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasProcessStepProperty.Name" /></summary>
				public const string NAME = "hasProcessStep";
				/// <summary>Constant value for <see cref="HasProcessStepProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasProcessStepProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasProcessStepProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasProcessStepProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasProcessStepProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasProcessStepProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasProcessStepProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="HasProcessStepProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="HasProcessStepProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasProcessStepProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1..*";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ProcessStepClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Process.ProcessStepClass);
				
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
		/// List of constraint rules for <see cref="RoutingClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
