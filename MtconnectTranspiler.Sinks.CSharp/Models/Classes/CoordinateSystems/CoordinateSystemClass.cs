using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems;
// using Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model;
// using Mtconnect.DataTypes;

namespace Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems
{
	/// <summary>
	/// reference system that associates a unique set of n parameters with each point in an n-dimensional space. <seealso href="https://www.google.com/search?q=ISO 10303-218:2004&btnI=I">ISO 10303-218:2004</seealso>/// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CoordinateSystemClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579100679936_1279_16310";
		
		/// <inheritdoc />
		public string Summary => @"/// reference system that associates a unique set of n parameters with each point in an n-dimensional space. <seealso href=""https://www.google.com/search?q=ISO 10303-218:2004&btnI=I"">ISO 10303-218:2004</seealso>/// Description";

		/// <inheritdoc />
		public string Name => "CoordinateSystemClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.6";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public CoordinateSystemClassProperties Properties { get; } = new CoordinateSystemClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class CoordinateSystemClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Id,
				Name,
				NativeName,
				ParentIdRef,
				HasOriginPart,
				HasTransformationPart,
				Type,
				Uuid,
				Description,
			};
			/// <summary>
			/// <inheritdoc cref="IdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Id</remarks>
			/// </summary>
			public IdProperty Id { get; } = new IdProperty();
			/// <summary>
			/// unique identifier for the coordinate system.
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
				public string Name => "Id";
				
				/// <inheritdoc />
				public string Summary => @"/// reference system that associates a unique set of n parameters with each point in an n-dimensional space. <seealso href=""https://www.google.com/search?q=ISO 10303-218:2004&btnI=I"">ISO 10303-218:2004</seealso>/// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.6";
				
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
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			/// <summary>
			/// name of the coordinate system.
			/// </summary>
			public sealed class NameProperty : IProperty
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
				public string Name => "Name";
				
				/// <inheritdoc />
				public string Summary => @"/// reference system that associates a unique set of n parameters with each point in an n-dimensional space. <seealso href=""https://www.google.com/search?q=ISO 10303-218:2004&btnI=I"">ISO 10303-218:2004</seealso>/// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.6";
				
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
			/// <inheritdoc cref="NativeNameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NativeName</remarks>
			/// </summary>
			public NativeNameProperty NativeName { get; } = new NativeNameProperty();
			/// <summary>
			/// manufacturer's name or users name for the coordinate system.
			/// </summary>
			public sealed class NativeNameProperty : IProperty
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
				public string Name => "NativeName";
				
				/// <inheritdoc />
				public string Summary => @"/// reference system that associates a unique set of n parameters with each point in an n-dimensional space. <seealso href=""https://www.google.com/search?q=ISO 10303-218:2004&btnI=I"">ISO 10303-218:2004</seealso>/// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.6";
				
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
			/// <inheritdoc cref="ParentIdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ParentIdRef</remarks>
			/// </summary>
			public ParentIdRefProperty ParentIdRef { get; } = new ParentIdRefProperty();
			/// <summary>
			/// pointer to the <see cref="CoordinateSystem::id" />.
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
				public string Name => "ParentIdRef";
				
				/// <inheritdoc />
				public string Summary => @"/// reference system that associates a unique set of n parameters with each point in an n-dimensional space. <seealso href=""https://www.google.com/search?q=ISO 10303-218:2004&btnI=I"">ISO 10303-218:2004</seealso>/// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.6";
				
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
				public string Name => "HasOrigin";
				
				/// <inheritdoc />
				public string Summary => @"/// reference system that associates a unique set of n parameters with each point in an n-dimensional space. <seealso href=""https://www.google.com/search?q=ISO 10303-218:2004&btnI=I"">ISO 10303-218:2004</seealso>/// Description";

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
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.TransformationClass);
				
				/// <inheritdoc />
				public string Name => "HasTransformation";
				
				/// <inheritdoc />
				public string Summary => @"/// reference system that associates a unique set of n parameters with each point in an n-dimensional space. <seealso href=""https://www.google.com/search?q=ISO 10303-218:2004&btnI=I"">ISO 10303-218:2004</seealso>/// Description";

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
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			/// <summary>
			/// type of coordinate system.
			/// </summary>
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579107560604_392738_163543</item>
				/// <item>Type: CoordinateSystemTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.CoordinateSystemTypeEnum);
				
				/// <inheritdoc />
				public string Name => "Type";
				
				/// <inheritdoc />
				public string Summary => @"/// reference system that associates a unique set of n parameters with each point in an n-dimensional space. <seealso href=""https://www.google.com/search?q=ISO 10303-218:2004&btnI=I"">ISO 10303-218:2004</seealso>/// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.6";
				
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
			/// <inheritdoc cref="UuidProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Uuid</remarks>
			/// </summary>
			public UuidProperty Uuid { get; } = new UuidProperty();
			/// <summary>
			/// <i>UUID</i> for the coordinate system.
			/// </summary>
			public sealed class UuidProperty : IProperty
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
				public string Name => "Uuid";
				
				/// <inheritdoc />
				public string Summary => @"/// reference system that associates a unique set of n parameters with each point in an n-dimensional space. <seealso href=""https://www.google.com/search?q=ISO 10303-218:2004&btnI=I"">ISO 10303-218:2004</seealso>/// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
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
			/// <inheritdoc cref="DescriptionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Description</remarks>
			/// </summary>
			public DescriptionProperty Description { get; } = new DescriptionProperty();
			/// <summary>
			/// natural language description of the <see cref="CoordinateSystem">CoordinateSystem</see>.
			/// </summary>
			public sealed class DescriptionProperty : IProperty
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
				public string Name => "Description";
				
				/// <inheritdoc />
				public string Summary => @"/// reference system that associates a unique set of n parameters with each point in an n-dimensional space. <seealso href=""https://www.google.com/search?q=ISO 10303-218:2004&btnI=I"">ISO 10303-218:2004</seealso>/// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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

		# region Rules
		/// <summary>
		/// Coordinatesystem
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string Coordinatesystem => @"hasOrigin->size() + hasTransformation->size() <= 1 and hasOrigin->size() + hasTransformation->size() <> 0";
		/*
		hasOrigin->size() + hasTransformation->size() <= 1 and hasOrigin->size() + hasTransformation->size() <> 0
		*/
		# endregion
	}
}