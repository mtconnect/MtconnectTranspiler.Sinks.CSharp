#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Configurations.Motion
{
	/// <summary>﻿axis along or around which the <see cref="Component">Component</see> moves relative to a coordinate system.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_3_3870182_1764951682685_285104_645">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class AxisClass : IClass
	{
		/// <summary>Constant value for <see cref="AxisClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_3_3870182_1764951682685_285104_645";
		/// <summary>Constant value for <see cref="AxisClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_3_3870182_1764951682685_285104_645";
		/// <summary>Constant value for <see cref="AxisClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;axis along or around which the {{block(Component)}} moves relative to a coordinate system.&#10;
";
		/// <summary>Constant value for <see cref="AxisClass.Name" /></summary>
		public const string NAME = "Axis";
		/// <summary>Constant value for <see cref="AxisClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="AxisClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="AxisClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="AxisClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_7D0C7298_9CC4_4c45_A016_310B9A55DD7F
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Configurations.Motion.AbstractAxisClass);

		/// <inheritdoc />
		public new AxisClassProperties Properties { get; } = new AxisClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AxisClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Configurations.Motion.AbstractAxisClass.AbstractAxisClassProperties" />.
		/// </summary>
		public class AxisClassProperties : Mtconnect.DeviceInformationModel.Configurations.Motion.AbstractAxisClass.AbstractAxisClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
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
				/// <summary>Constant value for <see cref="ValueProperty.Name" /></summary>
				public const string NAME = "value";
				/// <summary>Constant value for <see cref="ValueProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ValueProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="ValueProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ValueProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ValueProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ValueProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ValueProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ValueProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ValueProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="ValueProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Float[] </remarks>
				/// </summary>
				public System.Type Type => typeof(float[]);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="AxisClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			Axis,
		};
		/// <summary>
		/// Axis
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string Axis => @"val:AxisValueMustBeUnitVector
    a sh:NodeShape ;
    sh:message ""Axis value must be a unit vector."" ;
    sh:targetClass mt:Axis ;
    sh:sparql [
        a sh:SPARQLConstraint ;
        sh:message ""'value' property must form a unit vector: sqrt(x^2 + y^2 + z^2) = 1."" ;
        sh:select """"""
            SELECT $this
            WHERE {
                $this mt:value ?vec .
                ?vec mt:x ?x ; mt:y ?y ; mt:z ?z .
                FILTER ( ABS( SQRT((?x*?x) + (?y*?y) + (?z*?z)) - 1.0 ) > 1e-6 )
            }
        """""" ;
    ] .
";
		/*
		val:AxisValueMustBeUnitVector
		    a sh:NodeShape ;
		    sh:message "Axis value must be a unit vector." ;
		    sh:targetClass mt:Axis ;
		    sh:sparql [
		        a sh:SPARQLConstraint ;
		        sh:message "'value' property must form a unit vector: sqrt(x^2 + y^2 + z^2) = 1." ;
		        sh:select """
		            SELECT $this
		            WHERE {
		                $this mt:value ?vec .
		                ?vec mt:x ?x ; mt:y ?y ; mt:z ?z .
		                FILTER ( ABS( SQRT((?x*?x) + (?y*?y) + (?z*?z)) - 1.0 ) > 1e-6 )
		            }
		        """ ;
		    ] .

		*/
		# endregion
	}
}