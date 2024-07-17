using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel;
// using Mtconnect.AssetInformationModel;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class TaskArchetypeClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622718466282_854894_1238";
		
		/// <inheritdoc />
		public string Name => "TaskArchetypeClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_C7D39183_23CB_416b_A62D_F60815E08B1A";

		/// <inheritdoc />
		public TaskArchetypeClassProperties Properties { get; } = new TaskArchetypeClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class TaskArchetypeClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasCollaboratorPart,
				HasCoordinatorPart,
				HasAssetPart,
				TaskType,
				HasPriorityPart,
				IsSubTaskOfPart,
				HasSubTaskPart,
			};
			/// <remarks>Original Name: HasCollaborator</remarks>
			public HasCollaboratorPartProperty HasCollaboratorPart { get; } = new HasCollaboratorPartProperty();
			public sealed class HasCollaboratorPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622718569783_691547_1331</item>
				/// <item>Type: CollaboratorClass</item>
				/// <item>Namespace: Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel.CollaboratorClass);
				
				/// <inheritdoc />
				public string Name => "HasCollaborator";
				
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
				public string Association => "Collaborators";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasCoordinator</remarks>
			public HasCoordinatorPartProperty HasCoordinatorPart { get; } = new HasCoordinatorPartProperty();
			public sealed class HasCoordinatorPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622718569783_691547_1331</item>
				/// <item>Type: CollaboratorClass</item>
				/// <item>Namespace: Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel.CollaboratorClass);
				
				/// <inheritdoc />
				public string Name => "HasCoordinator";
				
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
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "Coordinator";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasAsset</remarks>
			public HasAssetPartProperty HasAssetPart { get; } = new HasAssetPartProperty();
			public sealed class HasAssetPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A</item>
				/// <item>Type: AssetClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.AssetClass);
				
				/// <inheritdoc />
				public string Name => "HasAsset";
				
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
				public string Association => "Assets";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: TaskType</remarks>
			public TaskTypeProperty TaskType { get; } = new TaskTypeProperty();
			public sealed class TaskTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622719977582_803160_1892</item>
				/// <item>Type: TaskTypeEnum</item>
				/// <item>Namespace: Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel.TaskTypeEnum);
				
				/// <inheritdoc />
				public string Name => "TaskType";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasPriority</remarks>
			public HasPriorityPartProperty HasPriorityPart { get; } = new HasPriorityPartProperty();
			public sealed class HasPriorityPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622721553723_407241_2231</item>
				/// <item>Type: PriorityClass</item>
				/// <item>Namespace: Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel.PriorityClass);
				
				/// <inheritdoc />
				public string Name => "HasPriority";
				
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
				public string Association => "Priority";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: IsSubTaskOf</remarks>
			public IsSubTaskOfPartProperty IsSubTaskOfPart { get; } = new IsSubTaskOfPartProperty();
			public sealed class IsSubTaskOfPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622718466282_854894_1238</item>
				/// <item>Type: TaskArchetypeClass</item>
				/// <item>Namespace: Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel.TaskArchetypeClass);
				
				/// <inheritdoc />
				public string Name => "IsSubTaskOf";
				
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
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "SubTaskRefClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasSubTask</remarks>
			public HasSubTaskPartProperty HasSubTaskPart { get; } = new HasSubTaskPartProperty();
			public sealed class HasSubTaskPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622718466282_854894_1238</item>
				/// <item>Type: TaskArchetypeClass</item>
				/// <item>Namespace: Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel.TaskArchetypeClass);
				
				/// <inheritdoc />
				public string Name => "HasSubTask";
				
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
				public string Association => "SubTaskRefClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}