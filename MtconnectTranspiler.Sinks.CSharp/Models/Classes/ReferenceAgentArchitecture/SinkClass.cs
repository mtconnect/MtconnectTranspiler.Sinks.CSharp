#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.ReferenceAgentArchitecture
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1645213825022_980161_355">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SinkClass : IClass
	{
		/// <summary>Constant value for <see cref="SinkClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_4_45f01b9_1645213825022_980161_355";
		/// <summary>Constant value for <see cref="SinkClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1645213825022_980161_355";
		/// <summary>Constant value for <see cref="SinkClass.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="SinkClass.Name" /></summary>
		public const string NAME = "Sink";
		/// <summary>Constant value for <see cref="SinkClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="SinkClass.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="SinkClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="SinkClass.DeprecatedVersion" /></summary>
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
		public new SinkClassProperties Properties { get; } = new SinkClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="SinkClass" />.
		/// </summary>
		public class SinkClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}