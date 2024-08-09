using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>
	/// <i>configuration</i> for a <i>Component</i>
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1635251403887_914466_345">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ConfigurationGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1635251403887_914466_345";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>configuration</i> for a <i>Component</i>";

		/// <inheritdoc />
		public string Name => "Configuration";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1581970391175_482710_6078
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.IndustrialTerms.ConfigurationClass);

		/// <inheritdoc />
		public ConfigurationGeneralizationProperties Properties { get; } = new ConfigurationGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class ConfigurationGeneralizationProperties : Mtconnect.Glossary.IndustrialTerms.ConfigurationClass.ConfigurationClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ConfigurationFor,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ConfigurationForProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ConfigurationFor</remarks>
			/// </summary>
			public ConfigurationForProperty ConfigurationFor { get; } = new ConfigurationForProperty();
			public sealed class ConfigurationForProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1581734537697_742151_1119</item>
				/// <item>Type: ComponentClass</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.ComponentClass);
				
				/// <inheritdoc />
				public string Name => "configuration for";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>configuration</i> for a <i>Component</i>";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}