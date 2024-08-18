#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>﻿default <see cref="Representation">Representation</see> type for all <see cref="Observation">Observation</see> types where <see cref="Observation.result">result in Observation</see> type is an MTConnect data type. See <see cref="DataTypes">DataTypes</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1633690320192_358108_736">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ValueClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1633690320192_358108_736";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;default {{block(Representation)}} type for all {{block(Observation)}} types where {{property(Observation::result)}} type is an MTConnect data type. See {{package(DataTypes)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Value";
		
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
		/// Original Type: _19_0_3_68e0225_1633615188301_96457_1251
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.Representations.RepresentationClass);

		/// <inheritdoc />
		public new ValueClassProperties Properties { get; } = new ValueClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ValueClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.RepresentationClass.RepresentationClassProperties" />.
		/// </summary>
		public class ValueClassProperties : Mtconnect.ObservationInformationModel.Representations.RepresentationClass.RepresentationClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				Result,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public new ResultProperty Result { get; } = new ResultProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ResultProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: </item>
				/// <item>Type: Object</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(object);
				
				/// <inheritdoc />
				public string Name => "result";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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