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
	/// <summary>﻿<see cref="Interface">Interface</see> that coordinates the operations between two pieces of equipment, one of which controls the operation of a chuck.<br /><br />The piece of equipment that is controlling the chuck <b>MUST</b> provide the data item <see cref="ChuckState">ChuckState</see> as part of the set of information provided.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622717445425_648389_1075">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ChuckInterfaceGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="ChuckInterfaceGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622717445425_648389_1075";
		/// <summary>Constant value for <see cref="ChuckInterfaceGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622717445425_648389_1075";
		/// <summary>Constant value for <see cref="ChuckInterfaceGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Interface)}} that coordinates the operations between two pieces of equipment, one of which controls the operation of a chuck.

The piece of equipment that is controlling the chuck **MUST** provide the data item {{block(ChuckState)}} as part of the set of information provided.&#10;
";
		/// <summary>Constant value for <see cref="ChuckInterfaceGeneralization.Name" /></summary>
		public const string NAME = "ChuckInterface";
		/// <summary>Constant value for <see cref="ChuckInterfaceGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ChuckInterfaceGeneralization.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ChuckInterfaceGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.3";
		/// <summary>Constant value for <see cref="ChuckInterfaceGeneralization.DeprecatedVersion" /></summary>
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
		public new ChuckInterfaceGeneralizationProperties Properties { get; } = new ChuckInterfaceGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ChuckInterfaceGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.InterfaceInteractionModel.InterfaceClass.InterfaceClassProperties" />.
		/// </summary>
		public class ChuckInterfaceGeneralizationProperties : Mtconnect.InterfaceInteractionModel.InterfaceClass.InterfaceClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}