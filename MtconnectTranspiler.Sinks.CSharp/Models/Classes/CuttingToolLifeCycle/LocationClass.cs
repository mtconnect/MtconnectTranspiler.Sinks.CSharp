#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle
{
	/// <summary>﻿location of the pot or spindle the cutting tool currently resides in.<br /><br />If <see cref="Location.negativeOverlap">negativeOverlap in Location</see> or <see cref="Location.positiveOverlap">positiveOverlap in Location</see> is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.<br /><br />If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a <see cref="Location.positiveOverlap">positiveOverlap in Location</see> of 1, the first pot <b>MAY</b> be occupied as well.<br /><br /><br />Description<br /><br /><see cref="Location">Location</see> <b>MUST</b> be defined only for the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> of <see cref="CuttingTool">CuttingTool</see> and <b>MUST NOT</b> be defined for the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> of <see cref="CuttingToolArchetype">CuttingToolArchetype</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_A012A42B_DBEC_4334_891D_5B45D7A7E340">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class LocationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_A012A42B_DBEC_4334_891D_5B45D7A7E340";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;location of the pot or spindle the cutting tool currently resides in.

If {{property(Location::negativeOverlap)}} or {{property(Location::positiveOverlap)}} is provided, the tool reserves additional locations on either side, otherwise if they are not given, no additional locations are required for this tool.

If the pot occupies the first or last location, a rollover to the beginning or the end of the indexable values may occur. For example, if there are 64 pots and the tool is in pot 64 with a {{property(Location::positiveOverlap)}} of 1, the first pot **MAY** be occupied as well.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(Location)}} **MUST** be defined only for the {{block(CuttingToolLifeCycle)}} of {{block(CuttingTool)}} and **MUST NOT** be defined for the {{block(CuttingToolLifeCycle)}} of {{block(CuttingToolArchetype)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Location";
		
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
		public new LocationClassProperties Properties { get; } = new LocationClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="LocationClass" />.
		/// </summary>
		public class LocationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
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
			
			/// <summary>﻿number of locations at lower index values from this location.<br /><br /><br />
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
				public string Name => "negativeOverlap";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;number of locations at lower index values from this location.&#10;
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
			
			/// <summary>﻿number of locations at higher index value from this location.<br /><br /><br /><br />
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
				public string Name => "positiveOverlap";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;number of locations at higher index value from this location.&#10;
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
			
			/// <summary>﻿type of location being identified. <br /><br />When a <c>POT</c> or <c>STATION</c> type is used, <see cref="Location.value">value in Location</see><b>MUST</b> be a numeric value.<br /><br /><br />
			/// </summary>
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_0167FC5F_C61F_4bc7_A1B3_C724FE8865BA</item>
				/// <item>Type: LocationTypeEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.LocationTypeEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;type of location being identified. 

When a `POT` or `STATION` type is used, {{property(Location::value)}}**MUST** be a numeric value.&#10;
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
			
			/// <summary>﻿turret associated with a tool.<br /><br /><br />
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
				public string Name => "turret";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;turret associated with a tool.&#10;
";

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
			
			/// <summary>﻿tool magazine associated with a tool.<br /><br /><br /><br />
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
				public string Name => "toolMagazine";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;tool magazine associated with a tool.&#10;
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
			/// <summary>
			/// <inheritdoc cref="ToolBarProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ToolBar</remarks>
			/// </summary>
			public ToolBarProperty ToolBar { get; } = new ToolBarProperty();
			
			/// <summary>﻿tool bar associated with a tool.<br /><br /><br />
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
				public string Name => "toolBar";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;tool bar associated with a tool.&#10;
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
			/// <summary>
			/// <inheritdoc cref="ToolRackProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ToolRack</remarks>
			/// </summary>
			public ToolRackProperty ToolRack { get; } = new ToolRackProperty();
			
			/// <summary>﻿tool rack associated with a tool.<br /><br /><br />
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
				public string Name => "toolRack";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;tool rack associated with a tool.&#10;
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
			/// <summary>
			/// <inheritdoc cref="AutomaticToolChangerProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AutomaticToolChanger</remarks>
			/// </summary>
			public AutomaticToolChangerProperty AutomaticToolChanger { get; } = new AutomaticToolChangerProperty();
			
			/// <summary>﻿automatic tool changer associated with a tool.<br /><br /><br />
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
				public string Name => "automaticToolChanger";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;automatic tool changer associated with a tool.&#10;
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
			/// <summary>
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
			
			/// <summary>﻿
			/// </summary>
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
				public string Name => "value";
				
				/// <inheritdoc />
				public string Summary => @"";

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