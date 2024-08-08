using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.Files
{
	/// <summary>
	/// reference to the target <see cref="Device">Device</see> for this <see cref="File">File</see>. 
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DestinationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605277188545_673734_476";
		
		/// <inheritdoc />
		public string Summary => @"/// reference to the target <see cref=""Device"">Device</see> for this <see cref=""File"">File</see>. ";

		/// <inheritdoc />
		public string Name => "DestinationClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public DestinationClassProperties Properties { get; } = new DestinationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class DestinationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				DeviceUuid,
			};
			/// <summary>
			/// <inheritdoc cref="DeviceUuidProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DeviceUuid</remarks>
			/// </summary>
			public DeviceUuidProperty DeviceUuid { get; } = new DeviceUuidProperty();
			/// <summary>
			/// <c>uuid</c> of the target device or application.
			/// </summary>
			public sealed class DeviceUuidProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "DeviceUuid";
				
				/// <inheritdoc />
				public string Summary => @"/// reference to the target <see cref=""Device"">Device</see> for this <see cref=""File"">File</see>. ";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}