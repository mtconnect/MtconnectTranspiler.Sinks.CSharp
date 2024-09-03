#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument
{
	/// <summary>﻿provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_2299B0B3_B209_47ae_B93A_BA694AD50051">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HeaderClass : IClass
	{
		/// <summary>Constant value for <see cref="HeaderClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_2299B0B3_B209_47ae_B93A_BA694AD50051";
		/// <summary>Constant value for <see cref="HeaderClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_2299B0B3_B209_47ae_B93A_BA694AD50051";
		/// <summary>Constant value for <see cref="HeaderClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;provides information from an {{term(agent)}} defining version information, storage capacity, and parameters associated with the data management within the {{term(agent)}}.&#10;
";
		/// <summary>Constant value for <see cref="HeaderClass.Name" /></summary>
		public const string NAME = "Header";
		/// <summary>Constant value for <see cref="HeaderClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="HeaderClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="HeaderClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="HeaderClass.DeprecatedVersion" /></summary>
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
		public new HeaderClassProperties Properties { get; } = new HeaderClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="HeaderClass" />.
		/// </summary>
		public class HeaderClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				FirstSequence,
				LastSequence,
				NextSequence,
				Version,
				TestIndicator,
				Sender,
				InstanceId,
				CreationTime,
				BufferSize,
				DeviceModelChangeTime,
			};
			/// <summary>
			/// <inheritdoc cref="FirstSequenceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: FirstSequence</remarks>
			/// </summary>
			public FirstSequenceProperty FirstSequence { get; } = new FirstSequenceProperty();
			
			/// <summary>﻿<i>sequence number</i> assigned to the oldest piece of <i>streaming data</i> stored in the <i>buffer</i> of the <i>agent</i> immediately prior to the time that the <i>agent</i> published the <i>response document</i>.   <br /><br /><br />
			/// </summary>
			public sealed class FirstSequenceProperty : IProperty
			{
				/// <summary>Constant value for <see cref="FirstSequenceProperty.Name" /></summary>
				public const string NAME = "firstSequence";
				/// <summary>Constant value for <see cref="FirstSequenceProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(sequence number)}} assigned to the oldest piece of {{term(streaming data)}} stored in the {{term(buffer)}} of the {{term(agent)}} immediately prior to the time that the {{term(agent)}} published the {{term(response document)}}.   &#10;
";
				/// <summary>Constant value for <see cref="FirstSequenceProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="FirstSequenceProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="FirstSequenceProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="FirstSequenceProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="FirstSequenceProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="FirstSequenceProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="FirstSequenceProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="FirstSequenceProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="LastSequenceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: LastSequence</remarks>
			/// </summary>
			public LastSequenceProperty LastSequence { get; } = new LastSequenceProperty();
			
			/// <summary>﻿<i>sequence number</i> assigned to the last piece of <i>streaming data</i> that was added to the <i>buffer</i> of the <i>agent</i> immediately prior to the time that the <i>agent</i> published the <i>response document</i>.   <br /><br /><br /><br /><br />
			/// </summary>
			public sealed class LastSequenceProperty : IProperty
			{
				/// <summary>Constant value for <see cref="LastSequenceProperty.Name" /></summary>
				public const string NAME = "lastSequence";
				/// <summary>Constant value for <see cref="LastSequenceProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(sequence number)}} assigned to the last piece of {{term(streaming data)}} that was added to the {{term(buffer)}} of the {{term(agent)}} immediately prior to the time that the {{term(agent)}} published the {{term(response document)}}.   

&#10;
";
				/// <summary>Constant value for <see cref="LastSequenceProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="LastSequenceProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="LastSequenceProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="LastSequenceProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="LastSequenceProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="LastSequenceProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="LastSequenceProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="LastSequenceProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="NextSequenceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NextSequence</remarks>
			/// </summary>
			public NextSequenceProperty NextSequence { get; } = new NextSequenceProperty();
			
			/// <summary>﻿<i>sequence number</i> of the piece of <i>streaming data</i> that is the next piece of data to be retrieved from the <i>buffer</i> of the <i>agent</i> that was not included in the <i>response document</i> published by the <i>agent</i>.<br /><br />If the <i>streaming data</i> included in the <i>response document</i> includes the last piece of data stored in the <i>buffer</i> of the <i>agent</i> at the time that the document was published, then the value reported for <see cref="Header.nextSequence">nextSequence in Header</see> <b>MUST</b> be equal to <see cref="Header.lastSequence">lastSequence in Header</see> + 1.<br /><br /><br />
			/// </summary>
			public sealed class NextSequenceProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NextSequenceProperty.Name" /></summary>
				public const string NAME = "nextSequence";
				/// <summary>Constant value for <see cref="NextSequenceProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(sequence number)}} of the piece of {{term(streaming data)}} that is the next piece of data to be retrieved from the {{term(buffer)}} of the {{term(agent)}} that was not included in the {{term(response document)}} published by the {{term(agent)}}.

If the {{term(streaming data)}} included in the {{term(response document)}} includes the last piece of data stored in the {{term(buffer)}} of the {{term(agent)}} at the time that the document was published, then the value reported for {{property(Header::nextSequence)}} **MUST** be equal to {{property(Header::lastSequence)}} + 1.&#10;
";
				/// <summary>Constant value for <see cref="NextSequenceProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NextSequenceProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NextSequenceProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="NextSequenceProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NextSequenceProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="NextSequenceProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="NextSequenceProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NextSequenceProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="VersionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Version</remarks>
			/// </summary>
			public VersionProperty Version { get; } = new VersionProperty();
			
			/// <summary>﻿<i>major</i>, <i>minor</i>, and <i>revision</i> number of the MTConnect Standard that defines the <i>semantic data model</i> that represents the content of the <i>response document</i>. It also includes the revision number of the <i>schema</i> associated with that specific <i>semantic data model</i>.<br /><br />As an example, the value reported for <see cref="Header.version">version in Header</see> for a <i>response document</i> that was structured based on <i>schema</i> revision 10 associated with Version 1.4.0 of the MTConnect Standard would be:  1.4.0.10<br /><br /><br />
			/// </summary>
			public sealed class VersionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="VersionProperty.Name" /></summary>
				public const string NAME = "version";
				/// <summary>Constant value for <see cref="VersionProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(major)}}, {{term(minor)}}, and {{term(revision)}} number of the MTConnect Standard that defines the {{term(semantic data model)}} that represents the content of the {{term(response document)}}. It also includes the revision number of the {{term(schema)}} associated with that specific {{term(semantic data model)}}.

As an example, the value reported for {{property(Header::version)}} for a {{term(response document)}} that was structured based on {{term(schema)}} revision 10 associated with Version 1.4.0 of the MTConnect Standard would be:  1.4.0.10&#10;
";
				/// <summary>Constant value for <see cref="VersionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="VersionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="VersionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="VersionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="VersionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="VersionProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="VersionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="VersionProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="TestIndicatorProperty" path="/summary" /><br/>
			/// <remarks>Original Name: TestIndicator</remarks>
			/// </summary>
			public TestIndicatorProperty TestIndicator { get; } = new TestIndicatorProperty();
			
			/// <summary>﻿indicates whether the <i>agent</i> that published the <i>response document</i> is operating in a test mode.<br /><br />If <see cref="Header.testIndicator">testIndicator in Header</see> is not specified, the value for <see cref="Header.testIndicator">testIndicator in Header</see> <b>MUST</b> be interpreted to be <c>false</c>.<br /><br /><br />
			/// </summary>
			public sealed class TestIndicatorProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TestIndicatorProperty.Name" /></summary>
				public const string NAME = "testIndicator";
				/// <summary>Constant value for <see cref="TestIndicatorProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;indicates whether the {{term(agent)}} that published the {{term(response document)}} is operating in a test mode.

If {{property(Header::testIndicator)}} is not specified, the value for {{property(Header::testIndicator)}} **MUST** be interpreted to be `false`.&#10;
";
				/// <summary>Constant value for <see cref="TestIndicatorProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TestIndicatorProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TestIndicatorProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="TestIndicatorProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TestIndicatorProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="TestIndicatorProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="TestIndicatorProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TestIndicatorProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Boolean </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
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
			/// <inheritdoc cref="SenderProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Sender</remarks>
			/// </summary>
			public SenderProperty Sender { get; } = new SenderProperty();
			
			/// <summary>﻿identification defining where the <i>agent</i> that published the <i>response document</i> is installed or hosted.<br /><br /><see cref="Header.sender">sender in Header</see> <b>MUST</b> be either an IP Address or Hostname describing where the <i>agent</i> is installed or the URL of the <i>agent</i>; e.g., <c>http://&lt;address&gt;[:port]/</c>. <br /><br />&gt; Note:  The port number need not be specified if it is the default HTTP port 80.<br /><br /><br />
			/// </summary>
			public sealed class SenderProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SenderProperty.Name" /></summary>
				public const string NAME = "sender";
				/// <summary>Constant value for <see cref="SenderProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identification defining where the {{term(agent)}} that published the {{term(response document)}} is installed or hosted.

{{property(Header::sender)}} **MUST** be either an IP Address or Hostname describing where the {{term(agent)}} is installed or the URL of the {{term(agent)}}; e.g., `http://<address>[:port]/`. 

> Note:  The port number need not be specified if it is the default HTTP port 80.&#10;
";
				/// <summary>Constant value for <see cref="SenderProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SenderProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SenderProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="SenderProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SenderProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="SenderProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="SenderProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SenderProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="InstanceIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: InstanceId</remarks>
			/// </summary>
			public InstanceIdProperty InstanceId { get; } = new InstanceIdProperty();
			
			/// <summary>﻿identifier for a specific instantiation of the <i>buffer</i> associated with the <i>agent</i> that published the <i>response document</i>.  <br />     <br /><see cref="Header.instanceId">instanceId in Header</see> <b>MUST</b> be changed to a different unique number each time the <i>buffer</i> is cleared and a new set of data begins to be collected.<br /><br /><br />
			/// </summary>
			public sealed class InstanceIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="InstanceIdProperty.Name" /></summary>
				public const string NAME = "instanceId";
				/// <summary>Constant value for <see cref="InstanceIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier for a specific instantiation of the {{term(buffer)}} associated with the {{term(agent)}} that published the {{term(response document)}}.  
     
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
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="InstanceIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="InstanceIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="InstanceIdProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="CreationTimeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CreationTime</remarks>
			/// </summary>
			public CreationTimeProperty CreationTime { get; } = new CreationTimeProperty();
			
			/// <summary>﻿timestamp that an <i>agent</i> published the <i>response document</i>. <br /><br /><br />
			/// </summary>
			public sealed class CreationTimeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CreationTimeProperty.Name" /></summary>
				public const string NAME = "creationTime";
				/// <summary>Constant value for <see cref="CreationTimeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;timestamp that an {{term(agent)}} published the {{term(response document)}}. &#10;
";
				/// <summary>Constant value for <see cref="CreationTimeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CreationTimeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CreationTimeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="CreationTimeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CreationTimeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CreationTimeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="CreationTimeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CreationTimeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DateTime </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
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
			
			/// <summary>﻿maximum number of <i>DataItem</i>s that <b>MAY</b> be retained in the <i>agent</i> that published the <i>response document</i> at any point in time.<br /><br />&gt; Note 1 to entry:  <see cref="Header.bufferSize">bufferSize in Header</see> represents the maximum number of sequence numbers that <b>MAY</b> be stored in the <i>agent</i>. <br /><br />&gt; Note 2 to entry: The implementer is responsible for allocating the appropriate amount of storage capacity required to accommodate the <see cref="Header.bufferSize">bufferSize in Header</see>.<br /><br /><br /><br />
			/// </summary>
			public sealed class BufferSizeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="BufferSizeProperty.Name" /></summary>
				public const string NAME = "bufferSize";
				/// <summary>Constant value for <see cref="BufferSizeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;maximum number of {{termplural(DataItem)}} that **MAY** be retained in the {{term(agent)}} that published the {{term(response document)}} at any point in time.

> Note 1 to entry:  {{property(Header::bufferSize)}} represents the maximum number of sequence numbers that **MAY** be stored in the {{term(agent)}}. 

> Note 2 to entry: The implementer is responsible for allocating the appropriate amount of storage capacity required to accommodate the {{property(Header::bufferSize)}}.
&#10;
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
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="BufferSizeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
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
			/// <inheritdoc cref="DeviceModelChangeTimeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DeviceModelChangeTime</remarks>
			/// </summary>
			public DeviceModelChangeTimeProperty DeviceModelChangeTime { get; } = new DeviceModelChangeTimeProperty();
			
			/// <summary>﻿timestamp of the last update of the <see cref="Device">Device</see> information for any device.<br /><br /><br />
			/// </summary>
			public sealed class DeviceModelChangeTimeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DeviceModelChangeTimeProperty.Name" /></summary>
				public const string NAME = "deviceModelChangeTime";
				/// <summary>Constant value for <see cref="DeviceModelChangeTimeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;timestamp of the last update of the {{block(Device)}} information for any device.&#10;
";
				/// <summary>Constant value for <see cref="DeviceModelChangeTimeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="DeviceModelChangeTimeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DeviceModelChangeTimeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.7";
				/// <summary>Constant value for <see cref="DeviceModelChangeTimeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DeviceModelChangeTimeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="DeviceModelChangeTimeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="DeviceModelChangeTimeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DeviceModelChangeTimeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DateTime </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
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

	}
}