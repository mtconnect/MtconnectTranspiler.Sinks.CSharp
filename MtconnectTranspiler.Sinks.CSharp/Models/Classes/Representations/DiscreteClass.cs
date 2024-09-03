#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>﻿<b>DEPRECATED</b> <see cref="Representation">Representation</see> for an <see cref="Observation">Observation</see> where each discrete occurrence of the data may have the same value as the previous occurrence of the data.<br /><br /><br /><br />Description<br /><br /><br /><see cref="Discrete">Discrete</see> for an <see cref="Observation">Observation</see> is defined by the associated <see cref="DataItem.representation">representation in DataItem</see> as <c>DISCRETE</c>.<br /><br /><see cref="DataItem.representation">representation in DataItem</see> as <c>DISCRETE</c> <b>MUST</b> have <see cref="DataItem.category">category in DataItem</see> as <c>EVENT</c>.<br /><br /><i>MTConnect Version 1.5</i> replaced <see cref="DataItem.representation">representation in DataItem</see> as <c>DISCRETE</c> with <see cref="DataItem.discrete">discrete in DataItem</see>.<br /><br />Each occurrence of the <see cref="Observation">Observation</see> <b>MAY</b> have the same value as the previous occurrence, and <b>MUST NOT</b> suppress duplicates.<br /><br />Examples of <see cref="Discrete">Discrete</see>: A <c>PartCount</c> reporting the completion of each part using a 1 to indicate completion of a single part, a <c>Message</c> that occurs each time a door opens. <br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531114_595827_25728">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.5 according to https://model.mtconnect.org/#_Version_1.5")]

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DiscreteClass : IClass
	{
		/// <summary>Constant value for <see cref="DiscreteClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579566531114_595827_25728";
		/// <summary>Constant value for <see cref="DiscreteClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531114_595827_25728";
		/// <summary>Constant value for <see cref="DiscreteClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;**DEPRECATED** {{block(Representation)}} for an {{block(Observation)}} where each discrete occurrence of the data may have the same value as the previous occurrence of the data.
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;
{{block(Discrete)}} for an {{block(Observation)}} is defined by the associated {{property(DataItem::representation)}} as `DISCRETE`.

{{property(DataItem::representation)}} as `DISCRETE` **MUST** have {{property(DataItem::category)}} as `EVENT`.

*MTConnect Version 1.5* replaced {{property(DataItem::representation)}} as `DISCRETE` with {{property(DataItem::discrete)}}.

Each occurrence of the {{block(Observation)}} **MAY** have the same value as the previous occurrence, and **MUST NOT** suppress duplicates.

Examples of {{block(Discrete)}}: A `PartCount` reporting the completion of each part using a 1 to indicate completion of a single part, a `Message` that occurs each time a door opens. &#10;
";
		/// <summary>Constant value for <see cref="DiscreteClass.Name" /></summary>
		public const string NAME = "Discrete";
		/// <summary>Constant value for <see cref="DiscreteClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DiscreteClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DiscreteClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.3";
		/// <summary>Constant value for <see cref="DiscreteClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "1.5";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
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
				/// <summary>Constant value for <see cref="ResultProperty.Name" /></summary>
				public const string NAME = "result";
				/// <summary>Constant value for <see cref="ResultProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ResultProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ResultProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ResultProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.3";
				/// <summary>Constant value for <see cref="ResultProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "1.5";
				/// <summary>Constant value for <see cref="ResultProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="ResultProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="ResultProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ResultProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
		};

	}
}