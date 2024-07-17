using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument;
// using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class MTConnectDevicesClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_76BFE349_267B_45b3_B5FF_3C89D29AE715";
		
		/// <inheritdoc />
		public string Name => "MTConnectDevicesClass";
		
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
		public MTConnectDevicesClassProperties Properties { get; } = new MTConnectDevicesClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class MTConnectDevicesClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasHeaderPart,
				HasDevicePart,
			};
			/// <remarks>Original Name: HasHeader</remarks>
			public HasHeaderPartProperty HasHeaderPart { get; } = new HasHeaderPartProperty();
			public sealed class HasHeaderPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_08B1605D_39B4_4475_A436_A457B1D646A2</item>
				/// <item>Type: HeaderClass</item>
				/// <item>Namespace: Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument.HeaderClass);
				
				/// <inheritdoc />
				public string Name => "HasHeader";
				
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
				public string Association => "Header";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasDevice</remarks>
			public HasDevicePartProperty HasDevicePart { get; } = new HasDevicePartProperty();
			public sealed class HasDevicePartProperty : IProperty
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
				public string Name => "HasDevice";
				
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
				public string Association => "Devices";

				// Note: DefaultValue.Name
				/// <inheritdoc />
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