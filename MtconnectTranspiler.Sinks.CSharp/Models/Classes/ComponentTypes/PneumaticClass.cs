using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="System">System</see> that uses compressed gasses to actuate components or do work within the piece of equipment./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PneumaticClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382008_658658_42273";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""System"">System</see> that uses compressed gasses to actuate components or do work within the piece of equipment./// Description";

		/// <inheritdoc />
		public string Name => "PneumaticClass";
		
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
		public PneumaticClassProperties Properties { get; } = new PneumaticClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class PneumaticClassProperties : IPropertyList
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
				public string Summary => @"/// <see cref=""System"">System</see> that uses compressed gasses to actuate components or do work within the piece of equipment./// Description";

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