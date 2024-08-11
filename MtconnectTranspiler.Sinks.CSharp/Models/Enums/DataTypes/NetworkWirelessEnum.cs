using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643979384902_745208_1916">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum NetworkWirelessEnum
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		YES,
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		NO,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643979384902_745208_1916">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class NetworkWirelessEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "NetworkWirelessEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(NetworkWirelessEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.6";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		YES,
		NO,
		};

		private YESValue _YES;
		/// <summary>
		/// 
		/// </summary>
		public YESValue YES => _YES ?? (_YES = new YESValue());

		/// <summary>
		/// 
		/// </summary>
		public sealed class YESValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "YES";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// ";
		}
		private NOValue _NO;
		/// <summary>
		/// 
		/// </summary>
		public NOValue NO => _NO ?? (_NO = new NOValue());

		/// <summary>
		/// 
		/// </summary>
		public sealed class NOValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NO";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// ";
		}
	}
}