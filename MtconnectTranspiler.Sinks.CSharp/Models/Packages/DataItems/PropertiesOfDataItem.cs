using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.DataItems {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class PropertiesOfDataItemPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			PropertiesOfDefinitionPackage,
			RelationshipTypesForDataItemPackage,
		};

		public IClass[] Classes => new IClass[] {
			ResetTriggerClass,
			SourceClass,
			InitialValueClass,
			FilterClass,
			ConstraintsClass,
			DefinitionClass,
			MinimumDeltaFilterGeneralization,
			PeriodFilterGeneralization,
		};
	private Package.PropertiesOfDefinitionPackage _PropertiesOfDefinitionPackage;
	public Package.PropertiesOfDefinitionPackage PropertiesOfDefinitionPackage => _PropertiesOfDefinitionPackage ?? (_PropertiesOfDefinitionPackage = new Package.PropertiesOfDefinitionPackage());
	private Package.RelationshipTypesForDataItemPackage _RelationshipTypesForDataItemPackage;
	public Package.RelationshipTypesForDataItemPackage RelationshipTypesForDataItemPackage => _RelationshipTypesForDataItemPackage ?? (_RelationshipTypesForDataItemPackage = new Package.RelationshipTypesForDataItemPackage());

	private Package.ResetTriggerClass _ResetTriggerClass;
	public Package.ResetTriggerClass ResetTriggerClass => _ResetTriggerClass ?? (_ResetTriggerClass = new Package.ResetTriggerClass());
	private Package.SourceClass _SourceClass;
	public Package.SourceClass SourceClass => _SourceClass ?? (_SourceClass = new Package.SourceClass());
	private Package.InitialValueClass _InitialValueClass;
	public Package.InitialValueClass InitialValueClass => _InitialValueClass ?? (_InitialValueClass = new Package.InitialValueClass());
	private Package.FilterClass _FilterClass;
	public Package.FilterClass FilterClass => _FilterClass ?? (_FilterClass = new Package.FilterClass());
	private Package.ConstraintsClass _ConstraintsClass;
	public Package.ConstraintsClass ConstraintsClass => _ConstraintsClass ?? (_ConstraintsClass = new Package.ConstraintsClass());
	private Package.DefinitionClass _DefinitionClass;
	public Package.DefinitionClass DefinitionClass => _DefinitionClass ?? (_DefinitionClass = new Package.DefinitionClass());
	private Package.MinimumDeltaFilterGeneralization _MinimumDeltaFilterGeneralization;
	public Package.MinimumDeltaFilterGeneralization MinimumDeltaFilterGeneralization => _MinimumDeltaFilterGeneralization ?? (_MinimumDeltaFilterGeneralization = new Package.MinimumDeltaFilterGeneralization());
	private Package.PeriodFilterGeneralization _PeriodFilterGeneralization;
	public Package.PeriodFilterGeneralization PeriodFilterGeneralization => _PeriodFilterGeneralization ?? (_PeriodFilterGeneralization = new Package.PeriodFilterGeneralization());
	}
}