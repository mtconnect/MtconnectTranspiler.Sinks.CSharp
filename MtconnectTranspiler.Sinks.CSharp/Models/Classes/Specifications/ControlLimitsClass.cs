using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary;

namespace Mtconnect.DeviceInformationModel.Configurations.Specifications
{
	/// <summary>
	/// set of limits that is used to indicate whether a process variable is stable and in control.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ControlLimitsClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605643876416_54094_959";
		
		/// <inheritdoc />
		public string Summary => @"/// set of limits that is used to indicate whether a process variable is stable and in control.";

		/// <inheritdoc />
		public string Name => "ControlLimitsClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public ControlLimitsClassProperties Properties { get; } = new ControlLimitsClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ControlLimitsClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				UpperLimitPart,
				UpperWarningPart,
				LowerWarningPart,
				NominalPart,
				LowerLimitPart,
			};
			/// <summary>
			/// <inheritdoc cref="UpperLimitPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: UpperLimit</remarks>
			/// </summary>
			public UpperLimitPartProperty UpperLimitPart { get; } = new UpperLimitPartProperty();
			public sealed class UpperLimitPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605643508394_491668_626</item>
				/// <item>Type: UpperLimitClass</item>
				/// <item>Namespace: Mtconnect.Glossary</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.UpperLimitClass);
				
				/// <inheritdoc />
				public string Name => "UpperLimit";
				
				/// <inheritdoc />
				public string Summary => @"/// set of limits that is used to indicate whether a process variable is stable and in control.";

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
				public string Association => "UpperLimit";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="UpperWarningPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: UpperWarning</remarks>
			/// </summary>
			public UpperWarningPartProperty UpperWarningPart { get; } = new UpperWarningPartProperty();
			public sealed class UpperWarningPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605643515595_841451_671</item>
				/// <item>Type: UpperWarningClass</item>
				/// <item>Namespace: Mtconnect.Glossary</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.UpperWarningClass);
				
				/// <inheritdoc />
				public string Name => "UpperWarning";
				
				/// <inheritdoc />
				public string Summary => @"/// set of limits that is used to indicate whether a process variable is stable and in control.";

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
				public string Association => "UpperWarning";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="LowerWarningPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: LowerWarning</remarks>
			/// </summary>
			public LowerWarningPartProperty LowerWarningPart { get; } = new LowerWarningPartProperty();
			public sealed class LowerWarningPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605643531502_63450_761</item>
				/// <item>Type: LowerWarningClass</item>
				/// <item>Namespace: Mtconnect.Glossary</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.LowerWarningClass);
				
				/// <inheritdoc />
				public string Name => "LowerWarning";
				
				/// <inheritdoc />
				public string Summary => @"/// set of limits that is used to indicate whether a process variable is stable and in control.";

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
				public string Association => "LowerWarning";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="NominalPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Nominal</remarks>
			/// </summary>
			public NominalPartProperty NominalPart { get; } = new NominalPartProperty();
			public sealed class NominalPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580316543777_893941_47725</item>
				/// <item>Type: NominalClass</item>
				/// <item>Namespace: Mtconnect.Glossary</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.NominalClass);
				
				/// <inheritdoc />
				public string Name => "Nominal";
				
				/// <inheritdoc />
				public string Summary => @"/// set of limits that is used to indicate whether a process variable is stable and in control.";

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
				public string Association => "Nominal";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="LowerLimitPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: LowerLimit</remarks>
			/// </summary>
			public LowerLimitPartProperty LowerLimitPart { get; } = new LowerLimitPartProperty();
			public sealed class LowerLimitPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605643526040_637158_716</item>
				/// <item>Type: LowerLimitClass</item>
				/// <item>Namespace: Mtconnect.Glossary</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.LowerLimitClass);
				
				/// <inheritdoc />
				public string Name => "LowerLimit";
				
				/// <inheritdoc />
				public string Summary => @"/// set of limits that is used to indicate whether a process variable is stable and in control.";

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
				public string Association => "LowerLimit";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}