using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="System">System</see> composed of the main power supply for the piece of equipment that provides distribution of that power throughout the equipment./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ElectricClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381986_185851_42231";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""System"">System</see> composed of the main power supply for the piece of equipment that provides distribution of that power throughout the equipment./// Description";

		/// <inheritdoc />
		public string Name => "ElectricClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572382020_336298_42297";

		/// <inheritdoc />
		public ElectricClassProperties Properties { get; } = new ElectricClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ElectricClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesWattage,
			};
			/// <summary>
			/// <inheritdoc cref="ObservesWattageProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesWattage</remarks>
			/// </summary>
			public ObservesWattageProperty ObservesWattage { get; } = new ObservesWattageProperty();
			public sealed class ObservesWattageProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218484_57384_2301</item>
				/// <item>Type: WattageClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.WattageClass);
				
				/// <inheritdoc />
				public string Name => "ObservesWattage";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""System"">System</see> composed of the main power supply for the piece of equipment that provides distribution of that power throughout the equipment./// Description";

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