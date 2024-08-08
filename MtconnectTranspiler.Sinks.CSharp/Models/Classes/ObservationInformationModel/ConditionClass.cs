using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;
// using Mtconnect.ObservationInformationModel;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>
	/// <see cref="Observation">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.  /// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ConditionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566531113_85883_25726";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Observation"">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.  /// Description";

		/// <inheritdoc />
		public string Name => "ConditionClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579566531115_47734_25731";

		/// <inheritdoc />
		public ConditionClassProperties Properties { get; } = new ConditionClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ConditionClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				NativeCode,
				NativeSeverity,
				Qualifier,
				Statistic,
				Xs_Lang,
				OrganizedByComponentStreamPart,
				State,
				Type,
				ConditionId,
			};
			/// <summary>
			/// <inheritdoc cref="NativeCodeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NativeCode</remarks>
			/// </summary>
			public NativeCodeProperty NativeCode { get; } = new NativeCodeProperty();
			/// <summary>
			/// native code is the proprietary identifier designating a specific alarm, fault or warning code provided by the piece of equipment.
			/// </summary>
			public sealed class NativeCodeProperty : IProperty
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
				public string Name => "NativeCode";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Observation"">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.  /// Description";

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
			/// <inheritdoc cref="NativeSeverityProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NativeSeverity</remarks>
			/// </summary>
			public NativeSeverityProperty NativeSeverity { get; } = new NativeSeverityProperty();
			/// <summary>
			/// severity information to a client software application if the piece of equipment designates a severity level to a fault.
			/// </summary>
			public sealed class NativeSeverityProperty : IProperty
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
				public string Name => "NativeSeverity";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Observation"">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.  /// Description";

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
			/// <inheritdoc cref="QualifierProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Qualifier</remarks>
			/// </summary>
			public QualifierProperty Qualifier { get; } = new QualifierProperty();
			/// <summary>
			/// additional information regarding a <i>condition state</i> associated with the measured value of a process variable.  <see cref="Condition::qualifier" /> defines whether the <i>condition state</i> represented indicates a measured value that is above or below an expected value of a process variable.
			/// </summary>
			public sealed class QualifierProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579566531117_877396_25735</item>
				/// <item>Type: QualifierEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.QualifierEnum);
				
				/// <inheritdoc />
				public string Name => "Qualifier";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Observation"">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.  /// Description";

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
			/// <inheritdoc cref="StatisticProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Statistic</remarks>
			/// </summary>
			public StatisticProperty Statistic { get; } = new StatisticProperty();
			/// <summary>
			/// <see cref="Condition::statistic" /> provides additional information describing the meaning of the <see cref="Condition">Condition</see> entity.  <see cref="Condition::statistic" /> <b>MUST</b> match the <see cref="DataItem::statistic" /> defined in the <i>MTConnectDevices Response Document</i>.
			/// </summary>
			public sealed class StatisticProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_51F1600E_2F14_4045_86C0_42B336850079</item>
				/// <item>Type: StatisticEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.StatisticEnum);
				
				/// <inheritdoc />
				public string Name => "Statistic";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Observation"">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.  /// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
			/// <inheritdoc cref="Xs_LangProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Xs:Lang</remarks>
			/// </summary>
			public Xs_LangProperty Xs_Lang { get; } = new Xs_LangProperty();
			/// <summary>
			/// specifies the language of the <see cref="Observation::result" /> returned for the <see cref="Condition">Condition</see>.   See <seealso href="https://www.google.com/search?q=IETF RFC 4646&btnI=I">IETF RFC 4646</seealso> (http://www.ietf.org/rfc/rfc4646.txt).
			/// </summary>
			public sealed class Xs_LangProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579298295798_975011_6970</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "Xs:Lang";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Observation"">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.  /// Description";

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
			/// <inheritdoc cref="OrganizedByComponentStreamPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizedByComponentStream</remarks>
			/// </summary>
			public OrganizedByComponentStreamPartProperty OrganizedByComponentStreamPart { get; } = new OrganizedByComponentStreamPartProperty();
			public sealed class OrganizedByComponentStreamPartProperty : IProperty
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
				public string Name => "OrganizedByComponentStream";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Observation"">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.  /// Description";

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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Conditions";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="StateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: State</remarks>
			/// </summary>
			public StateProperty State { get; } = new StateProperty();
			/// <summary>
			/// <i>condition state</i> of the piece of equipment or <see cref="Component">Component</see>.
			/// </summary>
			public sealed class StateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1633610276495_636137_441</item>
				/// <item>Type: ConditionStateEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.ConditionStateEnum);
				
				/// <inheritdoc />
				public string Name => "State";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Observation"">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.  /// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.1";
				
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
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580398386435_855466_12827</item>
				/// <item>Type: ConditionEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.ConditionEnum);
				
				/// <inheritdoc />
				public string Name => "Type";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Observation"">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.  /// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.1";
				
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
			/// <inheritdoc cref="ConditionIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ConditionId</remarks>
			/// </summary>
			public ConditionIdProperty ConditionId { get; } = new ConditionIdProperty();
			/// <summary>
			/// identifier of an individual <i>condition activation</i> provided by a piece of equipment.  <see cref="Condition::conditionId" /> <b>MUST</b> be unique for all concurrent {{termpl(condition activation)}}.  <see cref="Condition::conditionId" /> <b>MUST</b> be maintained for all state transitions related to the same <i>condition activation</i>.  Multiple <see cref="Condition::conditionId" />s <b>MAY</b> exist for the same <see cref="nativeCode" />.  If <see cref="Condition::conditionId" /> is not given, the value is the <see cref="Condition::nativeCode" />. If <see cref="Condition::nativeCode" /> and <see cref="Condition::conditionId" /> are not given, <see cref="Condition::conditionId" /> <b>MUST</b> be generated.
			/// </summary>
			public sealed class ConditionIdProperty : IProperty
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
				public string Name => "ConditionId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Observation"">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.  /// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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