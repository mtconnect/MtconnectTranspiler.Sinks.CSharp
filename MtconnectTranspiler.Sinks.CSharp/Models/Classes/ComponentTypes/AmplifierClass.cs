#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿leaf <see cref="Component">Component</see> composed of an electronic component or circuit that amplifies power, electric current, or voltage.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580312106460_808314_44366">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AmplifierClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580312106460_808314_44366";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;leaf {{block(Component)}} composed of an electronic component or circuit that amplifies power, electric current, or voltage.&#10;
";

		/// <inheritdoc />
		public string Name => "Amplifier";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);

		/// <inheritdoc />
		public new AmplifierClassProperties Properties { get; } = new AmplifierClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AmplifierClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties" />.
		/// </summary>
		public class AmplifierClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				HasComposition,
				HasComponent,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="HasCompositionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasComposition</remarks>
			/// </summary>
			public new HasCompositionProperty HasComposition { get; } = new HasCompositionProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasCompositionProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1658936424016_561586_139</item>
				/// <item>Type: CompositionClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Compositions</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Compositions.CompositionClass);
				
				/// <inheritdoc />
				public string Name => "hasComposition";
				
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
			public new HasComponentProperty HasComponent { get; } = new HasComponentProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasComponentProperty : IProperty
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
				public string Name => "hasComponent";
				
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