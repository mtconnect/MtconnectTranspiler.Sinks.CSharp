#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectExceptionsReportResponseDocument
{
	/// <summary>﻿root entity of an <i>MTConnectExceptionsReport Response Document</i> that contains the <i>ExceptionReport Information Model</i>.<br /><br />![MTConnectExceptionsReport](figures/MTConnectExceptionsReport.png "MTConnectAssets"){: width="0.8"}<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1744801655431_368883_23324">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class MTConnectExceptionsReportClass : IClass
	{
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744801655431_368883_23324";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1744801655431_368883_23324";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;root entity of an {{term(MTConnectExceptionsReport Response Document)}} that contains the {{term(ExceptionReport Information Model)}}.

![MTConnectExceptionsReport](figures/MTConnectExceptionsReport.png ""MTConnectAssets""){: width=""0.8""}&#10;
";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportClass.Name" /></summary>
		public const string NAME = "MTConnectExceptionsReport";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportClass.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportClass.DeprecatedVersion" /></summary>
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
		public Type Generalization => null;

		/// <inheritdoc />
		public new MTConnectExceptionsReportClassProperties Properties { get; } = new MTConnectExceptionsReportClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectExceptionsReportClass" />.
		/// </summary>
		public class MTConnectExceptionsReportClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}