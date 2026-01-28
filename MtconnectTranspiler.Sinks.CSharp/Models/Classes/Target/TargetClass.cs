#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.Process.Target
{
	/// <summary>﻿information related to a <see cref="Device">Device</see> or <see cref="Component">Component</see> that may implement a <see cref="Process">Process</see> or a <see cref="Task">Task</see><br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1758718089527_408759_881">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class TargetClass : IClass
	{
		/// <summary>Constant value for <see cref="TargetClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1758718089527_408759_881";
		/// <summary>Constant value for <see cref="TargetClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1758718089527_408759_881";
		/// <summary>Constant value for <see cref="TargetClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;information related to a {{block(Device)}} or {{block(Component)}} that may implement a {{block(Process)}} or a {{block(Task)}}

&#10;
";
		/// <summary>Constant value for <see cref="TargetClass.Name" /></summary>
		public const string NAME = "Target";
		/// <summary>Constant value for <see cref="TargetClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="TargetClass.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="TargetClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.7";
		/// <summary>Constant value for <see cref="TargetClass.DeprecatedVersion" /></summary>
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
		public new TargetClassProperties Properties { get; } = new TargetClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="TargetClass" />.
		/// </summary>
		public class TargetClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="TargetClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}