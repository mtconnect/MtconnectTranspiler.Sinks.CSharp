using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>
	/// <i>observable</i> observed by a <i>Component</i> that may make <i>Observation</i>s
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DataItemClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1635251889215_363828_393";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>observable</i> observed by a <i>Component</i> that may make <i>Observation</i>s";

		/// <inheritdoc />
		public string Name => "DataItemClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1629291153288_544363_79";

		/// <inheritdoc />
		public DataItemClassProperties Properties { get; } = new DataItemClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class DataItemClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservedBy,
			};
			/// <summary>
			/// <inheritdoc cref="ObservedByProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservedBy</remarks>
			/// </summary>
			public ObservedByProperty ObservedBy { get; } = new ObservedByProperty();
			public sealed class ObservedByProperty : IProperty
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
				public string Name => "ObservedBy";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>observable</i> observed by a <i>Component</i> that may make <i>Observation</i>s";

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