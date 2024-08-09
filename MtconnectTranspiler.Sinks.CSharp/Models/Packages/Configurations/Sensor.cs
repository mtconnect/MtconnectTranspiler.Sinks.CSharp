using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.Sensor;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>
	/// This section provides semantic information for the <see cref="SensorConfiguration">SensorConfiguration</see> entity.  <i>sensor</i> is a unique type of a piece of equipment.  A <i>sensor</i> is typically comprised of two major components: a <i>sensor unit</i> that provides signal processing, conversion, and communications and the <i>sensing element</i>s that provides a signal or measured value.  The <i>sensor unit</i> is modeled as a <i>lower level</i> <see cref="Component">Component</see> called <see cref="Sensor">Sensor</see>.  The <i>sensing element</i> may be modeled as a <see cref="Composition">Composition</see> element of a <see cref="Sensor">Sensor</see> element and the measured value would be modeled as a <see cref="DataItem">DataItem</see> (See <see cref="DataItems">DataItems</see> for more information on <see cref="DataItem">DataItem</see> elements).  Each <i>sensor unit</i> may have multiple <i>sensing element</i>s; each representing the data for a variety of measured values.  ![Sensing Element provided as a DataItem Example](figures/Sensing%20Element%20provided%20as%20a%20DataItem%20Example.png "Sensing Element provided as a DataItem Example"){: width="0.8"}  > Note: See {{lst(example-of-sensing-element-provided-as-data-item-associated-with-a-component)}} for an <i>XML</i> example.  When a <i>sensor unit</i> is modeled as a <see cref="Component">Component</see> or as a separate piece of equipment, it may provide additional configuration information for the <i>sensor element</i>s and the <i>sensor unit</i> itself.    ![Sensor for Rotary Axis Example](figures/Sensor%20for%20Rotary%20Axis%20Example.png "Sensor for Rotary Axis Example"){: width="0.8"}  > Note: If a <see cref="Sensor">Sensor</see> provides vibration measurement data for the spindle on a piece of equipment, it could be modeled as a <see cref="Sensor">Sensor</see> for rotary axis named <c>C</c>. See {{lst(example-of-sensor-for-rotary-axis)}} for an <i>XML</i> example.  ![Sensor unit with Sensing Elements Example](figures/Sensor%20unit%20with%20Sensing%20Elements%20Example.png "Sensor unit with Sensing Elements Example"){: width="0.8"}  > Note: If a <see cref="Sensor">Sensor</see> provides measurement data for multiple <see cref="Component">Component</see> elements within a piece of equipment and is not associated with any particular <see cref="Component">Component</see>, it <b>MAY</b> be modeled as an independent <see cref="Component">Component</see> and the data associated with measurements are associated with their associated <see cref="Component">Component</see> entities. See {{lst(example-of-sensor-unit-with-sensing-element)}} for an <i>XML</i> example.  <see cref="Configuration">Configuration</see> data provides information required for maintenance and support of the sensor.  When <see cref="Sensor">Sensor</see> represents the <i>sensor unit</i> for multiple <i>sensing element</i>(s), each sensing element is represented by a <see cref="Channel">Channel</see>.   The <i>sensor unit</i> itself and each <see cref="Channel">Channel</see> representing one <i>sensing element</i> <b>MAY</b> have its own configuration data.  ![Sensor Configuration Example](figures/Sensor%20Configuration%20Example.png "Sensor Configuration Example"){: width="0.8"}  > Note: See {{lst(example-of-configuration-data-for-sensor)}} for an <i>XML</i> example. 
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_2799F394_9540_4e1f_8171_D8E5BC08A63E">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class SensorPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_2799F394_9540_4e1f_8171_D8E5BC08A63E";
		
		/// <inheritdoc />
		public string Name => "Sensor";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""SensorConfiguration"">SensorConfiguration</see> entity.  <i>sensor</i> is a unique type of a piece of equipment.  A <i>sensor</i> is typically comprised of two major components: a <i>sensor unit</i> that provides signal processing, conversion, and communications and the <i>sensing element</i>s that provides a signal or measured value.  The <i>sensor unit</i> is modeled as a <i>lower level</i> <see cref=""Component"">Component</see> called <see cref=""Sensor"">Sensor</see>.  The <i>sensing element</i> may be modeled as a <see cref=""Composition"">Composition</see> element of a <see cref=""Sensor"">Sensor</see> element and the measured value would be modeled as a <see cref=""DataItem"">DataItem</see> (See <see cref=""DataItems"">DataItems</see> for more information on <see cref=""DataItem"">DataItem</see> elements).  Each <i>sensor unit</i> may have multiple <i>sensing element</i>s; each representing the data for a variety of measured values.  ![Sensing Element provided as a DataItem Example](figures/Sensing%20Element%20provided%20as%20a%20DataItem%20Example.png ""Sensing Element provided as a DataItem Example""){: width=""0.8""}  > Note: See {{lst(example-of-sensing-element-provided-as-data-item-associated-with-a-component)}} for an <i>XML</i> example.  When a <i>sensor unit</i> is modeled as a <see cref=""Component"">Component</see> or as a separate piece of equipment, it may provide additional configuration information for the <i>sensor element</i>s and the <i>sensor unit</i> itself.    ![Sensor for Rotary Axis Example](figures/Sensor%20for%20Rotary%20Axis%20Example.png ""Sensor for Rotary Axis Example""){: width=""0.8""}  > Note: If a <see cref=""Sensor"">Sensor</see> provides vibration measurement data for the spindle on a piece of equipment, it could be modeled as a <see cref=""Sensor"">Sensor</see> for rotary axis named <c>C</c>. See {{lst(example-of-sensor-for-rotary-axis)}} for an <i>XML</i> example.  ![Sensor unit with Sensing Elements Example](figures/Sensor%20unit%20with%20Sensing%20Elements%20Example.png ""Sensor unit with Sensing Elements Example""){: width=""0.8""}  > Note: If a <see cref=""Sensor"">Sensor</see> provides measurement data for multiple <see cref=""Component"">Component</see> elements within a piece of equipment and is not associated with any particular <see cref=""Component"">Component</see>, it <b>MAY</b> be modeled as an independent <see cref=""Component"">Component</see> and the data associated with measurements are associated with their associated <see cref=""Component"">Component</see> entities. See {{lst(example-of-sensor-unit-with-sensing-element)}} for an <i>XML</i> example.  <see cref=""Configuration"">Configuration</see> data provides information required for maintenance and support of the sensor.  When <see cref=""Sensor"">Sensor</see> represents the <i>sensor unit</i> for multiple <i>sensing element</i>(s), each sensing element is represented by a <see cref=""Channel"">Channel</see>.   The <i>sensor unit</i> itself and each <see cref=""Channel"">Channel</see> representing one <i>sensing element</i> <b>MAY</b> have its own configuration data.  ![Sensor Configuration Example](figures/Sensor%20Configuration%20Example.png ""Sensor Configuration Example""){: width=""0.8""}  > Note: See {{lst(example-of-configuration-data-for-sensor)}} for an <i>XML</i> example. ";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			SensorConfigurationClass,
			ChannelClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.SensorConfigurationClass _SensorConfigurationClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorConfigurationClass" path="/summary" />
	/// </summary>
	public Package.SensorConfigurationClass SensorConfigurationClass => _SensorConfigurationClass ?? (_SensorConfigurationClass = new Package.SensorConfigurationClass());

	private Package.ChannelClass _ChannelClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChannelClass" path="/summary" />
	/// </summary>
	public Package.ChannelClass ChannelClass => _ChannelClass ?? (_ChannelClass = new Package.ChannelClass());

	#endregion
	}
}