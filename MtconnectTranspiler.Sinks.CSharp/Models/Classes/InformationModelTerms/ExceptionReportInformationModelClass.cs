#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.InformationModelTerms
{
	/// <summary>﻿<i>information model</i> that describes the <i>response document</i> returned by an <i>agent</i> when it encounters an exception in the <i>MTConnectAssets Response Document</i>, <i>MTConnectDevices Response Document</i> or <i>MTConnectStreams Response Document</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1744886744103_883625_23578">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class ExceptionReportInformationModelClass : IClass
	{
		/// <summary>Constant value for <see cref="ExceptionReportInformationModelClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744886744103_883625_23578";
		/// <summary>Constant value for <see cref="ExceptionReportInformationModelClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1744886744103_883625_23578";
		/// <summary>Constant value for <see cref="ExceptionReportInformationModelClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(information model)}} that describes the {{term(response document)}} returned by an {{term(agent)}} when it encounters an exception in the {{term(MTConnectAssets Response Document)}}, {{term(MTConnectDevices Response Document)}} or {{term(MTConnectStreams Response Document)}}.&#10;
";
		/// <summary>Constant value for <see cref="ExceptionReportInformationModelClass.Name" /></summary>
		public const string NAME = "ExceptionReport Information Model";
		/// <summary>Constant value for <see cref="ExceptionReportInformationModelClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ExceptionReportInformationModelClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ExceptionReportInformationModelClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="ExceptionReportInformationModelClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_68e0225_1623664375172_792733_2037
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.InformationModelTerms.MTConnectInformationModelGeneralization);

		/// <inheritdoc />
		public new ExceptionReportInformationModelClassProperties Properties { get; } = new ExceptionReportInformationModelClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ExceptionReportInformationModelClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.InformationModelTerms.MTConnectInformationModelGeneralization.MTConnectInformationModelGeneralizationProperties" />.
		/// </summary>
		public class ExceptionReportInformationModelClassProperties : Mtconnect.Glossary.InformationModelTerms.MTConnectInformationModelGeneralization.MTConnectInformationModelGeneralizationProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}