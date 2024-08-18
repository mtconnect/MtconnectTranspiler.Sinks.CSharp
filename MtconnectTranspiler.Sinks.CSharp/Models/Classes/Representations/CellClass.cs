#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>﻿<i>key-value pair</i> published as part of a <see cref="TableEntry">TableEntry</see>.<br /><br /><br />Constraints for Cell Values<br /><br />#### Constraints for Cell Values<br /><br />The value of each <see cref="Cell">Cell</see> <b>MUST</b> have the same restrictions as the value of an <i>observation</i> with <see cref="DataItem.representation">representation in DataItem</see> as <c>VALUE</c>.<br /><br />An <see cref="Cell">Cell</see> <b>MAY</b> be further constrained by the <see cref="DataItem">DataItem</see> definition (see <see cref="Device Information Model">Device Information Model</see>), for example a <c>VariableDataSet</c> having a string value <b>MAY</b> have a floating-point <see cref="Temperature">Temperature</see> value. A restriction <b>MUST NOT</b> be broadened or removed, for example, the value <c>READY</c> <b>MUST NOT</b> occur with a <c>TemperatureDataSet</c> constrained limited to floating-point numbers.<br /><br /><see cref="CellDefinition">CellDefinition</see> <b>MAY</b> provide type and units of a <see cref="Cell.key">key in Cell</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1582847071494_298325_2235">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CellClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1582847071494_298325_2235";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(key-value pair)}} published as part of a {{block(TableEntry)}}.&#10;
&#10;&#10;&#10;Constraints for Cell Values&#10;&#10;&#10;&#10;#### Constraints for Cell Values

The value of each {{block(Cell)}} **MUST** have the same restrictions as the value of an {{term(observation)}} with {{property(DataItem::representation)}} as `VALUE`.

An {{block(Cell)}} **MAY** be further constrained by the {{block(DataItem)}} definition (see {{package(Device Information Model)}}), for example a `VariableDataSet` having a string value **MAY** have a floating-point {{block(Temperature)}} value. A restriction **MUST NOT** be broadened or removed, for example, the value `READY` **MUST NOT** occur with a `TemperatureDataSet` constrained limited to floating-point numbers.

{{block(CellDefinition)}} **MAY** provide type and units of a {{property(Cell::key)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Cell";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.6";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new CellClassProperties Properties { get; } = new CellClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CellClass" />.
		/// </summary>
		public class CellClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Key,
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
				public string NormativeVersion => "1.6";
				
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
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public ResultProperty Result { get; } = new ResultProperty();
			
			/// <summary>﻿value of the <see cref="Cell">Cell</see>.<br /><br /><br />
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
				public string Summary => @"&#10;&#10;&#10;value of the {{block(Cell)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.6";
				
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