using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle
{
	/// <summary>
	/// constrained process spindle speed for the tool in revolutions/minute.  The <see cref="ProcessSpindleSpeed::value" /> <b>MAY</b> contain the nominal process target spindle speed if available. If <see cref="ProcessSpindleSpeed">ProcessSpindleSpeed</see> is provided, at least one value of <see cref="ProcessSpindleSpeed::maximum" />, <see cref="ProcessSpindleSpeed::nominal" />, or <see cref="ProcessSpindleSpeed::minimum" /> <b>MUST</b> be specified.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ProcessSpindleSpeedClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_3B2E47CE_BBF6_4b7a_A0C6_146B2BE8331A";
		
		/// <inheritdoc />
		public string Summary => @"/// constrained process spindle speed for the tool in revolutions/minute.  The <see cref=""ProcessSpindleSpeed::value"" /> <b>MAY</b> contain the nominal process target spindle speed if available. If <see cref=""ProcessSpindleSpeed"">ProcessSpindleSpeed</see> is provided, at least one value of <see cref=""ProcessSpindleSpeed::maximum"" />, <see cref=""ProcessSpindleSpeed::nominal"" />, or <see cref=""ProcessSpindleSpeed::minimum"" /> <b>MUST</b> be specified.";

		/// <inheritdoc />
		public string Name => "ProcessSpindleSpeedClass";
		
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
		public ProcessSpindleSpeedClassProperties Properties { get; } = new ProcessSpindleSpeedClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ProcessSpindleSpeedClassProperties : IPropertyList
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
			/// upper bound for the tool’s target spindle speed.
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
				public string Summary => @"/// constrained process spindle speed for the tool in revolutions/minute.  The <see cref=""ProcessSpindleSpeed::value"" /> <b>MAY</b> contain the nominal process target spindle speed if available. If <see cref=""ProcessSpindleSpeed"">ProcessSpindleSpeed</see> is provided, at least one value of <see cref=""ProcessSpindleSpeed::maximum"" />, <see cref=""ProcessSpindleSpeed::nominal"" />, or <see cref=""ProcessSpindleSpeed::minimum"" /> <b>MUST</b> be specified.";

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
			/// lower bound for the tools spindle speed. 
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
				public string Summary => @"/// constrained process spindle speed for the tool in revolutions/minute.  The <see cref=""ProcessSpindleSpeed::value"" /> <b>MAY</b> contain the nominal process target spindle speed if available. If <see cref=""ProcessSpindleSpeed"">ProcessSpindleSpeed</see> is provided, at least one value of <see cref=""ProcessSpindleSpeed::maximum"" />, <see cref=""ProcessSpindleSpeed::nominal"" />, or <see cref=""ProcessSpindleSpeed::minimum"" /> <b>MUST</b> be specified.";

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
			/// nominal speed the tool is designed to operate at.
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
				public string Summary => @"/// constrained process spindle speed for the tool in revolutions/minute.  The <see cref=""ProcessSpindleSpeed::value"" /> <b>MAY</b> contain the nominal process target spindle speed if available. If <see cref=""ProcessSpindleSpeed"">ProcessSpindleSpeed</see> is provided, at least one value of <see cref=""ProcessSpindleSpeed::maximum"" />, <see cref=""ProcessSpindleSpeed::nominal"" />, or <see cref=""ProcessSpindleSpeed::minimum"" /> <b>MUST</b> be specified.";

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
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "Value";
				
				/// <inheritdoc />
				public string Summary => @"/// constrained process spindle speed for the tool in revolutions/minute.  The <see cref=""ProcessSpindleSpeed::value"" /> <b>MAY</b> contain the nominal process target spindle speed if available. If <see cref=""ProcessSpindleSpeed"">ProcessSpindleSpeed</see> is provided, at least one value of <see cref=""ProcessSpindleSpeed::maximum"" />, <see cref=""ProcessSpindleSpeed::nominal"" />, or <see cref=""ProcessSpindleSpeed::minimum"" /> <b>MUST</b> be specified.";

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