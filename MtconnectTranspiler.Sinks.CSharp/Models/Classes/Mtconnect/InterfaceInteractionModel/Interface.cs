
using System;
using System.CodeDom.Compiler;

using Mtconnect.Glossary.MTConnectTerms;
using Mtconnect.InterfaceInteractionModel.DataItemTypesForInterface;

namespace Mtconnect.InterfaceInteractionModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class InterfaceClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381996_964170_42252";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Interface";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "abstract";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_3_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public InterfaceProperties Properties { get; } = new InterfaceProperties();
		public sealed class InterfaceProperties
		{
		
		
			/// <remarks>Original Name: IsInterfaceOf</remarks>
			public IsInterfaceOfPartProperty IsInterfaceOfPart { get; } = new IsInterfaceOfPartProperty();
			public sealed class IsInterfaceOfPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1620240839406_285612_1596
				public Type Type => typeof(DeviceClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "IsInterfaceOf";
				
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

				public string Association => "InterfacesClass";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: ObservesInterfaceState</remarks>
			public ObservesInterfaceStateProperty ObservesInterfaceState { get; } = new ObservesInterfaceStateProperty();
			public sealed class ObservesInterfaceStateProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218325_627294_1860
				public Type Type => typeof(InterfaceStateClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesInterfaceState";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

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