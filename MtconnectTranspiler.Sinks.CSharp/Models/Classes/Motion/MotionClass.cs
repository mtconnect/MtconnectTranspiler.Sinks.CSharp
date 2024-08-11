using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.Motion
{
	/// <summary>
	/// movement of the component relative to a coordinate system. /// Description
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_1F084FBF_2AC7_41f6_8485_C356E6D7A9C1">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MotionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_1F084FBF_2AC7_41f6_8485_C356E6D7A9C1";
		
		/// <inheritdoc />
		public string Summary => @"/// movement of the component relative to a coordinate system. /// Description";

		/// <inheritdoc />
		public string Name => "Motion";
		
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
		public MotionClassProperties Properties { get; } = new MotionClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class MotionClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Actuation,
				CoordinateSystemIdRef,
				Id,
				ParentIdRef,
				Type,
				HasAxisPart,
				HasOriginPart,
				HasTransformationPart,
				HasDescriptionPart,
			};
			/// <summary>
			/// <inheritdoc cref="ActuationProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Actuation</remarks>
			/// </summary>
			public ActuationProperty Actuation { get; } = new ActuationProperty();
			/// <summary>
			/// describes if this component is actuated directly or indirectly as a result of other motion.
			/// </summary>
			public sealed class ActuationProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_C5CA1571_EA21_4123_942E_7329B6C61618</item>
				/// <item>Type: MotionActuationTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.MotionActuationTypeEnum);
				
				/// <inheritdoc />
				public string Name => "actuation";
				
				/// <inheritdoc />
				public string Summary => @"/// movement of the component relative to a coordinate system. /// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
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
			/// <inheritdoc cref="CoordinateSystemIdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CoordinateSystemIdRef</remarks>
			/// </summary>
			public CoordinateSystemIdRefProperty CoordinateSystemIdRef { get; } = new CoordinateSystemIdRefProperty();
			/// <summary>
			/// coordinate system within which the kinematic motion occurs.
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
				public string Summary => @"/// movement of the component relative to a coordinate system. /// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
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
			/// <inheritdoc cref="IdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Id</remarks>
			/// </summary>
			public IdProperty Id { get; } = new IdProperty();
			/// <summary>
			/// unique identifier for this element.
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
				public string Summary => @"/// movement of the component relative to a coordinate system. /// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
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
			/// <inheritdoc cref="ParentIdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ParentIdRef</remarks>
			/// </summary>
			public ParentIdRefProperty ParentIdRef { get; } = new ParentIdRefProperty();
			/// <summary>
			/// pointer to the <see cref="Motion::id" />.  The kinematic chain connects all components using the parent relations. All motion is connected to the motion of the parent. The first node in the chain will not have a parent.
			/// </summary>
			public sealed class ParentIdRefProperty : IProperty
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
				public string Name => "parentIdRef";
				
				/// <inheritdoc />
				public string Summary => @"/// movement of the component relative to a coordinate system. /// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
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
			/// type of motion.
			/// </summary>
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_4BA8528B_F152_49aa_BEFD_2574649F9F1A</item>
				/// <item>Type: MotionTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.MotionTypeEnum);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"/// movement of the component relative to a coordinate system. /// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
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
			/// <inheritdoc cref="HasAxisPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAxis</remarks>
			/// </summary>
			public HasAxisPartProperty HasAxisPart { get; } = new HasAxisPartProperty();
			public sealed class HasAxisPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_7D0C7298_9CC4_4c45_A016_310B9A55DD7F</item>
				/// <item>Type: AxisClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.Motion</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.Motion.AxisClass);
				
				/// <inheritdoc />
				public string Name => "hasAxis";
				
				/// <inheritdoc />
				public string Summary => @"/// movement of the component relative to a coordinate system. /// Description";

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
				public string Association => "Axis";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasOriginPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasOrigin</remarks>
			/// </summary>
			public HasOriginPartProperty HasOriginPart { get; } = new HasOriginPartProperty();
			public sealed class HasOriginPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579107743274_159386_163610</item>
				/// <item>Type: OriginClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems.OriginClass);
				
				/// <inheritdoc />
				public string Name => "hasOrigin";
				
				/// <inheritdoc />
				public string Summary => @"/// movement of the component relative to a coordinate system. /// Description";

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
				public string Association => "Origin";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasTransformationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasTransformation</remarks>
			/// </summary>
			public HasTransformationPartProperty HasTransformationPart { get; } = new HasTransformationPartProperty();
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
				public string Summary => @"/// movement of the component relative to a coordinate system. /// Description";

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
			/// <inheritdoc cref="HasDescriptionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDescription</remarks>
			/// </summary>
			public HasDescriptionPartProperty HasDescriptionPart { get; } = new HasDescriptionPartProperty();
			public sealed class HasDescriptionPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_64352755_7251_46af_846D_937E5A1E3949</item>
				/// <item>Type: DescriptionClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.DescriptionClass);
				
				/// <inheritdoc />
				public string Name => "hasDescription";
				
				/// <inheritdoc />
				public string Summary => @"/// movement of the component relative to a coordinate system. /// Description";

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
				public string Association => "Description";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}