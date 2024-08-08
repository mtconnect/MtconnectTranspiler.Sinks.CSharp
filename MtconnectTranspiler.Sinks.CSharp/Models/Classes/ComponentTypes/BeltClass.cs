using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.MTConnectTerms;
// using Mtconnect.DeviceInformationModel.Components;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// leaf <see cref="Component">Component</see> composed of an endless flexible band that transmits motion for a piece of equipment or conveys materials and objects.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class BeltClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580312106461_211983_44372";
		
		/// <inheritdoc />
		public string Summary => @"/// leaf <see cref=""Component"">Component</see> composed of an endless flexible band that transmits motion for a piece of equipment or conveys materials and objects.";

		/// <inheritdoc />
		public string Name => "BeltClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";

		/// <inheritdoc />
		public BeltClassProperties Properties { get; } = new BeltClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class BeltClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasComposition,
				HasComponent,
			};
			/// <summary>
			/// <inheritdoc cref="HasCompositionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasComposition</remarks>
			/// </summary>
			public HasCompositionProperty HasComposition { get; } = new HasCompositionProperty();
			public sealed class HasCompositionProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1658936424016_561586_139</item>
				/// <item>Type: CompositionClass</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.CompositionClass);
				
				/// <inheritdoc />
				public string Name => "HasComposition";
				
				/// <inheritdoc />
				public string Summary => @"/// leaf <see cref=""Component"">Component</see> composed of an endless flexible band that transmits motion for a piece of equipment or conveys materials and objects.";

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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasComponentProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasComponent</remarks>
			/// </summary>
			public HasComponentProperty HasComponent { get; } = new HasComponentProperty();
			public sealed class HasComponentProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779</item>
				/// <item>Type: ComponentGeneralization</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);
				
				/// <inheritdoc />
				public string Name => "HasComponent";
				
				/// <inheritdoc />
				public string Summary => @"/// leaf <see cref=""Component"">Component</see> composed of an endless flexible band that transmits motion for a piece of equipment or conveys materials and objects.";

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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}