using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// 3D orthogonal coordinate system <seealso href="https://www.google.com/search?q=ISO/IEC 19794-5:2011(en)&btnI=I">ISO/IEC 19794-5:2011(en)</seealso>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1660363224934_593112_802">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CartesianCoordinateSystemClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1660363224934_593112_802";
		
		/// <inheritdoc />
		public string Summary => @"/// 3D orthogonal coordinate system <seealso href=""https://www.google.com/search?q=ISO/IEC 19794-5:2011(en)&btnI=I"">ISO/IEC 19794-5:2011(en)</seealso>.";

		/// <inheritdoc />
		public string Name => "cartesian coordinate system";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public CartesianCoordinateSystemClassProperties Properties { get; } = new CartesianCoordinateSystemClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class CartesianCoordinateSystemClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}