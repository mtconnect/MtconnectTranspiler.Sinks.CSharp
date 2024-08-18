#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>﻿<i>key-value pair</i> published as part of a <see cref="DataSet">DataSet</see>.<br /><br /><br />Constraints for Entry Values<br /><br />#### Constraints for Entry Values<br /><br />The value of each <see cref="Entry">Entry</see> <b>MUST</b> have the same restrictions as the value of an <i>observation</i> with <see cref="DataItem.representation">representation in DataItem</see> as <c>VALUE</c>.<br /><br />An <see cref="Entry">Entry</see> <b>MAY</b> be further constrained by the <see cref="DataItem">DataItem</see> definition (see <see cref="Device Information Model">Device Information Model</see>), for example a <c>VariableDataSet</c> having a string value <b>MAY</b> have a floating-point <see cref="Temperature">Temperature</see> value. A restriction <b>MUST NOT</b> be broadened or removed, for example, the value "READY" <b>MUST NOT</b> occur with a <c>TemperatureDataSet</c> constrained to floating-point numbers.<br /><br /><see cref="EntryDefinition">EntryDefinition</see> <b>MAY</b> provide the type and units of an <see cref="Entry.key">key in Entry</see>.<br /><br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531114_364030_25729">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EntryClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566531114_364030_25729";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(key-value pair)}} published as part of a {{block(DataSet)}}.&#10;
&#10;&#10;&#10;Constraints for Entry Values&#10;&#10;&#10;&#10;#### Constraints for Entry Values

The value of each {{block(Entry)}} **MUST** have the same restrictions as the value of an {{term(observation)}} with {{property(DataItem::representation)}} as `VALUE`.

An {{block(Entry)}} **MAY** be further constrained by the {{block(DataItem)}} definition (see {{package(Device Information Model)}}), for example a `VariableDataSet` having a string value **MAY** have a floating-point {{block(Temperature)}} value. A restriction **MUST NOT** be broadened or removed, for example, the value ""READY"" **MUST NOT** occur with a `TemperatureDataSet` constrained to floating-point numbers.

{{block(EntryDefinition)}} **MAY** provide the type and units of an {{property(Entry::key)}}.
&#10;
";

		/// <inheritdoc />
		public string Name => "Entry";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.5";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new EntryClassProperties Properties { get; } = new EntryClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="EntryClass" />.
		/// </summary>
		public class EntryClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Key,
				Removed,
				IsEntryForPart,
				Result,
			};
			/// <summary>
			/// <inheritdoc cref="KeyProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Key</remarks>
			/// </summary>
			public KeyProperty Key { get; } = new KeyProperty();
			
			/// <summary>﻿unique identifier for each <i>key-value pair</i>.<br /><br /><br />
			/// </summary>
			public sealed class KeyProperty : IProperty
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
				public string Name => "key";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;unique identifier for each {{term(key-value pair)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.5";
				
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
			/// <inheritdoc cref="RemovedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Removed</remarks>
			/// </summary>
			public RemovedProperty Removed { get; } = new RemovedProperty();
			
			/// <summary>﻿removal indicator of a <i>key-value pair</i>.<br /><br /><br />
			/// </summary>
			public sealed class RemovedProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579278876899_683310_3821</item>
				/// <item>Type: Boolean</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
				/// <inheritdoc />
				public string Name => "removed";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;removal indicator of a {{term(key-value pair)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.5";
				
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
			/// <inheritdoc cref="IsEntryForPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsEntryFor</remarks>
			/// </summary>
			public IsEntryForPartProperty IsEntryForPart { get; } = new IsEntryForPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class IsEntryForPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579566531114_503405_25727</item>
				/// <item>Type: DataSetClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.Representations</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.Representations.DataSetClass);
				
				/// <inheritdoc />
				public string Name => "isEntryFor";
				
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
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "Entry";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public ResultProperty Result { get; } = new ResultProperty();
			
			/// <summary>﻿value of the <see cref="Entry">Entry</see>.<br /><br /><br />
			/// </summary>
			public sealed class ResultProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;value of the {{block(Entry)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.5";
				
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
		};

	}
}