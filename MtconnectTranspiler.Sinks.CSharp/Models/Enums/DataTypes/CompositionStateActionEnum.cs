using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550701661_755056_78">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum CompositionStateActionEnum
	{
		/// <summary>
		/// <see cref="Composition">Composition</see> is operating.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ACTIVE,
		/// <summary>
		/// <see cref="Composition">Composition</see> is not operating.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		INACTIVE,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550701661_755056_78">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CompositionStateActionEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CompositionStateActionEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(CompositionStateActionEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ACTIVE,
		INACTIVE,
		};

		private ACTIVEValue _ACTIVE;
		/// <summary>
		/// <see cref="Composition">Composition</see> is operating.
		/// </summary>
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> is operating.
		/// </summary>
		public sealed class ACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> is operating.";
		}
		private INACTIVEValue _INACTIVE;
		/// <summary>
		/// <see cref="Composition">Composition</see> is not operating.
		/// </summary>
		public INACTIVEValue INACTIVE => _INACTIVE ?? (_INACTIVE = new INACTIVEValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> is not operating.
		/// </summary>
		public sealed class INACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> is not operating.";
		}
	}
}