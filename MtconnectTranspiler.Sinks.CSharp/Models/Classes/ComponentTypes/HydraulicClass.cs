using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="System">System</see> that provides movement and distribution of pressurized liquid throughout the piece of equipment.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class HydraulicClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381993_131470_42246";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""System"">System</see> that provides movement and distribution of pressurized liquid throughout the piece of equipment.";

		/// <inheritdoc />
		public string Name => "HydraulicClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572381968_750236_42201";

		/// <inheritdoc />
		public HydraulicClassProperties Properties { get; } = new HydraulicClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class HydraulicClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesPressure,
			};
			/// <summary>
			/// <inheritdoc cref="ObservesPressureProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPressure</remarks>
			/// </summary>
			public ObservesPressureProperty ObservesPressure { get; } = new ObservesPressureProperty();
			public sealed class ObservesPressureProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218410_510683_2076</item>
				/// <item>Type: PressureClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.PressureClass);
				
				/// <inheritdoc />
				public string Name => "ObservesPressure";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""System"">System</see> that provides movement and distribution of pressurized liquid throughout the piece of equipment.";

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