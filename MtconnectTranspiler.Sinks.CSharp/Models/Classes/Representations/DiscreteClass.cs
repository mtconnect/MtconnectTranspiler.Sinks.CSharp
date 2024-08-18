#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>﻿<b>DEPRECATED</b> <see cref="Representation">Representation</see> for an <see cref="Observation">Observation</see> where each discrete occurrence of the data may have the same value as the previous occurrence of the data.<br /><br /><br /><br />Description<br /><br /><br /><see cref="Discrete">Discrete</see> for an <see cref="Observation">Observation</see> is defined by the associated <see cref="DataItem.representation">representation in DataItem</see> as <c>DISCRETE</c>.<br /><br /><see cref="DataItem.representation">representation in DataItem</see> as <c>DISCRETE</c> <b>MUST</b> have <see cref="DataItem.category">category in DataItem</see> as <c>EVENT</c>.<br /><br /><i>MTConnect Version 1.5</i> replaced <see cref="DataItem.representation">representation in DataItem</see> as <c>DISCRETE</c> with <see cref="DataItem.discrete">discrete in DataItem</see>.<br /><br />Each occurrence of the <see cref="Observation">Observation</see> <b>MAY</b> have the same value as the previous occurrence, and <b>MUST NOT</b> suppress duplicates.<br /><br />Examples of <see cref="Discrete">Discrete</see>: A <c>PartCount</c> reporting the completion of each part using a 1 to indicate completion of a single part, a <c>Message</c> that occurs each time a door opens. <br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531114_595827_25728">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DiscreteClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566531114_595827_25728";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;**DEPRECATED** {{block(Representation)}} for an {{block(Observation)}} where each discrete occurrence of the data may have the same value as the previous occurrence of the data.
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;
{{block(Discrete)}} for an {{block(Observation)}} is defined by the associated {{property(DataItem::representation)}} as `DISCRETE`.

{{property(DataItem::representation)}} as `DISCRETE` **MUST** have {{property(DataItem::category)}} as `EVENT`.

*MTConnect Version 1.5* replaced {{property(DataItem::representation)}} as `DISCRETE` with {{property(DataItem::discrete)}}.

Each occurrence of the {{block(Observation)}} **MAY** have the same value as the previous occurrence, and **MUST NOT** suppress duplicates.

Examples of {{block(Discrete)}}: A `PartCount` reporting the completion of each part using a 1 to indicate completion of a single part, a `Message` that occurs each time a door opens. &#10;
";

		/// <inheritdoc />
		public string Name => "Discrete";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "1.5";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1633615188301_96457_1251
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.Representations.RepresentationClass);

		/// <inheritdoc />
		public new DiscreteClassProperties Properties { get; } = new DiscreteClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DiscreteClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.RepresentationClass.RepresentationClassProperties" />.
		/// </summary>
		public class DiscreteClassProperties : Mtconnect.ObservationInformationModel.Representations.RepresentationClass.RepresentationClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Result,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public new ResultProperty Result { get; } = new ResultProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ResultProperty : IProperty
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
				public string Name => "result";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.3";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "1.5";
				
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
		};

	}
}