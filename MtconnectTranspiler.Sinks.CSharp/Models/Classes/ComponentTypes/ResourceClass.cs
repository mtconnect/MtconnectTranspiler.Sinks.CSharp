using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// abstract <see cref="Component">Component</see> composed of material or personnel involved in a manufacturing process.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382014_307743_42285">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ResourceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382014_307743_42285";
		
		/// <inheritdoc />
		public string Summary => @"/// abstract <see cref=""Component"">Component</see> composed of material or personnel involved in a manufacturing process.";

		/// <inheritdoc />
		public string Name => "Resource";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
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
		public ResourceClassProperties Properties { get; } = new ResourceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ResourceClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IsResourceOfPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="IsResourceOfPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsResourceOf</remarks>
			/// </summary>
			public IsResourceOfPartProperty IsResourceOfPart { get; } = new IsResourceOfPartProperty();
			public sealed class IsResourceOfPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1620240839406_285612_1596</item>
				/// <item>Type: DeviceClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DeviceClass);
				
				/// <inheritdoc />
				public string Name => "isResourceOf";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract <see cref=""Component"">Component</see> composed of material or personnel involved in a manufacturing process.";

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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "ResourcesClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}