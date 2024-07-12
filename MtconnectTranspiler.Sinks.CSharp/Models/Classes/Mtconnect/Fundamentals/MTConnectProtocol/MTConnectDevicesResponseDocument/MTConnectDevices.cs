
using System;
using System.CodeDom.Compiler;

using Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument;
using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class MTConnectDevicesClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "EAID_76BFE349_267B_45b3_B5FF_3C89D29AE715";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "MTConnectDevices";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public MTConnectDevicesProperties Properties { get; } = new MTConnectDevicesProperties();
		public sealed class MTConnectDevicesProperties
		{
		
		
			/// <remarks>Original Name: HasHeader</remarks>
			public HasHeaderPartProperty HasHeaderPart { get; } = new HasHeaderPartProperty();
			public sealed class HasHeaderPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_08B1605D_39B4_4475_A436_A457B1D646A2
				public Type Type => typeof(HeaderClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasHeader";
				
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

				public string Association => "Header";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasDevice</remarks>
			public HasDevicePartProperty HasDevicePart { get; } = new HasDevicePartProperty();
			public sealed class HasDevicePartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1620240839406_285612_1596
				public Type Type => typeof(DeviceClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasDevice";
				
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

				public string Association => "Devices";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

		# region Rules
		/// <summary>
		/// MtconnectDevices1
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		/*
		Components::Component::allInstances()->forAll(comp1, comp2 | comp1 <> comp2 implies comp1.id <> comp2.id and comp1.name <> comp2.name)  and 
		DataItems::DataItem::allInstances()->forAll(di1, di2 | di1 <> di2 implies di1.id <> di2.id and di1.name <> di2.name) and
		Components::Devices::Device::allInstances()->forAll(d1, d2 | d1 <> d2 implies d1.id <> d2.id and d1.name <> d2.name) and 
		Compositions::Composition::allInstances()->forAll(compn1, compn2 | compn1 <> compn2 implies compn1.id <> compn2.id and compn1.name <> compn2.name)
		 
		*/
		# endregion
	}
}