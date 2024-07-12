
using System;
using System.CodeDom.Compiler;

using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.DeviceInformationModel.References
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ComponentRefClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_45f01b9_1581212139957_418083_223";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "ComponentRef";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_4_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public ComponentRefProperties Properties { get; } = new ComponentRefProperties();
		public sealed class ComponentRefProperties
		{
		
		
			/// <remarks>Original Name: IdRef</remarks>
			public IdRefProperty IdRef { get; } = new IdRefProperty();
			public sealed class IdRefProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
				public Type Type => typeof(ComponentClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "IdRef";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_4_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}