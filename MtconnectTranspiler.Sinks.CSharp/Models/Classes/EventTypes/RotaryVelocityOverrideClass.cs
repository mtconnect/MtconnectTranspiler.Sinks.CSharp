using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// <see cref="EventEnum::ROTARY_VELOCITY_OVERRIDE">EventEnum::ROTARY_VELOCITY_OVERRIDE</see>  This command represents a percentage change to the velocity calculated by a logic or motion program or set by a switch for a <see cref="Rotary">Rotary</see> type axis.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class RotaryVelocityOverrideClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218440_585732_2163";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""EventEnum::ROTARY_VELOCITY_OVERRIDE"">EventEnum::ROTARY_VELOCITY_OVERRIDE</see>  This command represents a percentage change to the velocity calculated by a logic or motion program or set by a switch for a <see cref=""Rotary"">Rotary</see> type axis.";

		/// <inheritdoc />
		public string Name => "RotaryVelocityOverrideClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579566531115_47447_25730";

		/// <inheritdoc />
		public RotaryVelocityOverrideClassProperties Properties { get; } = new RotaryVelocityOverrideClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class RotaryVelocityOverrideClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Result,
				Type,
			};
			/// <summary>
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public ResultProperty Result { get; } = new ResultProperty();
			public sealed class ResultProperty : IProperty
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
				public string Name => "Result";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""EventEnum::ROTARY_VELOCITY_OVERRIDE"">EventEnum::ROTARY_VELOCITY_OVERRIDE</see>  This command represents a percentage change to the velocity calculated by a logic or motion program or set by a switch for a <see cref=""Rotary"">Rotary</see> type axis.";

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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580398379726_606068_12802</item>
				/// <item>Type: EventEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.EventEnum);
				
				/// <inheritdoc />
				public string Name => "Type";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""EventEnum::ROTARY_VELOCITY_OVERRIDE"">EventEnum::ROTARY_VELOCITY_OVERRIDE</see>  This command represents a percentage change to the velocity calculated by a logic or motion program or set by a switch for a <see cref=""Rotary"">Rotary</see> type axis.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
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

	}
}