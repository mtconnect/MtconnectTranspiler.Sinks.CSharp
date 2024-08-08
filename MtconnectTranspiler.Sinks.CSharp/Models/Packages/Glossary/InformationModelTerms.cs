using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.InformationModelTerms;
// using Mtconnect;

namespace Mtconnect.Glossary
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class InformationModelTermsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623665808313_870132_8816";
		
		/// <inheritdoc />
		public string Name => "InformationModelTerms";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ErrorInformationModelClass,
			AssetInformationModelClass,
			MTConnectInformationModelGeneralization,
			ObservationInformationModelClass,
			DeviceInformationModelClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.ErrorInformationModelClass _ErrorInformationModelClass;
	/// <summary>
	/// <inheritdoc cref="Package.ErrorInformationModelClass" path="/summary" />
	/// </summary>
	public Package.ErrorInformationModelClass ErrorInformationModelClass => _ErrorInformationModelClass ?? (_ErrorInformationModelClass = new Package.ErrorInformationModelClass());

	private Package.AssetInformationModelClass _AssetInformationModelClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetInformationModelClass" path="/summary" />
	/// </summary>
	public Package.AssetInformationModelClass AssetInformationModelClass => _AssetInformationModelClass ?? (_AssetInformationModelClass = new Package.AssetInformationModelClass());

	private Package.MTConnectInformationModelGeneralization _MTConnectInformationModelGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectInformationModelGeneralization" path="/summary" />
	/// </summary>
	public Package.MTConnectInformationModelGeneralization MTConnectInformationModelGeneralization => _MTConnectInformationModelGeneralization ?? (_MTConnectInformationModelGeneralization = new Package.MTConnectInformationModelGeneralization());

	private Package.ObservationInformationModelClass _ObservationInformationModelClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservationInformationModelClass" path="/summary" />
	/// </summary>
	public Package.ObservationInformationModelClass ObservationInformationModelClass => _ObservationInformationModelClass ?? (_ObservationInformationModelClass = new Package.ObservationInformationModelClass());

	private Package.DeviceInformationModelClass _DeviceInformationModelClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceInformationModelClass" path="/summary" />
	/// </summary>
	public Package.DeviceInformationModelClass DeviceInformationModelClass => _DeviceInformationModelClass ?? (_DeviceInformationModelClass = new Package.DeviceInformationModelClass());

	#endregion
	}
}