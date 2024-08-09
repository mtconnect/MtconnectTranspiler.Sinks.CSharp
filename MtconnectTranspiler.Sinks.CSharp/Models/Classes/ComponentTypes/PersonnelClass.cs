using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Resource">Resource</see> composed of an individual or individuals who either control, support, or otherwise interface with a piece of equipment. 
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382005_168835_42270">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PersonnelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382005_168835_42270";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Resource"">Resource</see> composed of an individual or individuals who either control, support, or otherwise interface with a piece of equipment. ";

		/// <inheritdoc />
		public string Name => "Personnel";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572382014_307743_42285
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ResourceClass);

		/// <inheritdoc />
		public PersonnelClassProperties Properties { get; } = new PersonnelClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class PersonnelClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.ResourceClass.ResourceClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesUserOperator,
				ObservesUserMaintenance,
			}.Concat(base.Properties).ToArray();
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
				public string Name => "observesUserOperator";
				
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
				public string Name => "observesUserMaintenance";
				
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