using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes
{
	/// <summary>
	/// <see cref="ConditionEnum::DATA_RANGE">ConditionEnum::DATA_RANGE</see>
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1598552902597_214436_552">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DataRangeClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1598552902597_214436_552";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""ConditionEnum::DATA_RANGE"">ConditionEnum::DATA_RANGE</see>";

		/// <inheritdoc />
		public string Name => "DataRange";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579566531113_85883_25726
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ConditionClass);

		/// <inheritdoc />
		public DataRangeClassProperties Properties { get; } = new DataRangeClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class DataRangeClassProperties : Mtconnect.ObservationInformationModel.ConditionClass.ConditionClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Type,
			}.Concat(base.Properties).ToArray();
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
				/// <item>Original Type: _19_0_3_45f01b9_1580398386435_855466_12827</item>
				/// <item>Type: ConditionEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.ConditionEnum);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""ConditionEnum::DATA_RANGE"">ConditionEnum::DATA_RANGE</see>";

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
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "DATA_RANGE";
			}
		};

	}
}