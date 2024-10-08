#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.Glossary
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1623664932175_240534_7738">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MTConnectTermsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="MTConnectTermsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664932175_240534_7738";
		/// <summary>Constant value for <see cref="MTConnectTermsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1623664932175_240534_7738";
		/// <summary>Constant value for <see cref="MTConnectTermsPackage.Name" /></summary>
		public const string NAME = "MTConnect Terms";
		/// <summary>Constant value for <see cref="MTConnectTermsPackage.Summary" /></summary>
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
			AdditionalObservationTermsPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ComponentClass,
			MTConnectAgentGeneralization,
			AssetGeneralization,
			CompositionClass,
			MTConnectDocumentGeneralization,
			ConfigurationGeneralization,
			DeviceClass,
			MTConnectInterfaceClass,
			ObservationClass,
			MTConnectEventGeneralization,
			DataItemClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.AdditionalObservationTermsPackage _AdditionalObservationTermsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.AdditionalObservationTermsPackage" path="/summary" />
	/// </summary>
	public Package.AdditionalObservationTermsPackage AdditionalObservationTermsPackage => _AdditionalObservationTermsPackage ?? (_AdditionalObservationTermsPackage = new Package.AdditionalObservationTermsPackage());

	#endregion

	#region Classes
	private Package.ComponentClass _ComponentClass;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentClass" path="/summary" />
	/// </summary>
	public Package.ComponentClass ComponentClass => _ComponentClass ?? (_ComponentClass = new Package.ComponentClass());

	private Package.MTConnectAgentGeneralization _MTConnectAgentGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectAgentGeneralization" path="/summary" />
	/// </summary>
	public Package.MTConnectAgentGeneralization MTConnectAgentGeneralization => _MTConnectAgentGeneralization ?? (_MTConnectAgentGeneralization = new Package.MTConnectAgentGeneralization());

	private Package.AssetGeneralization _AssetGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.AssetGeneralization" path="/summary" />
	/// </summary>
	public Package.AssetGeneralization AssetGeneralization => _AssetGeneralization ?? (_AssetGeneralization = new Package.AssetGeneralization());

	private Package.CompositionClass _CompositionClass;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionClass" path="/summary" />
	/// </summary>
	public Package.CompositionClass CompositionClass => _CompositionClass ?? (_CompositionClass = new Package.CompositionClass());

	private Package.MTConnectDocumentGeneralization _MTConnectDocumentGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectDocumentGeneralization" path="/summary" />
	/// </summary>
	public Package.MTConnectDocumentGeneralization MTConnectDocumentGeneralization => _MTConnectDocumentGeneralization ?? (_MTConnectDocumentGeneralization = new Package.MTConnectDocumentGeneralization());

	private Package.ConfigurationGeneralization _ConfigurationGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.ConfigurationGeneralization" path="/summary" />
	/// </summary>
	public Package.ConfigurationGeneralization ConfigurationGeneralization => _ConfigurationGeneralization ?? (_ConfigurationGeneralization = new Package.ConfigurationGeneralization());

	private Package.DeviceClass _DeviceClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceClass" path="/summary" />
	/// </summary>
	public Package.DeviceClass DeviceClass => _DeviceClass ?? (_DeviceClass = new Package.DeviceClass());

	private Package.MTConnectInterfaceClass _MTConnectInterfaceClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectInterfaceClass" path="/summary" />
	/// </summary>
	public Package.MTConnectInterfaceClass MTConnectInterfaceClass => _MTConnectInterfaceClass ?? (_MTConnectInterfaceClass = new Package.MTConnectInterfaceClass());

	private Package.ObservationClass _ObservationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservationClass" path="/summary" />
	/// </summary>
	public Package.ObservationClass ObservationClass => _ObservationClass ?? (_ObservationClass = new Package.ObservationClass());

	private Package.MTConnectEventGeneralization _MTConnectEventGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectEventGeneralization" path="/summary" />
	/// </summary>
	public Package.MTConnectEventGeneralization MTConnectEventGeneralization => _MTConnectEventGeneralization ?? (_MTConnectEventGeneralization = new Package.MTConnectEventGeneralization());

	private Package.DataItemClass _DataItemClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemClass" path="/summary" />
	/// </summary>
	public Package.DataItemClass DataItemClass => _DataItemClass ?? (_DataItemClass = new Package.DataItemClass());

	#endregion

	#region Enums
	#endregion
	}
}