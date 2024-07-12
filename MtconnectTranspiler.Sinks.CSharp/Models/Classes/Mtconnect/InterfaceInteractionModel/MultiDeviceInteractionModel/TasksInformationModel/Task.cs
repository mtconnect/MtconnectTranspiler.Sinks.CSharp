
using System;
using System.CodeDom.Compiler;

using Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel;
using Mtconnect.AssetInformationModel;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class TaskClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1622718586034_177739_1376";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Task";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public TaskProperties Properties { get; } = new TaskProperties();
		public sealed class TaskProperties
		{
		
		
			/// <remarks>Original Name: HasTaskArchetype</remarks>
			public HasTaskArchetypePartProperty HasTaskArchetypePart { get; } = new HasTaskArchetypePartProperty();
			public sealed class HasTaskArchetypePartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1622718466282_854894_1238
				public Type Type => typeof(TaskArchetypeClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasTaskArchetype";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "TaskArchetype";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasCollaborator</remarks>
			public HasCollaboratorPartProperty HasCollaboratorPart { get; } = new HasCollaboratorPartProperty();
			public sealed class HasCollaboratorPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1622718569783_691547_1331
				public Type Type => typeof(CollaboratorClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasCollaborator";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "Collaborators";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasCoordinator</remarks>
			public HasCoordinatorPartProperty HasCoordinatorPart { get; } = new HasCoordinatorPartProperty();
			public sealed class HasCoordinatorPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1622718569783_691547_1331
				public Type Type => typeof(CollaboratorClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasCoordinator";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "Coordinator";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasParent</remarks>
			public HasParentPartProperty HasParentPart { get; } = new HasParentPartProperty();
			public sealed class HasParentPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1622718586034_177739_1376
				public Type Type => typeof(TaskClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasParent";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "Parent";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasAsset</remarks>
			public HasAssetPartProperty HasAssetPart { get; } = new HasAssetPartProperty();
			public sealed class HasAssetPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
				public Type Type => typeof(AssetClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasAsset";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "Assets";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: TaskType</remarks>
			public TaskTypeProperty TaskType { get; } = new TaskTypeProperty();
			public sealed class TaskTypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1622719977582_803160_1892
				public Type Type => typeof(TaskTypeEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "TaskType";
				
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
		
		
			/// <remarks>Original Name: State</remarks>
			public StateProperty State { get; } = new StateProperty();
			public sealed class StateProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1622721899109_23146_2663
				public Type Type => typeof(TaskStateEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "State";
				
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
		};

	}
}