using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.ProtocolTerms;

namespace Mtconnect.Glossary
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ProtocolTermsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623665982544_883035_11209";
		
		/// <inheritdoc />
		public string Name => "Protocol Terms";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
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
		#region Packages
	#endregion

	#region Classes
	private Package.MTConnectStreamsResponseDocumentClass _MTConnectStreamsResponseDocumentClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectStreamsResponseDocumentClass" path="/summary" />
	/// </summary>
	public Package.MTConnectStreamsResponseDocumentClass MTConnectStreamsResponseDocumentClass => _MTConnectStreamsResponseDocumentClass ?? (_MTConnectStreamsResponseDocumentClass = new Package.MTConnectStreamsResponseDocumentClass());

	private Package.MTConnectAssetsResponseDocumentClass _MTConnectAssetsResponseDocumentClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectAssetsResponseDocumentClass" path="/summary" />
	/// </summary>
	public Package.MTConnectAssetsResponseDocumentClass MTConnectAssetsResponseDocumentClass => _MTConnectAssetsResponseDocumentClass ?? (_MTConnectAssetsResponseDocumentClass = new Package.MTConnectAssetsResponseDocumentClass());

	private Package.MTConnectDevicesResponseDocumentClass _MTConnectDevicesResponseDocumentClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectDevicesResponseDocumentClass" path="/summary" />
	/// </summary>
	public Package.MTConnectDevicesResponseDocumentClass MTConnectDevicesResponseDocumentClass => _MTConnectDevicesResponseDocumentClass ?? (_MTConnectDevicesResponseDocumentClass = new Package.MTConnectDevicesResponseDocumentClass());

	private Package.MTConnectErrorsResponseDocumentClass _MTConnectErrorsResponseDocumentClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectErrorsResponseDocumentClass" path="/summary" />
	/// </summary>
	public Package.MTConnectErrorsResponseDocumentClass MTConnectErrorsResponseDocumentClass => _MTConnectErrorsResponseDocumentClass ?? (_MTConnectErrorsResponseDocumentClass = new Package.MTConnectErrorsResponseDocumentClass());

	private Package.MTConnectResponseDocumentClass _MTConnectResponseDocumentClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectResponseDocumentClass" path="/summary" />
	/// </summary>
	public Package.MTConnectResponseDocumentClass MTConnectResponseDocumentClass => _MTConnectResponseDocumentClass ?? (_MTConnectResponseDocumentClass = new Package.MTConnectResponseDocumentClass());

	private Package.TransportProtocolGeneralization _TransportProtocolGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.TransportProtocolGeneralization" path="/summary" />
	/// </summary>
	public Package.TransportProtocolGeneralization TransportProtocolGeneralization => _TransportProtocolGeneralization ?? (_TransportProtocolGeneralization = new Package.TransportProtocolGeneralization());

	private Package.SampleRequestClass _SampleRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.SampleRequestClass" path="/summary" />
	/// </summary>
	public Package.SampleRequestClass SampleRequestClass => _SampleRequestClass ?? (_SampleRequestClass = new Package.SampleRequestClass());

	private Package.MTConnectRequestGeneralization _MTConnectRequestGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectRequestGeneralization" path="/summary" />
	/// </summary>
	public Package.MTConnectRequestGeneralization MTConnectRequestGeneralization => _MTConnectRequestGeneralization ?? (_MTConnectRequestGeneralization = new Package.MTConnectRequestGeneralization());

	private Package.ProbeRequestClass _ProbeRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProbeRequestClass" path="/summary" />
	/// </summary>
	public Package.ProbeRequestClass ProbeRequestClass => _ProbeRequestClass ?? (_ProbeRequestClass = new Package.ProbeRequestClass());

	private Package.StreamingDataClass _StreamingDataClass;
	/// <summary>
	/// <inheritdoc cref="Package.StreamingDataClass" path="/summary" />
	/// </summary>
	public Package.StreamingDataClass StreamingDataClass => _StreamingDataClass ?? (_StreamingDataClass = new Package.StreamingDataClass());

	private Package.PublishClass _PublishClass;
	/// <summary>
	/// <inheritdoc cref="Package.PublishClass" path="/summary" />
	/// </summary>
	public Package.PublishClass PublishClass => _PublishClass ?? (_PublishClass = new Package.PublishClass());

	private Package.CurrentRequestClass _CurrentRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.CurrentRequestClass" path="/summary" />
	/// </summary>
	public Package.CurrentRequestClass CurrentRequestClass => _CurrentRequestClass ?? (_CurrentRequestClass = new Package.CurrentRequestClass());

	private Package.ProtocolClass _ProtocolClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProtocolClass" path="/summary" />
	/// </summary>
	public Package.ProtocolClass ProtocolClass => _ProtocolClass ?? (_ProtocolClass = new Package.ProtocolClass());

	private Package.DataStreamingClass _DataStreamingClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataStreamingClass" path="/summary" />
	/// </summary>
	public Package.DataStreamingClass DataStreamingClass => _DataStreamingClass ?? (_DataStreamingClass = new Package.DataStreamingClass());

	private Package.PublishAndSubscribeClass _PublishAndSubscribeClass;
	/// <summary>
	/// <inheritdoc cref="Package.PublishAndSubscribeClass" path="/summary" />
	/// </summary>
	public Package.PublishAndSubscribeClass PublishAndSubscribeClass => _PublishAndSubscribeClass ?? (_PublishAndSubscribeClass = new Package.PublishAndSubscribeClass());

	private Package.SubscribeClass _SubscribeClass;
	/// <summary>
	/// <inheritdoc cref="Package.SubscribeClass" path="/summary" />
	/// </summary>
	public Package.SubscribeClass SubscribeClass => _SubscribeClass ?? (_SubscribeClass = new Package.SubscribeClass());

	private Package.AssetRequestClass _AssetRequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetRequestClass" path="/summary" />
	/// </summary>
	public Package.AssetRequestClass AssetRequestClass => _AssetRequestClass ?? (_AssetRequestClass = new Package.AssetRequestClass());

	private Package.RequestClass _RequestClass;
	/// <summary>
	/// <inheritdoc cref="Package.RequestClass" path="/summary" />
	/// </summary>
	public Package.RequestClass RequestClass => _RequestClass ?? (_RequestClass = new Package.RequestClass());

	private Package.ResponseClass _ResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.ResponseClass" path="/summary" />
	/// </summary>
	public Package.ResponseClass ResponseClass => _ResponseClass ?? (_ResponseClass = new Package.ResponseClass());

	private Package.RequestAndResponseClass _RequestAndResponseClass;
	/// <summary>
	/// <inheritdoc cref="Package.RequestAndResponseClass" path="/summary" />
	/// </summary>
	public Package.RequestAndResponseClass RequestAndResponseClass => _RequestAndResponseClass ?? (_RequestAndResponseClass = new Package.RequestAndResponseClass());

	#endregion
	}
}