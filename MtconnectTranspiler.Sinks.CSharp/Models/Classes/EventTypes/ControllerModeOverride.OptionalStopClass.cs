using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// setting or operator selection that changes the behavior of the controller on a piece of equipment.   The program execution is stopped after a specific program block is executed when <c>OPTIONAL_STOP</c> is <c>ON</c>.      In the case of a G-Code program, a program block containing a M01 code designates the command for an <c>OPTIONAL_STOP</c>.   <see cref="Execution">Execution</see> <b>MUST</b> change to <c>OPTIONAL_STOP</c> after a program block specifying an optional stop is executed and the <see cref="ControllerModeOverride">ControllerModeOverride</see> <c>OPTIONAL_STOP</c> selection is <c>ON</c>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ControllerModeOverrideOptionalStopClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218242_341536_1671";
		
		/// <inheritdoc />
		public string Summary => @"/// setting or operator selection that changes the behavior of the controller on a piece of equipment.   The program execution is stopped after a specific program block is executed when <c>OPTIONAL_STOP</c> is <c>ON</c>.      In the case of a G-Code program, a program block containing a M01 code designates the command for an <c>OPTIONAL_STOP</c>.   <see cref=""Execution"">Execution</see> <b>MUST</b> change to <c>OPTIONAL_STOP</c> after a program block specifying an optional stop is executed and the <see cref=""ControllerModeOverride"">ControllerModeOverride</see> <c>OPTIONAL_STOP</c> selection is <c>ON</c>.";

		/// <inheritdoc />
		public string Name => "ControllerModeOverride.OptionalStopClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1580378218236_117661_1659";

		/// <inheritdoc />
		public ControllerModeOverrideOptionalStopClassProperties Properties { get; } = new ControllerModeOverrideOptionalStopClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ControllerModeOverrideOptionalStopClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				SubType,
			};
			/// <summary>
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public SubTypeProperty SubType { get; } = new SubTypeProperty();
			public sealed class SubTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579563592155_977172_22064</item>
				/// <item>Type: DataItemSubTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnum);
				
				/// <inheritdoc />
				public string Name => "SubType";
				
				/// <inheritdoc />
				public string Summary => @"/// setting or operator selection that changes the behavior of the controller on a piece of equipment.   The program execution is stopped after a specific program block is executed when <c>OPTIONAL_STOP</c> is <c>ON</c>.      In the case of a G-Code program, a program block containing a M01 code designates the command for an <c>OPTIONAL_STOP</c>.   <see cref=""Execution"">Execution</see> <b>MUST</b> change to <c>OPTIONAL_STOP</c> after a program block specifying an optional stop is executed and the <see cref=""ControllerModeOverride"">ControllerModeOverride</see> <c>OPTIONAL_STOP</c> selection is <c>ON</c>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}