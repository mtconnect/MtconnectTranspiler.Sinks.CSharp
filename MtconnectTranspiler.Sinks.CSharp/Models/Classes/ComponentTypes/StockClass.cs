using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Material">Material</see> that is used in a manufacturing process and to which work is applied in a machine or piece of equipment to produce parts./// Description
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382018_505205_42294">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class StockClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382018_505205_42294";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Material"">Material</see> that is used in a manufacturing process and to which work is applied in a machine or piece of equipment to produce parts./// Description";

		/// <inheritdoc />
		public string Name => "Stock";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572382002_513291_42264
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.MaterialClass);

		/// <inheritdoc />
		public StockClassProperties Properties { get; } = new StockClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class StockClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.MaterialClass.MaterialClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesMaterial,
				ObservesLengthRemaining,
				ObservesLengthStandard,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ObservesMaterialProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesMaterial</remarks>
			/// </summary>
			public ObservesMaterialProperty ObservesMaterial { get; } = new ObservesMaterialProperty();
			public sealed class ObservesMaterialProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218345_971688_1908</item>
				/// <item>Type: MaterialClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.MaterialClass);
				
				/// <inheritdoc />
				public string Name => "observesMaterial";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Material"">Material</see> that is used in a manufacturing process and to which work is applied in a machine or piece of equipment to produce parts./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="ObservesLengthRemainingProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesLengthRemaining</remarks>
			/// </summary>
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
				public string Name => "observesLengthRemaining";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Material"">Material</see> that is used in a manufacturing process and to which work is applied in a machine or piece of equipment to produce parts./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="ObservesLengthStandardProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesLengthStandard</remarks>
			/// </summary>
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
				public string Name => "observesLengthStandard";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Material"">Material</see> that is used in a manufacturing process and to which work is applied in a machine or piece of equipment to produce parts./// Description";

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
			}
		};

	}
}