using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary;
// using Mtconnect;

namespace Mtconnect
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class GlossaryPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581733974382_65435_581";
		
		/// <inheritdoc />
		public string Name => "Glossary";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			XMLTermsPackage,
			HTTPTermsPackage,
			MTConnectTermsPackage,
			InformationModelTermsPackage,
			ProtocolTermsPackage,
			IndustrialTermsPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			AdapterClass,
			AgentClass,
			AlarmLimitClass,
			ApplicationClass,
			ArchetypeClass,
			AssetBufferClass,
			AttachmentClass,
			BufferClass,
			ClientClass,
			ControlledVocabularyClass,
			DataDictionaryClass,
			DataModelClass,
			DataSetClass,
			DataSourceClass,
			DeprecatedClass,
			DeprecationWarningClass,
			DocumentClass,
			ElectricCurrentClass,
			ExtensibleClass,
			ForceClass,
			ImplementationClass,
			InformationModelClass,
			InstanceClass,
			InteractionModelClass,
			InterfaceClass,
			KeyClass,
			KeyValuePairClass,
			LowerCamelCaseClass,
			LowerLimitClass,
			LowerWarningClass,
			MajorClass,
			MaximumClass,
			MessageClass,
			MetadataClass,
			MinimumClass,
			MinorClass,
			NominalClass,
			OrganizeClass,
			OrganizerClass,
			ParameterClass,
			PartClass,
			PascalCaseClass,
			PersistenceClass,
			RequesterClass,
			ResetClass,
			ResponderClass,
			ResponseDocumentClass,
			PatchClass,
			SchemaClass,
			SemanticDataModelClass,
			SensingElementClass,
			SequenceNumberClass,
			SpecificationLimitClass,
			SpindleClass,
			StandardClass,
			SubtypeClass,
			TableClass,
			TableCellClass,
			TableEntryClass,
			TypeClass,
			UpperLimitClass,
			UpperWarningClass,
			VersionClass,
			ProbeClass,
			HeartbeatClass,
			ElementClass,
			HigherLevelClass,
			LowerLevelClass,
			ProfileClass,
			StereotypeClass,
			TopLevelClass,
			CartesianCoordinateSystemClass,
			CharacteristicClass,
			FeatureClass,
			LocationClass,
			PositionClass,
			UncertaintyClass,
			StandardUncertaintyGeneralization,
			CombinedStandardUncertaintyClass,
			ConditionActivationClass,
		};
		#region Packages
	private Package.XMLTermsPackage _XMLTermsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.XMLTermsPackage" path="/summary" />
	/// </summary>
	public Package.XMLTermsPackage XMLTermsPackage => _XMLTermsPackage ?? (_XMLTermsPackage = new Package.XMLTermsPackage());

	private Package.HTTPTermsPackage _HTTPTermsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.HTTPTermsPackage" path="/summary" />
	/// </summary>
	public Package.HTTPTermsPackage HTTPTermsPackage => _HTTPTermsPackage ?? (_HTTPTermsPackage = new Package.HTTPTermsPackage());

	private Package.MTConnectTermsPackage _MTConnectTermsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectTermsPackage" path="/summary" />
	/// </summary>
	public Package.MTConnectTermsPackage MTConnectTermsPackage => _MTConnectTermsPackage ?? (_MTConnectTermsPackage = new Package.MTConnectTermsPackage());

	private Package.InformationModelTermsPackage _InformationModelTermsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.InformationModelTermsPackage" path="/summary" />
	/// </summary>
	public Package.InformationModelTermsPackage InformationModelTermsPackage => _InformationModelTermsPackage ?? (_InformationModelTermsPackage = new Package.InformationModelTermsPackage());

	private Package.ProtocolTermsPackage _ProtocolTermsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ProtocolTermsPackage" path="/summary" />
	/// </summary>
	public Package.ProtocolTermsPackage ProtocolTermsPackage => _ProtocolTermsPackage ?? (_ProtocolTermsPackage = new Package.ProtocolTermsPackage());

	private Package.IndustrialTermsPackage _IndustrialTermsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.IndustrialTermsPackage" path="/summary" />
	/// </summary>
	public Package.IndustrialTermsPackage IndustrialTermsPackage => _IndustrialTermsPackage ?? (_IndustrialTermsPackage = new Package.IndustrialTermsPackage());

	#endregion

	#region Classes
	private Package.AdapterClass _AdapterClass;
	/// <summary>
	/// <inheritdoc cref="Package.AdapterClass" path="/summary" />
	/// </summary>
	public Package.AdapterClass AdapterClass => _AdapterClass ?? (_AdapterClass = new Package.AdapterClass());

	private Package.AgentClass _AgentClass;
	/// <summary>
	/// <inheritdoc cref="Package.AgentClass" path="/summary" />
	/// </summary>
	public Package.AgentClass AgentClass => _AgentClass ?? (_AgentClass = new Package.AgentClass());

	private Package.AlarmLimitClass _AlarmLimitClass;
	/// <summary>
	/// <inheritdoc cref="Package.AlarmLimitClass" path="/summary" />
	/// </summary>
	public Package.AlarmLimitClass AlarmLimitClass => _AlarmLimitClass ?? (_AlarmLimitClass = new Package.AlarmLimitClass());

	private Package.ApplicationClass _ApplicationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ApplicationClass" path="/summary" />
	/// </summary>
	public Package.ApplicationClass ApplicationClass => _ApplicationClass ?? (_ApplicationClass = new Package.ApplicationClass());

	private Package.ArchetypeClass _ArchetypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.ArchetypeClass" path="/summary" />
	/// </summary>
	public Package.ArchetypeClass ArchetypeClass => _ArchetypeClass ?? (_ArchetypeClass = new Package.ArchetypeClass());

	private Package.AssetBufferClass _AssetBufferClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetBufferClass" path="/summary" />
	/// </summary>
	public Package.AssetBufferClass AssetBufferClass => _AssetBufferClass ?? (_AssetBufferClass = new Package.AssetBufferClass());

	private Package.AttachmentClass _AttachmentClass;
	/// <summary>
	/// <inheritdoc cref="Package.AttachmentClass" path="/summary" />
	/// </summary>
	public Package.AttachmentClass AttachmentClass => _AttachmentClass ?? (_AttachmentClass = new Package.AttachmentClass());

	private Package.BufferClass _BufferClass;
	/// <summary>
	/// <inheritdoc cref="Package.BufferClass" path="/summary" />
	/// </summary>
	public Package.BufferClass BufferClass => _BufferClass ?? (_BufferClass = new Package.BufferClass());

	private Package.ClientClass _ClientClass;
	/// <summary>
	/// <inheritdoc cref="Package.ClientClass" path="/summary" />
	/// </summary>
	public Package.ClientClass ClientClass => _ClientClass ?? (_ClientClass = new Package.ClientClass());

	private Package.ControlledVocabularyClass _ControlledVocabularyClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControlledVocabularyClass" path="/summary" />
	/// </summary>
	public Package.ControlledVocabularyClass ControlledVocabularyClass => _ControlledVocabularyClass ?? (_ControlledVocabularyClass = new Package.ControlledVocabularyClass());

	private Package.DataDictionaryClass _DataDictionaryClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataDictionaryClass" path="/summary" />
	/// </summary>
	public Package.DataDictionaryClass DataDictionaryClass => _DataDictionaryClass ?? (_DataDictionaryClass = new Package.DataDictionaryClass());

	private Package.DataModelClass _DataModelClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataModelClass" path="/summary" />
	/// </summary>
	public Package.DataModelClass DataModelClass => _DataModelClass ?? (_DataModelClass = new Package.DataModelClass());

	private Package.DataSetClass _DataSetClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataSetClass" path="/summary" />
	/// </summary>
	public Package.DataSetClass DataSetClass => _DataSetClass ?? (_DataSetClass = new Package.DataSetClass());

	private Package.DataSourceClass _DataSourceClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataSourceClass" path="/summary" />
	/// </summary>
	public Package.DataSourceClass DataSourceClass => _DataSourceClass ?? (_DataSourceClass = new Package.DataSourceClass());

	private Package.DeprecatedClass _DeprecatedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeprecatedClass" path="/summary" />
	/// </summary>
	public Package.DeprecatedClass DeprecatedClass => _DeprecatedClass ?? (_DeprecatedClass = new Package.DeprecatedClass());

	private Package.DeprecationWarningClass _DeprecationWarningClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeprecationWarningClass" path="/summary" />
	/// </summary>
	public Package.DeprecationWarningClass DeprecationWarningClass => _DeprecationWarningClass ?? (_DeprecationWarningClass = new Package.DeprecationWarningClass());

	private Package.DocumentClass _DocumentClass;
	/// <summary>
	/// <inheritdoc cref="Package.DocumentClass" path="/summary" />
	/// </summary>
	public Package.DocumentClass DocumentClass => _DocumentClass ?? (_DocumentClass = new Package.DocumentClass());

	private Package.ElectricCurrentClass _ElectricCurrentClass;
	/// <summary>
	/// <inheritdoc cref="Package.ElectricCurrentClass" path="/summary" />
	/// </summary>
	public Package.ElectricCurrentClass ElectricCurrentClass => _ElectricCurrentClass ?? (_ElectricCurrentClass = new Package.ElectricCurrentClass());

	private Package.ExtensibleClass _ExtensibleClass;
	/// <summary>
	/// <inheritdoc cref="Package.ExtensibleClass" path="/summary" />
	/// </summary>
	public Package.ExtensibleClass ExtensibleClass => _ExtensibleClass ?? (_ExtensibleClass = new Package.ExtensibleClass());

	private Package.ForceClass _ForceClass;
	/// <summary>
	/// <inheritdoc cref="Package.ForceClass" path="/summary" />
	/// </summary>
	public Package.ForceClass ForceClass => _ForceClass ?? (_ForceClass = new Package.ForceClass());

	private Package.ImplementationClass _ImplementationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ImplementationClass" path="/summary" />
	/// </summary>
	public Package.ImplementationClass ImplementationClass => _ImplementationClass ?? (_ImplementationClass = new Package.ImplementationClass());

	private Package.InformationModelClass _InformationModelClass;
	/// <summary>
	/// <inheritdoc cref="Package.InformationModelClass" path="/summary" />
	/// </summary>
	public Package.InformationModelClass InformationModelClass => _InformationModelClass ?? (_InformationModelClass = new Package.InformationModelClass());

	private Package.InstanceClass _InstanceClass;
	/// <summary>
	/// <inheritdoc cref="Package.InstanceClass" path="/summary" />
	/// </summary>
	public Package.InstanceClass InstanceClass => _InstanceClass ?? (_InstanceClass = new Package.InstanceClass());

	private Package.InteractionModelClass _InteractionModelClass;
	/// <summary>
	/// <inheritdoc cref="Package.InteractionModelClass" path="/summary" />
	/// </summary>
	public Package.InteractionModelClass InteractionModelClass => _InteractionModelClass ?? (_InteractionModelClass = new Package.InteractionModelClass());

	private Package.InterfaceClass _InterfaceClass;
	/// <summary>
	/// <inheritdoc cref="Package.InterfaceClass" path="/summary" />
	/// </summary>
	public Package.InterfaceClass InterfaceClass => _InterfaceClass ?? (_InterfaceClass = new Package.InterfaceClass());

	private Package.KeyClass _KeyClass;
	/// <summary>
	/// <inheritdoc cref="Package.KeyClass" path="/summary" />
	/// </summary>
	public Package.KeyClass KeyClass => _KeyClass ?? (_KeyClass = new Package.KeyClass());

	private Package.KeyValuePairClass _KeyValuePairClass;
	/// <summary>
	/// <inheritdoc cref="Package.KeyValuePairClass" path="/summary" />
	/// </summary>
	public Package.KeyValuePairClass KeyValuePairClass => _KeyValuePairClass ?? (_KeyValuePairClass = new Package.KeyValuePairClass());

	private Package.LowerCamelCaseClass _LowerCamelCaseClass;
	/// <summary>
	/// <inheritdoc cref="Package.LowerCamelCaseClass" path="/summary" />
	/// </summary>
	public Package.LowerCamelCaseClass LowerCamelCaseClass => _LowerCamelCaseClass ?? (_LowerCamelCaseClass = new Package.LowerCamelCaseClass());

	private Package.LowerLimitClass _LowerLimitClass;
	/// <summary>
	/// <inheritdoc cref="Package.LowerLimitClass" path="/summary" />
	/// </summary>
	public Package.LowerLimitClass LowerLimitClass => _LowerLimitClass ?? (_LowerLimitClass = new Package.LowerLimitClass());

	private Package.LowerWarningClass _LowerWarningClass;
	/// <summary>
	/// <inheritdoc cref="Package.LowerWarningClass" path="/summary" />
	/// </summary>
	public Package.LowerWarningClass LowerWarningClass => _LowerWarningClass ?? (_LowerWarningClass = new Package.LowerWarningClass());

	private Package.MajorClass _MajorClass;
	/// <summary>
	/// <inheritdoc cref="Package.MajorClass" path="/summary" />
	/// </summary>
	public Package.MajorClass MajorClass => _MajorClass ?? (_MajorClass = new Package.MajorClass());

	private Package.MaximumClass _MaximumClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaximumClass" path="/summary" />
	/// </summary>
	public Package.MaximumClass MaximumClass => _MaximumClass ?? (_MaximumClass = new Package.MaximumClass());

	private Package.MessageClass _MessageClass;
	/// <summary>
	/// <inheritdoc cref="Package.MessageClass" path="/summary" />
	/// </summary>
	public Package.MessageClass MessageClass => _MessageClass ?? (_MessageClass = new Package.MessageClass());

	private Package.MetadataClass _MetadataClass;
	/// <summary>
	/// <inheritdoc cref="Package.MetadataClass" path="/summary" />
	/// </summary>
	public Package.MetadataClass MetadataClass => _MetadataClass ?? (_MetadataClass = new Package.MetadataClass());

	private Package.MinimumClass _MinimumClass;
	/// <summary>
	/// <inheritdoc cref="Package.MinimumClass" path="/summary" />
	/// </summary>
	public Package.MinimumClass MinimumClass => _MinimumClass ?? (_MinimumClass = new Package.MinimumClass());

	private Package.MinorClass _MinorClass;
	/// <summary>
	/// <inheritdoc cref="Package.MinorClass" path="/summary" />
	/// </summary>
	public Package.MinorClass MinorClass => _MinorClass ?? (_MinorClass = new Package.MinorClass());

	private Package.NominalClass _NominalClass;
	/// <summary>
	/// <inheritdoc cref="Package.NominalClass" path="/summary" />
	/// </summary>
	public Package.NominalClass NominalClass => _NominalClass ?? (_NominalClass = new Package.NominalClass());

	private Package.OrganizeClass _OrganizeClass;
	/// <summary>
	/// <inheritdoc cref="Package.OrganizeClass" path="/summary" />
	/// </summary>
	public Package.OrganizeClass OrganizeClass => _OrganizeClass ?? (_OrganizeClass = new Package.OrganizeClass());

	private Package.OrganizerClass _OrganizerClass;
	/// <summary>
	/// <inheritdoc cref="Package.OrganizerClass" path="/summary" />
	/// </summary>
	public Package.OrganizerClass OrganizerClass => _OrganizerClass ?? (_OrganizerClass = new Package.OrganizerClass());

	private Package.ParameterClass _ParameterClass;
	/// <summary>
	/// <inheritdoc cref="Package.ParameterClass" path="/summary" />
	/// </summary>
	public Package.ParameterClass ParameterClass => _ParameterClass ?? (_ParameterClass = new Package.ParameterClass());

	private Package.PartClass _PartClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartClass" path="/summary" />
	/// </summary>
	public Package.PartClass PartClass => _PartClass ?? (_PartClass = new Package.PartClass());

	private Package.PascalCaseClass _PascalCaseClass;
	/// <summary>
	/// <inheritdoc cref="Package.PascalCaseClass" path="/summary" />
	/// </summary>
	public Package.PascalCaseClass PascalCaseClass => _PascalCaseClass ?? (_PascalCaseClass = new Package.PascalCaseClass());

	private Package.PersistenceClass _PersistenceClass;
	/// <summary>
	/// <inheritdoc cref="Package.PersistenceClass" path="/summary" />
	/// </summary>
	public Package.PersistenceClass PersistenceClass => _PersistenceClass ?? (_PersistenceClass = new Package.PersistenceClass());

	private Package.RequesterClass _RequesterClass;
	/// <summary>
	/// <inheritdoc cref="Package.RequesterClass" path="/summary" />
	/// </summary>
	public Package.RequesterClass RequesterClass => _RequesterClass ?? (_RequesterClass = new Package.RequesterClass());

	private Package.ResetClass _ResetClass;
	/// <summary>
	/// <inheritdoc cref="Package.ResetClass" path="/summary" />
	/// </summary>
	public Package.ResetClass ResetClass => _ResetClass ?? (_ResetClass = new Package.ResetClass());

	private Package.ResponderClass _ResponderClass;
	/// <summary>
	/// <inheritdoc cref="Package.ResponderClass" path="/summary" />
	/// </summary>
	public Package.ResponderClass ResponderClass => _ResponderClass ?? (_ResponderClass = new Package.ResponderClass());

	private Package.ResponseDocumentClass _ResponseDocumentClass;
	/// <summary>
	/// <inheritdoc cref="Package.ResponseDocumentClass" path="/summary" />
	/// </summary>
	public Package.ResponseDocumentClass ResponseDocumentClass => _ResponseDocumentClass ?? (_ResponseDocumentClass = new Package.ResponseDocumentClass());

	private Package.PatchClass _PatchClass;
	/// <summary>
	/// <inheritdoc cref="Package.PatchClass" path="/summary" />
	/// </summary>
	public Package.PatchClass PatchClass => _PatchClass ?? (_PatchClass = new Package.PatchClass());

	private Package.SchemaClass _SchemaClass;
	/// <summary>
	/// <inheritdoc cref="Package.SchemaClass" path="/summary" />
	/// </summary>
	public Package.SchemaClass SchemaClass => _SchemaClass ?? (_SchemaClass = new Package.SchemaClass());

	private Package.SemanticDataModelClass _SemanticDataModelClass;
	/// <summary>
	/// <inheritdoc cref="Package.SemanticDataModelClass" path="/summary" />
	/// </summary>
	public Package.SemanticDataModelClass SemanticDataModelClass => _SemanticDataModelClass ?? (_SemanticDataModelClass = new Package.SemanticDataModelClass());

	private Package.SensingElementClass _SensingElementClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensingElementClass" path="/summary" />
	/// </summary>
	public Package.SensingElementClass SensingElementClass => _SensingElementClass ?? (_SensingElementClass = new Package.SensingElementClass());

	private Package.SequenceNumberClass _SequenceNumberClass;
	/// <summary>
	/// <inheritdoc cref="Package.SequenceNumberClass" path="/summary" />
	/// </summary>
	public Package.SequenceNumberClass SequenceNumberClass => _SequenceNumberClass ?? (_SequenceNumberClass = new Package.SequenceNumberClass());

	private Package.SpecificationLimitClass _SpecificationLimitClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpecificationLimitClass" path="/summary" />
	/// </summary>
	public Package.SpecificationLimitClass SpecificationLimitClass => _SpecificationLimitClass ?? (_SpecificationLimitClass = new Package.SpecificationLimitClass());

	private Package.SpindleClass _SpindleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpindleClass" path="/summary" />
	/// </summary>
	public Package.SpindleClass SpindleClass => _SpindleClass ?? (_SpindleClass = new Package.SpindleClass());

	private Package.StandardClass _StandardClass;
	/// <summary>
	/// <inheritdoc cref="Package.StandardClass" path="/summary" />
	/// </summary>
	public Package.StandardClass StandardClass => _StandardClass ?? (_StandardClass = new Package.StandardClass());

	private Package.SubtypeClass _SubtypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.SubtypeClass" path="/summary" />
	/// </summary>
	public Package.SubtypeClass SubtypeClass => _SubtypeClass ?? (_SubtypeClass = new Package.SubtypeClass());

	private Package.TableClass _TableClass;
	/// <summary>
	/// <inheritdoc cref="Package.TableClass" path="/summary" />
	/// </summary>
	public Package.TableClass TableClass => _TableClass ?? (_TableClass = new Package.TableClass());

	private Package.TableCellClass _TableCellClass;
	/// <summary>
	/// <inheritdoc cref="Package.TableCellClass" path="/summary" />
	/// </summary>
	public Package.TableCellClass TableCellClass => _TableCellClass ?? (_TableCellClass = new Package.TableCellClass());

	private Package.TableEntryClass _TableEntryClass;
	/// <summary>
	/// <inheritdoc cref="Package.TableEntryClass" path="/summary" />
	/// </summary>
	public Package.TableEntryClass TableEntryClass => _TableEntryClass ?? (_TableEntryClass = new Package.TableEntryClass());

	private Package.TypeClass _TypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.TypeClass" path="/summary" />
	/// </summary>
	public Package.TypeClass TypeClass => _TypeClass ?? (_TypeClass = new Package.TypeClass());

	private Package.UpperLimitClass _UpperLimitClass;
	/// <summary>
	/// <inheritdoc cref="Package.UpperLimitClass" path="/summary" />
	/// </summary>
	public Package.UpperLimitClass UpperLimitClass => _UpperLimitClass ?? (_UpperLimitClass = new Package.UpperLimitClass());

	private Package.UpperWarningClass _UpperWarningClass;
	/// <summary>
	/// <inheritdoc cref="Package.UpperWarningClass" path="/summary" />
	/// </summary>
	public Package.UpperWarningClass UpperWarningClass => _UpperWarningClass ?? (_UpperWarningClass = new Package.UpperWarningClass());

	private Package.VersionClass _VersionClass;
	/// <summary>
	/// <inheritdoc cref="Package.VersionClass" path="/summary" />
	/// </summary>
	public Package.VersionClass VersionClass => _VersionClass ?? (_VersionClass = new Package.VersionClass());

	private Package.ProbeClass _ProbeClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProbeClass" path="/summary" />
	/// </summary>
	public Package.ProbeClass ProbeClass => _ProbeClass ?? (_ProbeClass = new Package.ProbeClass());

	private Package.HeartbeatClass _HeartbeatClass;
	/// <summary>
	/// <inheritdoc cref="Package.HeartbeatClass" path="/summary" />
	/// </summary>
	public Package.HeartbeatClass HeartbeatClass => _HeartbeatClass ?? (_HeartbeatClass = new Package.HeartbeatClass());

	private Package.ElementClass _ElementClass;
	/// <summary>
	/// <inheritdoc cref="Package.ElementClass" path="/summary" />
	/// </summary>
	public Package.ElementClass ElementClass => _ElementClass ?? (_ElementClass = new Package.ElementClass());

	private Package.HigherLevelClass _HigherLevelClass;
	/// <summary>
	/// <inheritdoc cref="Package.HigherLevelClass" path="/summary" />
	/// </summary>
	public Package.HigherLevelClass HigherLevelClass => _HigherLevelClass ?? (_HigherLevelClass = new Package.HigherLevelClass());

	private Package.LowerLevelClass _LowerLevelClass;
	/// <summary>
	/// <inheritdoc cref="Package.LowerLevelClass" path="/summary" />
	/// </summary>
	public Package.LowerLevelClass LowerLevelClass => _LowerLevelClass ?? (_LowerLevelClass = new Package.LowerLevelClass());

	private Package.ProfileClass _ProfileClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProfileClass" path="/summary" />
	/// </summary>
	public Package.ProfileClass ProfileClass => _ProfileClass ?? (_ProfileClass = new Package.ProfileClass());

	private Package.StereotypeClass _StereotypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.StereotypeClass" path="/summary" />
	/// </summary>
	public Package.StereotypeClass StereotypeClass => _StereotypeClass ?? (_StereotypeClass = new Package.StereotypeClass());

	private Package.TopLevelClass _TopLevelClass;
	/// <summary>
	/// <inheritdoc cref="Package.TopLevelClass" path="/summary" />
	/// </summary>
	public Package.TopLevelClass TopLevelClass => _TopLevelClass ?? (_TopLevelClass = new Package.TopLevelClass());

	private Package.CartesianCoordinateSystemClass _CartesianCoordinateSystemClass;
	/// <summary>
	/// <inheritdoc cref="Package.CartesianCoordinateSystemClass" path="/summary" />
	/// </summary>
	public Package.CartesianCoordinateSystemClass CartesianCoordinateSystemClass => _CartesianCoordinateSystemClass ?? (_CartesianCoordinateSystemClass = new Package.CartesianCoordinateSystemClass());

	private Package.CharacteristicClass _CharacteristicClass;
	/// <summary>
	/// <inheritdoc cref="Package.CharacteristicClass" path="/summary" />
	/// </summary>
	public Package.CharacteristicClass CharacteristicClass => _CharacteristicClass ?? (_CharacteristicClass = new Package.CharacteristicClass());

	private Package.FeatureClass _FeatureClass;
	/// <summary>
	/// <inheritdoc cref="Package.FeatureClass" path="/summary" />
	/// </summary>
	public Package.FeatureClass FeatureClass => _FeatureClass ?? (_FeatureClass = new Package.FeatureClass());

	private Package.LocationClass _LocationClass;
	/// <summary>
	/// <inheritdoc cref="Package.LocationClass" path="/summary" />
	/// </summary>
	public Package.LocationClass LocationClass => _LocationClass ?? (_LocationClass = new Package.LocationClass());

	private Package.PositionClass _PositionClass;
	/// <summary>
	/// <inheritdoc cref="Package.PositionClass" path="/summary" />
	/// </summary>
	public Package.PositionClass PositionClass => _PositionClass ?? (_PositionClass = new Package.PositionClass());

	private Package.UncertaintyClass _UncertaintyClass;
	/// <summary>
	/// <inheritdoc cref="Package.UncertaintyClass" path="/summary" />
	/// </summary>
	public Package.UncertaintyClass UncertaintyClass => _UncertaintyClass ?? (_UncertaintyClass = new Package.UncertaintyClass());

	private Package.StandardUncertaintyGeneralization _StandardUncertaintyGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.StandardUncertaintyGeneralization" path="/summary" />
	/// </summary>
	public Package.StandardUncertaintyGeneralization StandardUncertaintyGeneralization => _StandardUncertaintyGeneralization ?? (_StandardUncertaintyGeneralization = new Package.StandardUncertaintyGeneralization());

	private Package.CombinedStandardUncertaintyClass _CombinedStandardUncertaintyClass;
	/// <summary>
	/// <inheritdoc cref="Package.CombinedStandardUncertaintyClass" path="/summary" />
	/// </summary>
	public Package.CombinedStandardUncertaintyClass CombinedStandardUncertaintyClass => _CombinedStandardUncertaintyClass ?? (_CombinedStandardUncertaintyClass = new Package.CombinedStandardUncertaintyClass());

	private Package.ConditionActivationClass _ConditionActivationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConditionActivationClass" path="/summary" />
	/// </summary>
	public Package.ConditionActivationClass ConditionActivationClass => _ConditionActivationClass ?? (_ConditionActivationClass = new Package.ConditionActivationClass());

	#endregion
	}
}