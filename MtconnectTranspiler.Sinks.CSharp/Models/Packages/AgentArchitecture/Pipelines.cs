using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Pipelines;
// using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class PipelinesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

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

	private Package.Entity_Command_Class _Entity_Command_Class;
	public Package.Entity_Command_Class Entity_Command_Class => _Entity_Command_Class ?? (_Entity_Command_Class = new Package.Entity_Command_Class());
	private Package.Entity_Message_Class _Entity_Message_Class;
	public Package.Entity_Message_Class Entity_Message_Class => _Entity_Message_Class ?? (_Entity_Message_Class = new Package.Entity_Message_Class());
	private Package.Entity_Data_Class _Entity_Data_Class;
	public Package.Entity_Data_Class Entity_Data_Class => _Entity_Data_Class ?? (_Entity_Data_Class = new Package.Entity_Data_Class());
	private Package.EntityClass _EntityClass;
	public Package.EntityClass EntityClass => _EntityClass ?? (_EntityClass = new Package.EntityClass());
	private Package.Entity_ConnectionStatus_Class _Entity_ConnectionStatus_Class;
	public Package.Entity_ConnectionStatus_Class Entity_ConnectionStatus_Class => _Entity_ConnectionStatus_Class ?? (_Entity_ConnectionStatus_Class = new Package.Entity_ConnectionStatus_Class());
	private Package.TokensClass _TokensClass;
	public Package.TokensClass TokensClass => _TokensClass ?? (_TokensClass = new Package.TokensClass());
	private Package.TimestampedClass _TimestampedClass;
	public Package.TimestampedClass TimestampedClass => _TimestampedClass ?? (_TimestampedClass = new Package.TimestampedClass());
	private Package.ObservationsClass _ObservationsClass;
	public Package.ObservationsClass ObservationsClass => _ObservationsClass ?? (_ObservationsClass = new Package.ObservationsClass());
	private Package.AssetCommandClass _AssetCommandClass;
	public Package.AssetCommandClass AssetCommandClass => _AssetCommandClass ?? (_AssetCommandClass = new Package.AssetCommandClass());
	private Package.Entity_MClass _Entity_MClass;
	public Package.Entity_MClass Entity_MClass => _Entity_MClass ?? (_Entity_MClass = new Package.Entity_MClass());
	private Package.PipelineMessageClass _PipelineMessageClass;
	public Package.PipelineMessageClass PipelineMessageClass => _PipelineMessageClass ?? (_PipelineMessageClass = new Package.PipelineMessageClass());
	private Package.JsonMessageClass _JsonMessageClass;
	public Package.JsonMessageClass JsonMessageClass => _JsonMessageClass ?? (_JsonMessageClass = new Package.JsonMessageClass());
	private Package.DataMessageClass _DataMessageClass;
	public Package.DataMessageClass DataMessageClass => _DataMessageClass ?? (_DataMessageClass = new Package.DataMessageClass());
	private Package.TransformClass _TransformClass;
	public Package.TransformClass TransformClass => _TransformClass ?? (_TransformClass = new Package.TransformClass());
	private Package.GuardClass _GuardClass;
	public Package.GuardClass GuardClass => _GuardClass ?? (_GuardClass = new Package.GuardClass());
	private Package.TypeGuardGeneralization _TypeGuardGeneralization;
	public Package.TypeGuardGeneralization TypeGuardGeneralization => _TypeGuardGeneralization ?? (_TypeGuardGeneralization = new Package.TypeGuardGeneralization());
	private Package.ExactTypeGuardGeneralization _ExactTypeGuardGeneralization;
	public Package.ExactTypeGuardGeneralization ExactTypeGuardGeneralization => _ExactTypeGuardGeneralization ?? (_ExactTypeGuardGeneralization = new Package.ExactTypeGuardGeneralization());
	private Package.EntityNameGuardGeneralization _EntityNameGuardGeneralization;
	public Package.EntityNameGuardGeneralization EntityNameGuardGeneralization => _EntityNameGuardGeneralization ?? (_EntityNameGuardGeneralization = new Package.EntityNameGuardGeneralization());
	private Package.LambdaGuardGeneralization _LambdaGuardGeneralization;
	public Package.LambdaGuardGeneralization LambdaGuardGeneralization => _LambdaGuardGeneralization ?? (_LambdaGuardGeneralization = new Package.LambdaGuardGeneralization());
	private Package.ConvertSampleClass _ConvertSampleClass;
	public Package.ConvertSampleClass ConvertSampleClass => _ConvertSampleClass ?? (_ConvertSampleClass = new Package.ConvertSampleClass());
	}
}