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
	/// <summary>﻿requester does not have sufficient permissions to access the requested information.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1744717293160_193447_24005">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class UnauthorizedClass : IClass
	{
		/// <summary>Constant value for <see cref="UnauthorizedClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744717293160_193447_24005";
		/// <summary>Constant value for <see cref="UnauthorizedClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1744717293160_193447_24005";
		/// <summary>Constant value for <see cref="UnauthorizedClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;requester does not have sufficient permissions to access the requested information.&#10;
";
		/// <summary>Constant value for <see cref="UnauthorizedClass.Name" /></summary>
		public const string NAME = "Unauthorized";
		/// <summary>Constant value for <see cref="UnauthorizedClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="UnauthorizedClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="UnauthorizedClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="UnauthorizedClass.DeprecatedVersion" /></summary>
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
		public new UnauthorizedClassProperties Properties { get; } = new UnauthorizedClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="UnauthorizedClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorClass.ErrorClassProperties" />.
		/// </summary>
		public class UnauthorizedClassProperties : Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorClass.ErrorClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="UnauthorizedClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}