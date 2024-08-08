using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle
{
	/// <summary>
	/// location of the pot or spindle the cutting tool currently resides in.  If <see cref="Location::negativeOverlap" /> or <see cref="Location::positiveOverlap" /> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.  If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref="Location::positiveOverlap" /> of 1, the first pot <b>MAY</b> be occupied as well./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class LocationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_A012A42B_DBEC_4334_891D_5B45D7A7E340";
		
		/// <inheritdoc />
		public string Summary => @"/// location of the pot or spindle the cutting tool currently resides in.  If <see cref=""Location::negativeOverlap"" /> or <see cref=""Location::positiveOverlap"" /> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.  If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref=""Location::positiveOverlap"" /> of 1, the first pot <b>MAY</b> be occupied as well./// Description";

		/// <inheritdoc />
		public string Name => "LocationClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public LocationClassProperties Properties { get; } = new LocationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class LocationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				NegativeOverlap,
				PositiveOverlap,
				Type,
				Turret,
				ToolMagazine,
				ToolBar,
				ToolRack,
				AutomaticToolChanger,
				Value,
			};
			/// <summary>
			/// <inheritdoc cref="NegativeOverlapProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NegativeOverlap</remarks>
			/// </summary>
			public NegativeOverlapProperty NegativeOverlap { get; } = new NegativeOverlapProperty();
			/// <summary>
			/// number of locations at lower index values from this location.
			/// </summary>
			public sealed class NegativeOverlapProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272271512_537408_674</item>
				/// <item>Type: Int32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
				/// <inheritdoc />
				public string Name => "NegativeOverlap";
				
				/// <inheritdoc />
				public string Summary => @"/// location of the pot or spindle the cutting tool currently resides in.  If <see cref=""Location::negativeOverlap"" /> or <see cref=""Location::positiveOverlap"" /> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.  If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref=""Location::positiveOverlap"" /> of 1, the first pot <b>MAY</b> be occupied as well./// Description";

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
			/// <inheritdoc cref="PositiveOverlapProperty" path="/summary" /><br/>
			/// <remarks>Original Name: PositiveOverlap</remarks>
			/// </summary>
			public PositiveOverlapProperty PositiveOverlap { get; } = new PositiveOverlapProperty();
			/// <summary>
			/// number of locations at higher index value from this location. 
			/// </summary>
			public sealed class PositiveOverlapProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272271512_537408_674</item>
				/// <item>Type: Int32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
				/// <inheritdoc />
				public string Name => "PositiveOverlap";
				
				/// <inheritdoc />
				public string Summary => @"/// location of the pot or spindle the cutting tool currently resides in.  If <see cref=""Location::negativeOverlap"" /> or <see cref=""Location::positiveOverlap"" /> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.  If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref=""Location::positiveOverlap"" /> of 1, the first pot <b>MAY</b> be occupied as well./// Description";

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
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			/// <summary>
			/// type of location being identified.   When a <c>POT</c> or <c>STATION</c> type is used, <see cref="Location::value" /><b>MUST</b> be a numeric value.
			/// </summary>
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_0167FC5F_C61F_4bc7_A1B3_C724FE8865BA</item>
				/// <item>Type: LocationTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.LocationTypeEnum);
				
				/// <inheritdoc />
				public string Name => "Type";
				
				/// <inheritdoc />
				public string Summary => @"/// location of the pot or spindle the cutting tool currently resides in.  If <see cref=""Location::negativeOverlap"" /> or <see cref=""Location::positiveOverlap"" /> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.  If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref=""Location::positiveOverlap"" /> of 1, the first pot <b>MAY</b> be occupied as well./// Description";

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
			/// <inheritdoc cref="TurretProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Turret</remarks>
			/// </summary>
			public TurretProperty Turret { get; } = new TurretProperty();
			/// <summary>
			/// turret associated with a tool.
			/// </summary>
			public sealed class TurretProperty : IProperty
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
				public string Name => "Turret";
				
				/// <inheritdoc />
				public string Summary => @"/// location of the pot or spindle the cutting tool currently resides in.  If <see cref=""Location::negativeOverlap"" /> or <see cref=""Location::positiveOverlap"" /> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.  If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref=""Location::positiveOverlap"" /> of 1, the first pot <b>MAY</b> be occupied as well./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.4";
				
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
			/// <inheritdoc cref="ToolMagazineProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ToolMagazine</remarks>
			/// </summary>
			public ToolMagazineProperty ToolMagazine { get; } = new ToolMagazineProperty();
			/// <summary>
			/// tool magazine associated with a tool. 
			/// </summary>
			public sealed class ToolMagazineProperty : IProperty
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
				public string Name => "ToolMagazine";
				
				/// <inheritdoc />
				public string Summary => @"/// location of the pot or spindle the cutting tool currently resides in.  If <see cref=""Location::negativeOverlap"" /> or <see cref=""Location::positiveOverlap"" /> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.  If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref=""Location::positiveOverlap"" /> of 1, the first pot <b>MAY</b> be occupied as well./// Description";

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
			/// <inheritdoc cref="ToolBarProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ToolBar</remarks>
			/// </summary>
			public ToolBarProperty ToolBar { get; } = new ToolBarProperty();
			/// <summary>
			/// tool bar associated with a tool.
			/// </summary>
			public sealed class ToolBarProperty : IProperty
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
				public string Name => "ToolBar";
				
				/// <inheritdoc />
				public string Summary => @"/// location of the pot or spindle the cutting tool currently resides in.  If <see cref=""Location::negativeOverlap"" /> or <see cref=""Location::positiveOverlap"" /> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.  If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref=""Location::positiveOverlap"" /> of 1, the first pot <b>MAY</b> be occupied as well./// Description";

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
			/// <inheritdoc cref="ToolRackProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ToolRack</remarks>
			/// </summary>
			public ToolRackProperty ToolRack { get; } = new ToolRackProperty();
			/// <summary>
			/// tool rack associated with a tool.
			/// </summary>
			public sealed class ToolRackProperty : IProperty
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
				public string Name => "ToolRack";
				
				/// <inheritdoc />
				public string Summary => @"/// location of the pot or spindle the cutting tool currently resides in.  If <see cref=""Location::negativeOverlap"" /> or <see cref=""Location::positiveOverlap"" /> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.  If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref=""Location::positiveOverlap"" /> of 1, the first pot <b>MAY</b> be occupied as well./// Description";

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
			/// <inheritdoc cref="AutomaticToolChangerProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AutomaticToolChanger</remarks>
			/// </summary>
			public AutomaticToolChangerProperty AutomaticToolChanger { get; } = new AutomaticToolChangerProperty();
			/// <summary>
			/// automatic tool changer associated with a tool.
			/// </summary>
			public sealed class AutomaticToolChangerProperty : IProperty
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
				public string Name => "AutomaticToolChanger";
				
				/// <inheritdoc />
				public string Summary => @"/// location of the pot or spindle the cutting tool currently resides in.  If <see cref=""Location::negativeOverlap"" /> or <see cref=""Location::positiveOverlap"" /> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.  If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref=""Location::positiveOverlap"" /> of 1, the first pot <b>MAY</b> be occupied as well./// Description";

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
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
			public sealed class ValueProperty : IProperty
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
				public string Name => "Value";
				
				/// <inheritdoc />
				public string Summary => @"/// location of the pot or spindle the cutting tool currently resides in.  If <see cref=""Location::negativeOverlap"" /> or <see cref=""Location::positiveOverlap"" /> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.  If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref=""Location::positiveOverlap"" /> of 1, the first pot <b>MAY</b> be occupied as well./// Description";

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