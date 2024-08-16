using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="System">System</see> that uses compressed gasses to actuate components or do work within the piece of equipment.<br/><br />Description<br/>> Note: Actuation is usually performed using a cylinder.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382008_658658_42273">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PneumaticClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382008_658658_42273";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(System)}} that uses compressed gasses to actuate components or do work within the piece of equipment.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;> Note: Actuation is usually performed using a cylinder.&#10;
";

		/// <inheritdoc />
		public string Name => "Pneumatic";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572381968_750236_42201
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ActuatorClass);

		/// <inheritdoc />
		public PneumaticClassProperties Properties { get; } = new PneumaticClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class PneumaticClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.ActuatorClass.ActuatorClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesPressure,
			}.Concat(base.Properties).ToArray();
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
				public string Name => "observesPressure";
				
				/// <inheritdoc />
				public string Summary => @"";

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