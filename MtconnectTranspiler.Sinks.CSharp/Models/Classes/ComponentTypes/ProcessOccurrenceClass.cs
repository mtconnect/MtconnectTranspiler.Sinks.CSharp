#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="Process">Process</see> that takes place at a specific place and time, such as a specific instance of part-milling occurring at a specific timestamp.<br /><br /><br />Description<br /><br /><see cref="ProcessOccurrenceId">ProcessOccurrenceId</see> <b>MUST</b> be defined for <see cref="ProcessOccurrence">ProcessOccurrence</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605547395898_219029_214">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ProcessOccurrenceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605547395898_219029_214";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Process)}} that takes place at a specific place and time, such as a specific instance of part-milling occurring at a specific timestamp.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(ProcessOccurrenceId)}} **MUST** be defined for {{block(ProcessOccurrence)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "ProcessOccurrence";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1605547261014_920934_161
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ProcessClass);

		/// <inheritdoc />
		public ProcessOccurrenceClassProperties Properties { get; } = new ProcessOccurrenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ProcessOccurrenceClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.ProcessClass.ProcessClassProperties" />.
		/// </summary>
		public class ProcessOccurrenceClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.ProcessClass.ProcessClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				ObservesProcessOccurrenceId,
				ObservesProcessAggregateId,
				ObservesProcessTime,
				ObservesProcessKindId,
				ObservesUser,
				ObservesProgram,
				ObservesPartUniqueId,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ObservesProcessOccurrenceIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProcessOccurrenceId</remarks>
			/// </summary>
			public new ObservesProcessOccurrenceIdProperty ObservesProcessOccurrenceId { get; } = new ObservesProcessOccurrenceIdProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesProcessOccurrenceIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549692001_598671_1420</item>
				/// <item>Type: ProcessOccurrenceIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProcessOccurrenceIdClass);
				
				/// <inheritdoc />
				public string Name => "observesProcessOccurrenceId";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			/// <summary>
			/// <inheritdoc cref="ObservesProcessAggregateIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProcessAggregateId</remarks>
			/// </summary>
			public new ObservesProcessAggregateIdProperty ObservesProcessAggregateId { get; } = new ObservesProcessAggregateIdProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesProcessAggregateIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549689754_638221_1396</item>
				/// <item>Type: ProcessAggregateIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProcessAggregateIdClass);
				
				/// <inheritdoc />
				public string Name => "observesProcessAggregateId";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			/// <summary>
			/// <inheritdoc cref="ObservesProcessTimeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProcessTime</remarks>
			/// </summary>
			public new ObservesProcessTimeProperty ObservesProcessTime { get; } = new ObservesProcessTimeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesProcessTimeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218411_953996_2079</item>
				/// <item>Type: ProcessTimeClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProcessTimeClass);
				
				/// <inheritdoc />
				public string Name => "observesProcessTime";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			/// <summary>
			/// <inheritdoc cref="ObservesProcessKindIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProcessKindId</remarks>
			/// </summary>
			public new ObservesProcessKindIdProperty ObservesProcessKindId { get; } = new ObservesProcessKindIdProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesProcessKindIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549690346_543437_1404</item>
				/// <item>Type: ProcessKindIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProcessKindIdClass);
				
				/// <inheritdoc />
				public string Name => "observesProcessKindId";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			/// <summary>
			/// <inheritdoc cref="ObservesUserProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesUser</remarks>
			/// </summary>
			public new ObservesUserProperty ObservesUser { get; } = new ObservesUserProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesUserProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218462_589955_2238</item>
				/// <item>Type: UserClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.UserClass);
				
				/// <inheritdoc />
				public string Name => "observesUser";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			/// <summary>
			/// <inheritdoc cref="ObservesProgramProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProgram</remarks>
			/// </summary>
			public new ObservesProgramProperty ObservesProgram { get; } = new ObservesProgramProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesProgramProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218420_715490_2100</item>
				/// <item>Type: ProgramClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProgramClass);
				
				/// <inheritdoc />
				public string Name => "observesProgram";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			/// <summary>
			/// <inheritdoc cref="ObservesPartUniqueIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartUniqueId</remarks>
			/// </summary>
			public new ObservesPartUniqueIdProperty ObservesPartUniqueId { get; } = new ObservesPartUniqueIdProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPartUniqueIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605549240508_290295_764</item>
				/// <item>Type: PartUniqueIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartUniqueIdClass);
				
				/// <inheritdoc />
				public string Name => "observesPartUniqueId";
				
				/// <inheritdoc />
				public string Summary => @"";

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