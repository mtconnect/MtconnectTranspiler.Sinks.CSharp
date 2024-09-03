#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.WIP_DeviceExamples.KinematicsSimulation
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_91b028d_1582231560100_542213_121">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class Robot7axesClass : IClass
	{
		/// <summary>Constant value for <see cref="Robot7axesClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1582231560100_542213_121";
		/// <summary>Constant value for <see cref="Robot7axesClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_91b028d_1582231560100_542213_121";
		/// <summary>Constant value for <see cref="Robot7axesClass.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="Robot7axesClass.Name" /></summary>
		public const string NAME = "robot7axes";
		/// <summary>Constant value for <see cref="Robot7axesClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="Robot7axesClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="Robot7axesClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="Robot7axesClass.DeprecatedVersion" /></summary>
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
		public new Robot7axesClassProperties Properties { get; } = new Robot7axesClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="Robot7axesClass" />.
		/// </summary>
		public class Robot7axesClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Joint1,
				Joint2,
				Joint3,
				Joint4,
				Joint5,
				Joint6,
				Joint7,
				Position,
				Angle1,
				Angle2,
				Angle3,
				Angle4,
				Angle5,
				Angle6,
				Angle7,
			};
			/// <summary>
			/// <inheritdoc cref="Joint1Property" path="/summary" /><br/>
			/// <remarks>Original Name: Joint1</remarks>
			/// </summary>
			public Joint1Property Joint1 { get; } = new Joint1Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Joint1Property : IProperty
			{
				/// <summary>Constant value for <see cref="Joint1Property.Name" /></summary>
				public const string NAME = "joint1";
				/// <summary>Constant value for <see cref="Joint1Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Joint1Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Joint1Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Joint1Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Joint1Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Joint1Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Joint1Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Joint1Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Joint1Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: OriginPropertyClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
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
			/// <inheritdoc cref="Joint2Property" path="/summary" /><br/>
			/// <remarks>Original Name: Joint2</remarks>
			/// </summary>
			public Joint2Property Joint2 { get; } = new Joint2Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Joint2Property : IProperty
			{
				/// <summary>Constant value for <see cref="Joint2Property.Name" /></summary>
				public const string NAME = "joint2";
				/// <summary>Constant value for <see cref="Joint2Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Joint2Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Joint2Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Joint2Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Joint2Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Joint2Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Joint2Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Joint2Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Joint2Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: OriginPropertyClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
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
			/// <inheritdoc cref="Joint3Property" path="/summary" /><br/>
			/// <remarks>Original Name: Joint3</remarks>
			/// </summary>
			public Joint3Property Joint3 { get; } = new Joint3Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Joint3Property : IProperty
			{
				/// <summary>Constant value for <see cref="Joint3Property.Name" /></summary>
				public const string NAME = "joint3";
				/// <summary>Constant value for <see cref="Joint3Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Joint3Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="Joint3Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Joint3Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Joint3Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Joint3Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Joint3Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Joint3Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Joint3Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: OriginPropertyClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
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
			/// <inheritdoc cref="Joint4Property" path="/summary" /><br/>
			/// <remarks>Original Name: Joint4</remarks>
			/// </summary>
			public Joint4Property Joint4 { get; } = new Joint4Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Joint4Property : IProperty
			{
				/// <summary>Constant value for <see cref="Joint4Property.Name" /></summary>
				public const string NAME = "joint4";
				/// <summary>Constant value for <see cref="Joint4Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Joint4Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Joint4Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Joint4Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Joint4Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Joint4Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Joint4Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Joint4Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Joint4Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: OriginPropertyClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
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
			/// <inheritdoc cref="Joint5Property" path="/summary" /><br/>
			/// <remarks>Original Name: Joint5</remarks>
			/// </summary>
			public Joint5Property Joint5 { get; } = new Joint5Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Joint5Property : IProperty
			{
				/// <summary>Constant value for <see cref="Joint5Property.Name" /></summary>
				public const string NAME = "joint5";
				/// <summary>Constant value for <see cref="Joint5Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Joint5Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Joint5Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Joint5Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Joint5Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Joint5Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Joint5Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Joint5Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Joint5Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: OriginPropertyClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
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
			/// <inheritdoc cref="Joint6Property" path="/summary" /><br/>
			/// <remarks>Original Name: Joint6</remarks>
			/// </summary>
			public Joint6Property Joint6 { get; } = new Joint6Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Joint6Property : IProperty
			{
				/// <summary>Constant value for <see cref="Joint6Property.Name" /></summary>
				public const string NAME = "joint6";
				/// <summary>Constant value for <see cref="Joint6Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Joint6Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Joint6Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Joint6Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Joint6Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Joint6Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Joint6Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Joint6Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Joint6Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: OriginPropertyClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
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
			/// <inheritdoc cref="Joint7Property" path="/summary" /><br/>
			/// <remarks>Original Name: Joint7</remarks>
			/// </summary>
			public Joint7Property Joint7 { get; } = new Joint7Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Joint7Property : IProperty
			{
				/// <summary>Constant value for <see cref="Joint7Property.Name" /></summary>
				public const string NAME = "joint7";
				/// <summary>Constant value for <see cref="Joint7Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Joint7Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Joint7Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Joint7Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Joint7Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Joint7Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Joint7Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Joint7Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Joint7Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: OriginPropertyClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
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
			/// <inheritdoc cref="PositionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Position</remarks>
			/// </summary>
			public PositionProperty Position { get; } = new PositionProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class PositionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="PositionProperty.Name" /></summary>
				public const string NAME = "Position";
				/// <summary>Constant value for <see cref="PositionProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="PositionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="PositionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="PositionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="PositionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="PositionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="PositionProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="PositionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="PositionProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PositionClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.PositionClass);
				
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
			/// <inheritdoc cref="Angle1Property" path="/summary" /><br/>
			/// <remarks>Original Name: Angle1</remarks>
			/// </summary>
			public Angle1Property Angle1 { get; } = new Angle1Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Angle1Property : IProperty
			{
				/// <summary>Constant value for <see cref="Angle1Property.Name" /></summary>
				public const string NAME = "angle1";
				/// <summary>Constant value for <see cref="Angle1Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Angle1Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Angle1Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Angle1Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Angle1Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Angle1Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Angle1Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Angle1Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Angle1Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AngleClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.AngleClass);
				
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
			/// <inheritdoc cref="Angle2Property" path="/summary" /><br/>
			/// <remarks>Original Name: Angle2</remarks>
			/// </summary>
			public Angle2Property Angle2 { get; } = new Angle2Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Angle2Property : IProperty
			{
				/// <summary>Constant value for <see cref="Angle2Property.Name" /></summary>
				public const string NAME = "angle2";
				/// <summary>Constant value for <see cref="Angle2Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Angle2Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Angle2Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Angle2Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Angle2Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Angle2Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Angle2Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Angle2Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Angle2Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AngleClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.AngleClass);
				
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
			/// <inheritdoc cref="Angle3Property" path="/summary" /><br/>
			/// <remarks>Original Name: Angle3</remarks>
			/// </summary>
			public Angle3Property Angle3 { get; } = new Angle3Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Angle3Property : IProperty
			{
				/// <summary>Constant value for <see cref="Angle3Property.Name" /></summary>
				public const string NAME = "angle3";
				/// <summary>Constant value for <see cref="Angle3Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Angle3Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Angle3Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Angle3Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Angle3Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Angle3Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Angle3Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Angle3Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Angle3Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AngleClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.AngleClass);
				
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
			/// <inheritdoc cref="Angle4Property" path="/summary" /><br/>
			/// <remarks>Original Name: Angle4</remarks>
			/// </summary>
			public Angle4Property Angle4 { get; } = new Angle4Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Angle4Property : IProperty
			{
				/// <summary>Constant value for <see cref="Angle4Property.Name" /></summary>
				public const string NAME = "angle4";
				/// <summary>Constant value for <see cref="Angle4Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Angle4Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Angle4Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Angle4Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Angle4Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Angle4Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Angle4Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Angle4Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Angle4Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AngleClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.AngleClass);
				
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
			/// <inheritdoc cref="Angle5Property" path="/summary" /><br/>
			/// <remarks>Original Name: Angle5</remarks>
			/// </summary>
			public Angle5Property Angle5 { get; } = new Angle5Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Angle5Property : IProperty
			{
				/// <summary>Constant value for <see cref="Angle5Property.Name" /></summary>
				public const string NAME = "angle5";
				/// <summary>Constant value for <see cref="Angle5Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Angle5Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Angle5Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Angle5Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Angle5Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Angle5Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Angle5Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Angle5Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Angle5Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AngleClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.AngleClass);
				
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
			/// <inheritdoc cref="Angle6Property" path="/summary" /><br/>
			/// <remarks>Original Name: Angle6</remarks>
			/// </summary>
			public Angle6Property Angle6 { get; } = new Angle6Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Angle6Property : IProperty
			{
				/// <summary>Constant value for <see cref="Angle6Property.Name" /></summary>
				public const string NAME = "angle6";
				/// <summary>Constant value for <see cref="Angle6Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Angle6Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Angle6Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Angle6Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Angle6Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Angle6Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Angle6Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Angle6Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Angle6Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AngleClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.AngleClass);
				
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
			/// <inheritdoc cref="Angle7Property" path="/summary" /><br/>
			/// <remarks>Original Name: Angle7</remarks>
			/// </summary>
			public Angle7Property Angle7 { get; } = new Angle7Property();
			
			/// <summary>﻿
			/// </summary>
			public sealed class Angle7Property : IProperty
			{
				/// <summary>Constant value for <see cref="Angle7Property.Name" /></summary>
				public const string NAME = "angle7";
				/// <summary>Constant value for <see cref="Angle7Property.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="Angle7Property.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Angle7Property.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Angle7Property.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="Angle7Property.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Angle7Property.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Angle7Property.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="Angle7Property.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Angle7Property.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AngleClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_DeviceExamples.KinematicsSimulation.XArm7Model.AngleClass);
				
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