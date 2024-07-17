using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class CollaboratorClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622718569783_691547_1331";
		
		/// <inheritdoc />
		public string Name => "CollaboratorClass";
		
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
		public CollaboratorClassProperties Properties { get; } = new CollaboratorClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class CollaboratorClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasPriorityPart,
				CollaboratorId,
				CollaboratorType,
				Optional,
				HasCapabilityPart,
			};
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
			/// <remarks>Original Name: CollaboratorId</remarks>
			public CollaboratorIdProperty CollaboratorId { get; } = new CollaboratorIdProperty();
			public sealed class CollaboratorIdProperty : IProperty
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
				public string Name => "CollaboratorId";
				
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
			/// <remarks>Original Name: CollaboratorType</remarks>
			public CollaboratorTypeProperty CollaboratorType { get; } = new CollaboratorTypeProperty();
			public sealed class CollaboratorTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622723031886_684761_3039</item>
				/// <item>Type: CollaboratorTypeEnum</item>
				/// <item>Namespace: Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel.CollaboratorTypeEnum);
				
				/// <inheritdoc />
				public string Name => "CollaboratorType";
				
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
			/// <remarks>Original Name: Optional</remarks>
			public OptionalProperty Optional { get; } = new OptionalProperty();
			public sealed class OptionalProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579278876899_683310_3821</item>
				/// <item>Type: Boolean</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
				/// <inheritdoc />
				public string Name => "Optional";
				
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
			/// <remarks>Original Name: HasCapability</remarks>
			public HasCapabilityPartProperty HasCapabilityPart { get; } = new HasCapabilityPartProperty();
			public sealed class HasCapabilityPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622723160082_480366_3118</item>
				/// <item>Type: CapabilityClass</item>
				/// <item>Namespace: Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel.CapabilityClass);
				
				/// <inheritdoc />
				public string Name => "HasCapability";
				
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
				public string Association => "Capabilities";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}