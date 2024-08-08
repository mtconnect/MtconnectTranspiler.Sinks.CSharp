using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Component Types::Axis">Component Types::Axis</see> that provides rotation about a fixed axis.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class RotaryClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382015_53595_42288";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component Types::Axis"">Component Types::Axis</see> that provides rotation about a fixed axis.";

		/// <inheritdoc />
		public string Name => "RotaryClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572381972_553005_42207";

		/// <inheritdoc />
		public RotaryClassProperties Properties { get; } = new RotaryClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class RotaryClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesLoad,
				ObservesTemperature,
				ObservesRotaryVelocity,
				ObservesAxisFeedrate,
			};
			/// <summary>
			/// <inheritdoc cref="ObservesLoadProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesLoad</remarks>
			/// </summary>
			public ObservesLoadProperty ObservesLoad { get; } = new ObservesLoadProperty();
			public sealed class ObservesLoadProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218342_32796_1902</item>
				/// <item>Type: LoadClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.LoadClass);
				
				/// <inheritdoc />
				public string Name => "ObservesLoad";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component Types::Axis"">Component Types::Axis</see> that provides rotation about a fixed axis.";

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
			/// <inheritdoc cref="ObservesTemperatureProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesTemperature</remarks>
			/// </summary>
			public ObservesTemperatureProperty ObservesTemperature { get; } = new ObservesTemperatureProperty();
			public sealed class ObservesTemperatureProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218451_953222_2205</item>
				/// <item>Type: TemperatureClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.TemperatureClass);
				
				/// <inheritdoc />
				public string Name => "ObservesTemperature";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component Types::Axis"">Component Types::Axis</see> that provides rotation about a fixed axis.";

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
			/// <inheritdoc cref="ObservesRotaryVelocityProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesRotaryVelocity</remarks>
			/// </summary>
			public ObservesRotaryVelocityProperty ObservesRotaryVelocity { get; } = new ObservesRotaryVelocityProperty();
			public sealed class ObservesRotaryVelocityProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218436_532649_2148</item>
				/// <item>Type: RotaryVelocityClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.RotaryVelocityClass);
				
				/// <inheritdoc />
				public string Name => "ObservesRotaryVelocity";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component Types::Axis"">Component Types::Axis</see> that provides rotation about a fixed axis.";

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
			/// <inheritdoc cref="ObservesAxisFeedrateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesAxisFeedrate</remarks>
			/// </summary>
			public ObservesAxisFeedrateProperty ObservesAxisFeedrate { get; } = new ObservesAxisFeedrateProperty();
			public sealed class ObservesAxisFeedrateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218186_884374_1560</item>
				/// <item>Type: AxisFeedrateClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.AxisFeedrateClass);
				
				/// <inheritdoc />
				public string Name => "ObservesAxisFeedrate";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component Types::Axis"">Component Types::Axis</see> that provides rotation about a fixed axis.";

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