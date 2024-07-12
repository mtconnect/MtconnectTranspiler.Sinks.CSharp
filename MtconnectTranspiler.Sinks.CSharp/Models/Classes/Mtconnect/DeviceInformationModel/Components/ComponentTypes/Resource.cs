
using System;
using System.CodeDom.Compiler;

using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ResourceClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382014_307743_42285";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Resource";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "abstract";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_4_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public ResourceProperties Properties { get; } = new ResourceProperties();
		public sealed class ResourceProperties
		{
		
		
			/// <remarks>Original Name: IsResourceOf</remarks>
			public IsResourceOfPartProperty IsResourceOfPart { get; } = new IsResourceOfPartProperty();
			public sealed class IsResourceOfPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1620240839406_285612_1596
				public Type Type => typeof(DeviceClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "IsResourceOf";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "ResourcesClass";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}