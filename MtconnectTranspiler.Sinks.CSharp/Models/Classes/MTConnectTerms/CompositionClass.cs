using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>
	/// <i>Component</i> belonging to a <i>Component</i> and not composed of any <i>Component</i>s.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CompositionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375147_715142_1964";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>Component</i> belonging to a <i>Component</i> and not composed of any <i>Component</i>s.";

		/// <inheritdoc />
		public string Name => "CompositionClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1581734537697_742151_1119";

		/// <inheritdoc />
		public CompositionClassProperties Properties { get; } = new CompositionClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class CompositionClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				BelongsTo,
			};
			/// <summary>
			/// <inheritdoc cref="BelongsToProperty" path="/summary" /><br/>
			/// <remarks>Original Name: BelongsTo</remarks>
			/// </summary>
			public BelongsToProperty BelongsTo { get; } = new BelongsToProperty();
			public sealed class BelongsToProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1581734537697_742151_1119</item>
				/// <item>Type: ComponentClass</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.ComponentClass);
				
				/// <inheritdoc />
				public string Name => "BelongsTo";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>Component</i> belonging to a <i>Component</i> and not composed of any <i>Component</i>s.";

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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}