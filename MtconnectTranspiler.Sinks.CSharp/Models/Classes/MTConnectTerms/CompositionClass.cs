#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>﻿<i>Component</i> belonging to a <i>Component</i> and not composed of any <i>Component</i>s.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375147_715142_1964">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CompositionClass : IClass
	{
		/// <summary>Constant value for <see cref="CompositionClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664375147_715142_1964";
		/// <summary>Constant value for <see cref="CompositionClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375147_715142_1964";
		/// <summary>Constant value for <see cref="CompositionClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(Component)}} belonging to a {{term(Component)}} and not composed of any {{termplural(Component)}}.&#10;
";
		/// <summary>Constant value for <see cref="CompositionClass.Name" /></summary>
		public const string NAME = "Composition";
		/// <summary>Constant value for <see cref="CompositionClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="CompositionClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="CompositionClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="CompositionClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1581734537697_742151_1119
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.MTConnectTerms.ComponentClass);

		/// <inheritdoc />
		public new CompositionClassProperties Properties { get; } = new CompositionClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CompositionClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.MTConnectTerms.ComponentClass.ComponentClassProperties" />.
		/// </summary>
		public class CompositionClassProperties : Mtconnect.Glossary.MTConnectTerms.ComponentClass.ComponentClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				BelongsTo,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="BelongsToProperty" path="/summary" /><br/>
			/// <remarks>Original Name: BelongsTo</remarks>
			/// </summary>
			public new BelongsToProperty BelongsTo { get; } = new BelongsToProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class BelongsToProperty : IProperty
			{
				/// <summary>Constant value for <see cref="BelongsToProperty.Name" /></summary>
				public const string NAME = "belongs to";
				/// <summary>Constant value for <see cref="BelongsToProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="BelongsToProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="BelongsToProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="BelongsToProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="BelongsToProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="BelongsToProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="BelongsToProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="BelongsToProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="BelongsToProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ComponentClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.ComponentClass);
				
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