using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model;
// using Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class Robot7axesClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1582231560100_542213_121";
		
		/// <inheritdoc />
		public string Name => "Robot7axesClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public Robot7axesClassProperties Properties { get; } = new Robot7axesClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class Robot7axesClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
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
			/// <remarks>Original Name: Joint1</remarks>
			public Joint1Property Joint1 { get; } = new Joint1Property();
			public sealed class Joint1Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232410859_111633_157</item>
				/// <item>Type: OriginPropertyClass</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
				/// <inheritdoc />
				public string Name => "Joint1";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Joint2</remarks>
			public Joint2Property Joint2 { get; } = new Joint2Property();
			public sealed class Joint2Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232410859_111633_157</item>
				/// <item>Type: OriginPropertyClass</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
				/// <inheritdoc />
				public string Name => "Joint2";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Joint3</remarks>
			public Joint3Property Joint3 { get; } = new Joint3Property();
			public sealed class Joint3Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232410859_111633_157</item>
				/// <item>Type: OriginPropertyClass</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
				/// <inheritdoc />
				public string Name => "Joint3";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Joint4</remarks>
			public Joint4Property Joint4 { get; } = new Joint4Property();
			public sealed class Joint4Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232410859_111633_157</item>
				/// <item>Type: OriginPropertyClass</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
				/// <inheritdoc />
				public string Name => "Joint4";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Joint5</remarks>
			public Joint5Property Joint5 { get; } = new Joint5Property();
			public sealed class Joint5Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232410859_111633_157</item>
				/// <item>Type: OriginPropertyClass</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
				/// <inheritdoc />
				public string Name => "Joint5";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Joint6</remarks>
			public Joint6Property Joint6 { get; } = new Joint6Property();
			public sealed class Joint6Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232410859_111633_157</item>
				/// <item>Type: OriginPropertyClass</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
				/// <inheritdoc />
				public string Name => "Joint6";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Joint7</remarks>
			public Joint7Property Joint7 { get; } = new Joint7Property();
			public sealed class Joint7Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232410859_111633_157</item>
				/// <item>Type: OriginPropertyClass</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.OriginPropertyClass);
				
				/// <inheritdoc />
				public string Name => "Joint7";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Position</remarks>
			public PositionProperty Position { get; } = new PositionProperty();
			public sealed class PositionProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232689807_149219_388</item>
				/// <item>Type: PositionClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.PositionClass);
				
				/// <inheritdoc />
				public string Name => "Position";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Angle1</remarks>
			public Angle1Property Angle1 { get; } = new Angle1Property();
			public sealed class Angle1Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582289110377_617694_24</item>
				/// <item>Type: AngleClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.AngleClass);
				
				/// <inheritdoc />
				public string Name => "Angle1";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Angle2</remarks>
			public Angle2Property Angle2 { get; } = new Angle2Property();
			public sealed class Angle2Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582289110377_617694_24</item>
				/// <item>Type: AngleClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.AngleClass);
				
				/// <inheritdoc />
				public string Name => "Angle2";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Angle3</remarks>
			public Angle3Property Angle3 { get; } = new Angle3Property();
			public sealed class Angle3Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582289110377_617694_24</item>
				/// <item>Type: AngleClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.AngleClass);
				
				/// <inheritdoc />
				public string Name => "Angle3";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Angle4</remarks>
			public Angle4Property Angle4 { get; } = new Angle4Property();
			public sealed class Angle4Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582289110377_617694_24</item>
				/// <item>Type: AngleClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.AngleClass);
				
				/// <inheritdoc />
				public string Name => "Angle4";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Angle5</remarks>
			public Angle5Property Angle5 { get; } = new Angle5Property();
			public sealed class Angle5Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582289110377_617694_24</item>
				/// <item>Type: AngleClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.AngleClass);
				
				/// <inheritdoc />
				public string Name => "Angle5";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Angle6</remarks>
			public Angle6Property Angle6 { get; } = new Angle6Property();
			public sealed class Angle6Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582289110377_617694_24</item>
				/// <item>Type: AngleClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.AngleClass);
				
				/// <inheritdoc />
				public string Name => "Angle6";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Angle7</remarks>
			public Angle7Property Angle7 { get; } = new Angle7Property();
			public sealed class Angle7Property : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582289110377_617694_24</item>
				/// <item>Type: AngleClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.AngleClass);
				
				/// <inheritdoc />
				public string Name => "Angle7";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}