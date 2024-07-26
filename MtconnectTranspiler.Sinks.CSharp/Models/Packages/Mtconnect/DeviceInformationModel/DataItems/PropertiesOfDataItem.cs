
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.DataItems {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class PropertiesOfDataItemPackage {

	private Package.PropertiesOfDefinitionPackage _PropertiesOfDefinitionPackage;
	public Package.PropertiesOfDefinitionPackage PropertiesOfDefinitionPackage => _PropertiesOfDefinitionPackage ?? (_PropertiesOfDefinitionPackage = new Package.PropertiesOfDefinitionPackage());

	private Package.RelationshipTypesForDataItemPackage _RelationshipTypesForDataItemPackage;
	public Package.RelationshipTypesForDataItemPackage RelationshipTypesForDataItemPackage => _RelationshipTypesForDataItemPackage ?? (_RelationshipTypesForDataItemPackage = new Package.RelationshipTypesForDataItemPackage());


	private Package.ResetTriggerClass _ResetTrigger;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ResetTriggerClass ResetTrigger => _ResetTrigger ?? (_ResetTrigger = new Package.ResetTriggerClass());

	private Package.SourceClass _Source;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SourceClass Source => _Source ?? (_Source = new Package.SourceClass());

	private Package.InitialValueClass _InitialValue;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.InitialValueClass InitialValue => _InitialValue ?? (_InitialValue = new Package.InitialValueClass());

	private Package.FilterClass _Filter;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FilterClass Filter => _Filter ?? (_Filter = new Package.FilterClass());

	private Package.ConstraintsClass _Constraints;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ConstraintsClass Constraints => _Constraints ?? (_Constraints = new Package.ConstraintsClass());

	private Package.DefinitionClass _Definition;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DefinitionClass Definition => _Definition ?? (_Definition = new Package.DefinitionClass());

	private Package.MinimumDeltaFilterClass _MinimumDeltaFilter;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MinimumDeltaFilterClass MinimumDeltaFilter => _MinimumDeltaFilter ?? (_MinimumDeltaFilter = new Package.MinimumDeltaFilterClass());

	private Package.PeriodFilterClass _PeriodFilter;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PeriodFilterClass PeriodFilter => _PeriodFilter ?? (_PeriodFilter = new Package.PeriodFilterClass());
	}
}