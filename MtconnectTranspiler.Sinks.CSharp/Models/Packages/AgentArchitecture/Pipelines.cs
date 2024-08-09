using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Pipelines;

namespace Mtconnect.AgentArchitecture
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class PipelinesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1673980318563_67496_96";
		
		/// <inheritdoc />
		public string Name => "Pipelines";

		/// <inheritdoc />
		public string Summary => @"";

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
	}
}