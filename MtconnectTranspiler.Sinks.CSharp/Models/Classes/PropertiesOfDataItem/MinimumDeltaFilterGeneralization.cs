using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	/// <summary>
	/// <see cref="FilterEnum::MINIMUM_DELTA">FilterEnum::MINIMUM_DELTA</see>
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1644604760483_617184_91">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MinimumDeltaFilterGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1644604760483_617184_91";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""FilterEnum::MINIMUM_DELTA"">FilterEnum::MINIMUM_DELTA</see>";

		/// <inheritdoc />
		public string Name => "MinimumDeltaFilter";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_8A5219C3_747D_4904_A58A_A312D13DAEE9
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.FilterClass);

		/// <inheritdoc />
		public MinimumDeltaFilterGeneralizationProperties Properties { get; } = new MinimumDeltaFilterGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class MinimumDeltaFilterGeneralizationProperties : Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.FilterClass.FilterClassProperties
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
				/// <item>Original Type: EAID_EF8EFACB_B3D8_4199_B5D5_84735797D463</item>
				/// <item>Type: FilterEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.FilterEnum);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""FilterEnum::MINIMUM_DELTA"">FilterEnum::MINIMUM_DELTA</see>";

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
				public string DefaultValue => "MINIMUM_DELTA";
			}
		};

	}
}