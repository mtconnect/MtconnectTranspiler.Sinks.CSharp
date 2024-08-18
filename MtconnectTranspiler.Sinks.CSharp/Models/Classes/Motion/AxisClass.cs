#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.Motion
{
	/// <summary>﻿axis along or around which the <see cref="Component">Component</see> moves relative to a coordinate system.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_7D0C7298_9CC4_4c45_A016_310B9A55DD7F">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AxisClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_7D0C7298_9CC4_4c45_A016_310B9A55DD7F";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;axis along or around which the {{block(Component)}} moves relative to a coordinate system.&#10;
";

		/// <inheritdoc />
		public string Name => "Axis";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new AxisClassProperties Properties { get; } = new AxisClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AxisClass" />.
		/// </summary>
		public class AxisClassProperties : IPropertyList
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
			
			/// <summary>﻿unit vector defining the axis of motion.<br /><br /><br />
			/// </summary>
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
				public string Name => "value";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;unit vector defining the axis of motion.&#10;
";

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
			}
		};

		# region Rules
		/// <summary>
		/// Axis
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string Axis => @"value->iterate(e:Real;sum:Real=0|sum+e*e) >= 0.9 and  value->iterate(e:Real;sum:Real=0|sum+e*e) <= 1.1";
		/*
		value->iterate(e:Real;sum:Real=0|sum+e*e) >= 0.9 and  value->iterate(e:Real;sum:Real=0|sum+e*e) <= 1.1
		*/
		# endregion
	}
}