using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.Representations;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>
	/// <see cref="Representation">Representation</see> for an <see cref="Observation">Observation</see> composed of two-dimensional sets of <i>key-value pair</i>s where the <see cref="Entry">Entry</see> represents rows containing sets of <i>key-value pair</i>s given by <see cref="Cell">Cell</see> entities.  /// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class TableClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1582846972437_483160_2181";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Representation"">Representation</see> for an <see cref=""Observation"">Observation</see> composed of two-dimensional sets of <i>key-value pair</i>s where the <see cref=""Entry"">Entry</see> represents rows containing sets of <i>key-value pair</i>s given by <see cref=""Cell"">Cell</see> entities.  /// Description";

		/// <inheritdoc />
		public string Name => "TableClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.6";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1633615188301_96457_1251";

		/// <inheritdoc />
		public TableClassProperties Properties { get; } = new TableClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class TableClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ResultPart,
				Count,
			};
			/// <summary>
			/// <inheritdoc cref="ResultPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public ResultPartProperty ResultPart { get; } = new ResultPartProperty();
			public sealed class ResultPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1600164112807_45306_44</item>
				/// <item>Type: TableEntryClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.Representations</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.Representations.TableEntryClass);
				
				/// <inheritdoc />
				public string Name => "Result";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Representation"">Representation</see> for an <see cref=""Observation"">Observation</see> composed of two-dimensional sets of <i>key-value pair</i>s where the <see cref=""Entry"">Entry</see> represents rows containing sets of <i>key-value pair</i>s given by <see cref=""Cell"">Cell</see> entities.  /// Description";

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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "TableEntry";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="CountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Count</remarks>
			/// </summary>
			public CountProperty Count { get; } = new CountProperty();
			/// <summary>
			/// number of <i>key-value pair</i>s represented as <see cref="Entry">Entry</see> entities.
			/// </summary>
			public sealed class CountProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272271512_537408_674</item>
				/// <item>Type: Int32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
				/// <inheritdoc />
				public string Name => "Count";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Representation"">Representation</see> for an <see cref=""Observation"">Observation</see> composed of two-dimensional sets of <i>key-value pair</i>s where the <see cref=""Entry"">Entry</see> represents rows containing sets of <i>key-value pair</i>s given by <see cref=""Cell"">Cell</see> entities.  /// Description";

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
		};

	}
}