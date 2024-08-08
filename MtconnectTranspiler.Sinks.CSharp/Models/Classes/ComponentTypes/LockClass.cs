using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Component">Component</see> that physically prohibits a <see cref="Device">Device</see> or <see cref="Component">Component</see> from opening or operating.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class LockClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622457426342_839834_623";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component"">Component</see> that physically prohibits a <see cref=""Device"">Device</see> or <see cref=""Component"">Component</see> from opening or operating.";

		/// <inheritdoc />
		public string Name => "LockClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.8";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";

		/// <inheritdoc />
		public LockClassProperties Properties { get; } = new LockClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class LockClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesLockState,
			};
			/// <summary>
			/// <inheritdoc cref="ObservesLockStateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesLockState</remarks>
			/// </summary>
			public ObservesLockStateProperty ObservesLockState { get; } = new ObservesLockStateProperty();
			public sealed class ObservesLockStateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622457702589_196111_730</item>
				/// <item>Type: LockStateClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.LockStateClass);
				
				/// <inheritdoc />
				public string Name => "ObservesLockState";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that physically prohibits a <see cref=""Device"">Device</see> or <see cref=""Component"">Component</see> from opening or operating.";

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
			}
		};

	}
}