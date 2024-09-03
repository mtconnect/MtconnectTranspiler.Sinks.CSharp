#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.RESTProtocol
{
	/// <summary>﻿<i>agent</i>.<br /><br />An <i>agent</i> <b>MUST</b> perform the following tasks:<br /><br />* Collect data from manufacturing equipment.<br />* Generate <i>response document</i>s.<br />* Provide a REST interface using <i>HTTP</i>.<br /><br />In addition to <i>XML</i> and <i>HTTP</i>, An <i>agent</i> <b>MAY</b> provide additional protocols and representations. Some representations <b>MAY</b> have companion specifications.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1637708823096_359717_5786">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AgentClass : IClass
	{
		/// <summary>Constant value for <see cref="AgentClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_4_45f01b9_1637708823096_359717_5786";
		/// <summary>Constant value for <see cref="AgentClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1637708823096_359717_5786";
		/// <summary>Constant value for <see cref="AgentClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(agent)}}.

An {{term(agent)}} **MUST** perform the following tasks:

* Collect data from manufacturing equipment.
* Generate {{termplural(response document)}}.
* Provide a REST interface using {{term(HTTP)}}.

In addition to {{term(XML)}} and {{term(HTTP)}}, An {{term(agent)}} **MAY** provide additional protocols and representations. Some representations **MAY** have companion specifications.&#10;
";
		/// <summary>Constant value for <see cref="AgentClass.Name" /></summary>
		public const string NAME = "Agent";
		/// <summary>Constant value for <see cref="AgentClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="AgentClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="AgentClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="AgentClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new AgentClassProperties Properties { get; } = new AgentClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AgentClass" />.
		/// </summary>
		public class AgentClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
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
			
			/// <summary>﻿identifier for an <i>instance</i> of the <i>agent</i>.<br />     <br /><see cref="Header.instanceId">instanceId in Header</see> <b>MUST</b> be changed to a different unique number each time the <i>buffer</i> is cleared and a new set of data begins to be collected.<br /><br /><br />
			/// </summary>
			public sealed class InstanceIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="InstanceIdProperty.Name" /></summary>
				public const string NAME = "instanceId";
				/// <summary>Constant value for <see cref="InstanceIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier for an {{term(instance)}} of the {{term(agent)}}.
     
{{property(Header::instanceId)}} **MUST** be changed to a different unique number each time the {{term(buffer)}} is cleared and a new set of data begins to be collected.&#10;
";
				/// <summary>Constant value for <see cref="InstanceIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="InstanceIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="InstanceIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="InstanceIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="InstanceIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="InstanceIdProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="InstanceIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="InstanceIdProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UInt32 </remarks>
				/// </summary>
				public System.Type Type => typeof(UInt32);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="SequenceNumberProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SequenceNumber</remarks>
			/// </summary>
			public SequenceNumberProperty SequenceNumber { get; } = new SequenceNumberProperty();
			
			/// <summary>﻿<i>sequence number</i>.<br /><br /><br />
			/// </summary>
			public sealed class SequenceNumberProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SequenceNumberProperty.Name" /></summary>
				public const string NAME = "sequenceNumber";
				/// <summary>Constant value for <see cref="SequenceNumberProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(sequence number)}}.&#10;
";
				/// <summary>Constant value for <see cref="SequenceNumberProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SequenceNumberProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SequenceNumberProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="SequenceNumberProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SequenceNumberProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="SequenceNumberProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="SequenceNumberProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SequenceNumberProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UInt64 </remarks>
				/// </summary>
				public System.Type Type => typeof(UInt64);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="BufferSizeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: BufferSize</remarks>
			/// </summary>
			public BufferSizeProperty BufferSize { get; } = new BufferSizeProperty();
			
			/// <summary>﻿maximum number of <i>Observation</i>s that <b>MAY</b> be retained in the <i>agent</i> that published the <i>response document</i> at any point in time.<br /><br /><br />
			/// </summary>
			public sealed class BufferSizeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="BufferSizeProperty.Name" /></summary>
				public const string NAME = "bufferSize";
				/// <summary>Constant value for <see cref="BufferSizeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;maximum number of {{termplural(Observation)}} that **MAY** be retained in the {{term(agent)}} that published the {{term(response document)}} at any point in time.&#10;
";
				/// <summary>Constant value for <see cref="BufferSizeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="BufferSizeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="BufferSizeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="BufferSizeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="BufferSizeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="BufferSizeProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="BufferSizeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="BufferSizeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UInt32 </remarks>
				/// </summary>
				public System.Type Type => typeof(UInt32);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="MaxAssetsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MaxAssets</remarks>
			/// </summary>
			public MaxAssetsProperty MaxAssets { get; } = new MaxAssetsProperty();
			
			/// <summary>﻿maximum number of <i>Asset</i>s that <b>MAY</b> be retained in the <i>agent</i> that published the <i>response document</i> at any point in time.<br /><br /><br />
			/// </summary>
			public sealed class MaxAssetsProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MaxAssetsProperty.Name" /></summary>
				public const string NAME = "maxAssets";
				/// <summary>Constant value for <see cref="MaxAssetsProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;maximum number of {{termplural(Asset)}} that **MAY** be retained in the {{term(agent)}} that published the {{term(response document)}} at any point in time.&#10;
";
				/// <summary>Constant value for <see cref="MaxAssetsProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="MaxAssetsProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MaxAssetsProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="MaxAssetsProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MaxAssetsProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="MaxAssetsProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="MaxAssetsProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MaxAssetsProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UInt32 </remarks>
				/// </summary>
				public System.Type Type => typeof(UInt32);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="AssetCountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetCount</remarks>
			/// </summary>
			public AssetCountProperty AssetCount { get; } = new AssetCountProperty();
			
			/// <summary>﻿current number of <i>Asset</i>s that are currently stored in the <i>agent</i> as of the <see cref="Header.creationTime">creationTime in Header</see> that the <i>agent</i> published the <i>response document</i>.<br /><br /><br />
			/// </summary>
			public sealed class AssetCountProperty : IProperty
			{
				/// <summary>Constant value for <see cref="AssetCountProperty.Name" /></summary>
				public const string NAME = "assetCount";
				/// <summary>Constant value for <see cref="AssetCountProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;current number of {{termplural(Asset)}} that are currently stored in the {{term(agent)}} as of the {{property(Header::creationTime)}} that the {{term(agent)}} published the {{term(response document)}}.&#10;
";
				/// <summary>Constant value for <see cref="AssetCountProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="AssetCountProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="AssetCountProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="AssetCountProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="AssetCountProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="AssetCountProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="AssetCountProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="AssetCountProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UInt32 </remarks>
				/// </summary>
				public System.Type Type => typeof(UInt32);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HasObservationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasObservation</remarks>
			/// </summary>
			public HasObservationPartProperty HasObservationPart { get; } = new HasObservationPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasObservationPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Name" /></summary>
				public const string NAME = "hasObservation";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.Association" /></summary>
				public const string ASSOCIATION = "buffer";
				/// <summary>Constant value for <see cref="HasObservationPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ObservationGeneralization </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationGeneralization);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HasAssetPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAsset</remarks>
			/// </summary>
			public HasAssetPartProperty HasAssetPart { get; } = new HasAssetPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasAssetPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Name" /></summary>
				public const string NAME = "hasAsset";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Association" /></summary>
				public const string ASSOCIATION = "assetBuffer";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AssetClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.AssetClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
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