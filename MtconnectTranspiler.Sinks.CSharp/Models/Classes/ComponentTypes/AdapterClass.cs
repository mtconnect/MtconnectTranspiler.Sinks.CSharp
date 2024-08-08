using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Component">Component</see> that provides information about the data source for an <i>MTConnect Agent</i>./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AdapterClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605101651646_782838_139";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component"">Component</see> that provides information about the data source for an <i>MTConnect Agent</i>./// Description";

		/// <inheritdoc />
		public string Name => "AdapterClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";

		/// <inheritdoc />
		public AdapterClassProperties Properties { get; } = new AdapterClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class AdapterClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IsAdapterOfPart,
			};
			/// <summary>
			/// <inheritdoc cref="IsAdapterOfPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsAdapterOf</remarks>
			/// </summary>
			public IsAdapterOfPartProperty IsAdapterOfPart { get; } = new IsAdapterOfPartProperty();
			public sealed class IsAdapterOfPartProperty : IProperty
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
				public string Name => "IsAdapterOf";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that provides information about the data source for an <i>MTConnect Agent</i>./// Description";

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
				public string Association => "AdaptersClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}