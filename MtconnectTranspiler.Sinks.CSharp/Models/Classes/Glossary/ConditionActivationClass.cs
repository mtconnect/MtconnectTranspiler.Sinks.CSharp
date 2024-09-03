#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>﻿state transition from <c>Normal</c> to either <c>Warning</c> or <c>Fault</c>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1696057534085_612559_255">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ConditionActivationClass : IClass
	{
		/// <summary>Constant value for <see cref="ConditionActivationClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1696057534085_612559_255";
		/// <summary>Constant value for <see cref="ConditionActivationClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1696057534085_612559_255";
		/// <summary>Constant value for <see cref="ConditionActivationClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;state transition from `Normal` to either `Warning` or `Fault`.&#10;
";
		/// <summary>Constant value for <see cref="ConditionActivationClass.Name" /></summary>
		public const string NAME = "condition activation";
		/// <summary>Constant value for <see cref="ConditionActivationClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ConditionActivationClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ConditionActivationClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.3";
		/// <summary>Constant value for <see cref="ConditionActivationClass.DeprecatedVersion" /></summary>
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
		public new ConditionActivationClassProperties Properties { get; } = new ConditionActivationClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ConditionActivationClass" />.
		/// </summary>
		public class ConditionActivationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}