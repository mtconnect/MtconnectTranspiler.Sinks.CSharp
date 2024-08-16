using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem;

namespace Mtconnect.DeviceInformationModel.DataItems
{
	/// <summary>
	﻿/// This section provides additional semantic information for the Part Properties of <see cref="DataItem">DataItem</see>.<br /><br />> Note: See <see cref="DataItems Schema Diagrams">DataItems Schema Diagrams</see> for XML schema of the elements for <see cref="DataItem">DataItem</see>.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1589399339634_269147_34">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class PropertiesOfDataItemPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1589399339634_269147_34";
		
		/// <inheritdoc />
		public string Name => "Properties of DataItem";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides additional semantic information for the Part Properties of {{block(DataItem)}}.

> Note: See {{sect(DataItems Schema Diagrams)}} for XML schema of the elements for {{block(DataItem)}}.&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			PropertiesOfDefinitionPackage,
			RelationshipTypesForDataItemPackage,
		};
		
		/// <inheritdoc />
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
		#region Packages
	private Package.PropertiesOfDefinitionPackage _PropertiesOfDefinitionPackage;
	/// <summary>
	/// <inheritdoc cref="Package.PropertiesOfDefinitionPackage" path="/summary" />
	/// </summary>
	public Package.PropertiesOfDefinitionPackage PropertiesOfDefinitionPackage => _PropertiesOfDefinitionPackage ?? (_PropertiesOfDefinitionPackage = new Package.PropertiesOfDefinitionPackage());

	private Package.RelationshipTypesForDataItemPackage _RelationshipTypesForDataItemPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RelationshipTypesForDataItemPackage" path="/summary" />
	/// </summary>
	public Package.RelationshipTypesForDataItemPackage RelationshipTypesForDataItemPackage => _RelationshipTypesForDataItemPackage ?? (_RelationshipTypesForDataItemPackage = new Package.RelationshipTypesForDataItemPackage());

	#endregion

	#region Classes
	private Package.ResetTriggerClass _ResetTriggerClass;
	/// <summary>
	/// <inheritdoc cref="Package.ResetTriggerClass" path="/summary" />
	/// </summary>
	public Package.ResetTriggerClass ResetTriggerClass => _ResetTriggerClass ?? (_ResetTriggerClass = new Package.ResetTriggerClass());

	private Package.SourceClass _SourceClass;
	/// <summary>
	/// <inheritdoc cref="Package.SourceClass" path="/summary" />
	/// </summary>
	public Package.SourceClass SourceClass => _SourceClass ?? (_SourceClass = new Package.SourceClass());

	private Package.InitialValueClass _InitialValueClass;
	/// <summary>
	/// <inheritdoc cref="Package.InitialValueClass" path="/summary" />
	/// </summary>
	public Package.InitialValueClass InitialValueClass => _InitialValueClass ?? (_InitialValueClass = new Package.InitialValueClass());

	private Package.FilterClass _FilterClass;
	/// <summary>
	/// <inheritdoc cref="Package.FilterClass" path="/summary" />
	/// </summary>
	public Package.FilterClass FilterClass => _FilterClass ?? (_FilterClass = new Package.FilterClass());

	private Package.ConstraintsClass _ConstraintsClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConstraintsClass" path="/summary" />
	/// </summary>
	public Package.ConstraintsClass ConstraintsClass => _ConstraintsClass ?? (_ConstraintsClass = new Package.ConstraintsClass());

	private Package.DefinitionClass _DefinitionClass;
	/// <summary>
	/// <inheritdoc cref="Package.DefinitionClass" path="/summary" />
	/// </summary>
	public Package.DefinitionClass DefinitionClass => _DefinitionClass ?? (_DefinitionClass = new Package.DefinitionClass());

	private Package.MinimumDeltaFilterGeneralization _MinimumDeltaFilterGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.MinimumDeltaFilterGeneralization" path="/summary" />
	/// </summary>
	public Package.MinimumDeltaFilterGeneralization MinimumDeltaFilterGeneralization => _MinimumDeltaFilterGeneralization ?? (_MinimumDeltaFilterGeneralization = new Package.MinimumDeltaFilterGeneralization());

	private Package.PeriodFilterGeneralization _PeriodFilterGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.PeriodFilterGeneralization" path="/summary" />
	/// </summary>
	public Package.PeriodFilterGeneralization PeriodFilterGeneralization => _PeriodFilterGeneralization ?? (_PeriodFilterGeneralization = new Package.PeriodFilterGeneralization());

	#endregion
	}
}