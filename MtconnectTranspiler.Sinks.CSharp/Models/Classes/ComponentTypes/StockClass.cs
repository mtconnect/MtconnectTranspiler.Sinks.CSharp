using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.AssetInformationModel.RawMaterial;
// using Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class StockClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382018_505205_42294";
		
		/// <inheritdoc />
		public string Name => "StockClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572382002_513291_42264";

		/// <inheritdoc />
		public StockClassProperties Properties { get; } = new StockClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class StockClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesMaterial,
				ObservesLengthRemaining,
				ObservesLengthStandard,
			};
			/// <remarks>Original Name: ObservesMaterial</remarks>
			public ObservesMaterialProperty ObservesMaterial { get; } = new ObservesMaterialProperty();
			public sealed class ObservesMaterialProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218345_971688_1908</item>
				/// <item>Type: MaterialClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.RawMaterial</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.RawMaterial.MaterialClass);
				
				/// <inheritdoc />
				public string Name => "ObservesMaterial";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesLengthRemaining</remarks>
			public ObservesLengthRemainingProperty ObservesLengthRemaining { get; } = new ObservesLengthRemainingProperty();
			public sealed class ObservesLengthRemainingProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218329_303079_1869</item>
				/// <item>Type: Length.RemainingClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.LengthRemainingClass);
				
				/// <inheritdoc />
				public string Name => "ObservesLengthRemaining";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesLengthStandard</remarks>
			public ObservesLengthStandardProperty ObservesLengthStandard { get; } = new ObservesLengthStandardProperty();
			public sealed class ObservesLengthStandardProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218327_469818_1866</item>
				/// <item>Type: Length.StandardClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.LengthStandardClass);
				
				/// <inheritdoc />
				public string Name => "ObservesLengthStandard";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}