#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.SolidModel
{
	/// <summary>﻿references to a file with the three-dimensional geometry of the <see cref="Component">Component</see> or <see cref="Composition">Composition</see>.<br /><br /><br />Description<br /><br />The geometry <b>MAY</b> have a transformation and a scale to position the <see cref="Component">Component</see> with respect to the other <see cref="Component">Component</see>s. A geometry file can contain a set of assembled items, in this case, the <see cref="SolidModel">SolidModel</see> references the <see cref="SolidModel.id">id in SolidModel</see> of the assembly model file and the specific item within that file.<br /><br />The <see cref="SolidModel">SolidModel</see> <b>MAY</b> provide a translation, rotation, and scale to correctly place it relative to the other geometries in the machine. If the <see cref="Component">Component</see> can move and has a <see cref="Motion">Motion</see> <see cref="Configuration">Configuration</see>, the <see cref="SolidModel">SolidModel</see> will move when the <see cref="Component">Component</see> or <see cref="Composition">Composition</see> moves.<br /><br />Either an <see cref="SolidModel.href">href in SolidModel</see> or a <see cref="SolidModel.modelIdRef">modelIdRef in SolidModel</see> and an <see cref="SolidModel.itemRef">itemRef in SolidModel</see> <b>MUST</b> be specified.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1587596157073_106480_480">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SolidModelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1587596157073_106480_480";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;references to a file with the three-dimensional geometry of the {{block(Component)}} or {{block(Composition)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;The geometry **MAY** have a transformation and a scale to position the {{block(Component)}} with respect to the other {{block(Component)}}s. A geometry file can contain a set of assembled items, in this case, the {{block(SolidModel)}} references the {{property(SolidModel::id)}} of the assembly model file and the specific item within that file.

The {{block(SolidModel)}} **MAY** provide a translation, rotation, and scale to correctly place it relative to the other geometries in the machine. If the {{block(Component)}} can move and has a {{block(Motion)}} {{block(Configuration)}}, the {{block(SolidModel)}} will move when the {{block(Component)}} or {{block(Composition)}} moves.

Either an {{property(SolidModel::href)}} or a {{property(SolidModel::modelIdRef)}} and an {{property(SolidModel::itemRef)}} **MUST** be specified.&#10;
";

		/// <inheritdoc />
		public string Name => "SolidModel";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new SolidModelClassProperties Properties { get; } = new SolidModelClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="SolidModelClass" />.
		/// </summary>
		public class SolidModelClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Id,
				HasTransformationPart,
				HasScalePart,
				SolidModelIdRef,
				Href,
				ItemRef,
				MediaType,
				CoordinateSystemIdRef,
				NativeUnits,
				Units,
			};
			/// <summary>
			/// <inheritdoc cref="IdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Id</remarks>
			/// </summary>
			public IdProperty Id { get; } = new IdProperty();
			
			/// <summary>﻿unique identifier for this element.<br /><br /><br />
			/// </summary>
			public sealed class IdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "id";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;unique identifier for this element.&#10;
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
			/// <inheritdoc cref="HasTransformationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasTransformation</remarks>
			/// </summary>
			public HasTransformationPartProperty HasTransformationPart { get; } = new HasTransformationPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasTransformationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579103900791_417826_16362</item>
				/// <item>Type: TransformationClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems.TransformationClass);
				
				/// <inheritdoc />
				public string Name => "hasTransformation";
				
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
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "Transformation";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasScalePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasScale</remarks>
			/// </summary>
			public HasScalePartProperty HasScalePart { get; } = new HasScalePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasScalePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1587596359868_51018_760</item>
				/// <item>Type: ScaleClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.SolidModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.SolidModel.ScaleClass);
				
				/// <inheritdoc />
				public string Name => "hasScale";
				
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
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "Scale";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="SolidModelIdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SolidModelIdRef</remarks>
			/// </summary>
			public SolidModelIdRefProperty SolidModelIdRef { get; } = new SolidModelIdRefProperty();
			
			/// <summary>﻿associated model file if an item reference is used.<br /><br /><br />
			/// </summary>
			public sealed class SolidModelIdRefProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "solidModelIdRef";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;associated model file if an item reference is used.&#10;
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
			/// <inheritdoc cref="HrefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Href</remarks>
			/// </summary>
			public HrefProperty Href { get; } = new HrefProperty();
			
			/// <summary>﻿<i>URL</i> giving the location of the <see cref="SolidModel">SolidModel</see>. <br /><br />If not present, the model referenced in the <see cref="SolidModel.solidModelIdRef">solidModelIdRef in SolidModel</see> is used.<br /><br /><br /><see cref="SolidModel.href">href in SolidModel</see> is of type <c>xlink:href</c> from the W3C XLink specification.<br /><br /><br />
			/// </summary>
			public sealed class HrefProperty : IProperty
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
				public string Name => "href";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(URL)}} giving the location of the {{block(SolidModel)}}. 

If not present, the model referenced in the {{property(SolidModel::solidModelIdRef)}} is used.

{{property(SolidModel::href)}} is of type `xlink:href` from the W3C XLink specification.&#10;
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
			/// <inheritdoc cref="ItemRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ItemRef</remarks>
			/// </summary>
			public ItemRefProperty ItemRef { get; } = new ItemRefProperty();
			
			/// <summary>﻿reference to the item within the model within the related geometry. A <see cref="SolidModel.solidModelIdRef">solidModelIdRef in SolidModel</see> <b>MUST</b> be given. <br /><br />&gt; Note: <c>Item</c> defined in ASME Y14.100 - A nonspecific term used to denote any unit or product, including materials, parts, assemblies, equipment, accessories, and computer software.<br /><br /><br />
			/// </summary>
			public sealed class ItemRefProperty : IProperty
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
				public string Name => "itemRef";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;reference to the item within the model within the related geometry. A {{property(SolidModel::solidModelIdRef)}} **MUST** be given. 

> Note: `Item` defined in ASME Y14.100 - A nonspecific term used to denote any unit or product, including materials, parts, assemblies, equipment, accessories, and computer software.&#10;
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
			/// <inheritdoc cref="MediaTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MediaType</remarks>
			/// </summary>
			public MediaTypeProperty MediaType { get; } = new MediaTypeProperty();
			
			/// <summary>﻿format of the referenced document.<br /><br /><br />
			/// </summary>
			public sealed class MediaTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605297694306_501792_610</item>
				/// <item>Type: MediaTypeEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.MediaTypeEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "mediaType";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;format of the referenced document.&#10;
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
			/// <inheritdoc cref="CoordinateSystemIdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CoordinateSystemIdRef</remarks>
			/// </summary>
			public CoordinateSystemIdRefProperty CoordinateSystemIdRef { get; } = new CoordinateSystemIdRefProperty();
			
			/// <summary>﻿reference to the coordinate system for this <see cref="SolidModel">SolidModel</see>.<br /><br /><br /><br />
			/// </summary>
			public sealed class CoordinateSystemIdRefProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "coordinateSystemIdRef";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;reference to the coordinate system for this {{block(SolidModel)}}.&#10;
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
			/// <inheritdoc cref="NativeUnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NativeUnits</remarks>
			/// </summary>
			public NativeUnitsProperty NativeUnits { get; } = new NativeUnitsProperty();
			
			/// <summary>﻿same as <see cref="DataItem.nativeUnits">nativeUnits in DataItem</see>. See <see cref="DataItem">DataItem</see>.<br /><br /><br />
			/// </summary>
			public sealed class NativeUnitsProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_678122A4_E8FD_4243_8427_6B7E0E78D5F5</item>
				/// <item>Type: NativeUnitEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.NativeUnitEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "nativeUnits";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;same as {{property(DataItem::nativeUnits)}}. See {{sect(DataItem)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.0";
				
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
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public UnitsProperty Units { get; } = new UnitsProperty();
			
			/// <summary>﻿same as <see cref="DataItem.units">units in DataItem</see>. See <see cref="DataItem">DataItem</see>.<br /><br /><br />
			/// </summary>
			public sealed class UnitsProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A</item>
				/// <item>Type: UnitEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UnitEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "units";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;same as {{property(DataItem::units)}}. See {{sect(DataItem)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.0";
				
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