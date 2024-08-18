#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.ComponentConfigurationParameters
{
	/// <summary>﻿set of <see cref="ParameterSet">ParameterSet</see>s that govern the functionality of the related <see cref="Component">Component</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678197202508_829668_17803">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ComponentConfigurationParametersClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678197202508_829668_17803";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;set of {{block(ParameterSet)}}s that govern the functionality of the related {{block(Component)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "ComponentConfigurationParameters";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.AssetClass);

		/// <inheritdoc />
		public new ComponentConfigurationParametersClassProperties Properties { get; } = new ComponentConfigurationParametersClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ComponentConfigurationParametersClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties" />.
		/// </summary>
		public class ComponentConfigurationParametersClassProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				HasParameterSetPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="HasParameterSetPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasParameterSet</remarks>
			/// </summary>
			public new HasParameterSetPartProperty HasParameterSetPart { get; } = new HasParameterSetPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasParameterSetPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678197254209_96040_17915</item>
				/// <item>Type: ParameterSetClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.ComponentConfigurationParameters</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.ComponentConfigurationParameters.ParameterSetClass);
				
				/// <inheritdoc />
				public string Name => "hasParameterSet";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "ParameterSets";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}