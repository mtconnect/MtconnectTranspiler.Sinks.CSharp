#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.InterfaceInteractionModel.InterfaceTypes
{
	/// <summary>﻿<see cref="Interface">Interface</see> that coordinates the operations between a piece of equipment and another associated piece of equipment used to automatically handle various types of materials or services associated with the original piece of equipment.<br /><br />A material handler is a piece of equipment capable of providing any one, or more, of a variety of support services for another piece of equipment or a process like:<br /><br />* Loading/unloading material or tooling<br />* Part inspection<br />* Testing<br />* Cleaning<br /><br />A robot is a common example of a material handler.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622717400199_925921_979">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MaterialHandlerInterfaceGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="MaterialHandlerInterfaceGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622717400199_925921_979";
		/// <summary>Constant value for <see cref="MaterialHandlerInterfaceGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622717400199_925921_979";
		/// <summary>Constant value for <see cref="MaterialHandlerInterfaceGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Interface)}} that coordinates the operations between a piece of equipment and another associated piece of equipment used to automatically handle various types of materials or services associated with the original piece of equipment.

A material handler is a piece of equipment capable of providing any one, or more, of a variety of support services for another piece of equipment or a process like:

* Loading/unloading material or tooling
* Part inspection
* Testing
* Cleaning

A robot is a common example of a material handler.&#10;
";
		/// <summary>Constant value for <see cref="MaterialHandlerInterfaceGeneralization.Name" /></summary>
		public const string NAME = "MaterialHandlerInterface";
		/// <summary>Constant value for <see cref="MaterialHandlerInterfaceGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MaterialHandlerInterfaceGeneralization.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="MaterialHandlerInterfaceGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.3";
		/// <summary>Constant value for <see cref="MaterialHandlerInterfaceGeneralization.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1579572381996_964170_42252
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.InterfaceInteractionModel.InterfaceClass);

		/// <inheritdoc />
		public new MaterialHandlerInterfaceGeneralizationProperties Properties { get; } = new MaterialHandlerInterfaceGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MaterialHandlerInterfaceGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.InterfaceInteractionModel.InterfaceClass.InterfaceClassProperties" />.
		/// </summary>
		public class MaterialHandlerInterfaceGeneralizationProperties : Mtconnect.InterfaceInteractionModel.InterfaceClass.InterfaceClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}