#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.Task.TaskArchetype
{
	/// <summary>﻿<see cref="Asset">Asset</see> that defines common data for all derived <see cref="Task">Task</see>s<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1759816184972_278171_638">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class TaskArchetypeClass : IClass
	{
		/// <summary>Constant value for <see cref="TaskArchetypeClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1759816184972_278171_638";
		/// <summary>Constant value for <see cref="TaskArchetypeClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1759816184972_278171_638";
		/// <summary>Constant value for <see cref="TaskArchetypeClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Asset)}} that defines common data for all derived {{block(Task)}}s&#10;
";
		/// <summary>Constant value for <see cref="TaskArchetypeClass.Name" /></summary>
		public const string NAME = "TaskArchetype";
		/// <summary>Constant value for <see cref="TaskArchetypeClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="TaskArchetypeClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="TaskArchetypeClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.7";
		/// <summary>Constant value for <see cref="TaskArchetypeClass.DeprecatedVersion" /></summary>
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
		/// <remarks>
		/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.AssetClass);

		/// <inheritdoc />
		public new TaskArchetypeClassProperties Properties { get; } = new TaskArchetypeClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="TaskArchetypeClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties" />.
		/// </summary>
		public class TaskArchetypeClassProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				HasCollaboratorPart,
				HasCoordinatorPart,
				TaskType,
				IsSubTaskOfPart,
				HasSubTaskPart,
				Priority,
				HasTargetPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="HasCollaboratorPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCollaborator</remarks>
			/// </summary>
			public new HasCollaboratorPartProperty HasCollaboratorPart { get; } = new HasCollaboratorPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasCollaboratorPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasCollaboratorPartProperty.Name" /></summary>
				public const string NAME = "hasCollaborator";
				/// <summary>Constant value for <see cref="HasCollaboratorPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasCollaboratorPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasCollaboratorPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasCollaboratorPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasCollaboratorPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasCollaboratorPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="HasCollaboratorPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="HasCollaboratorPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Collaborators";
				/// <summary>Constant value for <see cref="HasCollaboratorPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasCollaboratorPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1..*";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: CollaboratorClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Task.TaskArchetype.CollaboratorClass);
				
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

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
			/// <summary>
			/// <inheritdoc cref="HasCoordinatorPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCoordinator</remarks>
			/// </summary>
			public new HasCoordinatorPartProperty HasCoordinatorPart { get; } = new HasCoordinatorPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasCoordinatorPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasCoordinatorPartProperty.Name" /></summary>
				public const string NAME = "hasCoordinator";
				/// <summary>Constant value for <see cref="HasCoordinatorPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasCoordinatorPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasCoordinatorPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasCoordinatorPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasCoordinatorPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasCoordinatorPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="HasCoordinatorPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x;MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="HasCoordinatorPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Coordinator";
				/// <summary>Constant value for <see cref="HasCoordinatorPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasCoordinatorPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: CollaboratorClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Task.TaskArchetype.CollaboratorClass);
				
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

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
			/// <summary>
			/// <inheritdoc cref="TaskTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: TaskType</remarks>
			/// </summary>
			public new TaskTypeProperty TaskType { get; } = new TaskTypeProperty();
			
			/// <summary>﻿semantic goal of the task<br /><br />Examples include <c>MOVE_MATERIAL</c> and <c>CHANGE_TOOL</c>.<br /><br /><br />
			/// </summary>
			public new sealed class TaskTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TaskTypeProperty.Name" /></summary>
				public const string NAME = "TaskType";
				/// <summary>Constant value for <see cref="TaskTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;semantic goal of the task

Examples include `MOVE_MATERIAL` and `CHANGE_TOOL`.&#10;
";
				/// <summary>Constant value for <see cref="TaskTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TaskTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TaskTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.7";
				/// <summary>Constant value for <see cref="TaskTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TaskTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="TaskTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x;MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="TaskTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TaskTypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="TaskTypeProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
			/// <summary>
			/// <inheritdoc cref="IsSubTaskOfPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsSubTaskOf</remarks>
			/// </summary>
			public new IsSubTaskOfPartProperty IsSubTaskOfPart { get; } = new IsSubTaskOfPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class IsSubTaskOfPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IsSubTaskOfPartProperty.Name" /></summary>
				public const string NAME = "isSubTaskOf";
				/// <summary>Constant value for <see cref="IsSubTaskOfPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="IsSubTaskOfPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="IsSubTaskOfPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="IsSubTaskOfPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="IsSubTaskOfPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="IsSubTaskOfPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="IsSubTaskOfPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="IsSubTaskOfPartProperty.Association" /></summary>
				public const string ASSOCIATION = "SubTaskRefClass";
				/// <summary>Constant value for <see cref="IsSubTaskOfPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="IsSubTaskOfPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: TaskArchetypeClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Task.TaskArchetype.TaskArchetypeClass);
				
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

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
			/// <summary>
			/// <inheritdoc cref="HasSubTaskPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasSubTask</remarks>
			/// </summary>
			public new HasSubTaskPartProperty HasSubTaskPart { get; } = new HasSubTaskPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasSubTaskPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasSubTaskPartProperty.Name" /></summary>
				public const string NAME = "hasSubTask";
				/// <summary>Constant value for <see cref="HasSubTaskPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasSubTaskPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasSubTaskPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasSubTaskPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasSubTaskPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasSubTaskPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasSubTaskPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasSubTaskPartProperty.Association" /></summary>
				public const string ASSOCIATION = "SubTaskRefClass";
				/// <summary>Constant value for <see cref="HasSubTaskPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasSubTaskPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..*";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: TaskArchetypeClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Task.TaskArchetype.TaskArchetypeClass);
				
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

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
			/// <summary>
			/// <inheritdoc cref="PriorityProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Priority</remarks>
			/// </summary>
			public new PriorityProperty Priority { get; } = new PriorityProperty();
			
			/// <summary>﻿relative importance that determines the order in which a task should be performed<br /><br /><br />
			/// </summary>
			public new sealed class PriorityProperty : IProperty
			{
				/// <summary>Constant value for <see cref="PriorityProperty.Name" /></summary>
				public const string NAME = "Priority";
				/// <summary>Constant value for <see cref="PriorityProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;relative importance that determines the order in which a task should be performed&#10;
";
				/// <summary>Constant value for <see cref="PriorityProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="PriorityProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="PriorityProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.7";
				/// <summary>Constant value for <see cref="PriorityProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="PriorityProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="PriorityProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2026x";
				/// <summary>Constant value for <see cref="PriorityProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="PriorityProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="PriorityProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..1";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Int32 </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
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

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
			/// <summary>
			/// <inheritdoc cref="HasTargetPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasTarget</remarks>
			/// </summary>
			public new HasTargetPartProperty HasTargetPart { get; } = new HasTargetPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasTargetPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Name" /></summary>
				public const string NAME = "hasTarget";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Targets";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";
				/// <summary>Constant value for <see cref="HasTargetPartProperty.Multiplicity" /></summary>
				public const string MULTIPLICITY = "0..*";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: TargetClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Process.Target.TargetClass);
				
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

				/// <inheritdoc />
				public string Multiplicity => MULTIPLICITY;
			}
		};
		
		# region Rules
		/// <summary>
		/// List of constraint rules for <see cref="TaskArchetypeClass" />.
		/// </summary>
		public string[] Rules => new string[] {
			// No Constraints
		};
		# endregion
	}
}
