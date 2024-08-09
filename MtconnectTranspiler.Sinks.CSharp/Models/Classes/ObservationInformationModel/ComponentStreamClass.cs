using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>
	/// organizes the data associated with each <see cref="Component">Component</see> entity defined for a <see cref="Device">Device</see> in the associated <i>MTConnectDevices Response Document</i>./// Description
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_9057AAF9_4687_42be_BD2B_E2F18DF049DC">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ComponentStreamClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_9057AAF9_4687_42be_BD2B_E2F18DF049DC";
		
		/// <inheritdoc />
		public string Summary => @"/// organizes the data associated with each <see cref=""Component"">Component</see> entity defined for a <see cref=""Device"">Device</see> in the associated <i>MTConnectDevices Response Document</i>./// Description";

		/// <inheritdoc />
		public string Name => "ComponentStream";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public ComponentStreamClassProperties Properties { get; } = new ComponentStreamClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ComponentStreamClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Component,
				ComponentId,
				Name,
				NativeName,
				Uuid,
				OrganizesEventPart,
				OrganizesSamplePart,
				OrganizesConditionPart,
				IsOrganizerForPart,
			};
			/// <summary>
			/// <inheritdoc cref="ComponentProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Component</remarks>
			/// </summary>
			public ComponentProperty Component { get; } = new ComponentProperty();
			/// <summary>
			/// identifies the <see cref="Component">Component</see> type associated with the <see cref="ComponentStream">ComponentStream</see>.  Examples of <see cref="ComponentStream::component" /> are <see cref="Device">Device</see>, <see cref="Controller">Controller</see>, <see cref="Linear">Linear</see> and <see cref="Loader">Loader</see>.
			/// </summary>
			public sealed class ComponentProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "component";
				
				/// <inheritdoc />
				public string Summary => @"/// organizes the data associated with each <see cref=""Component"">Component</see> entity defined for a <see cref=""Device"">Device</see> in the associated <i>MTConnectDevices Response Document</i>./// Description";

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
			/// <inheritdoc cref="ComponentIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ComponentId</remarks>
			/// </summary>
			public ComponentIdProperty ComponentId { get; } = new ComponentIdProperty();
			/// <summary>
			/// identifier of the <see cref="Component">Component</see> as defined by the <see cref="Component::id" /> in the <i>MTConnectDevices Response Document</i>.
			/// </summary>
			public sealed class ComponentIdProperty : IProperty
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
				public string Name => "componentId";
				
				/// <inheritdoc />
				public string Summary => @"/// organizes the data associated with each <see cref=""Component"">Component</see> entity defined for a <see cref=""Device"">Device</see> in the associated <i>MTConnectDevices Response Document</i>./// Description";

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
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			/// <summary>
			/// name of the <see cref="Component">Component</see> associated with the <see cref="ComponentStream">ComponentStream</see>.
			/// </summary>
			public sealed class NameProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "name";
				
				/// <inheritdoc />
				public string Summary => @"/// organizes the data associated with each <see cref=""Component"">Component</see> entity defined for a <see cref=""Device"">Device</see> in the associated <i>MTConnectDevices Response Document</i>./// Description";

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
			/// <inheritdoc cref="NativeNameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NativeName</remarks>
			/// </summary>
			public NativeNameProperty NativeName { get; } = new NativeNameProperty();
			/// <summary>
			/// common name of the <see cref="Component">Component</see> associated with the <see cref="ComponentStream">ComponentStream</see>.
			/// </summary>
			public sealed class NativeNameProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "nativeName";
				
				/// <inheritdoc />
				public string Summary => @"/// organizes the data associated with each <see cref=""Component"">Component</see> entity defined for a <see cref=""Device"">Device</see> in the associated <i>MTConnectDevices Response Document</i>./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.1";
				
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
			/// uuid of the <see cref="Component">Component</see> associated with the <see cref="ComponentStream">ComponentStream</see>.
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
				public string Name => "uuid";
				
				/// <inheritdoc />
				public string Summary => @"/// organizes the data associated with each <see cref=""Component"">Component</see> entity defined for a <see cref=""Device"">Device</see> in the associated <i>MTConnectDevices Response Document</i>./// Description";

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
			/// <inheritdoc cref="OrganizesEventPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizesEvent</remarks>
			/// </summary>
			public OrganizesEventPartProperty OrganizesEventPart { get; } = new OrganizesEventPartProperty();
			public sealed class OrganizesEventPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579566531115_47447_25730</item>
				/// <item>Type: EventClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.EventClass);
				
				/// <inheritdoc />
				public string Name => "organizesEvent";
				
				/// <inheritdoc />
				public string Summary => @"/// organizes the data associated with each <see cref=""Component"">Component</see> entity defined for a <see cref=""Device"">Device</see> in the associated <i>MTConnectDevices Response Document</i>./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "shared";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Events";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="OrganizesSamplePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizesSample</remarks>
			/// </summary>
			public OrganizesSamplePartProperty OrganizesSamplePart { get; } = new OrganizesSamplePartProperty();
			public sealed class OrganizesSamplePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579566531116_175117_25733</item>
				/// <item>Type: SampleClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.SampleClass);
				
				/// <inheritdoc />
				public string Name => "organizesSample";
				
				/// <inheritdoc />
				public string Summary => @"/// organizes the data associated with each <see cref=""Component"">Component</see> entity defined for a <see cref=""Device"">Device</see> in the associated <i>MTConnectDevices Response Document</i>./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "shared";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Samples";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="OrganizesConditionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizesCondition</remarks>
			/// </summary>
			public OrganizesConditionPartProperty OrganizesConditionPart { get; } = new OrganizesConditionPartProperty();
			public sealed class OrganizesConditionPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579566531113_85883_25726</item>
				/// <item>Type: ConditionClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ConditionClass);
				
				/// <inheritdoc />
				public string Name => "organizesCondition";
				
				/// <inheritdoc />
				public string Summary => @"/// organizes the data associated with each <see cref=""Component"">Component</see> entity defined for a <see cref=""Device"">Device</see> in the associated <i>MTConnectDevices Response Document</i>./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "shared";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Conditions";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="IsOrganizerForPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsOrganizerFor</remarks>
			/// </summary>
			public IsOrganizerForPartProperty IsOrganizerForPart { get; } = new IsOrganizerForPartProperty();
			public sealed class IsOrganizerForPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779</item>
				/// <item>Type: ComponentGeneralization</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);
				
				/// <inheritdoc />
				public string Name => "isOrganizerFor";
				
				/// <inheritdoc />
				public string Summary => @"/// organizes the data associated with each <see cref=""Component"">Component</see> entity defined for a <see cref=""Device"">Device</see> in the associated <i>MTConnectDevices Response Document</i>./// Description";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

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

		# region Rules
		/// <summary>
		/// ComponentStream1
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string ComponentStream1 => @"self.organizesEvent->size() <> 0 or self.organizesSample->size() <> 0 or self.organizesCondition->size() <> 0";
		/*
		self.organizesEvent->size() <> 0 or self.organizesSample->size() <> 0 or self.organizesCondition->size() <> 0
		*/
		# endregion
	}
}