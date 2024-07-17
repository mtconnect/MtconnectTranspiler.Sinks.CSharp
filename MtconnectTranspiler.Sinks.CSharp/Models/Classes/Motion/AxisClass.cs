using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.Motion
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class AxisClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_7D0C7298_9CC4_4c45_A016_310B9A55DD7F";
		
		/// <inheritdoc />
		public string Name => "AxisClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public AxisClassProperties Properties { get; } = new AxisClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class AxisClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Value,
			};
			/// <remarks>Original Name: Value</remarks>
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
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

		# region Rules
		/// <summary>
		/// Axis
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		/*
		value->iterate(e:Real;sum:Real=0|sum+e*e) >= 0.9 and  value->iterate(e:Real;sum:Real=0|sum+e*e) <= 1.1
		*/
		# endregion
	}
}