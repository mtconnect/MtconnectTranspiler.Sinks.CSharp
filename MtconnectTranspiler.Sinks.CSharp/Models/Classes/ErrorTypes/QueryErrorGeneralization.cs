#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorTypes
{
	/// <summary>﻿agent was unable to interpret the query.<br /><br />The query parameters do not contain valid values or include an invalid parameter.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1744717269803_730301_23937">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class QueryErrorGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="QueryErrorGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744717269803_730301_23937";
		/// <summary>Constant value for <see cref="QueryErrorGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1744717269803_730301_23937";
		/// <summary>Constant value for <see cref="QueryErrorGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;agent was unable to interpret the query.

The query parameters do not contain valid values or include an invalid parameter.&#10;
";
		/// <summary>Constant value for <see cref="QueryErrorGeneralization.Name" /></summary>
		public const string NAME = "QueryError";
		/// <summary>Constant value for <see cref="QueryErrorGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="QueryErrorGeneralization.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="QueryErrorGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="QueryErrorGeneralization.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_91b028d_1579560710732_245440_6708
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorClass);

		/// <inheritdoc />
		public new QueryErrorGeneralizationProperties Properties { get; } = new QueryErrorGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="QueryErrorGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorClass.ErrorClassProperties" />.
		/// </summary>
		public class QueryErrorGeneralizationProperties : Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorClass.ErrorClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="QueryErrorGeneralization" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
