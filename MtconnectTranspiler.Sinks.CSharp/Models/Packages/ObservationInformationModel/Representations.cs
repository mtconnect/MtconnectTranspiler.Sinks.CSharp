#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.Representations;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="Representation">Representation</see> model.<br /><br />![Representation](figures/Representation.png "Representation"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Representation Schema Diagrams">Representation Schema Diagrams</see> for XML schema.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1583339330789_426055_14911">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class RepresentationsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="RepresentationsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1583339330789_426055_14911";
		/// <summary>Constant value for <see cref="RepresentationsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_45f01b9_1583339330789_426055_14911";
		/// <summary>Constant value for <see cref="RepresentationsPackage.Name" /></summary>
		public const string NAME = "Representations";
		/// <summary>Constant value for <see cref="RepresentationsPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(Representation)}} model.

![Representation](figures/Representation.png ""Representation""){: width=""0.8""}

> Note: See {{sect(Representation Schema Diagrams)}} for XML schema.&#10;
";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			RepresentationClass,
			ValueClass,
			TimeSeriesClass,
			DiscreteClass,
			DataSetClass,
			EntryClass,
			TableClass,
			TableEntryClass,
			CellClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.RepresentationClass _RepresentationClass;
	/// <summary>
	/// <inheritdoc cref="Package.RepresentationClass" path="/summary" />
	/// </summary>
	public Package.RepresentationClass RepresentationClass => _RepresentationClass ?? (_RepresentationClass = new Package.RepresentationClass());

	private Package.ValueClass _ValueClass;
	/// <summary>
	/// <inheritdoc cref="Package.ValueClass" path="/summary" />
	/// </summary>
	public Package.ValueClass ValueClass => _ValueClass ?? (_ValueClass = new Package.ValueClass());

	private Package.TimeSeriesClass _TimeSeriesClass;
	/// <summary>
	/// <inheritdoc cref="Package.TimeSeriesClass" path="/summary" />
	/// </summary>
	public Package.TimeSeriesClass TimeSeriesClass => _TimeSeriesClass ?? (_TimeSeriesClass = new Package.TimeSeriesClass());

	private Package.DiscreteClass _DiscreteClass;
	/// <summary>
	/// <inheritdoc cref="Package.DiscreteClass" path="/summary" />
	/// </summary>
	public Package.DiscreteClass DiscreteClass => _DiscreteClass ?? (_DiscreteClass = new Package.DiscreteClass());

	private Package.DataSetClass _DataSetClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataSetClass" path="/summary" />
	/// </summary>
	public Package.DataSetClass DataSetClass => _DataSetClass ?? (_DataSetClass = new Package.DataSetClass());

	private Package.EntryClass _EntryClass;
	/// <summary>
	/// <inheritdoc cref="Package.EntryClass" path="/summary" />
	/// </summary>
	public Package.EntryClass EntryClass => _EntryClass ?? (_EntryClass = new Package.EntryClass());

	private Package.TableClass _TableClass;
	/// <summary>
	/// <inheritdoc cref="Package.TableClass" path="/summary" />
	/// </summary>
	public Package.TableClass TableClass => _TableClass ?? (_TableClass = new Package.TableClass());

	private Package.TableEntryClass _TableEntryClass;
	/// <summary>
	/// <inheritdoc cref="Package.TableEntryClass" path="/summary" />
	/// </summary>
	public Package.TableEntryClass TableEntryClass => _TableEntryClass ?? (_TableEntryClass = new Package.TableEntryClass());

	private Package.CellClass _CellClass;
	/// <summary>
	/// <inheritdoc cref="Package.CellClass" path="/summary" />
	/// </summary>
	public Package.CellClass CellClass => _CellClass ?? (_CellClass = new Package.CellClass());

	#endregion

	#region Enums
	#endregion
	}
}