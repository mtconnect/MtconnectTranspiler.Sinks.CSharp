using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// abstract <see cref="Component">Component</see> composed of a <i>part</i> being processed by a piece of equipment.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PartClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622456766067_72580_282";
		
		/// <inheritdoc />
		public string Summary => @"/// abstract <see cref=""Component"">Component</see> composed of a <i>part</i> being processed by a piece of equipment.";

		/// <inheritdoc />
		public string Name => "PartClass";
		
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
		public PartClassProperties Properties { get; } = new PartClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class PartClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IsWorkedOnPart,
			};
			/// <summary>
			/// <inheritdoc cref="IsWorkedOnPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsWorkedOn</remarks>
			/// </summary>
			public IsWorkedOnPartProperty IsWorkedOnPart { get; } = new IsWorkedOnPartProperty();
			public sealed class IsWorkedOnPartProperty : IProperty
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
				public string Name => "IsWorkedOn";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract <see cref=""Component"">Component</see> composed of a <i>part</i> being processed by a piece of equipment.";

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
				public string Association => "PartsClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}