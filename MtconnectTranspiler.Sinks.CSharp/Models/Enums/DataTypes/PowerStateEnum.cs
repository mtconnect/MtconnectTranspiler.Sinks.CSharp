using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632489430362_282150_112">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum PowerStateEnum
	{
		/// <summary>
		/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is present and active.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		ON,
		/// <summary>
		/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is not present or is disconnected.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		OFF,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632489430362_282150_112">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PowerStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "PowerStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(PowerStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ON,
		OFF,
		};

		private ONValue _ON;
		/// <summary>
		/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is present and active.
		/// </summary>
		public ONValue ON => _ON ?? (_ON = new ONValue());

		/// <summary>
		/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is present and active.
		/// </summary>
		public sealed class ONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ON";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is present and active.";
		}
		private OFFValue _OFF;
		/// <summary>
		/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is not present or is disconnected.
		/// </summary>
		public OFFValue OFF => _OFF ?? (_OFF = new OFFValue());

		/// <summary>
		/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is not present or is disconnected.
		/// </summary>
		public sealed class OFFValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OFF";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is not present or is disconnected.";
		}
	}
}