using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument
{
	/// <summary>
	/// provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_B6A102D0_7CF7_495e_816A_17AC11572B70">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class HeaderClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_B6A102D0_7CF7_495e_816A_17AC11572B70";
		
		/// <inheritdoc />
		public string Summary => @"/// provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.";

		/// <inheritdoc />
		public string Name => "Header";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public HeaderClassProperties Properties { get; } = new HeaderClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class HeaderClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				DeviceModelChangeTime,
				AssetBufferSize,
				AssetCount,
				CreationTime,
				InstanceId,
				Sender,
				TestIndicator,
				Version,
			};
			/// <summary>
			/// <inheritdoc cref="DeviceModelChangeTimeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DeviceModelChangeTime</remarks>
			/// </summary>
			public DeviceModelChangeTimeProperty DeviceModelChangeTime { get; } = new DeviceModelChangeTimeProperty();
			/// <summary>
			/// timestamp of the last update of the <see cref="Device">Device</see> information for any device.
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
				public string Summary => @"/// provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.";

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
			/// <summary>
			/// <inheritdoc cref="AssetBufferSizeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetBufferSize</remarks>
			/// </summary>
			public AssetBufferSizeProperty AssetBufferSize { get; } = new AssetBufferSizeProperty();
			/// <summary>
			/// maximum number of <see cref="Asset">Asset</see> types that can be stored in the <i>agent</i> that published the <i>response document</i>.    > Note: The implementer is responsible for allocating the appropriate amount of storage capacity required to accommodate the <see cref="Header::assetBufferSize" />. 
			/// </summary>
			public sealed class AssetBufferSizeProperty : IProperty
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
				public string Name => "assetBufferSize";
				
				/// <inheritdoc />
				public string Summary => @"/// provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
			/// <inheritdoc cref="AssetCountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetCount</remarks>
			/// </summary>
			public AssetCountProperty AssetCount { get; } = new AssetCountProperty();
			/// <summary>
			/// current number of <see cref="Asset">Asset</see> that are currently stored in the <i>agent</i> as of the <see cref="Header::creationTime" /> that the <i>agent</i> published the <i>response document</i>.  <see cref="Header::assetCount" /> <b>MUST NOT</b> be larger than the value reported for <see cref="Header::assetBufferSize" />. 
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
				public string Summary => @"/// provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
			/// <summary>
			/// timestamp that an <i>agent</i> published the <i>response document</i>. 
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
				public string Summary => @"/// provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
			/// <summary>
			/// identifier for a specific instantiation of the <i>buffer</i> associated with the <i>agent</i> that published the <i>response document</i>.         <see cref="Header::instanceId" /> <b>MUST</b> be changed to a different unique number each time the <i>buffer</i> is cleared and a new set of data begins to be collected.
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
				public string Summary => @"/// provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
			/// <summary>
			/// identification defining where the <i>agent</i> that published the <i>response document</i> is installed or hosted.  <see cref="Header::sender" /> <b>MUST</b> be either an IP Address or Hostname describing where the <i>agent</i> is installed or the URL of the <i>agent</i>; e.g., <c>http://<address>[:port]/</c>.   > Note:  The port number need not be specified if it is the default HTTP port 80.
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
				public string Summary => @"/// provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
			/// <summary>
			/// indicates whether the <i>agent</i> that published the <i>response document</i> is operating in a test mode.  If <see cref="Header::testIndicator" /> is not specified, the value for <see cref="Header::testIndicator" /> <b>MUST</b> be interpreted to be <c>false</c>.
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
				public string Summary => @"/// provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
			/// <summary>
			/// <i>major</i>, <i>minor</i>, and <i>revision</i> number of the MTConnect Standard that defines the <i>semantic data model</i> that represents the content of the <i>response document</i>. It also includes the revision number of the <i>schema</i> associated with that specific <i>semantic data model</i>.  As an example, the value reported for <see cref="Header::version" /> for a <i>response document</i> that was structured based on <i>schema</i> revision 10 associated with Version 1.4.0 of the MTConnect Standard would be:  1.4.0.10
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
				public string Summary => @"/// provides information from an <i>agent</i> defining version information, storage capacity, and parameters associated with the data management within the <i>agent</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
		};

	}
}