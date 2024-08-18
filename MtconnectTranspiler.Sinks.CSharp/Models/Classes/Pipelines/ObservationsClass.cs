#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AgentArchitecture.Pipelines
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1674406832907_5231_497">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ObservationsClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1674406832907_5231_497";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "Observations";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_4_45f01b9_1674406425739_249387_380
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AgentArchitecture.Pipelines.TimestampedClass);

		/// <inheritdoc />
		public new ObservationsClassProperties Properties { get; } = new ObservationsClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ObservationsClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AgentArchitecture.Pipelines.TimestampedClass.TimestampedClassProperties" />.
		/// </summary>
		public class ObservationsClassProperties : Mtconnect.AgentArchitecture.Pipelines.TimestampedClass.TimestampedClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				Value,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public new ValueProperty Value { get; } = new ValueProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ValueProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579566531115_47734_25731</item>
				/// <item>Type: ObservationGeneralization</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationGeneralization);
				
				/// <inheritdoc />
				public string Name => "value";
				
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
				public string Aggregation => "shared";

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