#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Imports.CSVImports;

namespace Mtconnect.Imports
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579210647400_714066_3582">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class CSVImportsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579210647400_714066_3582";
		
		/// <inheritdoc />
		public string Name => "CSV Imports";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			PropertyMapClass,
			ImportDescriptorClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.PropertyMapClass _PropertyMapClass;
	/// <summary>
	/// <inheritdoc cref="Package.PropertyMapClass" path="/summary" />
	/// </summary>
	public Package.PropertyMapClass PropertyMapClass => _PropertyMapClass ?? (_PropertyMapClass = new Package.PropertyMapClass());

	private Package.ImportDescriptorClass _ImportDescriptorClass;
	/// <summary>
	/// <inheritdoc cref="Package.ImportDescriptorClass" path="/summary" />
	/// </summary>
	public Package.ImportDescriptorClass ImportDescriptorClass => _ImportDescriptorClass ?? (_ImportDescriptorClass = new Package.ImportDescriptorClass());

	#endregion

	#region Enums
	#endregion
	}
}