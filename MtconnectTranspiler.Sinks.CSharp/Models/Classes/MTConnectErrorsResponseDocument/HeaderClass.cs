#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument
{
	/// <summary>﻿provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_91b028d_1579560593039_375117_6558">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HeaderClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1579560593039_375117_6558";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;provides information from an {{term(agent)}} defining version information, storage capacity, and parameters associated with the data management within the {{term(agent)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Header";
		
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
		public new HeaderClassProperties Properties { get; } = new HeaderClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="HeaderClass" />.
		/// </summary>
		public class HeaderClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				BufferSize,
				CreationTime,
				InstanceId,
				Sender,
				TestIndicator,
				Version,
				FirstSequence,
				LastSequence,
				NextSequence,
				DeviceModelChangeTime,
			};
			/// <summary>
			/// <inheritdoc cref="BufferSizeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: BufferSize</remarks>
			/// </summary>
			public BufferSizeProperty BufferSize { get; } = new BufferSizeProperty();
			
			/// <summary>﻿maximum number of <i>DataItem</i>s that <b>MAY</b> be retained in the <i>agent</i> that published the <i>response document</i> at any point in time.<br /><br />&gt; Note 1 to entry:  <see cref="Header.bufferSize">bufferSize in Header</see> represents the maximum number of sequence numbers that <b>MAY</b> be stored in the <i>agent</i>. <br /><br />&gt; Note 2 to entry: The implementer is responsible for allocating the appropriate amount of storage capacity required to accommodate the <see cref="Header.bufferSize">bufferSize in Header</see>.<br /><br /><br /><br />
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
				public string Summary => @"&#10;&#10;&#10;maximum number of {{termplural(DataItem)}} that **MAY** be retained in the {{term(agent)}} that published the {{term(response document)}} at any point in time.

> Note 1 to entry:  {{property(Header::bufferSize)}} represents the maximum number of sequence numbers that **MAY** be stored in the {{term(agent)}}. 

> Note 2 to entry: The implementer is responsible for allocating the appropriate amount of storage capacity required to accommodate the {{property(Header::bufferSize)}}.
&#10;
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
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272233011_597138_670</item>
				/// <item>Type: DateTime</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
				/// <inheritdoc />
				public string Name => "creationTime";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;timestamp that an {{term(agent)}} published the {{term(response document)}}. &#10;
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
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				public string Name => "instanceId";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;identifier for a specific instantiation of the {{term(buffer)}} associated with the {{term(agent)}} that published the {{term(response document)}}.  
     
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
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "sender";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;identification defining where the {{term(agent)}} that published the {{term(response document)}} is installed or hosted.

{{property(Header::sender)}} **MUST** be either an IP Address or Hostname describing where the {{term(agent)}} is installed or the URL of the {{term(agent)}}; e.g., `http://<address>[:port]/`. 

> Note:  The port number need not be specified if it is the default HTTP port 80.&#10;
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
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579278876899_683310_3821</item>
				/// <item>Type: Boolean</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
				/// <inheritdoc />
				public string Name => "testIndicator";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;indicates whether the {{term(agent)}} that published the {{term(response document)}} is operating in a test mode.

If {{property(Header::testIndicator)}} is not specified, the value for {{property(Header::testIndicator)}} **MUST** be interpreted to be `false`.&#10;
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
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1638532805092_219797_373</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "version";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(major)}}, {{term(minor)}}, and {{term(revision)}} number of the MTConnect Standard that defines the {{term(semantic data model)}} that represents the content of the {{term(response document)}}. It also includes the revision number of the {{term(schema)}} associated with that specific {{term(semantic data model)}}.

As an example, the value reported for {{property(Header::version)}} for a {{term(response document)}} that was structured based on {{term(schema)}} revision 10 associated with Version 1.4.0 of the MTConnect Standard would be:  1.4.0.10&#10;
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
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="FirstSequenceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: FirstSequence</remarks>
			/// </summary>
			public FirstSequenceProperty FirstSequence { get; } = new FirstSequenceProperty();
			
			/// <summary>﻿<i>sequence number</i> assigned to the oldest piece of <i>streaming data</i> stored in the <i>buffer</i> of the <i>agent</i> immediately prior to the time that the <i>agent</i> published the <i>response document</i>.   <br /><br /><br />
			/// </summary>
			public sealed class FirstSequenceProperty : IProperty
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
				public string Name => "firstSequence";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(sequence number)}} assigned to the oldest piece of {{term(streaming data)}} stored in the {{term(buffer)}} of the {{term(agent)}} immediately prior to the time that the {{term(agent)}} published the {{term(response document)}}.   &#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "1.4";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				public string Name => "lastSequence";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(sequence number)}} assigned to the last piece of {{term(streaming data)}} that was added to the {{term(buffer)}} of the {{term(agent)}} immediately prior to the time that the {{term(agent)}} published the {{term(response document)}}.   

&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "1.4";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				public string Name => "nextSequence";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(sequence number)}} of the piece of {{term(streaming data)}} that is the next piece of data to be retrieved from the {{term(buffer)}} of the {{term(agent)}} that was not included in the {{term(response document)}} published by the {{term(agent)}}.

If the {{term(streaming data)}} included in the {{term(response document)}} includes the last piece of data stored in the {{term(buffer)}} of the {{term(agent)}} at the time that the document was published, then the value reported for {{property(Header::nextSequence)}} **MUST** be equal to {{property(Header::lastSequence)}} + 1.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "1.4";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272233011_597138_670</item>
				/// <item>Type: DateTime</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
				/// <inheritdoc />
				public string Name => "deviceModelChangeTime";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;timestamp of the last update of the {{block(Device)}} information for any device.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}