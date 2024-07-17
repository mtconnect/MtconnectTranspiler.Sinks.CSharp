using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.ProtocolTerms;
// using Mtconnect;

namespace Mtconnect.Glossary {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ProtocolTermsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			MTConnectStreamsResponseDocumentClass,
			MTConnectAssetsResponseDocumentClass,
			MTConnectDevicesResponseDocumentClass,
			MTConnectErrorsResponseDocumentClass,
			MTConnectResponseDocumentClass,
			TransportProtocolGeneralization,
			SampleRequestClass,
			MTConnectRequestGeneralization,
			ProbeRequestClass,
			StreamingDataClass,
			PublishClass,
			CurrentRequestClass,
			ProtocolClass,
			DataStreamingClass,
			PublishAndSubscribeClass,
			SubscribeClass,
			AssetRequestClass,
			RequestClass,
			ResponseClass,
			RequestAndResponseClass,
		};

	private Package.MTConnectStreamsResponseDocumentClass _MTConnectStreamsResponseDocumentClass;
	public Package.MTConnectStreamsResponseDocumentClass MTConnectStreamsResponseDocumentClass => _MTConnectStreamsResponseDocumentClass ?? (_MTConnectStreamsResponseDocumentClass = new Package.MTConnectStreamsResponseDocumentClass());
	private Package.MTConnectAssetsResponseDocumentClass _MTConnectAssetsResponseDocumentClass;
	public Package.MTConnectAssetsResponseDocumentClass MTConnectAssetsResponseDocumentClass => _MTConnectAssetsResponseDocumentClass ?? (_MTConnectAssetsResponseDocumentClass = new Package.MTConnectAssetsResponseDocumentClass());
	private Package.MTConnectDevicesResponseDocumentClass _MTConnectDevicesResponseDocumentClass;
	public Package.MTConnectDevicesResponseDocumentClass MTConnectDevicesResponseDocumentClass => _MTConnectDevicesResponseDocumentClass ?? (_MTConnectDevicesResponseDocumentClass = new Package.MTConnectDevicesResponseDocumentClass());
	private Package.MTConnectErrorsResponseDocumentClass _MTConnectErrorsResponseDocumentClass;
	public Package.MTConnectErrorsResponseDocumentClass MTConnectErrorsResponseDocumentClass => _MTConnectErrorsResponseDocumentClass ?? (_MTConnectErrorsResponseDocumentClass = new Package.MTConnectErrorsResponseDocumentClass());
	private Package.MTConnectResponseDocumentClass _MTConnectResponseDocumentClass;
	public Package.MTConnectResponseDocumentClass MTConnectResponseDocumentClass => _MTConnectResponseDocumentClass ?? (_MTConnectResponseDocumentClass = new Package.MTConnectResponseDocumentClass());
	private Package.TransportProtocolGeneralization _TransportProtocolGeneralization;
	public Package.TransportProtocolGeneralization TransportProtocolGeneralization => _TransportProtocolGeneralization ?? (_TransportProtocolGeneralization = new Package.TransportProtocolGeneralization());
	private Package.SampleRequestClass _SampleRequestClass;
	public Package.SampleRequestClass SampleRequestClass => _SampleRequestClass ?? (_SampleRequestClass = new Package.SampleRequestClass());
	private Package.MTConnectRequestGeneralization _MTConnectRequestGeneralization;
	public Package.MTConnectRequestGeneralization MTConnectRequestGeneralization => _MTConnectRequestGeneralization ?? (_MTConnectRequestGeneralization = new Package.MTConnectRequestGeneralization());
	private Package.ProbeRequestClass _ProbeRequestClass;
	public Package.ProbeRequestClass ProbeRequestClass => _ProbeRequestClass ?? (_ProbeRequestClass = new Package.ProbeRequestClass());
	private Package.StreamingDataClass _StreamingDataClass;
	public Package.StreamingDataClass StreamingDataClass => _StreamingDataClass ?? (_StreamingDataClass = new Package.StreamingDataClass());
	private Package.PublishClass _PublishClass;
	public Package.PublishClass PublishClass => _PublishClass ?? (_PublishClass = new Package.PublishClass());
	private Package.CurrentRequestClass _CurrentRequestClass;
	public Package.CurrentRequestClass CurrentRequestClass => _CurrentRequestClass ?? (_CurrentRequestClass = new Package.CurrentRequestClass());
	private Package.ProtocolClass _ProtocolClass;
	public Package.ProtocolClass ProtocolClass => _ProtocolClass ?? (_ProtocolClass = new Package.ProtocolClass());
	private Package.DataStreamingClass _DataStreamingClass;
	public Package.DataStreamingClass DataStreamingClass => _DataStreamingClass ?? (_DataStreamingClass = new Package.DataStreamingClass());
	private Package.PublishAndSubscribeClass _PublishAndSubscribeClass;
	public Package.PublishAndSubscribeClass PublishAndSubscribeClass => _PublishAndSubscribeClass ?? (_PublishAndSubscribeClass = new Package.PublishAndSubscribeClass());
	private Package.SubscribeClass _SubscribeClass;
	public Package.SubscribeClass SubscribeClass => _SubscribeClass ?? (_SubscribeClass = new Package.SubscribeClass());
	private Package.AssetRequestClass _AssetRequestClass;
	public Package.AssetRequestClass AssetRequestClass => _AssetRequestClass ?? (_AssetRequestClass = new Package.AssetRequestClass());
	private Package.RequestClass _RequestClass;
	public Package.RequestClass RequestClass => _RequestClass ?? (_RequestClass = new Package.RequestClass());
	private Package.ResponseClass _ResponseClass;
	public Package.ResponseClass ResponseClass => _ResponseClass ?? (_ResponseClass = new Package.ResponseClass());
	private Package.RequestAndResponseClass _RequestAndResponseClass;
	public Package.RequestAndResponseClass RequestAndResponseClass => _RequestAndResponseClass ?? (_RequestAndResponseClass = new Package.RequestAndResponseClass());
	}
}