using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// <see cref="EventEnum::MAINTENANCE_LIST">EventEnum::MAINTENANCE_LIST</see>  If <see cref="MaintenanceList::result::Interval" /> <c>key</c> is not provided, it is assumed <c>ABSOLUTE</c>.  If <see cref="MaintenanceList::result::Direction" /> <c>key</c> is not provided, it is assumed <c>UP</c>.  If <see cref="MaintenanceList::result::Units" /> <c>key</c> is not provided, it is assumed to be <c>COUNT</c>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1640604216330_942815_196">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MaintenanceListClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1640604216330_942815_196";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""EventEnum::MAINTENANCE_LIST"">EventEnum::MAINTENANCE_LIST</see>  If <see cref=""MaintenanceList::result::Interval"" /> <c>key</c> is not provided, it is assumed <c>ABSOLUTE</c>.  If <see cref=""MaintenanceList::result::Direction"" /> <c>key</c> is not provided, it is assumed <c>UP</c>.  If <see cref=""MaintenanceList::result::Units"" /> <c>key</c> is not provided, it is assumed to be <c>COUNT</c>.";

		/// <inheritdoc />
		public string Name => "MaintenanceList";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579566531115_47447_25730
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.EventClass);

		/// <inheritdoc />
		public MaintenanceListClassProperties Properties { get; } = new MaintenanceListClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class MaintenanceListClassProperties : Mtconnect.ObservationInformationModel.EventClass.EventClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Type,
				Result,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580398379726_606068_12802</item>
				/// <item>Type: EventEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.EventEnum);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""EventEnum::MAINTENANCE_LIST"">EventEnum::MAINTENANCE_LIST</see>  If <see cref=""MaintenanceList::result::Interval"" /> <c>key</c> is not provided, it is assumed <c>ABSOLUTE</c>.  If <see cref=""MaintenanceList::result::Direction"" /> <c>key</c> is not provided, it is assumed <c>UP</c>.  If <see cref=""MaintenanceList::result::Units"" /> <c>key</c> is not provided, it is assumed to be <c>COUNT</c>.";

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
				public string DefaultValue => "MAINTENANCE_LIST";
			}
			/// <summary>
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public ResultProperty Result { get; } = new ResultProperty();
			public sealed class ResultProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1643971089385_291275_851</item>
				/// <item>Type: MaintenanceListResultClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.MaintenanceListResultClass);
				
				/// <inheritdoc />
				public string Name => "result";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""EventEnum::MAINTENANCE_LIST"">EventEnum::MAINTENANCE_LIST</see>  If <see cref=""MaintenanceList::result::Interval"" /> <c>key</c> is not provided, it is assumed <c>ABSOLUTE</c>.  If <see cref=""MaintenanceList::result::Direction"" /> <c>key</c> is not provided, it is assumed <c>UP</c>.  If <see cref=""MaintenanceList::result::Units"" /> <c>key</c> is not provided, it is assumed to be <c>COUNT</c>.";

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