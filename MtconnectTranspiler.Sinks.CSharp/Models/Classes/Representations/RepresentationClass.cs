#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>﻿specifies the format and structure of <see cref="Observation.result">result in Observation</see>.<br /><br /><br />Description<br /><br />The <see cref="Representation">Representation</see> type for an <see cref="Observation">Observation</see> is defined by the associated <see cref="DataItem.representation">representation in DataItem</see> in the <i>MTConnectDevices Response Document</i>.<br /><br /><see cref="Value">Value</see> is the default <see cref="Representation">Representation</see> type for all <see cref="Observation">Observation</see> types.<br /><br />The name of the <see cref="Observation">Observation</see> type is modified for all <see cref="Representation">Representation</see> types other than <see cref="Value">Value</see> by appending the pascal case of the <see cref="Representation">Representation</see> type. <br /><br />Example: The name for <see cref="Sample">Sample</see> <see cref="Observation">Observation</see> type <c>Temperature</c>with <c>Representation</c> type of <c>TimeSeries</c> becomes <c>TemperatureTimeSeries</c>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1633615188301_96457_1251">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RepresentationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1633615188301_96457_1251";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;specifies the format and structure of {{property(Observation::result)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;The {{block(Representation)}} type for an {{block(Observation)}} is defined by the associated {{property(DataItem::representation)}} in the {{term(MTConnectDevices Response Document)}}.

{{block(Value)}} is the default {{block(Representation)}} type for all {{block(Observation)}} types.

The name of the {{block(Observation)}} type is modified for all {{block(Representation)}} types other than {{block(Value)}} by appending the pascal case of the {{block(Representation)}} type. 

Example: The name for {{block(Sample)}} {{block(Observation)}} type `Temperature`with `Representation` type of `TimeSeries` becomes `TemperatureTimeSeries`.&#10;
";

		/// <inheritdoc />
		public string Name => "Representation";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public RepresentationClassProperties Properties { get; } = new RepresentationClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="RepresentationClass" />.
		/// </summary>
		public class RepresentationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}