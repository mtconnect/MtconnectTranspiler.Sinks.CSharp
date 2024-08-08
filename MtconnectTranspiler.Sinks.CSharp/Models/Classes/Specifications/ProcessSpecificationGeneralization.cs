using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Configurations.Specifications
{
	/// <summary>
	/// <see cref="Specification">Specification</see> that provides information used to assess the conformance of a variable to process requirements.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ProcessSpecificationGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605643801279_773776_859";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Specification"">Specification</see> that provides information used to assess the conformance of a variable to process requirements.";

		/// <inheritdoc />
		public string Name => "ProcessSpecificationGeneralization";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1580315898400_607214_47155";

		/// <inheritdoc />
		public ProcessSpecificationGeneralizationProperties Properties { get; } = new ProcessSpecificationGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ProcessSpecificationGeneralizationProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasSpecificationLimitsPart,
				HasControlLimitsPart,
				HasAlarmLimitsPart,
			};
			/// <summary>
			/// <inheritdoc cref="HasSpecificationLimitsPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasSpecificationLimits</remarks>
			/// </summary>
			public HasSpecificationLimitsPartProperty HasSpecificationLimitsPart { get; } = new HasSpecificationLimitsPartProperty();
			public sealed class HasSpecificationLimitsPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605643883082_895051_1004</item>
				/// <item>Type: SpecificationLimitsClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.SpecificationLimitsClass);
				
				/// <inheritdoc />
				public string Name => "HasSpecificationLimits";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Specification"">Specification</see> that provides information used to assess the conformance of a variable to process requirements.";

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
				public string Association => "SpecificationLimits";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasControlLimitsPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasControlLimits</remarks>
			/// </summary>
			public HasControlLimitsPartProperty HasControlLimitsPart { get; } = new HasControlLimitsPartProperty();
			public sealed class HasControlLimitsPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605643876416_54094_959</item>
				/// <item>Type: ControlLimitsClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ControlLimitsClass);
				
				/// <inheritdoc />
				public string Name => "HasControlLimits";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Specification"">Specification</see> that provides information used to assess the conformance of a variable to process requirements.";

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
				public string Association => "ControlLimits";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasAlarmLimitsPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAlarmLimits</remarks>
			/// </summary>
			public HasAlarmLimitsPartProperty HasAlarmLimitsPart { get; } = new HasAlarmLimitsPartProperty();
			public sealed class HasAlarmLimitsPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605643893577_939623_1049</item>
				/// <item>Type: AlarmLimitsClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.AlarmLimitsClass);
				
				/// <inheritdoc />
				public string Name => "HasAlarmLimits";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Specification"">Specification</see> that provides information used to assess the conformance of a variable to process requirements.";

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
				public string Association => "AlarmLimits";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}