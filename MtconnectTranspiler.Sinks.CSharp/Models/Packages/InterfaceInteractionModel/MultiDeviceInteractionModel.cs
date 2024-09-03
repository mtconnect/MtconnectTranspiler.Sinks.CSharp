#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel;

namespace Mtconnect.InterfaceInteractionModel
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1622718371677_761407_1169">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MultiDeviceInteractionModelPackage : IPackage
	{
		/// <summary>Constant value for <see cref="MultiDeviceInteractionModelPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622718371677_761407_1169";
		/// <summary>Constant value for <see cref="MultiDeviceInteractionModelPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1622718371677_761407_1169";
		/// <summary>Constant value for <see cref="MultiDeviceInteractionModelPackage.Name" /></summary>
		public const string NAME = "Multi-Device Interaction Model";
		/// <summary>Constant value for <see cref="MultiDeviceInteractionModelPackage.Summary" /></summary>
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
			TasksInformationModelPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.TasksInformationModelPackage _TasksInformationModelPackage;
	/// <summary>
	/// <inheritdoc cref="Package.TasksInformationModelPackage" path="/summary" />
	/// </summary>
	public Package.TasksInformationModelPackage TasksInformationModelPackage => _TasksInformationModelPackage ?? (_TasksInformationModelPackage = new Package.TasksInformationModelPackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}