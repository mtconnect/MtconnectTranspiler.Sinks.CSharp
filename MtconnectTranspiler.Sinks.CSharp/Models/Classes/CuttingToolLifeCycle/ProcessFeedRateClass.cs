using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle
{
	/// <summary>
	/// constrained process feed rate for the tool in mm/s.  The <see cref="ProcessFeedRate::value" /> <b>MAY</b> contain the nominal process target feed rate if available. If <see cref="ProcessFeedRate">ProcessFeedRate</see> is provided, at least one value of <see cref="ProcessFeedRate::maximum" />, <see cref="ProcessFeedRate::nominal" />, or <see cref="ProcessFeedRate::minimum" /> <b>MUST</b> be specified.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ProcessFeedRateClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_07E81F95_CE0D_4404_9384_30E428006C48";
		
		/// <inheritdoc />
		public string Summary => @"/// constrained process feed rate for the tool in mm/s.  The <see cref=""ProcessFeedRate::value"" /> <b>MAY</b> contain the nominal process target feed rate if available. If <see cref=""ProcessFeedRate"">ProcessFeedRate</see> is provided, at least one value of <see cref=""ProcessFeedRate::maximum"" />, <see cref=""ProcessFeedRate::nominal"" />, or <see cref=""ProcessFeedRate::minimum"" /> <b>MUST</b> be specified.";

		/// <inheritdoc />
		public string Name => "ProcessFeedRateClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public ProcessFeedRateClassProperties Properties { get; } = new ProcessFeedRateClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ProcessFeedRateClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Maximum,
				Minimum,
				Nominal,
				Value,
			};
			/// <summary>
			/// <inheritdoc cref="MaximumProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Maximum</remarks>
			/// </summary>
			public MaximumProperty Maximum { get; } = new MaximumProperty();
			/// <summary>
			/// upper bound for the tool’s process target feedrate.
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
				public string Summary => @"/// constrained process feed rate for the tool in mm/s.  The <see cref=""ProcessFeedRate::value"" /> <b>MAY</b> contain the nominal process target feed rate if available. If <see cref=""ProcessFeedRate"">ProcessFeedRate</see> is provided, at least one value of <see cref=""ProcessFeedRate::maximum"" />, <see cref=""ProcessFeedRate::nominal"" />, or <see cref=""ProcessFeedRate::minimum"" /> <b>MUST</b> be specified.";

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
			/// <inheritdoc cref="MinimumProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Minimum</remarks>
			/// </summary>
			public MinimumProperty Minimum { get; } = new MinimumProperty();
			/// <summary>
			/// lower bound for the tool's feedrate.
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
				public string Summary => @"/// constrained process feed rate for the tool in mm/s.  The <see cref=""ProcessFeedRate::value"" /> <b>MAY</b> contain the nominal process target feed rate if available. If <see cref=""ProcessFeedRate"">ProcessFeedRate</see> is provided, at least one value of <see cref=""ProcessFeedRate::maximum"" />, <see cref=""ProcessFeedRate::nominal"" />, or <see cref=""ProcessFeedRate::minimum"" /> <b>MUST</b> be specified.";

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
			/// <inheritdoc cref="NominalProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Nominal</remarks>
			/// </summary>
			public NominalProperty Nominal { get; } = new NominalProperty();
			/// <summary>
			/// nominal feedrate the tool is designed to operate at. 
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
				public string Summary => @"/// constrained process feed rate for the tool in mm/s.  The <see cref=""ProcessFeedRate::value"" /> <b>MAY</b> contain the nominal process target feed rate if available. If <see cref=""ProcessFeedRate"">ProcessFeedRate</see> is provided, at least one value of <see cref=""ProcessFeedRate::maximum"" />, <see cref=""ProcessFeedRate::nominal"" />, or <see cref=""ProcessFeedRate::minimum"" /> <b>MUST</b> be specified.";

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
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
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
				public string Summary => @"/// constrained process feed rate for the tool in mm/s.  The <see cref=""ProcessFeedRate::value"" /> <b>MAY</b> contain the nominal process target feed rate if available. If <see cref=""ProcessFeedRate"">ProcessFeedRate</see> is provided, at least one value of <see cref=""ProcessFeedRate::maximum"" />, <see cref=""ProcessFeedRate::nominal"" />, or <see cref=""ProcessFeedRate::minimum"" /> <b>MUST</b> be specified.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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