using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel;

namespace Mtconnect.InterfaceInteractionModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class MultiDeviceInteractionModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622718371677_761407_1169";
		
		/// <inheritdoc />
		public string Name => "MultiDeviceInteractionModel";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			TasksInformationModelPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
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
	}
}