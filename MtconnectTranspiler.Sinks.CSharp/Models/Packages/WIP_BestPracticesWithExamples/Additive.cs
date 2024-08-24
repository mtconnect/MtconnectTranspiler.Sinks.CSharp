#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.WIP_BestPracticesWithExamples
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1690212965300_295487_830">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class AdditivePackage : IPackage
	{
		/// <summary>Constant value for <see cref="AdditivePackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1690212965300_295487_830";
		/// <summary>Constant value for <see cref="AdditivePackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1690212965300_295487_830";
		/// <summary>Constant value for <see cref="AdditivePackage.Name" /></summary>
		public const string NAME = "Additive";
		/// <summary>Constant value for <see cref="AdditivePackage.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}