using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingItem.CuttingItemMeasurementSubtypes
{
	/// <summary>
	/// angle between the driving mechanism locator on a tool item and the main cutting edge.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1582919119525_506701_1450">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DriveAngleClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1582919119525_506701_1450";
		
		/// <inheritdoc />
		public string Summary => @"/// angle between the driving mechanism locator on a tool item and the main cutting edge.";

		/// <inheritdoc />
		public string Name => "DriveAngle";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_C09F377D_8946_421b_B746_E23C01D97EAC
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.MeasurementClass);

		/// <inheritdoc />
		public DriveAngleClassProperties Properties { get; } = new DriveAngleClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class DriveAngleClassProperties : Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.MeasurementClass.MeasurementClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Code,
				Units,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="CodeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Code</remarks>
			/// </summary>
			public CodeProperty Code { get; } = new CodeProperty();
			public sealed class CodeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1582919522403_926879_1581</item>
				/// <item>Type: CodeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.CodeEnum);
				
				/// <inheritdoc />
				public string Name => "code";
				
				/// <inheritdoc />
				public string Summary => @"/// angle between the driving mechanism locator on a tool item and the main cutting edge.";

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
				public string DefaultValue => "DRVA";
			}
			/// <summary>
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public UnitsProperty Units { get; } = new UnitsProperty();
			public sealed class UnitsProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A</item>
				/// <item>Type: UnitEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UnitEnum);
				
				/// <inheritdoc />
				public string Name => "units";
				
				/// <inheritdoc />
				public string Summary => @"/// angle between the driving mechanism locator on a tool item and the main cutting edge.";

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
				public string DefaultValue => "DEGREE";
			}
		};

	}
}