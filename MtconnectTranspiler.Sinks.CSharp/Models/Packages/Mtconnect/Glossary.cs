using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary;
// using Mtconnect;

namespace Mtconnect {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class GlossaryPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			XMLTermsPackage,
			HTTPTermsPackage,
			MTConnectTermsPackage,
			InformationModelTermsPackage,
			ProtocolTermsPackage,
			IndustrialTermsPackage,
		};

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
	private Package.XMLTermsPackage _XMLTermsPackage;
	public Package.XMLTermsPackage XMLTermsPackage => _XMLTermsPackage ?? (_XMLTermsPackage = new Package.XMLTermsPackage());
	private Package.HTTPTermsPackage _HTTPTermsPackage;
	public Package.HTTPTermsPackage HTTPTermsPackage => _HTTPTermsPackage ?? (_HTTPTermsPackage = new Package.HTTPTermsPackage());
	private Package.MTConnectTermsPackage _MTConnectTermsPackage;
	public Package.MTConnectTermsPackage MTConnectTermsPackage => _MTConnectTermsPackage ?? (_MTConnectTermsPackage = new Package.MTConnectTermsPackage());
	private Package.InformationModelTermsPackage _InformationModelTermsPackage;
	public Package.InformationModelTermsPackage InformationModelTermsPackage => _InformationModelTermsPackage ?? (_InformationModelTermsPackage = new Package.InformationModelTermsPackage());
	private Package.ProtocolTermsPackage _ProtocolTermsPackage;
	public Package.ProtocolTermsPackage ProtocolTermsPackage => _ProtocolTermsPackage ?? (_ProtocolTermsPackage = new Package.ProtocolTermsPackage());
	private Package.IndustrialTermsPackage _IndustrialTermsPackage;
	public Package.IndustrialTermsPackage IndustrialTermsPackage => _IndustrialTermsPackage ?? (_IndustrialTermsPackage = new Package.IndustrialTermsPackage());

	private Package.AdapterClass _AdapterClass;
	public Package.AdapterClass AdapterClass => _AdapterClass ?? (_AdapterClass = new Package.AdapterClass());
	private Package.AgentClass _AgentClass;
	public Package.AgentClass AgentClass => _AgentClass ?? (_AgentClass = new Package.AgentClass());
	private Package.AlarmLimitClass _AlarmLimitClass;
	public Package.AlarmLimitClass AlarmLimitClass => _AlarmLimitClass ?? (_AlarmLimitClass = new Package.AlarmLimitClass());
	private Package.ApplicationClass _ApplicationClass;
	public Package.ApplicationClass ApplicationClass => _ApplicationClass ?? (_ApplicationClass = new Package.ApplicationClass());
	private Package.ArchetypeClass _ArchetypeClass;
	public Package.ArchetypeClass ArchetypeClass => _ArchetypeClass ?? (_ArchetypeClass = new Package.ArchetypeClass());
	private Package.AssetBufferClass _AssetBufferClass;
	public Package.AssetBufferClass AssetBufferClass => _AssetBufferClass ?? (_AssetBufferClass = new Package.AssetBufferClass());
	private Package.AttachmentClass _AttachmentClass;
	public Package.AttachmentClass AttachmentClass => _AttachmentClass ?? (_AttachmentClass = new Package.AttachmentClass());
	private Package.BufferClass _BufferClass;
	public Package.BufferClass BufferClass => _BufferClass ?? (_BufferClass = new Package.BufferClass());
	private Package.ClientClass _ClientClass;
	public Package.ClientClass ClientClass => _ClientClass ?? (_ClientClass = new Package.ClientClass());
	private Package.ControlledVocabularyClass _ControlledVocabularyClass;
	public Package.ControlledVocabularyClass ControlledVocabularyClass => _ControlledVocabularyClass ?? (_ControlledVocabularyClass = new Package.ControlledVocabularyClass());
	private Package.DataDictionaryClass _DataDictionaryClass;
	public Package.DataDictionaryClass DataDictionaryClass => _DataDictionaryClass ?? (_DataDictionaryClass = new Package.DataDictionaryClass());
	private Package.DataModelClass _DataModelClass;
	public Package.DataModelClass DataModelClass => _DataModelClass ?? (_DataModelClass = new Package.DataModelClass());
	private Package.DataSetClass _DataSetClass;
	public Package.DataSetClass DataSetClass => _DataSetClass ?? (_DataSetClass = new Package.DataSetClass());
	private Package.DataSourceClass _DataSourceClass;
	public Package.DataSourceClass DataSourceClass => _DataSourceClass ?? (_DataSourceClass = new Package.DataSourceClass());
	private Package.DeprecatedClass _DeprecatedClass;
	public Package.DeprecatedClass DeprecatedClass => _DeprecatedClass ?? (_DeprecatedClass = new Package.DeprecatedClass());
	private Package.DeprecationWarningClass _DeprecationWarningClass;
	public Package.DeprecationWarningClass DeprecationWarningClass => _DeprecationWarningClass ?? (_DeprecationWarningClass = new Package.DeprecationWarningClass());
	private Package.DocumentClass _DocumentClass;
	public Package.DocumentClass DocumentClass => _DocumentClass ?? (_DocumentClass = new Package.DocumentClass());
	private Package.ElectricCurrentClass _ElectricCurrentClass;
	public Package.ElectricCurrentClass ElectricCurrentClass => _ElectricCurrentClass ?? (_ElectricCurrentClass = new Package.ElectricCurrentClass());
	private Package.ExtensibleClass _ExtensibleClass;
	public Package.ExtensibleClass ExtensibleClass => _ExtensibleClass ?? (_ExtensibleClass = new Package.ExtensibleClass());
	private Package.ForceClass _ForceClass;
	public Package.ForceClass ForceClass => _ForceClass ?? (_ForceClass = new Package.ForceClass());
	private Package.ImplementationClass _ImplementationClass;
	public Package.ImplementationClass ImplementationClass => _ImplementationClass ?? (_ImplementationClass = new Package.ImplementationClass());
	private Package.InformationModelClass _InformationModelClass;
	public Package.InformationModelClass InformationModelClass => _InformationModelClass ?? (_InformationModelClass = new Package.InformationModelClass());
	private Package.InstanceClass _InstanceClass;
	public Package.InstanceClass InstanceClass => _InstanceClass ?? (_InstanceClass = new Package.InstanceClass());
	private Package.InteractionModelClass _InteractionModelClass;
	public Package.InteractionModelClass InteractionModelClass => _InteractionModelClass ?? (_InteractionModelClass = new Package.InteractionModelClass());
	private Package.InterfaceClass _InterfaceClass;
	public Package.InterfaceClass InterfaceClass => _InterfaceClass ?? (_InterfaceClass = new Package.InterfaceClass());
	private Package.KeyClass _KeyClass;
	public Package.KeyClass KeyClass => _KeyClass ?? (_KeyClass = new Package.KeyClass());
	private Package.KeyValuePairClass _KeyValuePairClass;
	public Package.KeyValuePairClass KeyValuePairClass => _KeyValuePairClass ?? (_KeyValuePairClass = new Package.KeyValuePairClass());
	private Package.LowerCamelCaseClass _LowerCamelCaseClass;
	public Package.LowerCamelCaseClass LowerCamelCaseClass => _LowerCamelCaseClass ?? (_LowerCamelCaseClass = new Package.LowerCamelCaseClass());
	private Package.LowerLimitClass _LowerLimitClass;
	public Package.LowerLimitClass LowerLimitClass => _LowerLimitClass ?? (_LowerLimitClass = new Package.LowerLimitClass());
	private Package.LowerWarningClass _LowerWarningClass;
	public Package.LowerWarningClass LowerWarningClass => _LowerWarningClass ?? (_LowerWarningClass = new Package.LowerWarningClass());
	private Package.MajorClass _MajorClass;
	public Package.MajorClass MajorClass => _MajorClass ?? (_MajorClass = new Package.MajorClass());
	private Package.MaximumClass _MaximumClass;
	public Package.MaximumClass MaximumClass => _MaximumClass ?? (_MaximumClass = new Package.MaximumClass());
	private Package.MessageClass _MessageClass;
	public Package.MessageClass MessageClass => _MessageClass ?? (_MessageClass = new Package.MessageClass());
	private Package.MetadataClass _MetadataClass;
	public Package.MetadataClass MetadataClass => _MetadataClass ?? (_MetadataClass = new Package.MetadataClass());
	private Package.MinimumClass _MinimumClass;
	public Package.MinimumClass MinimumClass => _MinimumClass ?? (_MinimumClass = new Package.MinimumClass());
	private Package.MinorClass _MinorClass;
	public Package.MinorClass MinorClass => _MinorClass ?? (_MinorClass = new Package.MinorClass());
	private Package.NominalClass _NominalClass;
	public Package.NominalClass NominalClass => _NominalClass ?? (_NominalClass = new Package.NominalClass());
	private Package.OrganizeClass _OrganizeClass;
	public Package.OrganizeClass OrganizeClass => _OrganizeClass ?? (_OrganizeClass = new Package.OrganizeClass());
	private Package.OrganizerClass _OrganizerClass;
	public Package.OrganizerClass OrganizerClass => _OrganizerClass ?? (_OrganizerClass = new Package.OrganizerClass());
	private Package.ParameterClass _ParameterClass;
	public Package.ParameterClass ParameterClass => _ParameterClass ?? (_ParameterClass = new Package.ParameterClass());
	private Package.PartClass _PartClass;
	public Package.PartClass PartClass => _PartClass ?? (_PartClass = new Package.PartClass());
	private Package.PascalCaseClass _PascalCaseClass;
	public Package.PascalCaseClass PascalCaseClass => _PascalCaseClass ?? (_PascalCaseClass = new Package.PascalCaseClass());
	private Package.PersistenceClass _PersistenceClass;
	public Package.PersistenceClass PersistenceClass => _PersistenceClass ?? (_PersistenceClass = new Package.PersistenceClass());
	private Package.RequesterClass _RequesterClass;
	public Package.RequesterClass RequesterClass => _RequesterClass ?? (_RequesterClass = new Package.RequesterClass());
	private Package.ResetClass _ResetClass;
	public Package.ResetClass ResetClass => _ResetClass ?? (_ResetClass = new Package.ResetClass());
	private Package.ResponderClass _ResponderClass;
	public Package.ResponderClass ResponderClass => _ResponderClass ?? (_ResponderClass = new Package.ResponderClass());
	private Package.ResponseDocumentClass _ResponseDocumentClass;
	public Package.ResponseDocumentClass ResponseDocumentClass => _ResponseDocumentClass ?? (_ResponseDocumentClass = new Package.ResponseDocumentClass());
	private Package.PatchClass _PatchClass;
	public Package.PatchClass PatchClass => _PatchClass ?? (_PatchClass = new Package.PatchClass());
	private Package.SchemaClass _SchemaClass;
	public Package.SchemaClass SchemaClass => _SchemaClass ?? (_SchemaClass = new Package.SchemaClass());
	private Package.SemanticDataModelClass _SemanticDataModelClass;
	public Package.SemanticDataModelClass SemanticDataModelClass => _SemanticDataModelClass ?? (_SemanticDataModelClass = new Package.SemanticDataModelClass());
	private Package.SensingElementClass _SensingElementClass;
	public Package.SensingElementClass SensingElementClass => _SensingElementClass ?? (_SensingElementClass = new Package.SensingElementClass());
	private Package.SequenceNumberClass _SequenceNumberClass;
	public Package.SequenceNumberClass SequenceNumberClass => _SequenceNumberClass ?? (_SequenceNumberClass = new Package.SequenceNumberClass());
	private Package.SpecificationLimitClass _SpecificationLimitClass;
	public Package.SpecificationLimitClass SpecificationLimitClass => _SpecificationLimitClass ?? (_SpecificationLimitClass = new Package.SpecificationLimitClass());
	private Package.SpindleClass _SpindleClass;
	public Package.SpindleClass SpindleClass => _SpindleClass ?? (_SpindleClass = new Package.SpindleClass());
	private Package.StandardClass _StandardClass;
	public Package.StandardClass StandardClass => _StandardClass ?? (_StandardClass = new Package.StandardClass());
	private Package.SubtypeClass _SubtypeClass;
	public Package.SubtypeClass SubtypeClass => _SubtypeClass ?? (_SubtypeClass = new Package.SubtypeClass());
	private Package.TableClass _TableClass;
	public Package.TableClass TableClass => _TableClass ?? (_TableClass = new Package.TableClass());
	private Package.TableCellClass _TableCellClass;
	public Package.TableCellClass TableCellClass => _TableCellClass ?? (_TableCellClass = new Package.TableCellClass());
	private Package.TableEntryClass _TableEntryClass;
	public Package.TableEntryClass TableEntryClass => _TableEntryClass ?? (_TableEntryClass = new Package.TableEntryClass());
	private Package.TypeClass _TypeClass;
	public Package.TypeClass TypeClass => _TypeClass ?? (_TypeClass = new Package.TypeClass());
	private Package.UpperLimitClass _UpperLimitClass;
	public Package.UpperLimitClass UpperLimitClass => _UpperLimitClass ?? (_UpperLimitClass = new Package.UpperLimitClass());
	private Package.UpperWarningClass _UpperWarningClass;
	public Package.UpperWarningClass UpperWarningClass => _UpperWarningClass ?? (_UpperWarningClass = new Package.UpperWarningClass());
	private Package.VersionClass _VersionClass;
	public Package.VersionClass VersionClass => _VersionClass ?? (_VersionClass = new Package.VersionClass());
	private Package.ProbeClass _ProbeClass;
	public Package.ProbeClass ProbeClass => _ProbeClass ?? (_ProbeClass = new Package.ProbeClass());
	private Package.HeartbeatClass _HeartbeatClass;
	public Package.HeartbeatClass HeartbeatClass => _HeartbeatClass ?? (_HeartbeatClass = new Package.HeartbeatClass());
	private Package.ElementClass _ElementClass;
	public Package.ElementClass ElementClass => _ElementClass ?? (_ElementClass = new Package.ElementClass());
	private Package.HigherLevelClass _HigherLevelClass;
	public Package.HigherLevelClass HigherLevelClass => _HigherLevelClass ?? (_HigherLevelClass = new Package.HigherLevelClass());
	private Package.LowerLevelClass _LowerLevelClass;
	public Package.LowerLevelClass LowerLevelClass => _LowerLevelClass ?? (_LowerLevelClass = new Package.LowerLevelClass());
	private Package.ProfileClass _ProfileClass;
	public Package.ProfileClass ProfileClass => _ProfileClass ?? (_ProfileClass = new Package.ProfileClass());
	private Package.StereotypeClass _StereotypeClass;
	public Package.StereotypeClass StereotypeClass => _StereotypeClass ?? (_StereotypeClass = new Package.StereotypeClass());
	private Package.TopLevelClass _TopLevelClass;
	public Package.TopLevelClass TopLevelClass => _TopLevelClass ?? (_TopLevelClass = new Package.TopLevelClass());
	private Package.CartesianCoordinateSystemClass _CartesianCoordinateSystemClass;
	public Package.CartesianCoordinateSystemClass CartesianCoordinateSystemClass => _CartesianCoordinateSystemClass ?? (_CartesianCoordinateSystemClass = new Package.CartesianCoordinateSystemClass());
	private Package.CharacteristicClass _CharacteristicClass;
	public Package.CharacteristicClass CharacteristicClass => _CharacteristicClass ?? (_CharacteristicClass = new Package.CharacteristicClass());
	private Package.FeatureClass _FeatureClass;
	public Package.FeatureClass FeatureClass => _FeatureClass ?? (_FeatureClass = new Package.FeatureClass());
	private Package.LocationClass _LocationClass;
	public Package.LocationClass LocationClass => _LocationClass ?? (_LocationClass = new Package.LocationClass());
	private Package.PositionClass _PositionClass;
	public Package.PositionClass PositionClass => _PositionClass ?? (_PositionClass = new Package.PositionClass());
	private Package.UncertaintyClass _UncertaintyClass;
	public Package.UncertaintyClass UncertaintyClass => _UncertaintyClass ?? (_UncertaintyClass = new Package.UncertaintyClass());
	private Package.StandardUncertaintyGeneralization _StandardUncertaintyGeneralization;
	public Package.StandardUncertaintyGeneralization StandardUncertaintyGeneralization => _StandardUncertaintyGeneralization ?? (_StandardUncertaintyGeneralization = new Package.StandardUncertaintyGeneralization());
	private Package.CombinedStandardUncertaintyClass _CombinedStandardUncertaintyClass;
	public Package.CombinedStandardUncertaintyClass CombinedStandardUncertaintyClass => _CombinedStandardUncertaintyClass ?? (_CombinedStandardUncertaintyClass = new Package.CombinedStandardUncertaintyClass());
	private Package.ConditionActivationClass _ConditionActivationClass;
	public Package.ConditionActivationClass ConditionActivationClass => _ConditionActivationClass ?? (_ConditionActivationClass = new Package.ConditionActivationClass());
	}
}