#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581814906056_937212_5515">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ObservedWarningClass : IClass
	{
		/// <summary>Constant value for <see cref="ObservedWarningClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1581814906056_937212_5515";
		/// <summary>Constant value for <see cref="ObservedWarningClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581814906056_937212_5515";
		/// <summary>Constant value for <see cref="ObservedWarningClass.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="ObservedWarningClass.Name" /></summary>
		public const string NAME = "Observed Warning";
		/// <summary>Constant value for <see cref="ObservedWarningClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ObservedWarningClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ObservedWarningClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="ObservedWarningClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1581814683848_300422_5123
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms.ObservedConditionClass);

		/// <inheritdoc />
		public new ObservedWarningClassProperties Properties { get; } = new ObservedWarningClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ObservedWarningClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms.ObservedConditionClass.ObservedConditionClassProperties" />.
		/// </summary>
		public class ObservedWarningClassProperties : Mtconnect.Glossary.MTConnectTerms.AdditionalObservationTerms.ObservedConditionClass.ObservedConditionClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}