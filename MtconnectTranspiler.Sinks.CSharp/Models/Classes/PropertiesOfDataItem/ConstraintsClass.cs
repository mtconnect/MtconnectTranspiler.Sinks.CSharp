using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	/// <summary>
	/// <i>organize</i>s a set of expected values that can be reported for a <see cref="DataItem">DataItem</see>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_E6F955EB_46CA_4c72_B547_8F4465A9620A">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ConstraintsClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_E6F955EB_46CA_4c72_B547_8F4465A9620A";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>organize</i>s a set of expected values that can be reported for a <see cref=""DataItem"">DataItem</see>.";

		/// <inheritdoc />
		public string Name => "Constraints";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public ConstraintsClassProperties Properties { get; } = new ConstraintsClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ConstraintsClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Maximum,
				Minimum,
				Nominal,
				Value,
				HasFilterPart,
			};
			/// <summary>
			/// <inheritdoc cref="MaximumProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Maximum</remarks>
			/// </summary>
			public MaximumProperty Maximum { get; } = new MaximumProperty();
			/// <summary>
			/// numeric upper constraint.  If the data reported for a data item is a range of numeric values, the expected value reported <b>MAY</b> be described with an upper limit defined by this constraint.
			/// </summary>
			public sealed class MaximumProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "Maximum";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>organize</i>s a set of expected values that can be reported for a <see cref=""DataItem"">DataItem</see>.";

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
			/// <inheritdoc cref="MinimumProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Minimum</remarks>
			/// </summary>
			public MinimumProperty Minimum { get; } = new MinimumProperty();
			/// <summary>
			/// numeric lower constraint.  If the data reported for a data item is a range of numeric values, the expected value reported <b>MAY</b> be described with a lower limit defined by this constraint.
			/// </summary>
			public sealed class MinimumProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "Minimum";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>organize</i>s a set of expected values that can be reported for a <see cref=""DataItem"">DataItem</see>.";

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
			/// <inheritdoc cref="NominalProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Nominal</remarks>
			/// </summary>
			public NominalProperty Nominal { get; } = new NominalProperty();
			/// <summary>
			/// numeric target or expected value.
			/// </summary>
			public sealed class NominalProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "Nominal";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>organize</i>s a set of expected values that can be reported for a <see cref=""DataItem"">DataItem</see>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.4";
				
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
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
			/// <summary>
			/// single data value that is expected to be reported for a <see cref="DataItem">DataItem</see>.  <see cref="Constraints::Value" /> <b>MUST NOT</b> be used in conjunction with any other <see cref="Constraint">Constraint</see> elements.
			/// </summary>
			public sealed class ValueProperty : IProperty
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
				public string Name => "Value";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>organize</i>s a set of expected values that can be reported for a <see cref=""DataItem"">DataItem</see>.";

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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasFilterPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasFilter</remarks>
			/// </summary>
			public HasFilterPartProperty HasFilterPart { get; } = new HasFilterPartProperty();
			public sealed class HasFilterPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8A5219C3_747D_4904_A58A_A312D13DAEE9</item>
				/// <item>Type: FilterClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.FilterClass);
				
				/// <inheritdoc />
				public string Name => "hasFilter";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>organize</i>s a set of expected values that can be reported for a <see cref=""DataItem"">DataItem</see>.";

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
				public string Association => "Filter";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}