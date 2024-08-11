using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417667_174664_2881">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum PathModeEnum
	{
		/// <summary>
		/// path is operating independently and without the influence of another path.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		INDEPENDENT,
		/// <summary>
		/// path provides information or state values that influences the operation of other <see cref="DataItem">DataItem</see> of similar type.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MASTER,
		/// <summary>
		/// physical or logical parts which are not physically connected to each other but are operating together.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		SYNCHRONOUS,
		/// <summary>
		/// axes associated with the path are mirroring the motion of the <c>MASTER</c> path.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		MIRROR,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417667_174664_2881">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PathModeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "PathModeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(PathModeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		INDEPENDENT,
		MASTER,
		SYNCHRONOUS,
		MIRROR,
		};

		private INDEPENDENTValue _INDEPENDENT;
		/// <summary>
		/// path is operating independently and without the influence of another path.
		/// </summary>
		public INDEPENDENTValue INDEPENDENT => _INDEPENDENT ?? (_INDEPENDENT = new INDEPENDENTValue());

		/// <summary>
		/// path is operating independently and without the influence of another path.
		/// </summary>
		public sealed class INDEPENDENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INDEPENDENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// path is operating independently and without the influence of another path.";
		}
		private MASTERValue _MASTER;
		/// <summary>
		/// path provides information or state values that influences the operation of other <see cref="DataItem">DataItem</see> of similar type.
		/// </summary>
		public MASTERValue MASTER => _MASTER ?? (_MASTER = new MASTERValue());

		/// <summary>
		/// path provides information or state values that influences the operation of other <see cref="DataItem">DataItem</see> of similar type.
		/// </summary>
		public sealed class MASTERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MASTER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// path provides information or state values that influences the operation of other <see cref=""DataItem"">DataItem</see> of similar type.";
		}
		private SYNCHRONOUSValue _SYNCHRONOUS;
		/// <summary>
		/// physical or logical parts which are not physically connected to each other but are operating together.
		/// </summary>
		public SYNCHRONOUSValue SYNCHRONOUS => _SYNCHRONOUS ?? (_SYNCHRONOUS = new SYNCHRONOUSValue());

		/// <summary>
		/// physical or logical parts which are not physically connected to each other but are operating together.
		/// </summary>
		public sealed class SYNCHRONOUSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SYNCHRONOUS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// physical or logical parts which are not physically connected to each other but are operating together.";
		}
		private MIRRORValue _MIRROR;
		/// <summary>
		/// axes associated with the path are mirroring the motion of the <c>MASTER</c> path.
		/// </summary>
		public MIRRORValue MIRROR => _MIRROR ?? (_MIRROR = new MIRRORValue());

		/// <summary>
		/// axes associated with the path are mirroring the motion of the <c>MASTER</c> path.
		/// </summary>
		public sealed class MIRRORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MIRROR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// axes associated with the path are mirroring the motion of the <c>MASTER</c> path.";
		}
	}
}