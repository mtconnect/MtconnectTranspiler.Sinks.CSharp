using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class OriginPropertyClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1582232410859_111633_157";
		
		/// <inheritdoc />
		public string Name => "OriginPropertyClass";
		
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
		public OriginPropertyClassProperties Properties { get; } = new OriginPropertyClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class OriginPropertyClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ParentCoordinates,
				Origin,
				RotationVector,
				TranslationVector,
				Transform,
				UnitVector,
			};
			/// <remarks>Original Name: ParentCoordinates</remarks>
			public ParentCoordinatesProperty ParentCoordinates { get; } = new ParentCoordinatesProperty();
			public sealed class ParentCoordinatesProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232446904_854073_202</item>
				/// <item>Type: ParentCoordinatesClass</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.ParentCoordinatesClass);
				
				/// <inheritdoc />
				public string Name => "ParentCoordinates";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

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
			/// <remarks>Original Name: Origin</remarks>
			public OriginProperty Origin { get; } = new OriginProperty();
			public sealed class OriginProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232449455_399436_247</item>
				/// <item>Type: OriginPositionGeneralization</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.OriginPositionGeneralization);
				
				/// <inheritdoc />
				public string Name => "Origin";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

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
			/// <remarks>Original Name: RotationVector</remarks>
			public RotationVectorProperty RotationVector { get; } = new RotationVectorProperty();
			public sealed class RotationVectorProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232453022_186519_292</item>
				/// <item>Type: RotationVectorGeneralization</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.RotationVectorGeneralization);
				
				/// <inheritdoc />
				public string Name => "RotationVector";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

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
			/// <remarks>Original Name: TranslationVector</remarks>
			public TranslationVectorProperty TranslationVector { get; } = new TranslationVectorProperty();
			public sealed class TranslationVectorProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582232454926_330097_337</item>
				/// <item>Type: TranslationVectorGeneralization</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.TranslationVectorGeneralization);
				
				/// <inheritdoc />
				public string Name => "TranslationVector";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

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
			/// <remarks>Original Name: Transform</remarks>
			public TransformProperty Transform { get; } = new TransformProperty();
			public sealed class TransformProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582233160564_921570_689</item>
				/// <item>Type: TransformationClass</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.TransformationClass);
				
				/// <inheritdoc />
				public string Name => "Transform";
				
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
			/// <remarks>Original Name: UnitVector</remarks>
			public UnitVectorProperty UnitVector { get; } = new UnitVectorProperty();
			public sealed class UnitVectorProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1582289916067_452845_327</item>
				/// <item>Type: AxisClass</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.AxisClass);
				
				/// <inheritdoc />
				public string Name => "UnitVector";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

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