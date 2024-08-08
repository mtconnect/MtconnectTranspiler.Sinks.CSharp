using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Components;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel
{
	/// <summary>
	/// This section provides semantic information for the <see cref="Component">Component</see> entity. {{figure(Components)}} shows the <see cref="Component">Component</see> model.   ![Components](figures/Components.png "Components"){: width="0.8"}  > Note: See <see cref="Components Schema Diagrams">Components Schema Diagrams</see> for XML schema. /// Components Model
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class ComponentsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_6F87CB48_AFED_473f_92DF_E7AFDAFD3CAC";
		
		/// <inheritdoc />
		public string Name => "Components";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""Component"">Component</see> entity. {{figure(Components)}} shows the <see cref=""Component"">Component</see> model.   ![Components](figures/Components.png ""Components""){: width=""0.8""}  > Note: See <see cref=""Components Schema Diagrams"">Components Schema Diagrams</see> for XML schema. /// Components Model";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			ComponentTypesPackage,
			DevicesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ComponentGeneralization,
			DescriptionClass,
		};
		#region Packages
	private Package.ComponentTypesPackage _ComponentTypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentTypesPackage" path="/summary" />
	/// </summary>
	public Package.ComponentTypesPackage ComponentTypesPackage => _ComponentTypesPackage ?? (_ComponentTypesPackage = new Package.ComponentTypesPackage());

	private Package.DevicesPackage _DevicesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.DevicesPackage" path="/summary" />
	/// </summary>
	public Package.DevicesPackage DevicesPackage => _DevicesPackage ?? (_DevicesPackage = new Package.DevicesPackage());

	#endregion

	#region Classes
	private Package.ComponentGeneralization _ComponentGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentGeneralization" path="/summary" />
	/// </summary>
	public Package.ComponentGeneralization ComponentGeneralization => _ComponentGeneralization ?? (_ComponentGeneralization = new Package.ComponentGeneralization());

	private Package.DescriptionClass _DescriptionClass;
	/// <summary>
	/// <inheritdoc cref="Package.DescriptionClass" path="/summary" />
	/// </summary>
	public Package.DescriptionClass DescriptionClass => _DescriptionClass ?? (_DescriptionClass = new Package.DescriptionClass());

	#endregion
	}
}