
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.Glossary.MTConnectTerms;

using Mtconnect;

namespace Mtconnect.Glossary {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MTConnectTermsPackage {

	private Package.AdditionalObservationTermsPackage _AdditionalObservationTermsPackage;
	public Package.AdditionalObservationTermsPackage AdditionalObservationTermsPackage => _AdditionalObservationTermsPackage ?? (_AdditionalObservationTermsPackage = new Package.AdditionalObservationTermsPackage());


	private Package.ComponentClass _Component;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ComponentClass Component => _Component ?? (_Component = new Package.ComponentClass());

	private Package.MTConnectAgentClass _MTConnectAgent;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MTConnectAgentClass MTConnectAgent => _MTConnectAgent ?? (_MTConnectAgent = new Package.MTConnectAgentClass());

	private Package.AssetClass _Asset;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AssetClass Asset => _Asset ?? (_Asset = new Package.AssetClass());

	private Package.CompositionClass _Composition;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CompositionClass Composition => _Composition ?? (_Composition = new Package.CompositionClass());

	private Package.MTConnectDocumentClass _MTConnectDocument;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MTConnectDocumentClass MTConnectDocument => _MTConnectDocument ?? (_MTConnectDocument = new Package.MTConnectDocumentClass());

	private Package.ConfigurationClass _Configuration;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ConfigurationClass Configuration => _Configuration ?? (_Configuration = new Package.ConfigurationClass());

	private Package.DeviceClass _Device;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeviceClass Device => _Device ?? (_Device = new Package.DeviceClass());

	private Package.MTConnectInterfaceClass _MTConnectInterface;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MTConnectInterfaceClass MTConnectInterface => _MTConnectInterface ?? (_MTConnectInterface = new Package.MTConnectInterfaceClass());

	private Package.ObservationClass _Observation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ObservationClass Observation => _Observation ?? (_Observation = new Package.ObservationClass());

	private Package.MTConnectEventClass _MTConnectEvent;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MTConnectEventClass MTConnectEvent => _MTConnectEvent ?? (_MTConnectEvent = new Package.MTConnectEventClass());

	private Package.DataItemClass _DataItem;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DataItemClass DataItem => _DataItem ?? (_DataItem = new Package.DataItemClass());
	}
}