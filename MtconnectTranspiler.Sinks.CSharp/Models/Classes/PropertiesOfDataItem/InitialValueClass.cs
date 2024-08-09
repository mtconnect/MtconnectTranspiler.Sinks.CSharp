using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	/// <summary>
	/// starting value for a <see cref="DataItem">DataItem</see> as well as the value to be set for the <see cref="DataItem">DataItem</see> after a reset event.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_3F705CFA_0BDC_4dc1_91C8_0A38B91DD3E6">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class InitialValueClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_3F705CFA_0BDC_4dc1_91C8_0A38B91DD3E6";
		
		/// <inheritdoc />
		public string Summary => @"/// starting value for a <see cref=""DataItem"">DataItem</see> as well as the value to be set for the <see cref=""DataItem"">DataItem</see> after a reset event.";

		/// <inheritdoc />
		public string Name => "InitialValue";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public InitialValueClassProperties Properties { get; } = new InitialValueClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class InitialValueClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Value,
			};
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
				public string Name => "value";
				
				/// <inheritdoc />
				public string Summary => @"/// starting value for a <see cref=""DataItem"">DataItem</see> as well as the value to be set for the <see cref=""DataItem"">DataItem</see> after a reset event.";

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
		};

	}
}