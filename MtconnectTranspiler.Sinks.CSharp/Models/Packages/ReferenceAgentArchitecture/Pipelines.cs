#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ReferenceAgentArchitecture.Pipelines;

namespace Mtconnect.ReferenceAgentArchitecture
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_4_45f01b9_1673980318563_67496_96">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class PipelinesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="PipelinesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_4_45f01b9_1673980318563_67496_96";
		/// <summary>Constant value for <see cref="PipelinesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_4_45f01b9_1673980318563_67496_96";
		/// <summary>Constant value for <see cref="PipelinesPackage.Name" /></summary>
		public const string NAME = "Pipelines";
		/// <summary>Constant value for <see cref="PipelinesPackage.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			Entity_Command_Class,
			Entity_Message_Class,
			Entity_Data_Class,
			EntityClass,
			Entity_ConnectionStatus_Class,
			TokensClass,
			TimestampedClass,
			ObservationsClass,
			AssetCommandClass,
			Entity_MClass,
			PipelineMessageClass,
			JsonMessageClass,
			DataMessageClass,
			TransformClass,
			GuardClass,
			TypeGuardGeneralization,
			ExactTypeGuardGeneralization,
			EntityNameGuardGeneralization,
			LambdaGuardGeneralization,
			ConvertSampleClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
			GuardResult,
		};

		#region Packages
	#endregion

	#region Classes
	private Package.Entity_Command_Class _Entity_Command_Class;
	/// <summary>
	/// <inheritdoc cref="Package.Entity_Command_Class" path="/summary" />
	/// </summary>
	public Package.Entity_Command_Class Entity_Command_Class => _Entity_Command_Class ?? (_Entity_Command_Class = new Package.Entity_Command_Class());

	private Package.Entity_Message_Class _Entity_Message_Class;
	/// <summary>
	/// <inheritdoc cref="Package.Entity_Message_Class" path="/summary" />
	/// </summary>
	public Package.Entity_Message_Class Entity_Message_Class => _Entity_Message_Class ?? (_Entity_Message_Class = new Package.Entity_Message_Class());

	private Package.Entity_Data_Class _Entity_Data_Class;
	/// <summary>
	/// <inheritdoc cref="Package.Entity_Data_Class" path="/summary" />
	/// </summary>
	public Package.Entity_Data_Class Entity_Data_Class => _Entity_Data_Class ?? (_Entity_Data_Class = new Package.Entity_Data_Class());

	private Package.EntityClass _EntityClass;
	/// <summary>
	/// <inheritdoc cref="Package.EntityClass" path="/summary" />
	/// </summary>
	public Package.EntityClass EntityClass => _EntityClass ?? (_EntityClass = new Package.EntityClass());

	private Package.Entity_ConnectionStatus_Class _Entity_ConnectionStatus_Class;
	/// <summary>
	/// <inheritdoc cref="Package.Entity_ConnectionStatus_Class" path="/summary" />
	/// </summary>
	public Package.Entity_ConnectionStatus_Class Entity_ConnectionStatus_Class => _Entity_ConnectionStatus_Class ?? (_Entity_ConnectionStatus_Class = new Package.Entity_ConnectionStatus_Class());

	private Package.TokensClass _TokensClass;
	/// <summary>
	/// <inheritdoc cref="Package.TokensClass" path="/summary" />
	/// </summary>
	public Package.TokensClass TokensClass => _TokensClass ?? (_TokensClass = new Package.TokensClass());

	private Package.TimestampedClass _TimestampedClass;
	/// <summary>
	/// <inheritdoc cref="Package.TimestampedClass" path="/summary" />
	/// </summary>
	public Package.TimestampedClass TimestampedClass => _TimestampedClass ?? (_TimestampedClass = new Package.TimestampedClass());

	private Package.ObservationsClass _ObservationsClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservationsClass" path="/summary" />
	/// </summary>
	public Package.ObservationsClass ObservationsClass => _ObservationsClass ?? (_ObservationsClass = new Package.ObservationsClass());

	private Package.AssetCommandClass _AssetCommandClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetCommandClass" path="/summary" />
	/// </summary>
	public Package.AssetCommandClass AssetCommandClass => _AssetCommandClass ?? (_AssetCommandClass = new Package.AssetCommandClass());

	private Package.Entity_MClass _Entity_MClass;
	/// <summary>
	/// <inheritdoc cref="Package.Entity_MClass" path="/summary" />
	/// </summary>
	public Package.Entity_MClass Entity_MClass => _Entity_MClass ?? (_Entity_MClass = new Package.Entity_MClass());

	private Package.PipelineMessageClass _PipelineMessageClass;
	/// <summary>
	/// <inheritdoc cref="Package.PipelineMessageClass" path="/summary" />
	/// </summary>
	public Package.PipelineMessageClass PipelineMessageClass => _PipelineMessageClass ?? (_PipelineMessageClass = new Package.PipelineMessageClass());

	private Package.JsonMessageClass _JsonMessageClass;
	/// <summary>
	/// <inheritdoc cref="Package.JsonMessageClass" path="/summary" />
	/// </summary>
	public Package.JsonMessageClass JsonMessageClass => _JsonMessageClass ?? (_JsonMessageClass = new Package.JsonMessageClass());

	private Package.DataMessageClass _DataMessageClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataMessageClass" path="/summary" />
	/// </summary>
	public Package.DataMessageClass DataMessageClass => _DataMessageClass ?? (_DataMessageClass = new Package.DataMessageClass());

	private Package.TransformClass _TransformClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransformClass" path="/summary" />
	/// </summary>
	public Package.TransformClass TransformClass => _TransformClass ?? (_TransformClass = new Package.TransformClass());

	private Package.GuardClass _GuardClass;
	/// <summary>
	/// <inheritdoc cref="Package.GuardClass" path="/summary" />
	/// </summary>
	public Package.GuardClass GuardClass => _GuardClass ?? (_GuardClass = new Package.GuardClass());

	private Package.TypeGuardGeneralization _TypeGuardGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.TypeGuardGeneralization" path="/summary" />
	/// </summary>
	public Package.TypeGuardGeneralization TypeGuardGeneralization => _TypeGuardGeneralization ?? (_TypeGuardGeneralization = new Package.TypeGuardGeneralization());

	private Package.ExactTypeGuardGeneralization _ExactTypeGuardGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.ExactTypeGuardGeneralization" path="/summary" />
	/// </summary>
	public Package.ExactTypeGuardGeneralization ExactTypeGuardGeneralization => _ExactTypeGuardGeneralization ?? (_ExactTypeGuardGeneralization = new Package.ExactTypeGuardGeneralization());

	private Package.EntityNameGuardGeneralization _EntityNameGuardGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.EntityNameGuardGeneralization" path="/summary" />
	/// </summary>
	public Package.EntityNameGuardGeneralization EntityNameGuardGeneralization => _EntityNameGuardGeneralization ?? (_EntityNameGuardGeneralization = new Package.EntityNameGuardGeneralization());

	private Package.LambdaGuardGeneralization _LambdaGuardGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.LambdaGuardGeneralization" path="/summary" />
	/// </summary>
	public Package.LambdaGuardGeneralization LambdaGuardGeneralization => _LambdaGuardGeneralization ?? (_LambdaGuardGeneralization = new Package.LambdaGuardGeneralization());

	private Package.ConvertSampleClass _ConvertSampleClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConvertSampleClass" path="/summary" />
	/// </summary>
	public Package.ConvertSampleClass ConvertSampleClass => _ConvertSampleClass ?? (_ConvertSampleClass = new Package.ConvertSampleClass());

	#endregion

	#region Enums
	private Package.GuardResultMetaClass _GuardResult;
	/// <summary>
	/// <inheritdoc cref="Package.GuardResultMetaClass" path="/summary" />
	/// </summary>
	public Package.GuardResultMetaClass GuardResult => _GuardResult ?? (_GuardResult = new Package.GuardResultMetaClass());

	#endregion
	}
}