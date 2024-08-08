using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// when multiple locations on a piece of bar stock are referenced as the indication for the <see cref="EndOfBar">EndOfBar</see>, the additional location(s) <b>MUST</b> be designated as <c>AUXILIARY</c> indication(s) for the <see cref="EndOfBar">EndOfBar</see>.  
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class EndOfBarAuxiliaryClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218290_73647_1782";
		
		/// <inheritdoc />
		public string Summary => @"/// when multiple locations on a piece of bar stock are referenced as the indication for the <see cref=""EndOfBar"">EndOfBar</see>, the additional location(s) <b>MUST</b> be designated as <c>AUXILIARY</c> indication(s) for the <see cref=""EndOfBar"">EndOfBar</see>.  ";

		/// <inheritdoc />
		public string Name => "EndOfBar.AuxiliaryClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1580378218288_775940_1776";

		/// <inheritdoc />
		public EndOfBarAuxiliaryClassProperties Properties { get; } = new EndOfBarAuxiliaryClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class EndOfBarAuxiliaryClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				SubType,
			};
			/// <summary>
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public SubTypeProperty SubType { get; } = new SubTypeProperty();
			public sealed class SubTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579563592155_977172_22064</item>
				/// <item>Type: DataItemSubTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnum);
				
				/// <inheritdoc />
				public string Name => "SubType";
				
				/// <inheritdoc />
				public string Summary => @"/// when multiple locations on a piece of bar stock are referenced as the indication for the <see cref=""EndOfBar"">EndOfBar</see>, the additional location(s) <b>MUST</b> be designated as <c>AUXILIARY</c> indication(s) for the <see cref=""EndOfBar"">EndOfBar</see>.  ";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}