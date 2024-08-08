using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Resource">Resource</see> composed of an individual or individuals who either control, support, or otherwise interface with a piece of equipment. 
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PersonnelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382005_168835_42270";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Resource"">Resource</see> composed of an individual or individuals who either control, support, or otherwise interface with a piece of equipment. ";

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
			/// <summary>
			/// <inheritdoc cref="ObservesUserOperatorProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesUserOperator</remarks>
			/// </summary>
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
				public string Summary => @"/// <see cref=""Resource"">Resource</see> composed of an individual or individuals who either control, support, or otherwise interface with a piece of equipment. ";

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
			/// <inheritdoc cref="ObservesUserMaintenanceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesUserMaintenance</remarks>
			/// </summary>
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
				public string Summary => @"/// <see cref=""Resource"">Resource</see> composed of an individual or individuals who either control, support, or otherwise interface with a piece of equipment. ";

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