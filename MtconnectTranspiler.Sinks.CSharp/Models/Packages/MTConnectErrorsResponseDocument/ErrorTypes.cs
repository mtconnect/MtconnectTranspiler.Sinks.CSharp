#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument.ErrorTypes;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument
{
	/// <summary>﻿This section provides semantic information for the types of {block(Error)}}.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___2024x_68e0225_1744886534332_597743_23496">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public class ErrorTypesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="ErrorTypesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744886534332_597743_23496";
		/// <summary>Constant value for <see cref="ErrorTypesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___2024x_68e0225_1744886534332_597743_23496";
		/// <summary>Constant value for <see cref="ErrorTypesPackage.Name" /></summary>
		public const string NAME = "Error Types";
		/// <summary>Constant value for <see cref="ErrorTypesPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the types of {block(Error)}}.&#10;
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
			InvalidParameterValueClass,
			InvalidXPathClass,
			QueryErrorGeneralization,
			AssetNotFoundClass,
			TooManyClass,
			UnsupportedClass,
			InvalidURIClass,
			InvalidRequestClass,
			InternalErrorGeneralization,
			NoDeviceClass,
			OutOfRangeClass,
			UnauthorizedClass,
			QueryParameterClass,
			InvalidQueryParameterClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.InvalidParameterValueClass _InvalidParameterValueClass;
	/// <summary>
	/// <inheritdoc cref="Package.InvalidParameterValueClass" path="/summary" />
	/// </summary>
	public Package.InvalidParameterValueClass InvalidParameterValueClass => _InvalidParameterValueClass ?? (_InvalidParameterValueClass = new Package.InvalidParameterValueClass());

	private Package.InvalidXPathClass _InvalidXPathClass;
	/// <summary>
	/// <inheritdoc cref="Package.InvalidXPathClass" path="/summary" />
	/// </summary>
	public Package.InvalidXPathClass InvalidXPathClass => _InvalidXPathClass ?? (_InvalidXPathClass = new Package.InvalidXPathClass());

	private Package.QueryErrorGeneralization _QueryErrorGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.QueryErrorGeneralization" path="/summary" />
	/// </summary>
	public Package.QueryErrorGeneralization QueryErrorGeneralization => _QueryErrorGeneralization ?? (_QueryErrorGeneralization = new Package.QueryErrorGeneralization());

	private Package.AssetNotFoundClass _AssetNotFoundClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetNotFoundClass" path="/summary" />
	/// </summary>
	public Package.AssetNotFoundClass AssetNotFoundClass => _AssetNotFoundClass ?? (_AssetNotFoundClass = new Package.AssetNotFoundClass());

	private Package.TooManyClass _TooManyClass;
	/// <summary>
	/// <inheritdoc cref="Package.TooManyClass" path="/summary" />
	/// </summary>
	public Package.TooManyClass TooManyClass => _TooManyClass ?? (_TooManyClass = new Package.TooManyClass());

	private Package.UnsupportedClass _UnsupportedClass;
	/// <summary>
	/// <inheritdoc cref="Package.UnsupportedClass" path="/summary" />
	/// </summary>
	public Package.UnsupportedClass UnsupportedClass => _UnsupportedClass ?? (_UnsupportedClass = new Package.UnsupportedClass());

	private Package.InvalidURIClass _InvalidURIClass;
	/// <summary>
	/// <inheritdoc cref="Package.InvalidURIClass" path="/summary" />
	/// </summary>
	public Package.InvalidURIClass InvalidURIClass => _InvalidURIClass ?? (_InvalidURIClass = new Package.InvalidURIClass());

	private Package.InvalidRequestClass _InvalidRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.InvalidRequestClass" path="/summary" />
	/// </summary>
	public Package.InvalidRequestClass InvalidRequestClass => _InvalidRequestClass ?? (_InvalidRequestClass = new Package.InvalidRequestClass());

	private Package.InternalErrorGeneralization _InternalErrorGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.InternalErrorGeneralization" path="/summary" />
	/// </summary>
	public Package.InternalErrorGeneralization InternalErrorGeneralization => _InternalErrorGeneralization ?? (_InternalErrorGeneralization = new Package.InternalErrorGeneralization());

	private Package.NoDeviceClass _NoDeviceClass;
	/// <summary>
	/// <inheritdoc cref="Package.NoDeviceClass" path="/summary" />
	/// </summary>
	public Package.NoDeviceClass NoDeviceClass => _NoDeviceClass ?? (_NoDeviceClass = new Package.NoDeviceClass());

	private Package.OutOfRangeClass _OutOfRangeClass;
	/// <summary>
	/// <inheritdoc cref="Package.OutOfRangeClass" path="/summary" />
	/// </summary>
	public Package.OutOfRangeClass OutOfRangeClass => _OutOfRangeClass ?? (_OutOfRangeClass = new Package.OutOfRangeClass());

	private Package.UnauthorizedClass _UnauthorizedClass;
	/// <summary>
	/// <inheritdoc cref="Package.UnauthorizedClass" path="/summary" />
	/// </summary>
	public Package.UnauthorizedClass UnauthorizedClass => _UnauthorizedClass ?? (_UnauthorizedClass = new Package.UnauthorizedClass());

	private Package.QueryParameterClass _QueryParameterClass;
	/// <summary>
	/// <inheritdoc cref="Package.QueryParameterClass" path="/summary" />
	/// </summary>
	public Package.QueryParameterClass QueryParameterClass => _QueryParameterClass ?? (_QueryParameterClass = new Package.QueryParameterClass());

	private Package.InvalidQueryParameterClass _InvalidQueryParameterClass;
	/// <summary>
	/// <inheritdoc cref="Package.InvalidQueryParameterClass" path="/summary" />
	/// </summary>
	public Package.InvalidQueryParameterClass InvalidQueryParameterClass => _InvalidQueryParameterClass ?? (_InvalidQueryParameterClass = new Package.InvalidQueryParameterClass());

	#endregion

	#region Enums
	#endregion
	}
}
