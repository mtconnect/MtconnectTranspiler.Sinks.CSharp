using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="System">System</see> that provides distribution and management of fluids that remove heat from a piece of equipment.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CoolantClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381979_456626_42219";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""System"">System</see> that provides distribution and management of fluids that remove heat from a piece of equipment.";

		/// <inheritdoc />
		public string Name => "CoolantClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572382020_336298_42297";

		/// <inheritdoc />
		public CoolantClassProperties Properties { get; } = new CoolantClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class CoolantClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesConcentration,
			};
			/// <summary>
			/// <inheritdoc cref="ObservesConcentrationProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesConcentration</remarks>
			/// </summary>
			public ObservesConcentrationProperty ObservesConcentration { get; } = new ObservesConcentrationProperty();
			public sealed class ObservesConcentrationProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218232_876552_1650</item>
				/// <item>Type: ConcentrationClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.ConcentrationClass);
				
				/// <inheritdoc />
				public string Name => "ObservesConcentration";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""System"">System</see> that provides distribution and management of fluids that remove heat from a piece of equipment.";

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