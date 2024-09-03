#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ReferenceAgentArchitecture.Rest.Storage;

namespace Mtconnect.ReferenceAgentArchitecture.Rest
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1585535517110_128182_1817">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class StoragePackage : IPackage
	{
		/// <summary>Constant value for <see cref="StoragePackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1585535517110_128182_1817";
		/// <summary>Constant value for <see cref="StoragePackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_45f01b9_1585535517110_128182_1817";
		/// <summary>Constant value for <see cref="StoragePackage.Name" /></summary>
		public const string NAME = "Storage";
		/// <summary>Constant value for <see cref="StoragePackage.Summary" /></summary>
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
			CircularBuffferClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.CircularBuffferClass _CircularBuffferClass;
	/// <summary>
	/// <inheritdoc cref="Package.CircularBuffferClass" path="/summary" />
	/// </summary>
	public Package.CircularBuffferClass CircularBuffferClass => _CircularBuffferClass ?? (_CircularBuffferClass = new Package.CircularBuffferClass());

	#endregion

	#region Enums
	#endregion
	}
}