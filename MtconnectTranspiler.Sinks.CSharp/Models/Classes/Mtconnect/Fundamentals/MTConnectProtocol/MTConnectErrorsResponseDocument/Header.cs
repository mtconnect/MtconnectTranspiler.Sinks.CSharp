
using System;
using System.CodeDom.Compiler;


namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class HeaderClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_91b028d_1579560593039_375117_6558";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Header";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public HeaderProperties Properties { get; } = new HeaderProperties();
		public sealed class HeaderProperties
		{
		
		
			/// <remarks>Original Name: BufferSize</remarks>
			public BufferSizeProperty BufferSize { get; } = new BufferSizeProperty();
			public sealed class BufferSizeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1638533232267_921642_410
				public Type Type => typeof(UInt32);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "BufferSize";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
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
		
		
			/// <remarks>Original Name: CreationTime</remarks>
			public CreationTimeProperty CreationTime { get; } = new CreationTimeProperty();
			public sealed class CreationTimeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272233011_597138_670
				public Type Type => typeof(DateTime);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "CreationTime";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
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
		
		
			/// <remarks>Original Name: InstanceId</remarks>
			public InstanceIdProperty InstanceId { get; } = new InstanceIdProperty();
			public sealed class InstanceIdProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1638534140373_733270_671
				public Type Type => typeof(UInt64);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "InstanceId";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
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
		
		
			/// <remarks>Original Name: Sender</remarks>
			public SenderProperty Sender { get; } = new SenderProperty();
			public sealed class SenderProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272360416_763325_681
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Sender";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
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
		
		
			/// <remarks>Original Name: TestIndicator</remarks>
			public TestIndicatorProperty TestIndicator { get; } = new TestIndicatorProperty();
			public sealed class TestIndicatorProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579278876899_683310_3821
				public Type Type => typeof(Boolean);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "TestIndicator";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
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
		
		
			/// <remarks>Original Name: Version</remarks>
			public VersionProperty Version { get; } = new VersionProperty();
			public sealed class VersionProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1638532805092_219797_373
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Version";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
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
		
		
			/// <remarks>Original Name: FirstSequence</remarks>
			public FirstSequenceProperty FirstSequence { get; } = new FirstSequenceProperty();
			public sealed class FirstSequenceProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1638534140373_733270_671
				public Type Type => typeof(UInt64);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "FirstSequence";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "MtconnectVersions.V_1_4_0";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: LastSequence</remarks>
			public LastSequenceProperty LastSequence { get; } = new LastSequenceProperty();
			public sealed class LastSequenceProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1638534140373_733270_671
				public Type Type => typeof(UInt64);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "LastSequence";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "MtconnectVersions.V_1_4_0";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: NextSequence</remarks>
			public NextSequenceProperty NextSequence { get; } = new NextSequenceProperty();
			public sealed class NextSequenceProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1638534140373_733270_671
				public Type Type => typeof(UInt64);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "NextSequence";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "MtconnectVersions.V_1_4_0";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: DeviceModelChangeTime</remarks>
			public DeviceModelChangeTimeProperty DeviceModelChangeTime { get; } = new DeviceModelChangeTimeProperty();
			public sealed class DeviceModelChangeTimeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272233011_597138_670
				public Type Type => typeof(DateTime);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "DeviceModelChangeTime";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_7_0";
				
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