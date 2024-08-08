using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// abstract <see cref="Component">Component</see> composed of a manufacturing process being executed on a piece of equipment. 
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ProcessClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605547261014_920934_161";
		
		/// <inheritdoc />
		public string Summary => @"/// abstract <see cref=""Component"">Component</see> composed of a manufacturing process being executed on a piece of equipment. ";

		/// <inheritdoc />
		public string Name => "ProcessClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";

		/// <inheritdoc />
		public ProcessClassProperties Properties { get; } = new ProcessClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ProcessClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IsExecutedOnPart,
			};
			/// <summary>
			/// <inheritdoc cref="IsExecutedOnPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsExecutedOn</remarks>
			/// </summary>
			public IsExecutedOnPartProperty IsExecutedOnPart { get; } = new IsExecutedOnPartProperty();
			public sealed class IsExecutedOnPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1620240839406_285612_1596</item>
				/// <item>Type: DeviceClass</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.DeviceClass);
				
				/// <inheritdoc />
				public string Name => "IsExecutedOn";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract <see cref=""Component"">Component</see> composed of a manufacturing process being executed on a piece of equipment. ";

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