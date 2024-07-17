using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class PersonnelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382005_168835_42270";
		
		/// <inheritdoc />
		public string Name => "PersonnelClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572382014_307743_42285";

		/// <inheritdoc />
		public PersonnelClassProperties Properties { get; } = new PersonnelClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class PersonnelClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesUserOperator,
				ObservesUserMaintenance,
			};
			/// <remarks>Original Name: ObservesUserOperator</remarks>
			public ObservesUserOperatorProperty ObservesUserOperator { get; } = new ObservesUserOperatorProperty();
			public sealed class ObservesUserOperatorProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218463_266708_2241</item>
				/// <item>Type: User.OperatorClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.UserOperatorClass);
				
				/// <inheritdoc />
				public string Name => "ObservesUserOperator";
				
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesUserMaintenance</remarks>
			public ObservesUserMaintenanceProperty ObservesUserMaintenance { get; } = new ObservesUserMaintenanceProperty();
			public sealed class ObservesUserMaintenanceProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218464_860925_2244</item>
				/// <item>Type: User.MaintenanceClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.UserMaintenanceClass);
				
				/// <inheritdoc />
				public string Name => "ObservesUserMaintenance";
				
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

				// TODO: Add Summary
			}
		};

	}
}