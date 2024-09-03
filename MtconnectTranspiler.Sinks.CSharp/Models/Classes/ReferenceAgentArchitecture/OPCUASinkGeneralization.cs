#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ReferenceAgentArchitecture
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1645214716551_214286_922">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class OPCUASinkGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="OPCUASinkGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_4_45f01b9_1645214716551_214286_922";
		/// <summary>Constant value for <see cref="OPCUASinkGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1645214716551_214286_922";
		/// <summary>Constant value for <see cref="OPCUASinkGeneralization.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="OPCUASinkGeneralization.Name" /></summary>
		public const string NAME = "OPC UA Sink";
		/// <summary>Constant value for <see cref="OPCUASinkGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="OPCUASinkGeneralization.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="OPCUASinkGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="OPCUASinkGeneralization.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_4_45f01b9_1645213825022_980161_355
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ReferenceAgentArchitecture.SinkClass);

		/// <inheritdoc />
		public new OPCUASinkGeneralizationProperties Properties { get; } = new OPCUASinkGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="OPCUASinkGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ReferenceAgentArchitecture.SinkClass.SinkClassProperties" />.
		/// </summary>
		public class OPCUASinkGeneralizationProperties : Mtconnect.ReferenceAgentArchitecture.SinkClass.SinkClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}