using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>
	/// <i>organize</i>s data reported from a <see cref="Device">Device</see>./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DeviceStreamClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_02192189_58E6_456c_A679_CDDFF559DA00";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>organize</i>s data reported from a <see cref=""Device"">Device</see>./// Description";

		/// <inheritdoc />
		public string Name => "DeviceStreamClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public DeviceStreamClassProperties Properties { get; } = new DeviceStreamClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class DeviceStreamClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Name,
				Uuid,
				HasComponentStreamPart,
			};
			/// <summary>
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			/// <summary>
			/// name of the <see cref="Device">Device</see>.  The value reported for <see cref="DeviceStream::name" /> <b>MUST</b> be the same as the value defined for the <see cref="Device::name" /> in the <i>MTConnectDevices Response Document</i>.
			/// </summary>
			public sealed class NameProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "Name";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>organize</i>s data reported from a <see cref=""Device"">Device</see>./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// <summary>
			/// <inheritdoc cref="UuidProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Uuid</remarks>
			/// </summary>
			public UuidProperty Uuid { get; } = new UuidProperty();
			/// <summary>
			/// uuid of the <see cref="Device">Device</see>.  The value reported for <see cref="DeviceStream::uuid" /> <b>MUST</b> be the same as the value defined for the <see cref="Device::uuid" /> of the same <see cref="Device">Device</see> in the <i>MTConnectDevices Response Document</i>.
			/// </summary>
			public sealed class UuidProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "Uuid";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>organize</i>s data reported from a <see cref=""Device"">Device</see>./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// <summary>
			/// <inheritdoc cref="HasComponentStreamPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasComponentStream</remarks>
			/// </summary>
			public HasComponentStreamPartProperty HasComponentStreamPart { get; } = new HasComponentStreamPartProperty();
			public sealed class HasComponentStreamPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_9057AAF9_4687_42be_BD2B_E2F18DF049DC</item>
				/// <item>Type: ComponentStreamClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ComponentStreamClass);
				
				/// <inheritdoc />
				public string Name => "HasComponentStream";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>organize</i>s data reported from a <see cref=""Device"">Device</see>./// Description";

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
				public string Association => "ComponentStream";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}