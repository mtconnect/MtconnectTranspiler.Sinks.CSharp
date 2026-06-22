#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.Motion
{
	/// <summary>﻿axis along or around which the <see cref="Component">Component</see> moves relative to a coordinate system.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_7D0C7298_9CC4_4c45_A016_310B9A55DD7F">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class AbstractAxisClass : IClass
	{
		/// <summary>Constant value for <see cref="AbstractAxisClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_7D0C7298_9CC4_4c45_A016_310B9A55DD7F";
		/// <summary>Constant value for <see cref="AbstractAxisClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_7D0C7298_9CC4_4c45_A016_310B9A55DD7F";
		/// <summary>Constant value for <see cref="AbstractAxisClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;axis along or around which the {{block(Component)}} moves relative to a coordinate system.&#10;
";
		/// <summary>Constant value for <see cref="AbstractAxisClass.Name" /></summary>
		public const string NAME = "AbstractAxis";
		/// <summary>Constant value for <see cref="AbstractAxisClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="AbstractAxisClass.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="AbstractAxisClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="AbstractAxisClass.DeprecatedVersion" /></summary>
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
		public new AbstractAxisClassProperties Properties { get; } = new AbstractAxisClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AbstractAxisClass" />.
		/// </summary>
		public class AbstractAxisClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="AbstractAxisClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
