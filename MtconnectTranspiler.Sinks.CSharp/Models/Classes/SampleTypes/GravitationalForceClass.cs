using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes
{
	/// <summary>
	/// <see cref="SampleEnum::GRAVITATIONAL_FORCE">SampleEnum::GRAVITATIONAL_FORCE</see>  > Note: <i>Mass\times GravitationalAcceleration</i>s
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class GravitationalForceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1660317516642_837590_88";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""SampleEnum::GRAVITATIONAL_FORCE"">SampleEnum::GRAVITATIONAL_FORCE</see>  > Note: <i>Mass\\times GravitationalAcceleration</i>s";

		/// <inheritdoc />
		public string Name => "GravitationalForceClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579566531116_175117_25733";

		/// <inheritdoc />
		public GravitationalForceClassProperties Properties { get; } = new GravitationalForceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class GravitationalForceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Units,
				Type,
			};
			/// <summary>
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public UnitsProperty Units { get; } = new UnitsProperty();
			public sealed class UnitsProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_678122A4_E8FD_4243_8427_6B7E0E78D5F5</item>
				/// <item>Type: NativeUnitEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.NativeUnitEnum);
				
				/// <inheritdoc />
				public string Name => "Units";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""SampleEnum::GRAVITATIONAL_FORCE"">SampleEnum::GRAVITATIONAL_FORCE</see>  > Note: <i>Mass\\times GravitationalAcceleration</i>s";

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
				/// <item>Original Type: _19_0_3_45f01b9_1580398370126_672808_12777</item>
				/// <item>Type: SampleEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.SampleEnum);
				
				/// <inheritdoc />
				public string Name => "Type";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""SampleEnum::GRAVITATIONAL_FORCE"">SampleEnum::GRAVITATIONAL_FORCE</see>  > Note: <i>Mass\\times GravitationalAcceleration</i>s";

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