using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Part">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description/// Example
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PartOccurrenceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605547467172_656422_264";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Part"">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description/// Example";

		/// <inheritdoc />
		public string Name => "PartOccurrenceClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1622456766067_72580_282";

		/// <inheritdoc />
		public PartOccurrenceClassProperties Properties { get; } = new PartOccurrenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class PartOccurrenceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesPartId,
				ObservesPartUniqueId,
				ObservesPartGroupId,
				ObservesPartKindId,
				ObservesPartCount,
				ObservesPartStatus,
				ObservesProcessOccurrenceId,
				ObservesProcessTime,
				ObservesUser,
			};
			/// <summary>
			/// <inheritdoc cref="ObservesPartIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartId</remarks>
			/// </summary>
			public ObservesPartIdProperty ObservesPartId { get; } = new ObservesPartIdProperty();
			public sealed class ObservesPartIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218372_674466_1974</item>
				/// <item>Type: PartIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartIdClass);
				
				/// <inheritdoc />
				public string Name => "ObservesPartId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Part"">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description/// Example";

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
			/// <inheritdoc cref="ObservesPartUniqueIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartUniqueId</remarks>
			/// </summary>
			public ObservesPartUniqueIdProperty ObservesPartUniqueId { get; } = new ObservesPartUniqueIdProperty();
			public sealed class ObservesPartUniqueIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549240508_290295_764</item>
				/// <item>Type: PartUniqueIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartUniqueIdClass);
				
				/// <inheritdoc />
				public string Name => "ObservesPartUniqueId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Part"">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description/// Example";

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
			/// <inheritdoc cref="ObservesPartGroupIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartGroupId</remarks>
			/// </summary>
			public ObservesPartGroupIdProperty ObservesPartGroupId { get; } = new ObservesPartGroupIdProperty();
			public sealed class ObservesPartGroupIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605548793581_13403_454</item>
				/// <item>Type: PartGroupIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartGroupIdClass);
				
				/// <inheritdoc />
				public string Name => "ObservesPartGroupId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Part"">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description/// Example";

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
			/// <inheritdoc cref="ObservesPartKindIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartKindId</remarks>
			/// </summary>
			public ObservesPartKindIdProperty ObservesPartKindId { get; } = new ObservesPartKindIdProperty();
			public sealed class ObservesPartKindIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549230052_910367_748</item>
				/// <item>Type: PartKindIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartKindIdClass);
				
				/// <inheritdoc />
				public string Name => "ObservesPartKindId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Part"">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description/// Example";

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
			/// <inheritdoc cref="ObservesPartCountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartCount</remarks>
			/// </summary>
			public ObservesPartCountProperty ObservesPartCount { get; } = new ObservesPartCountProperty();
			public sealed class ObservesPartCountProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218363_437912_1953</item>
				/// <item>Type: PartCountClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartCountClass);
				
				/// <inheritdoc />
				public string Name => "ObservesPartCount";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Part"">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description/// Example";

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
			/// <inheritdoc cref="ObservesPartStatusProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartStatus</remarks>
			/// </summary>
			public ObservesPartStatusProperty ObservesPartStatus { get; } = new ObservesPartStatusProperty();
			public sealed class ObservesPartStatusProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549230538_92395_756</item>
				/// <item>Type: PartStatusClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartStatusClass);
				
				/// <inheritdoc />
				public string Name => "ObservesPartStatus";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Part"">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description/// Example";

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
			/// <inheritdoc cref="ObservesProcessOccurrenceIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProcessOccurrenceId</remarks>
			/// </summary>
			public ObservesProcessOccurrenceIdProperty ObservesProcessOccurrenceId { get; } = new ObservesProcessOccurrenceIdProperty();
			public sealed class ObservesProcessOccurrenceIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549692001_598671_1420</item>
				/// <item>Type: ProcessOccurrenceIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProcessOccurrenceIdClass);
				
				/// <inheritdoc />
				public string Name => "ObservesProcessOccurrenceId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Part"">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description/// Example";

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
			/// <inheritdoc cref="ObservesProcessTimeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProcessTime</remarks>
			/// </summary>
			public ObservesProcessTimeProperty ObservesProcessTime { get; } = new ObservesProcessTimeProperty();
			public sealed class ObservesProcessTimeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218411_953996_2079</item>
				/// <item>Type: ProcessTimeClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProcessTimeClass);
				
				/// <inheritdoc />
				public string Name => "ObservesProcessTime";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Part"">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description/// Example";

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
			/// <inheritdoc cref="ObservesUserProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesUser</remarks>
			/// </summary>
			public ObservesUserProperty ObservesUser { get; } = new ObservesUserProperty();
			public sealed class ObservesUserProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218462_589955_2238</item>
				/// <item>Type: UserClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.UserClass);
				
				/// <inheritdoc />
				public string Name => "ObservesUser";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Part"">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description/// Example";

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