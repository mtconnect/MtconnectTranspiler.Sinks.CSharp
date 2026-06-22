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
	/// <summary>﻿request contains information that was not recognized by the agent.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1744717199272_790641_23763">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class InvalidRequestClass : IClass
	{
		/// <summary>Constant value for <see cref="InvalidRequestClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744717199272_790641_23763";
		/// <summary>Constant value for <see cref="InvalidRequestClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1744717199272_790641_23763";
		/// <summary>Constant value for <see cref="InvalidRequestClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;request contains information that was not recognized by the agent.&#10;
";
		/// <summary>Constant value for <see cref="InvalidRequestClass.Name" /></summary>
		public const string NAME = "InvalidRequest";
		/// <summary>Constant value for <see cref="InvalidRequestClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="InvalidRequestClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="InvalidRequestClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="InvalidRequestClass.DeprecatedVersion" /></summary>
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
		public new InvalidRequestClassProperties Properties { get; } = new InvalidRequestClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="InvalidRequestClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorClass.ErrorClassProperties" />.
		/// </summary>
		public class InvalidRequestClassProperties : Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorClass.ErrorClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				ErrorMessage,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ErrorMessageProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ErrorMessage</remarks>
			/// </summary>
			public new ErrorMessageProperty ErrorMessage { get; } = new ErrorMessageProperty();
			
			/// <summary>﻿possible reason for the <i>MTConnectErrors Response Document</i><br /><br /><br />
			/// </summary>
			public new sealed class ErrorMessageProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ErrorMessageProperty.Name" /></summary>
				public const string NAME = "ErrorMessage";
				/// <summary>Constant value for <see cref="ErrorMessageProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;possible reason for the {{term(MTConnectErrors Response Document)}}&#10;
";
				/// <summary>Constant value for <see cref="ErrorMessageProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="ErrorMessageProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ErrorMessageProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.6";
				/// <summary>Constant value for <see cref="ErrorMessageProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ErrorMessageProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ErrorMessageProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x;MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="ErrorMessageProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ErrorMessageProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="ErrorMessageProperty.Multiplicity" /></summary>
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
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="InvalidRequestClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
