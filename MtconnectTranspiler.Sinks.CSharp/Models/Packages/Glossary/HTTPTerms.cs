using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.HTTPTerms;
// using Mtconnect;

namespace Mtconnect.Glossary {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class HTTPTermsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

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

	private Package.HTTPStatusCodeClass _HTTPStatusCodeClass;
	public Package.HTTPStatusCodeClass HTTPStatusCodeClass => _HTTPStatusCodeClass ?? (_HTTPStatusCodeClass = new Package.HTTPStatusCodeClass());
	private Package.HTTPServerClass _HTTPServerClass;
	public Package.HTTPServerClass HTTPServerClass => _HTTPServerClass ?? (_HTTPServerClass = new Package.HTTPServerClass());
	private Package.HTTPBodyClass _HTTPBodyClass;
	public Package.HTTPBodyClass HTTPBodyClass => _HTTPBodyClass ?? (_HTTPBodyClass = new Package.HTTPBodyClass());
	private Package.HTTPHeaderFieldClass _HTTPHeaderFieldClass;
	public Package.HTTPHeaderFieldClass HTTPHeaderFieldClass => _HTTPHeaderFieldClass ?? (_HTTPHeaderFieldClass = new Package.HTTPHeaderFieldClass());
	private Package.HTTPRequestURIClass _HTTPRequestURIClass;
	public Package.HTTPRequestURIClass HTTPRequestURIClass => _HTTPRequestURIClass ?? (_HTTPRequestURIClass = new Package.HTTPRequestURIClass());
	private Package.HTTPRequestMethodClass _HTTPRequestMethodClass;
	public Package.HTTPRequestMethodClass HTTPRequestMethodClass => _HTTPRequestMethodClass ?? (_HTTPRequestMethodClass = new Package.HTTPRequestMethodClass());
	private Package.HTTPResponseClass _HTTPResponseClass;
	public Package.HTTPResponseClass HTTPResponseClass => _HTTPResponseClass ?? (_HTTPResponseClass = new Package.HTTPResponseClass());
	private Package.HTTPMessagingClass _HTTPMessagingClass;
	public Package.HTTPMessagingClass HTTPMessagingClass => _HTTPMessagingClass ?? (_HTTPMessagingClass = new Package.HTTPMessagingClass());
	private Package.HTTPRequestGeneralization _HTTPRequestGeneralization;
	public Package.HTTPRequestGeneralization HTTPRequestGeneralization => _HTTPRequestGeneralization ?? (_HTTPRequestGeneralization = new Package.HTTPRequestGeneralization());
	private Package.HTTPQueryClass _HTTPQueryClass;
	public Package.HTTPQueryClass HTTPQueryClass => _HTTPQueryClass ?? (_HTTPQueryClass = new Package.HTTPQueryClass());
	private Package.HTTPVersionClass _HTTPVersionClass;
	public Package.HTTPVersionClass HTTPVersionClass => _HTTPVersionClass ?? (_HTTPVersionClass = new Package.HTTPVersionClass());
	private Package.HTTPMessageClass _HTTPMessageClass;
	public Package.HTTPMessageClass HTTPMessageClass => _HTTPMessageClass ?? (_HTTPMessageClass = new Package.HTTPMessageClass());
	private Package.HTTPHeaderClass _HTTPHeaderClass;
	public Package.HTTPHeaderClass HTTPHeaderClass => _HTTPHeaderClass ?? (_HTTPHeaderClass = new Package.HTTPHeaderClass());
	private Package.HTTPErrorMessageClass _HTTPErrorMessageClass;
	public Package.HTTPErrorMessageClass HTTPErrorMessageClass => _HTTPErrorMessageClass ?? (_HTTPErrorMessageClass = new Package.HTTPErrorMessageClass());
	private Package.HTTPRequestLineClass _HTTPRequestLineClass;
	public Package.HTTPRequestLineClass HTTPRequestLineClass => _HTTPRequestLineClass ?? (_HTTPRequestLineClass = new Package.HTTPRequestLineClass());
	private Package.HTTPMethodClass _HTTPMethodClass;
	public Package.HTTPMethodClass HTTPMethodClass => _HTTPMethodClass ?? (_HTTPMethodClass = new Package.HTTPMethodClass());
	}
}