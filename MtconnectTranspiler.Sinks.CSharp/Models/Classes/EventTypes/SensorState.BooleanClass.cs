using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// <see cref="EventEnum::SENSOR_STATE">EventEnum::SENSOR_STATE</see> where the state is <see cref="DataItemSubTypeEnum::BOOLEAN">DataItemSubTypeEnum::BOOLEAN</see>
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1677588817279_198819_782">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SensorStateBooleanClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1677588817279_198819_782";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""EventEnum::SENSOR_STATE"">EventEnum::SENSOR_STATE</see> where the state is <see cref=""DataItemSubTypeEnum::BOOLEAN"">DataItemSubTypeEnum::BOOLEAN</see>";

		/// <inheritdoc />
		public string Name => "SensorState.Boolean";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1677588817278_345680_780
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.SensorStateClass);

		/// <inheritdoc />
		public SensorStateBooleanClassProperties Properties { get; } = new SensorStateBooleanClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class SensorStateBooleanClassProperties : Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.SensorStateClass.SensorStateClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				SubType,
				Result,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public SubTypeProperty SubType { get; } = new SubTypeProperty();
			public sealed class SubTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579563592155_977172_22064</item>
				/// <item>Type: DataItemSubTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnum);
				
				/// <inheritdoc />
				public string Name => "subType";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""EventEnum::SENSOR_STATE"">EventEnum::SENSOR_STATE</see> where the state is <see cref=""DataItemSubTypeEnum::BOOLEAN"">DataItemSubTypeEnum::BOOLEAN</see>";

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
				public string DefaultValue => "BOOLEAN";
			}
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
				/// <item>Original Type: _19_0_3_91b028d_1579278876899_683310_3821</item>
				/// <item>Type: Boolean</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
				/// <inheritdoc />
				public string Name => "result";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""EventEnum::SENSOR_STATE"">EventEnum::SENSOR_STATE</see> where the state is <see cref=""DataItemSubTypeEnum::BOOLEAN"">DataItemSubTypeEnum::BOOLEAN</see>";

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
		};

	}
}