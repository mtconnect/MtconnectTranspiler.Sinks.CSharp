#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿<see cref="Observation">Observation</see> that provides the <i>condition</i> of a piece of equipment or a <i>Component</i>.<br /><br /><br /><br /><br />Description<br /><br />It provides the information and data reported from a piece of equipment with <see cref="DataItem.category">category in DataItem</see> as <c>CONDITION</c> in the <i>MTConnectDevices Response Document</i>.<br /><br />{{figure(Condition Example)}} shows <see cref="Condition">Condition</see> type examples for various <see cref="Condition.state">state in Condition</see>: <c>Normal</c> (<c>dataItemId</c> = <c>path_system</c>) and <c>Warning</c> (<c>dataItemId</c> = <c>logic_cond</c>). It also shows an example for when the <see cref="Condition.state">state in Condition</see> is not available (<c>dataItemId</c> = <c>cont_system</c>).<br /><br />![Condition Example](figures/Condition%20Example.png "Condition Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(condition-example)}} for the <i>XML</i> representation of the same example.<br /><br />The following <see cref="Value Properties of Condition">Value Properties of Condition</see> lists the additional and/or updated attributes for <see cref="Condition">Condition</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531113_85883_25726">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ConditionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566531113_85883_25726";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Observation)}} that provides the {{term(condition)}} of a piece of equipment or a {{term(Component)}}.

&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;It provides the information and data reported from a piece of equipment with {{property(DataItem::category)}} as `CONDITION` in the {{term(MTConnectDevices Response Document)}}.

{{figure(Condition Example)}} shows {{block(Condition)}} type examples for various {{property(Condition::state)}}: `Normal` (`dataItemId` = `path_system`) and `Warning` (`dataItemId` = `logic_cond`). It also shows an example for when the {{property(Condition::state)}} is not available (`dataItemId` = `cont_system`).

![Condition Example](figures/Condition%20Example.png ""Condition Example""){: width=""0.8""}

> Note: See {{lst(condition-example)}} for the {{term(XML)}} representation of the same example.

The following {{sect(Value Properties of Condition)}} lists the additional and/or updated attributes for {{block(Condition)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Condition";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579566531115_47734_25731
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationGeneralization);

		/// <inheritdoc />
		public new ConditionClassProperties Properties { get; } = new ConditionClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ConditionClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.ObservationGeneralization.ObservationGeneralizationProperties" />.
		/// </summary>
		public class ConditionClassProperties : Mtconnect.ObservationInformationModel.ObservationGeneralization.ObservationGeneralizationProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				NativeCode,
				NativeSeverity,
				Qualifier,
				Statistic,
				Xs_Lang,
				OrganizedByComponentStreamPart,
				State,
				Type,
				ConditionId,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="NativeCodeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NativeCode</remarks>
			/// </summary>
			public new NativeCodeProperty NativeCode { get; } = new NativeCodeProperty();
			
			/// <summary>﻿native code is the proprietary identifier designating a specific alarm, fault or warning code provided by the piece of equipment.<br /><br /><br />
			/// </summary>
			public new sealed class NativeCodeProperty : IProperty
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
				public string Name => "nativeCode";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;native code is the proprietary identifier designating a specific alarm, fault or warning code provided by the piece of equipment.&#10;
";

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
			public new NativeSeverityProperty NativeSeverity { get; } = new NativeSeverityProperty();
			
			/// <summary>﻿severity information to a client software application if the piece of equipment designates a severity level to a fault.<br /><br /><br />
			/// </summary>
			public new sealed class NativeSeverityProperty : IProperty
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
				public string Name => "nativeSeverity";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;severity information to a client software application if the piece of equipment designates a severity level to a fault.&#10;
";

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
			public new QualifierProperty Qualifier { get; } = new QualifierProperty();
			
			/// <summary>﻿additional information regarding a <i>condition state</i> associated with the measured value of a process variable.<br /><br /><see cref="Condition.qualifier">qualifier in Condition</see> defines whether the <i>condition state</i> represented indicates a measured value that is above or below an expected value of a process variable.<br /><br /><br />
			/// </summary>
			public new sealed class QualifierProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579566531117_877396_25735</item>
				/// <item>Type: QualifierEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.QualifierEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "qualifier";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;additional information regarding a {{term(condition state)}} associated with the measured value of a process variable.

{{property(Condition::qualifier)}} defines whether the {{term(condition state)}} represented indicates a measured value that is above or below an expected value of a process variable.&#10;
";

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
			public new StatisticProperty Statistic { get; } = new StatisticProperty();
			
			/// <summary>﻿<see cref="Condition.statistic">statistic in Condition</see> provides additional information describing the meaning of the <see cref="Condition">Condition</see> entity.<br /><br /><see cref="Condition.statistic">statistic in Condition</see> <b>MUST</b> match the <see cref="DataItem.statistic">statistic in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class StatisticProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_51F1600E_2F14_4045_86C0_42B336850079</item>
				/// <item>Type: StatisticEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.StatisticEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "statistic";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{property(Condition::statistic)}} provides additional information describing the meaning of the {{block(Condition)}} entity.

{{property(Condition::statistic)}} **MUST** match the {{property(DataItem::statistic)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";

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
			public new Xs_LangProperty Xs_Lang { get; } = new Xs_LangProperty();
			
			/// <summary>﻿specifies the language of the <see cref="Observation.result">result in Observation</see> returned for the <see cref="Condition">Condition</see>. <br /><br />See <seealso href="https://www.google.com/search?q=IETF RFC 4646&btnI=I">IETF RFC 4646</seealso> (http://www.ietf.org/rfc/rfc4646.txt).<br /><br /><br />
			/// </summary>
			public new sealed class Xs_LangProperty : IProperty
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
				public string Name => "xs:lang";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;specifies the language of the {{property(Observation::result)}} returned for the {{block(Condition)}}. 

See {{cite(IETF RFC 4646)}} (http://www.ietf.org/rfc/rfc4646.txt).&#10;
";

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
			public new OrganizedByComponentStreamPartProperty OrganizedByComponentStreamPart { get; } = new OrganizedByComponentStreamPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class OrganizedByComponentStreamPartProperty : IProperty
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
				public string Name => "organizedByComponentStream";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			public new StateProperty State { get; } = new StateProperty();
			
			/// <summary>﻿<i>condition state</i> of the piece of equipment or <see cref="Component">Component</see>.<br /><br /><br />
			/// </summary>
			public new sealed class StateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1633610276495_636137_441</item>
				/// <item>Type: ConditionStateEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.ConditionStateEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "state";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(condition state)}} of the piece of equipment or {{block(Component)}}.&#10;
";

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
			public new TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580398386435_855466_12827</item>
				/// <item>Type: ConditionEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.ConditionEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			public new ConditionIdProperty ConditionId { get; } = new ConditionIdProperty();
			
			/// <summary>﻿identifier of an individual <i>condition activation</i> provided by a piece of equipment.<br /><br /><see cref="Condition.conditionId">conditionId in Condition</see> <b>MUST</b> be unique for all concurrent {{termpl(condition activation)}}.<br /><br /><see cref="Condition.conditionId">conditionId in Condition</see> <b>MUST</b> be maintained for all state transitions related to the same <i>condition activation</i>.<br /><br />Multiple <see cref="Condition.conditionId">conditionId in Condition</see>s <b>MAY</b> exist for the same {{property(nativeCode)}}.<br /><br />If <see cref="Condition.conditionId">conditionId in Condition</see> is not given, the value is the <see cref="Condition.nativeCode">nativeCode in Condition</see>. If <see cref="Condition.nativeCode">nativeCode in Condition</see> and <see cref="Condition.conditionId">conditionId in Condition</see> are not given, <see cref="Condition.conditionId">conditionId in Condition</see> <b>MUST</b> be generated.<br /><br /><br />
			/// </summary>
			public new sealed class ConditionIdProperty : IProperty
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
				public string Name => "conditionId";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;identifier of an individual {{term(condition activation)}} provided by a piece of equipment.

{{property(Condition::conditionId)}} **MUST** be unique for all concurrent {{termpl(condition activation)}}.

{{property(Condition::conditionId)}} **MUST** be maintained for all state transitions related to the same {{term(condition activation)}}.

Multiple {{property(Condition::conditionId)}}s **MAY** exist for the same {{property(nativeCode)}}.

If {{property(Condition::conditionId)}} is not given, the value is the {{property(Condition::nativeCode)}}. If {{property(Condition::nativeCode)}} and {{property(Condition::conditionId)}} are not given, {{property(Condition::conditionId)}} **MUST** be generated.&#10;
";

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