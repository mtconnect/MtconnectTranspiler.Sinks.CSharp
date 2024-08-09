using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument
{
	/// <summary>
	/// root entity of an <i>MTConnectErrors Response Document</i> that contains the <i>Error Information Model</i>.  ![MTConnectError](figures/MTConnectErrors.png "MTConnectError"){: width="0.8"}  > Note: Additional properties of <see cref="MTConnectError">MTConnectError</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref="Schema and Namespace Declaration Information">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_91b028d_1579560579030_994981_6548">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MTConnectErrorClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1579560579030_994981_6548";
		
		/// <inheritdoc />
		public string Summary => @"/// root entity of an <i>MTConnectErrors Response Document</i> that contains the <i>Error Information Model</i>.  ![MTConnectError](figures/MTConnectErrors.png ""MTConnectError""){: width=""0.8""}  > Note: Additional properties of <see cref=""MTConnectError"">MTConnectError</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref=""Schema and Namespace Declaration Information"">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.";

		/// <inheritdoc />
		public string Name => "MTConnectError";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public MTConnectErrorClassProperties Properties { get; } = new MTConnectErrorClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class MTConnectErrorClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasHeaderPart,
				HasErrorPart,
				ErrorPart,
			};
			/// <summary>
			/// <inheritdoc cref="HasHeaderPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasHeader</remarks>
			/// </summary>
			public HasHeaderPartProperty HasHeaderPart { get; } = new HasHeaderPartProperty();
			public sealed class HasHeaderPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579560593039_375117_6558</item>
				/// <item>Type: HeaderClass</item>
				/// <item>Namespace: Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.HeaderClass);
				
				/// <inheritdoc />
				public string Name => "hasHeader";
				
				/// <inheritdoc />
				public string Summary => @"/// root entity of an <i>MTConnectErrors Response Document</i> that contains the <i>Error Information Model</i>.  ![MTConnectError](figures/MTConnectErrors.png ""MTConnectError""){: width=""0.8""}  > Note: Additional properties of <see cref=""MTConnectError"">MTConnectError</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref=""Schema and Namespace Declaration Information"">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasErrorPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasError</remarks>
			/// </summary>
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
				public string Name => "hasError";
				
				/// <inheritdoc />
				public string Summary => @"/// root entity of an <i>MTConnectErrors Response Document</i> that contains the <i>Error Information Model</i>.  ![MTConnectError](figures/MTConnectErrors.png ""MTConnectError""){: width=""0.8""}  > Note: Additional properties of <see cref=""MTConnectError"">MTConnectError</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref=""Schema and Namespace Declaration Information"">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.";

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
			}
			/// <summary>
			/// <inheritdoc cref="ErrorPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Error</remarks>
			/// </summary>
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
				public string Name => "error";
				
				/// <inheritdoc />
				public string Summary => @"/// root entity of an <i>MTConnectErrors Response Document</i> that contains the <i>Error Information Model</i>.  ![MTConnectError](figures/MTConnectErrors.png ""MTConnectError""){: width=""0.8""}  > Note: Additional properties of <see cref=""MTConnectError"">MTConnectError</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref=""Schema and Namespace Declaration Information"">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.";

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
			}
		};

	}
}