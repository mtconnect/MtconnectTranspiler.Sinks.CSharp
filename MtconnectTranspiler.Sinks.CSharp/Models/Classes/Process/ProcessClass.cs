#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.Process
{
	/// <summary>﻿<see cref="Asset">Asset</see> that is composed of a series of actions to achieve a specific outcome.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1758719068590_751077_1428">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class ProcessClass : IClass
	{
		/// <summary>Constant value for <see cref="ProcessClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1758719068590_751077_1428";
		/// <summary>Constant value for <see cref="ProcessClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1758719068590_751077_1428";
		/// <summary>Constant value for <see cref="ProcessClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Asset)}} that is composed of a series of actions to achieve a specific outcome.&#10;
";
		/// <summary>Constant value for <see cref="ProcessClass.Name" /></summary>
		public const string NAME = "Process";
		/// <summary>Constant value for <see cref="ProcessClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ProcessClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ProcessClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.7";
		/// <summary>Constant value for <see cref="ProcessClass.DeprecatedVersion" /></summary>
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
		/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.AssetClass);

		/// <inheritdoc />
		public new ProcessClassProperties Properties { get; } = new ProcessClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ProcessClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties" />.
		/// </summary>
		public class ProcessClassProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Revision,
				HasRouting,
				HasTargetsPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="RevisionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Revision</remarks>
			/// </summary>
			public new RevisionProperty Revision { get; } = new RevisionProperty();
			
			/// <summary>﻿identifier assigned to a process version that reflects a change<br /><br /><br />
			/// </summary>
			public new sealed class RevisionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="RevisionProperty.Name" /></summary>
				public const string NAME = "revision";
				/// <summary>Constant value for <see cref="RevisionProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier assigned to a process version that reflects a change&#10;
";
				/// <summary>Constant value for <see cref="RevisionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="RevisionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="RevisionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.7";
				/// <summary>Constant value for <see cref="RevisionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="RevisionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="RevisionProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x;MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="RevisionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="RevisionProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="RevisionProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <summary>
			/// <inheritdoc cref="HasRoutingProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasRouting</remarks>
			/// </summary>
			public new HasRoutingProperty HasRouting { get; } = new HasRoutingProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasRoutingProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasRoutingProperty.Name" /></summary>
				public const string NAME = "hasRouting";
				/// <summary>Constant value for <see cref="HasRoutingProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasRoutingProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasRoutingProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasRoutingProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasRoutingProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasRoutingProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasRoutingProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x;MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasRoutingProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="HasRoutingProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasRoutingProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: RoutingClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Process.RoutingClass);
				
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
			/// <summary>
			/// <inheritdoc cref="HasTargetsPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasTargets</remarks>
			/// </summary>
			public new HasTargetsPartProperty HasTargetsPart { get; } = new HasTargetsPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasTargetsPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasTargetsPartProperty.Name" /></summary>
				public const string NAME = "hasTargets";
				/// <summary>Constant value for <see cref="HasTargetsPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasTargetsPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasTargetsPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasTargetsPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasTargetsPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasTargetsPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasTargetsPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasTargetsPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Targets";
				/// <summary>Constant value for <see cref="HasTargetsPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasTargetsPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..*";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: TargetClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Process.Target.TargetClass);
				
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
		/// List of constraint rules for <see cref="ProcessClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			ProcessRoutingProcessStep,
		};
		/// <summary>
		/// ProcessRoutingProcessStep
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string ProcessRoutingProcessStep => @"val:ProcessRoutingProcessStepMustHaveAtMostOneTarget
    a sh:NodeShape ;
    sh:message ""`ProcessStep` in `Routing` for `Process` **MUST** have at most one `TargetRef`."" ;
    sh:targetClass mt:ProcessStep ;
    sh:sparql [
        a sh:SPARQLConstraint ;
        sh:select """"""
            SELECT ?this WHERE {
                ?process a mt:Process .
                ?process mt:hasRouting ?routing .
                ?routing mt:hasProcessStep ?this .
                {
                  SELECT ?this (COUNT(?target) AS ?targetCount) WHERE {
                    ?this mt:hasTarget ?target .
                  }
                  GROUP BY ?this
                  HAVING (?targetCount > 1)
                }
            }
        """""" ;
    ] .
";
		/*
		val:ProcessRoutingProcessStepMustHaveAtMostOneTarget
		    a sh:NodeShape ;
		    sh:message "`ProcessStep` in `Routing` for `Process` **MUST** have at most one `TargetRef`." ;
		    sh:targetClass mt:ProcessStep ;
		    sh:sparql [
		        a sh:SPARQLConstraint ;
		        sh:select """
		            SELECT ?this WHERE {
		                ?process a mt:Process .
		                ?process mt:hasRouting ?routing .
		                ?routing mt:hasProcessStep ?this .
		                {
		                  SELECT ?this (COUNT(?target) AS ?targetCount) WHERE {
		                    ?this mt:hasTarget ?target .
		                  }
		                  GROUP BY ?this
		                  HAVING (?targetCount > 1)
		                }
		            }
		        """ ;
		    ] .

		*/
		# endregion
	}
}