#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems
{
	/// <summary>﻿translations along X, Y, and Z axes are expressed as x,y, and z respectively within a 3-dimensional vector. <br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1583182362743_846297_4736">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class AbstractTranslationClass : IClass
	{
		/// <summary>Constant value for <see cref="AbstractTranslationClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1583182362743_846297_4736";
		/// <summary>Constant value for <see cref="AbstractTranslationClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1583182362743_846297_4736";
		/// <summary>Constant value for <see cref="AbstractTranslationClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;translations along X, Y, and Z axes are expressed as x,y, and z respectively within a 3-dimensional vector. &#10;
";
		/// <summary>Constant value for <see cref="AbstractTranslationClass.Name" /></summary>
		public const string NAME = "AbstractTranslation";
		/// <summary>Constant value for <see cref="AbstractTranslationClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="AbstractTranslationClass.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="AbstractTranslationClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.6";
		/// <summary>Constant value for <see cref="AbstractTranslationClass.DeprecatedVersion" /></summary>
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
		public new AbstractTranslationClassProperties Properties { get; } = new AbstractTranslationClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AbstractTranslationClass" />.
		/// </summary>
		public class AbstractTranslationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="AbstractTranslationClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
