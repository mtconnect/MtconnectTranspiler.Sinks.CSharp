#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿abstract <see cref="Component">Component</see> composed of a manufacturing process being executed on a piece of equipment.<br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605547261014_920934_161">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ProcessClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605547261014_920934_161";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;abstract {{block(Component)}} composed of a manufacturing process being executed on a piece of equipment.&#10;
";

		/// <inheritdoc />
		public string Name => "Process";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);

		/// <inheritdoc />
		public new ProcessClassProperties Properties { get; } = new ProcessClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ProcessClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties" />.
		/// </summary>
		public class ProcessClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				IsExecutedOnPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="IsExecutedOnPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsExecutedOn</remarks>
			/// </summary>
			public new IsExecutedOnPartProperty IsExecutedOnPart { get; } = new IsExecutedOnPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class IsExecutedOnPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1620240839406_285612_1596</item>
				/// <item>Type: DeviceClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DeviceClass);
				
				/// <inheritdoc />
				public string Name => "isExecutedOn";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
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
				public string Association => "ProcessesClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}