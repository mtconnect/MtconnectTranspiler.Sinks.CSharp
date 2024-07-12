
using System;
using System.CodeDom.Compiler;

using Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class CollaboratorClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1622718569783_691547_1331";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Collaborator";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public CollaboratorProperties Properties { get; } = new CollaboratorProperties();
		public sealed class CollaboratorProperties
		{
		
		
			/// <remarks>Original Name: HasPriority</remarks>
			public HasPriorityPartProperty HasPriorityPart { get; } = new HasPriorityPartProperty();
			public sealed class HasPriorityPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1622721553723_407241_2231
				public Type Type => typeof(PriorityClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasPriority";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "Priority";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: CollaboratorId</remarks>
			public CollaboratorIdProperty CollaboratorId { get; } = new CollaboratorIdProperty();
			public sealed class CollaboratorIdProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272245466_691733_672
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "CollaboratorId";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: CollaboratorType</remarks>
			public CollaboratorTypeProperty CollaboratorType { get; } = new CollaboratorTypeProperty();
			public sealed class CollaboratorTypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1622723031886_684761_3039
				public Type Type => typeof(CollaboratorTypeEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "CollaboratorType";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Optional</remarks>
			public OptionalProperty Optional { get; } = new OptionalProperty();
			public sealed class OptionalProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579278876899_683310_3821
				public Type Type => typeof(Boolean);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Optional";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasCapability</remarks>
			public HasCapabilityPartProperty HasCapabilityPart { get; } = new HasCapabilityPartProperty();
			public sealed class HasCapabilityPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1622723160082_480366_3118
				public Type Type => typeof(CapabilityClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasCapability";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "Capabilities";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}