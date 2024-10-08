#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.InformationModelTerms;

namespace Mtconnect.Glossary
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1623665808313_870132_8816">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class InformationModelTermsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="InformationModelTermsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623665808313_870132_8816";
		/// <summary>Constant value for <see cref="InformationModelTermsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1623665808313_870132_8816";
		/// <summary>Constant value for <see cref="InformationModelTermsPackage.Name" /></summary>
		public const string NAME = "Information Model Terms";
		/// <summary>Constant value for <see cref="InformationModelTermsPackage.Summary" /></summary>
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
			ErrorInformationModelClass,
			AssetInformationModelClass,
			MTConnectInformationModelGeneralization,
			ObservationInformationModelClass,
			DeviceInformationModelClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}