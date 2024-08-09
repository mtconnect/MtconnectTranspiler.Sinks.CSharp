using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.RESTProtocol
{
	/// <summary>
	/// <i>agent</i>.  An <i>agent</i> <b>MUST</b> perform the following tasks:  * Collect data from manufacturing equipment. * Generate <i>response document</i>s. * Provide a REST interface using <i>HTTP</i>.  In addition to <i>XML</i> and <i>HTTP</i>, An <i>agent</i> <b>MAY</b> provide additional protocols and representations. Some representations <b>MAY</b> have companion specifications.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1637708823096_359717_5786">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AgentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1637708823096_359717_5786";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>agent</i>.  An <i>agent</i> <b>MUST</b> perform the following tasks:  * Collect data from manufacturing equipment. * Generate <i>response document</i>s. * Provide a REST interface using <i>HTTP</i>.  In addition to <i>XML</i> and <i>HTTP</i>, An <i>agent</i> <b>MAY</b> provide additional protocols and representations. Some representations <b>MAY</b> have companion specifications.";

		/// <inheritdoc />
		public string Name => "Agent";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public AgentClassProperties Properties { get; } = new AgentClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class AgentClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				InstanceId,
				SequenceNumber,
				BufferSize,
				MaxAssets,
				AssetCount,
				HasObservationPart,
				HasAssetPart,
			};
			/// <summary>
			/// <inheritdoc cref="InstanceIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: InstanceId</remarks>
			/// </summary>
			public InstanceIdProperty InstanceId { get; } = new InstanceIdProperty();
			/// <summary>
			/// identifier for an <i>instance</i> of the <i>agent</i>.       <see cref="Header::instanceId" /> <b>MUST</b> be changed to a different unique number each time the <i>buffer</i> is cleared and a new set of data begins to be collected.
			/// </summary>
			public sealed class InstanceIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1638533232267_921642_410</item>
				/// <item>Type: UInt32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(UInt32);
				
				/// <inheritdoc />
				public string Name => "instanceId";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>agent</i>.  An <i>agent</i> <b>MUST</b> perform the following tasks:  * Collect data from manufacturing equipment. * Generate <i>response document</i>s. * Provide a REST interface using <i>HTTP</i>.  In addition to <i>XML</i> and <i>HTTP</i>, An <i>agent</i> <b>MAY</b> provide additional protocols and representations. Some representations <b>MAY</b> have companion specifications.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="SequenceNumberProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SequenceNumber</remarks>
			/// </summary>
			public SequenceNumberProperty SequenceNumber { get; } = new SequenceNumberProperty();
			/// <summary>
			/// <i>sequence number</i>.
			/// </summary>
			public sealed class SequenceNumberProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1638534140373_733270_671</item>
				/// <item>Type: UInt64</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(UInt64);
				
				/// <inheritdoc />
				public string Name => "sequenceNumber";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>agent</i>.  An <i>agent</i> <b>MUST</b> perform the following tasks:  * Collect data from manufacturing equipment. * Generate <i>response document</i>s. * Provide a REST interface using <i>HTTP</i>.  In addition to <i>XML</i> and <i>HTTP</i>, An <i>agent</i> <b>MAY</b> provide additional protocols and representations. Some representations <b>MAY</b> have companion specifications.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="BufferSizeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: BufferSize</remarks>
			/// </summary>
			public BufferSizeProperty BufferSize { get; } = new BufferSizeProperty();
			/// <summary>
			/// maximum number of <i>Observation</i>s that <b>MAY</b> be retained in the <i>agent</i> that published the <i>response document</i> at any point in time.
			/// </summary>
			public sealed class BufferSizeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1638533232267_921642_410</item>
				/// <item>Type: UInt32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(UInt32);
				
				/// <inheritdoc />
				public string Name => "bufferSize";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>agent</i>.  An <i>agent</i> <b>MUST</b> perform the following tasks:  * Collect data from manufacturing equipment. * Generate <i>response document</i>s. * Provide a REST interface using <i>HTTP</i>.  In addition to <i>XML</i> and <i>HTTP</i>, An <i>agent</i> <b>MAY</b> provide additional protocols and representations. Some representations <b>MAY</b> have companion specifications.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="MaxAssetsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MaxAssets</remarks>
			/// </summary>
			public MaxAssetsProperty MaxAssets { get; } = new MaxAssetsProperty();
			/// <summary>
			/// maximum number of <i>Asset</i>s that <b>MAY</b> be retained in the <i>agent</i> that published the <i>response document</i> at any point in time.
			/// </summary>
			public sealed class MaxAssetsProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1638533232267_921642_410</item>
				/// <item>Type: UInt32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(UInt32);
				
				/// <inheritdoc />
				public string Name => "maxAssets";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>agent</i>.  An <i>agent</i> <b>MUST</b> perform the following tasks:  * Collect data from manufacturing equipment. * Generate <i>response document</i>s. * Provide a REST interface using <i>HTTP</i>.  In addition to <i>XML</i> and <i>HTTP</i>, An <i>agent</i> <b>MAY</b> provide additional protocols and representations. Some representations <b>MAY</b> have companion specifications.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="AssetCountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetCount</remarks>
			/// </summary>
			public AssetCountProperty AssetCount { get; } = new AssetCountProperty();
			/// <summary>
			/// current number of <i>Asset</i>s that are currently stored in the <i>agent</i> as of the <see cref="Header::creationTime" /> that the <i>agent</i> published the <i>response document</i>.
			/// </summary>
			public sealed class AssetCountProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1638533232267_921642_410</item>
				/// <item>Type: UInt32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(UInt32);
				
				/// <inheritdoc />
				public string Name => "assetCount";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>agent</i>.  An <i>agent</i> <b>MUST</b> perform the following tasks:  * Collect data from manufacturing equipment. * Generate <i>response document</i>s. * Provide a REST interface using <i>HTTP</i>.  In addition to <i>XML</i> and <i>HTTP</i>, An <i>agent</i> <b>MAY</b> provide additional protocols and representations. Some representations <b>MAY</b> have companion specifications.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasObservationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasObservation</remarks>
			/// </summary>
			public HasObservationPartProperty HasObservationPart { get; } = new HasObservationPartProperty();
			public sealed class HasObservationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579566531115_47734_25731</item>
				/// <item>Type: ObservationGeneralization</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationGeneralization);
				
				/// <inheritdoc />
				public string Name => "hasObservation";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>agent</i>.  An <i>agent</i> <b>MUST</b> perform the following tasks:  * Collect data from manufacturing equipment. * Generate <i>response document</i>s. * Provide a REST interface using <i>HTTP</i>.  In addition to <i>XML</i> and <i>HTTP</i>, An <i>agent</i> <b>MAY</b> provide additional protocols and representations. Some representations <b>MAY</b> have companion specifications.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "buffer";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasAssetPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAsset</remarks>
			/// </summary>
			public HasAssetPartProperty HasAssetPart { get; } = new HasAssetPartProperty();
			public sealed class HasAssetPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A</item>
				/// <item>Type: AssetClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.AssetClass);
				
				/// <inheritdoc />
				public string Name => "hasAsset";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>agent</i>.  An <i>agent</i> <b>MUST</b> perform the following tasks:  * Collect data from manufacturing equipment. * Generate <i>response document</i>s. * Provide a REST interface using <i>HTTP</i>.  In addition to <i>XML</i> and <i>HTTP</i>, An <i>agent</i> <b>MAY</b> provide additional protocols and representations. Some representations <b>MAY</b> have companion specifications.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "assetBuffer";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

		# region Rules
		/// <summary>
		/// SufficientObservationSpace
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string SufficientObservationSpace => @"buffer.length < agent.bufferSize";
		/*
		buffer.length < agent.bufferSize
		*/
		/// <summary>
		/// SufficientAssetSpace
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string SufficientAssetSpace => @"assetBuffer.length < agent.maxAssets";
		/*
		assetBuffer.length < agent.maxAssets
		*/
		# endregion
	}
}