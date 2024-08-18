#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1620206731259_178927_703">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ControlLimitResultClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1620206731259_178927_703";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "ControlLimitResult";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579566531114_503405_25727
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.Representations.DataSetClass);

		/// <inheritdoc />
		public new ControlLimitResultClassProperties Properties { get; } = new ControlLimitResultClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ControlLimitResultClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties" />.
		/// </summary>
		public class ControlLimitResultClassProperties : Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				UpperLimit,
				UpperWarning,
				Nominal,
				LowerWarning,
				LowerLimit,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="UpperLimitProperty" path="/summary" /><br/>
			/// <remarks>Original Name: UpperLimit</remarks>
			/// </summary>
			public new UpperLimitProperty UpperLimit { get; } = new UpperLimitProperty();
			
			/// <summary>﻿upper conformance boundary for a variable.<br /><br />&gt; Note: immediate concern or action may be required.<br /><br /><br /><br /><br />
			/// </summary>
			public new sealed class UpperLimitProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "UpperLimit";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;upper conformance boundary for a variable.

> Note: immediate concern or action may be required.

&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
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
			/// <summary>
			/// <inheritdoc cref="UpperWarningProperty" path="/summary" /><br/>
			/// <remarks>Original Name: UpperWarning</remarks>
			/// </summary>
			public new UpperWarningProperty UpperWarning { get; } = new UpperWarningProperty();
			
			/// <summary>﻿upper boundary indicating increased concern and supervision may be required.<br /><br /><br />
			/// </summary>
			public new sealed class UpperWarningProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "UpperWarning";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;upper boundary indicating increased concern and supervision may be required.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
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
			/// <summary>
			/// <inheritdoc cref="NominalProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Nominal</remarks>
			/// </summary>
			public new NominalProperty Nominal { get; } = new NominalProperty();
			
			/// <summary>﻿ideal or desired value for a variable.<br /><br /><br />
			/// </summary>
			public new sealed class NominalProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "Nominal";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;ideal or desired value for a variable.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
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
			/// <summary>
			/// <inheritdoc cref="LowerWarningProperty" path="/summary" /><br/>
			/// <remarks>Original Name: LowerWarning</remarks>
			/// </summary>
			public new LowerWarningProperty LowerWarning { get; } = new LowerWarningProperty();
			
			/// <summary>﻿lower boundary indicating increased concern and supervision may be required.<br /><br /><br />
			/// </summary>
			public new sealed class LowerWarningProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "LowerWarning";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;lower boundary indicating increased concern and supervision may be required.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
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
			/// <summary>
			/// <inheritdoc cref="LowerLimitProperty" path="/summary" /><br/>
			/// <remarks>Original Name: LowerLimit</remarks>
			/// </summary>
			public new LowerLimitProperty LowerLimit { get; } = new LowerLimitProperty();
			
			/// <summary>﻿lower conformance boundary for a variable.<br /><br />&gt; Note: immediate concern or action may be required.<br /><br /><br /><br /><br />
			/// </summary>
			public new sealed class LowerLimitProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "LowerLimit";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;lower conformance boundary for a variable.

> Note: immediate concern or action may be required.

&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
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