using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument;
// using Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class MTConnectErrorClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1579560579030_994981_6548";
		
		/// <inheritdoc />
		public string Name => "MTConnectErrorClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public MTConnectErrorClassProperties Properties { get; } = new MTConnectErrorClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class MTConnectErrorClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasHeaderPart,
				HasErrorPart,
				ErrorPart,
			};
			/// <remarks>Original Name: HasHeader</remarks>
			public HasHeaderPartProperty HasHeaderPart { get; } = new HasHeaderPartProperty();
			public sealed class HasHeaderPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579560593039_375117_6558</item>
				/// <item>Type: HeaderClass</item>
				/// <item>Namespace: Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument.HeaderClass);
				
				/// <inheritdoc />
				public string Name => "HasHeader";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
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
				public string Association => "Header";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasError</remarks>
			public HasErrorPartProperty HasErrorPart { get; } = new HasErrorPartProperty();
			public sealed class HasErrorPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579560710732_245440_6708</item>
				/// <item>Type: ErrorClass</item>
				/// <item>Namespace: Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorClass);
				
				/// <inheritdoc />
				public string Name => "HasError";
				
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
				public string Association => "Errors";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Error</remarks>
			public ErrorPartProperty ErrorPart { get; } = new ErrorPartProperty();
			public sealed class ErrorPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579560710732_245440_6708</item>
				/// <item>Type: ErrorClass</item>
				/// <item>Namespace: Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorClass);
				
				/// <inheritdoc />
				public string Name => "Error";
				
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
				public string Association => "Error";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}