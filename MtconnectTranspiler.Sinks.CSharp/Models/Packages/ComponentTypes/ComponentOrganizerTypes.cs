#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Components.ComponentTypes.ComponentOrganizerTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿This section provides semantic information for the types of <see cref="Component">Component</see> that are used to <i>organize</i> other <see cref="Component">Component</see> types. <br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1629981910583_240995_47">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public class ComponentOrganizerTypesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="ComponentOrganizerTypesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1629981910583_240995_47";
		/// <summary>Constant value for <see cref="ComponentOrganizerTypesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1629981910583_240995_47";
		/// <summary>Constant value for <see cref="ComponentOrganizerTypesPackage.Name" /></summary>
		public const string NAME = "Component Organizer Types";
		/// <summary>Constant value for <see cref="ComponentOrganizerTypesPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the types of {{block(Component)}} that are used to {{term(organize)}} other {{block(Component)}} types. &#10;
";

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
			StructuresClass,
			InterfacesClass,
			AuxiliariesClass,
			SystemsClass,
			AdaptersClass,
			ResourcesClass,
			AxesClass,
			ProcessesClass,
			PartsClass,
			MaterialsClass,
			ControllersClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.StructuresClass _StructuresClass;
	/// <summary>
	/// <inheritdoc cref="Package.StructuresClass" path="/summary" />
	/// </summary>
	public Package.StructuresClass StructuresClass => _StructuresClass ?? (_StructuresClass = new Package.StructuresClass());

	private Package.InterfacesClass _InterfacesClass;
	/// <summary>
	/// <inheritdoc cref="Package.InterfacesClass" path="/summary" />
	/// </summary>
	public Package.InterfacesClass InterfacesClass => _InterfacesClass ?? (_InterfacesClass = new Package.InterfacesClass());

	private Package.AuxiliariesClass _AuxiliariesClass;
	/// <summary>
	/// <inheritdoc cref="Package.AuxiliariesClass" path="/summary" />
	/// </summary>
	public Package.AuxiliariesClass AuxiliariesClass => _AuxiliariesClass ?? (_AuxiliariesClass = new Package.AuxiliariesClass());

	private Package.SystemsClass _SystemsClass;
	/// <summary>
	/// <inheritdoc cref="Package.SystemsClass" path="/summary" />
	/// </summary>
	public Package.SystemsClass SystemsClass => _SystemsClass ?? (_SystemsClass = new Package.SystemsClass());

	private Package.AdaptersClass _AdaptersClass;
	/// <summary>
	/// <inheritdoc cref="Package.AdaptersClass" path="/summary" />
	/// </summary>
	public Package.AdaptersClass AdaptersClass => _AdaptersClass ?? (_AdaptersClass = new Package.AdaptersClass());

	private Package.ResourcesClass _ResourcesClass;
	/// <summary>
	/// <inheritdoc cref="Package.ResourcesClass" path="/summary" />
	/// </summary>
	public Package.ResourcesClass ResourcesClass => _ResourcesClass ?? (_ResourcesClass = new Package.ResourcesClass());

	private Package.AxesClass _AxesClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxesClass" path="/summary" />
	/// </summary>
	public Package.AxesClass AxesClass => _AxesClass ?? (_AxesClass = new Package.AxesClass());

	private Package.ProcessesClass _ProcessesClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessesClass" path="/summary" />
	/// </summary>
	public Package.ProcessesClass ProcessesClass => _ProcessesClass ?? (_ProcessesClass = new Package.ProcessesClass());

	private Package.PartsClass _PartsClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartsClass" path="/summary" />
	/// </summary>
	public Package.PartsClass PartsClass => _PartsClass ?? (_PartsClass = new Package.PartsClass());

	private Package.MaterialsClass _MaterialsClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialsClass" path="/summary" />
	/// </summary>
	public Package.MaterialsClass MaterialsClass => _MaterialsClass ?? (_MaterialsClass = new Package.MaterialsClass());

	private Package.ControllersClass _ControllersClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControllersClass" path="/summary" />
	/// </summary>
	public Package.ControllersClass ControllersClass => _ControllersClass ?? (_ControllersClass = new Package.ControllersClass());

	#endregion

	#region Enums
	#endregion
	}
}