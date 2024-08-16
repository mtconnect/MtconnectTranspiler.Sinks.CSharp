using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle
{
	/// <summary>
	﻿/// number of times the cutter has been reconditioned.<br /><br/><br />Description<br/><see cref="ReconditionCount">ReconditionCount</see> <b>MUST</b> be defined only for the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> of <see cref="CuttingTool">CuttingTool</see> and <b>MUST NOT</b> be defined for the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> of <see cref="CuttingToolArchetype">CuttingToolArchetype</see>.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_AB33F1B2_493B_4f60_9394_4A69B30576F9">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ReconditionCountClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_AB33F1B2_493B_4f60_9394_4A69B30576F9";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;number of times the cutter has been reconditioned.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(ReconditionCount)}} **MUST** be defined only for the {{block(CuttingToolLifeCycle)}} of {{block(CuttingTool)}} and **MUST NOT** be defined for the {{block(CuttingToolLifeCycle)}} of {{block(CuttingToolArchetype)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "ReconditionCount";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public ReconditionCountClassProperties Properties { get; } = new ReconditionCountClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ReconditionCountClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				MaximumCount,
				Value,
			};
			/// <summary>
			/// <inheritdoc cref="MaximumCountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MaximumCount</remarks>
			/// </summary>
			public MaximumCountProperty MaximumCount { get; } = new MaximumCountProperty();
			/// <summary>
			﻿/// maximum number of times the tool may be reconditioned.<br /><br/><br />

			/// </summary>
			public sealed class MaximumCountProperty : IProperty
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
				public string Name => "maximumCount";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;maximum number of times the tool may be reconditioned.&#10;
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
				/// <item>Original Type: _19_0_3_91b028d_1579272271512_537408_674</item>
				/// <item>Type: Int32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
				/// <inheritdoc />
				public string Name => "value";
				
				/// <inheritdoc />
				public string Summary => @"";

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