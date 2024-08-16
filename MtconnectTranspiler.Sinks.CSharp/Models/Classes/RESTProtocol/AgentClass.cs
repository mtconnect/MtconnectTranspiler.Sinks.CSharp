using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.RESTProtocol
{
	/// <summary>
	﻿/// <i>agent</i>.<br /><br />An <i>agent</i> <b>MUST</b> perform the following tasks:<br /><br />* Collect data from manufacturing equipment.<br />* Generate <i>response document</i>s.<br />* Provide a REST interface using <i>HTTP</i>.<br /><br />In addition to <i>XML</i> and <i>HTTP</i>, An <i>agent</i> <b>MAY</b> provide additional protocols and representations. Some representations <b>MAY</b> have companion specifications.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1637708823096_359717_5786">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AgentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1637708823096_359717_5786";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(agent)}}.

An {{term(agent)}} **MUST** perform the following tasks:

* Collect data from manufacturing equipment.
* Generate {{termplural(response document)}}.
* Provide a REST interface using {{term(HTTP)}}.

In addition to {{term(XML)}} and {{term(HTTP)}}, An {{term(agent)}} **MAY** provide additional protocols and representations. Some representations **MAY** have companion specifications.&#10;
";

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
			﻿/// identifier for an <i>instance</i> of the <i>agent</i>.<br />     <br /><see cref="Header.instanceId">instanceId in Header</see> <b>MUST</b> be changed to a different unique number each time the <i>buffer</i> is cleared and a new set of data begins to be collected.<br/><br />

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
				public string Summary => @"&#10;&#10;&#10;identifier for an {{term(instance)}} of the {{term(agent)}}.
     
{{property(Header::instanceId)}} **MUST** be changed to a different unique number each time the {{term(buffer)}} is cleared and a new set of data begins to be collected.&#10;
";

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
			﻿/// <i>sequence number</i>.<br/><br />

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
				public string Summary => @"&#10;&#10;&#10;{{term(sequence number)}}.&#10;
";

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
			﻿/// maximum number of <i>Observation</i>s that <b>MAY</b> be retained in the <i>agent</i> that published the <i>response document</i> at any point in time.<br/><br />

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
				public string Summary => @"&#10;&#10;&#10;maximum number of {{termplural(Observation)}} that **MAY** be retained in the {{term(agent)}} that published the {{term(response document)}} at any point in time.&#10;
";

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
			﻿/// maximum number of <i>Asset</i>s that <b>MAY</b> be retained in the <i>agent</i> that published the <i>response document</i> at any point in time.<br/><br />

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
				public string Summary => @"&#10;&#10;&#10;maximum number of {{termplural(Asset)}} that **MAY** be retained in the {{term(agent)}} that published the {{term(response document)}} at any point in time.&#10;
";

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
			﻿/// current number of <i>Asset</i>s that are currently stored in the <i>agent</i> as of the <see cref="Header.creationTime">creationTime in Header</see> that the <i>agent</i> published the <i>response document</i>.<br/><br />

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
				public string Summary => @"&#10;&#10;&#10;current number of {{termplural(Asset)}} that are currently stored in the {{term(agent)}} as of the {{property(Header::creationTime)}} that the {{term(agent)}} published the {{term(response document)}}.&#10;
";

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
				public string Summary => @"";

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
				public string Summary => @"";

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