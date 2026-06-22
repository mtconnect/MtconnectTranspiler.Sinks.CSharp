#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectExceptionsReportResponseDocument;

namespace Mtconnect.Fundamentals.MTConnectProtocol
{
	/// <summary>﻿This section provides semantic information for the <see cref="MTConnectExceptionsReport">MTConnectExceptionsReport</see> entity.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___2024x_68e0225_1744801594606_394421_23291">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public class MTConnectExceptionsReportResponseDocumentPackage : IPackage
	{
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744801594606_394421_23291";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___2024x_68e0225_1744801594606_394421_23291";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentPackage.Name" /></summary>
		public const string NAME = "MTConnectExceptionsReport Response Document";
		/// <summary>Constant value for <see cref="MTConnectExceptionsReportResponseDocumentPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(MTConnectExceptionsReport)}} entity.&#10;
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
			MTConnectExceptionsReportClass,
			MTConnectDevicesExceptionsReportClass,
			MTConnectStreamsExceptionsReportClass,
			MTConnectAssetsExceptionsReportClass,
			ExceptionClass,
			TraceClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.MTConnectExceptionsReportClass _MTConnectExceptionsReportClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectExceptionsReportClass" path="/summary" />
	/// </summary>
	public Package.MTConnectExceptionsReportClass MTConnectExceptionsReportClass => _MTConnectExceptionsReportClass ?? (_MTConnectExceptionsReportClass = new Package.MTConnectExceptionsReportClass());

	private Package.MTConnectDevicesExceptionsReportClass _MTConnectDevicesExceptionsReportClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectDevicesExceptionsReportClass" path="/summary" />
	/// </summary>
	public Package.MTConnectDevicesExceptionsReportClass MTConnectDevicesExceptionsReportClass => _MTConnectDevicesExceptionsReportClass ?? (_MTConnectDevicesExceptionsReportClass = new Package.MTConnectDevicesExceptionsReportClass());

	private Package.MTConnectStreamsExceptionsReportClass _MTConnectStreamsExceptionsReportClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectStreamsExceptionsReportClass" path="/summary" />
	/// </summary>
	public Package.MTConnectStreamsExceptionsReportClass MTConnectStreamsExceptionsReportClass => _MTConnectStreamsExceptionsReportClass ?? (_MTConnectStreamsExceptionsReportClass = new Package.MTConnectStreamsExceptionsReportClass());

	private Package.MTConnectAssetsExceptionsReportClass _MTConnectAssetsExceptionsReportClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectAssetsExceptionsReportClass" path="/summary" />
	/// </summary>
	public Package.MTConnectAssetsExceptionsReportClass MTConnectAssetsExceptionsReportClass => _MTConnectAssetsExceptionsReportClass ?? (_MTConnectAssetsExceptionsReportClass = new Package.MTConnectAssetsExceptionsReportClass());

	private Package.ExceptionClass _ExceptionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ExceptionClass" path="/summary" />
	/// </summary>
	public Package.ExceptionClass ExceptionClass => _ExceptionClass ?? (_ExceptionClass = new Package.ExceptionClass());

	private Package.TraceClass _TraceClass;
	/// <summary>
	/// <inheritdoc cref="Package.TraceClass" path="/summary" />
	/// </summary>
	public Package.TraceClass TraceClass => _TraceClass ?? (_TraceClass = new Package.TraceClass());

	#endregion

	#region Enums
	#endregion
	}
}
