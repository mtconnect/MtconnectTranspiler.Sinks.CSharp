using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643980698480_209668_2427">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ProgramLocationTypeEnum
	{
		/// <summary>
		/// managed by the controller.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		LOCAL,
		/// <summary>
		/// not managed by the controller.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		EXTERNAL,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643980698480_209668_2427">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ProgramLocationTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ProgramLocationTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ProgramLocationTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.5";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		LOCAL,
		EXTERNAL,
		};

		private LOCALValue _LOCAL;
		/// <summary>
		/// managed by the controller.
		/// </summary>
		public LOCALValue LOCAL => _LOCAL ?? (_LOCAL = new LOCALValue());

		/// <summary>
		/// managed by the controller.
		/// </summary>
		public sealed class LOCALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOCAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// managed by the controller.";
		}
		private EXTERNALValue _EXTERNAL;
		/// <summary>
		/// not managed by the controller.
		/// </summary>
		public EXTERNALValue EXTERNAL => _EXTERNAL ?? (_EXTERNAL = new EXTERNALValue());

		/// <summary>
		/// not managed by the controller.
		/// </summary>
		public sealed class EXTERNALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EXTERNAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// not managed by the controller.";
		}
	}
}