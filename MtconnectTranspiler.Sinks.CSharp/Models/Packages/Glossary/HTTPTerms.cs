using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.HTTPTerms;

namespace Mtconnect.Glossary
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class HTTPTermsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664707546_436843_7242";
		
		/// <inheritdoc />
		public string Name => "HTTP Terms";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			HTTPStatusCodeClass,
			HTTPServerClass,
			HTTPBodyClass,
			HTTPHeaderFieldClass,
			HTTPRequestURIClass,
			HTTPRequestMethodClass,
			HTTPResponseClass,
			HTTPMessagingClass,
			HTTPRequestGeneralization,
			HTTPQueryClass,
			HTTPVersionClass,
			HTTPMessageClass,
			HTTPHeaderClass,
			HTTPErrorMessageClass,
			HTTPRequestLineClass,
			HTTPMethodClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.HTTPStatusCodeClass _HTTPStatusCodeClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPStatusCodeClass" path="/summary" />
	/// </summary>
	public Package.HTTPStatusCodeClass HTTPStatusCodeClass => _HTTPStatusCodeClass ?? (_HTTPStatusCodeClass = new Package.HTTPStatusCodeClass());

	private Package.HTTPServerClass _HTTPServerClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPServerClass" path="/summary" />
	/// </summary>
	public Package.HTTPServerClass HTTPServerClass => _HTTPServerClass ?? (_HTTPServerClass = new Package.HTTPServerClass());

	private Package.HTTPBodyClass _HTTPBodyClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPBodyClass" path="/summary" />
	/// </summary>
	public Package.HTTPBodyClass HTTPBodyClass => _HTTPBodyClass ?? (_HTTPBodyClass = new Package.HTTPBodyClass());

	private Package.HTTPHeaderFieldClass _HTTPHeaderFieldClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPHeaderFieldClass" path="/summary" />
	/// </summary>
	public Package.HTTPHeaderFieldClass HTTPHeaderFieldClass => _HTTPHeaderFieldClass ?? (_HTTPHeaderFieldClass = new Package.HTTPHeaderFieldClass());

	private Package.HTTPRequestURIClass _HTTPRequestURIClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPRequestURIClass" path="/summary" />
	/// </summary>
	public Package.HTTPRequestURIClass HTTPRequestURIClass => _HTTPRequestURIClass ?? (_HTTPRequestURIClass = new Package.HTTPRequestURIClass());

	private Package.HTTPRequestMethodClass _HTTPRequestMethodClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPRequestMethodClass" path="/summary" />
	/// </summary>
	public Package.HTTPRequestMethodClass HTTPRequestMethodClass => _HTTPRequestMethodClass ?? (_HTTPRequestMethodClass = new Package.HTTPRequestMethodClass());

	private Package.HTTPResponseClass _HTTPResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPResponseClass" path="/summary" />
	/// </summary>
	public Package.HTTPResponseClass HTTPResponseClass => _HTTPResponseClass ?? (_HTTPResponseClass = new Package.HTTPResponseClass());

	private Package.HTTPMessagingClass _HTTPMessagingClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPMessagingClass" path="/summary" />
	/// </summary>
	public Package.HTTPMessagingClass HTTPMessagingClass => _HTTPMessagingClass ?? (_HTTPMessagingClass = new Package.HTTPMessagingClass());

	private Package.HTTPRequestGeneralization _HTTPRequestGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPRequestGeneralization" path="/summary" />
	/// </summary>
	public Package.HTTPRequestGeneralization HTTPRequestGeneralization => _HTTPRequestGeneralization ?? (_HTTPRequestGeneralization = new Package.HTTPRequestGeneralization());

	private Package.HTTPQueryClass _HTTPQueryClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPQueryClass" path="/summary" />
	/// </summary>
	public Package.HTTPQueryClass HTTPQueryClass => _HTTPQueryClass ?? (_HTTPQueryClass = new Package.HTTPQueryClass());

	private Package.HTTPVersionClass _HTTPVersionClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPVersionClass" path="/summary" />
	/// </summary>
	public Package.HTTPVersionClass HTTPVersionClass => _HTTPVersionClass ?? (_HTTPVersionClass = new Package.HTTPVersionClass());

	private Package.HTTPMessageClass _HTTPMessageClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPMessageClass" path="/summary" />
	/// </summary>
	public Package.HTTPMessageClass HTTPMessageClass => _HTTPMessageClass ?? (_HTTPMessageClass = new Package.HTTPMessageClass());

	private Package.HTTPHeaderClass _HTTPHeaderClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPHeaderClass" path="/summary" />
	/// </summary>
	public Package.HTTPHeaderClass HTTPHeaderClass => _HTTPHeaderClass ?? (_HTTPHeaderClass = new Package.HTTPHeaderClass());

	private Package.HTTPErrorMessageClass _HTTPErrorMessageClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPErrorMessageClass" path="/summary" />
	/// </summary>
	public Package.HTTPErrorMessageClass HTTPErrorMessageClass => _HTTPErrorMessageClass ?? (_HTTPErrorMessageClass = new Package.HTTPErrorMessageClass());

	private Package.HTTPRequestLineClass _HTTPRequestLineClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPRequestLineClass" path="/summary" />
	/// </summary>
	public Package.HTTPRequestLineClass HTTPRequestLineClass => _HTTPRequestLineClass ?? (_HTTPRequestLineClass = new Package.HTTPRequestLineClass());

	private Package.HTTPMethodClass _HTTPMethodClass;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPMethodClass" path="/summary" />
	/// </summary>
	public Package.HTTPMethodClass HTTPMethodClass => _HTTPMethodClass ?? (_HTTPMethodClass = new Package.HTTPMethodClass());

	#endregion
	}
}