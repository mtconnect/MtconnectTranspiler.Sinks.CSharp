
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AgentArchitecture.Pipelines;

using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class PipelinesPackage {


	private Package.Entity_Command_Class _Entity_Command_;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.Entity_Command_Class Entity_Command_ => _Entity_Command_ ?? (_Entity_Command_ = new Package.Entity_Command_Class());

	private Package.Entity_Message_Class _Entity_Message_;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.Entity_Message_Class Entity_Message_ => _Entity_Message_ ?? (_Entity_Message_ = new Package.Entity_Message_Class());

	private Package.Entity_Data_Class _Entity_Data_;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.Entity_Data_Class Entity_Data_ => _Entity_Data_ ?? (_Entity_Data_ = new Package.Entity_Data_Class());

	private Package.EntityClass _Entity;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EntityClass Entity => _Entity ?? (_Entity = new Package.EntityClass());

	private Package.Entity_ConnectionStatus_Class _Entity_ConnectionStatus_;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.Entity_ConnectionStatus_Class Entity_ConnectionStatus_ => _Entity_ConnectionStatus_ ?? (_Entity_ConnectionStatus_ = new Package.Entity_ConnectionStatus_Class());

	private Package.TokensClass _Tokens;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TokensClass Tokens => _Tokens ?? (_Tokens = new Package.TokensClass());

	private Package.TimestampedClass _Timestamped;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TimestampedClass Timestamped => _Timestamped ?? (_Timestamped = new Package.TimestampedClass());

	private Package.ObservationsClass _Observations;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ObservationsClass Observations => _Observations ?? (_Observations = new Package.ObservationsClass());

	private Package.AssetCommandClass _AssetCommand;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AssetCommandClass AssetCommand => _AssetCommand ?? (_AssetCommand = new Package.AssetCommandClass());

	private Package.Entity_MClass _Entity_M;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.Entity_MClass Entity_M => _Entity_M ?? (_Entity_M = new Package.Entity_MClass());

	private Package.PipelineMessageClass _PipelineMessage;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PipelineMessageClass PipelineMessage => _PipelineMessage ?? (_PipelineMessage = new Package.PipelineMessageClass());

	private Package.JsonMessageClass _JsonMessage;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.JsonMessageClass JsonMessage => _JsonMessage ?? (_JsonMessage = new Package.JsonMessageClass());

	private Package.DataMessageClass _DataMessage;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DataMessageClass DataMessage => _DataMessage ?? (_DataMessage = new Package.DataMessageClass());

	private Package.TransformClass _Transform;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransformClass Transform => _Transform ?? (_Transform = new Package.TransformClass());

	private Package.GuardClass _Guard;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.GuardClass Guard => _Guard ?? (_Guard = new Package.GuardClass());

	private Package.TypeGuardClass _TypeGuard;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TypeGuardClass TypeGuard => _TypeGuard ?? (_TypeGuard = new Package.TypeGuardClass());

	private Package.ExactTypeGuardClass _ExactTypeGuard;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ExactTypeGuardClass ExactTypeGuard => _ExactTypeGuard ?? (_ExactTypeGuard = new Package.ExactTypeGuardClass());

	private Package.EntityNameGuardClass _EntityNameGuard;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EntityNameGuardClass EntityNameGuard => _EntityNameGuard ?? (_EntityNameGuard = new Package.EntityNameGuardClass());

	private Package.LambdaGuardClass _LambdaGuard;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LambdaGuardClass LambdaGuard => _LambdaGuard ?? (_LambdaGuard = new Package.LambdaGuardClass());

	private Package.ConvertSampleClass _ConvertSample;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ConvertSampleClass ConvertSample => _ConvertSample ?? (_ConvertSample = new Package.ConvertSampleClass());
	}
}