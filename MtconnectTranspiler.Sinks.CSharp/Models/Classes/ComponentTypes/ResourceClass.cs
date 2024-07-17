using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ResourceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382014_307743_42285";
		
		/// <inheritdoc />
		public string Name => "ResourceClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";

		/// <inheritdoc />
		public ResourceClassProperties Properties { get; } = new ResourceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ResourceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IsResourceOfPart,
			};
			/// <remarks>Original Name: IsResourceOf</remarks>
			public IsResourceOfPartProperty IsResourceOfPart { get; } = new IsResourceOfPartProperty();
			public sealed class IsResourceOfPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1620240839406_285612_1596</item>
				/// <item>Type: DeviceClass</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.DeviceClass);
				
				/// <inheritdoc />
				public string Name => "IsResourceOf";
				
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

				// TODO: Add Summary
			}
		};

	}
}