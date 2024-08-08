using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel.InterfaceTypes
{
	/// <summary>
	/// <see cref="Interface">Interface</see> that coordinates the operations between a piece of equipment and another associated piece of equipment used to automatically handle various types of materials or services associated with the original piece of equipment.  A material handler is a piece of equipment capable of providing any one, or more, of a variety of support services for another piece of equipment or a process like:  * Loading/unloading material or tooling * Part inspection * Testing * Cleaning  A robot is a common example of a material handler.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MaterialHandlerInterfaceGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622717400199_925921_979";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Interface"">Interface</see> that coordinates the operations between a piece of equipment and another associated piece of equipment used to automatically handle various types of materials or services associated with the original piece of equipment.  A material handler is a piece of equipment capable of providing any one, or more, of a variety of support services for another piece of equipment or a process like:  * Loading/unloading material or tooling * Part inspection * Testing * Cleaning  A robot is a common example of a material handler.";

		/// <inheritdoc />
		public string Name => "MaterialHandlerInterfaceGeneralization";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572381996_964170_42252";

		public IPropertyList Properties => null;

	}
}