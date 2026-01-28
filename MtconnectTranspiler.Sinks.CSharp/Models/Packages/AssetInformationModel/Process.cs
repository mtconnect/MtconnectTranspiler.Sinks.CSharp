#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.Process;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="Process">Process</see> model.<br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___2024x_68e0225_1758717892987_892930_673">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public class ProcessPackage : IPackage
	{
		/// <summary>Constant value for <see cref="ProcessPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1758717892987_892930_673";
		/// <summary>Constant value for <see cref="ProcessPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___2024x_68e0225_1758717892987_892930_673";
		/// <summary>Constant value for <see cref="ProcessPackage.Name" /></summary>
		public const string NAME = "Process";
		/// <summary>Constant value for <see cref="ProcessPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(Process)}} model.
&#10;
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
			TargetPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ProcessClass,
			ProcessArchetypeClass,
			RoutingClass,
			ProcessStepClass,
			ActivityGroupClass,
			ActivityClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.TargetPackage _TargetPackage;
	/// <summary>
	/// <inheritdoc cref="Package.TargetPackage" path="/summary" />
	/// </summary>
	public Package.TargetPackage TargetPackage => _TargetPackage ?? (_TargetPackage = new Package.TargetPackage());

	#endregion

	#region Classes
	private Package.ProcessClass _ProcessClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessClass" path="/summary" />
	/// </summary>
	public Package.ProcessClass ProcessClass => _ProcessClass ?? (_ProcessClass = new Package.ProcessClass());

	private Package.ProcessArchetypeClass _ProcessArchetypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessArchetypeClass" path="/summary" />
	/// </summary>
	public Package.ProcessArchetypeClass ProcessArchetypeClass => _ProcessArchetypeClass ?? (_ProcessArchetypeClass = new Package.ProcessArchetypeClass());

	private Package.RoutingClass _RoutingClass;
	/// <summary>
	/// <inheritdoc cref="Package.RoutingClass" path="/summary" />
	/// </summary>
	public Package.RoutingClass RoutingClass => _RoutingClass ?? (_RoutingClass = new Package.RoutingClass());

	private Package.ProcessStepClass _ProcessStepClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessStepClass" path="/summary" />
	/// </summary>
	public Package.ProcessStepClass ProcessStepClass => _ProcessStepClass ?? (_ProcessStepClass = new Package.ProcessStepClass());

	private Package.ActivityGroupClass _ActivityGroupClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivityGroupClass" path="/summary" />
	/// </summary>
	public Package.ActivityGroupClass ActivityGroupClass => _ActivityGroupClass ?? (_ActivityGroupClass = new Package.ActivityGroupClass());

	private Package.ActivityClass _ActivityClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivityClass" path="/summary" />
	/// </summary>
	public Package.ActivityClass ActivityClass => _ActivityClass ?? (_ActivityClass = new Package.ActivityClass());

	#endregion

	#region Enums
	#endregion
	}
}