#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605645712659_8263_2990">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum DataItemRelationshipTypeEnum
	{
		/// <summary>
		/// reference to a <see cref="DataItem">DataItem</see> that associates the values with an external entity. 
		/// </summary>
		ATTACHMENT,
		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides the <c>id</c> of the effective Coordinate System. 
		/// </summary>
		COORDINATE_SYSTEM,
		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides process limits. 
		/// </summary>
		LIMIT,
		/// <summary>
		/// referenced <see cref="DataItem">DataItem</see> provides the observed values. 
		/// </summary>
		OBSERVATION,
	}
}