using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// setting or operator selection that changes the behavior of the controller on a piece of equipment.   Program execution is paused after each block of code is executed when <c>SINGLE_BLOCK</c> is <c>ON</c>.     When <c>SINGLE_BLOCK</c> is <c>ON</c>, <see cref="Execution">Execution</see> <b>MUST</b> change to <c>INTERRUPTED</c> after completion of each block of code. 
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ControllerModeOverrideSingleBlockClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218239_202787_1665";
		
		/// <inheritdoc />
		public string Summary => @"/// setting or operator selection that changes the behavior of the controller on a piece of equipment.   Program execution is paused after each block of code is executed when <c>SINGLE_BLOCK</c> is <c>ON</c>.     When <c>SINGLE_BLOCK</c> is <c>ON</c>, <see cref=""Execution"">Execution</see> <b>MUST</b> change to <c>INTERRUPTED</c> after completion of each block of code. ";

		/// <inheritdoc />
		public string Name => "ControllerModeOverride.SingleBlockClass";
		
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
		public ControllerModeOverrideSingleBlockClassProperties Properties { get; } = new ControllerModeOverrideSingleBlockClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ControllerModeOverrideSingleBlockClassProperties : IPropertyList
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
				public string Summary => @"/// setting or operator selection that changes the behavior of the controller on a piece of equipment.   Program execution is paused after each block of code is executed when <c>SINGLE_BLOCK</c> is <c>ON</c>.     When <c>SINGLE_BLOCK</c> is <c>ON</c>, <see cref=""Execution"">Execution</see> <b>MUST</b> change to <c>INTERRUPTED</c> after completion of each block of code. ";

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