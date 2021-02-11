using System.ComponentModel;

namespace NChart.ComplexChart
{
    /// <summary>
    /// The complex chart type.
    /// </summary>
    public enum ComplexChartType
    {
        /// <summary>
        /// The line.
        /// </summary>
        [Description("line")]
        Line = 0,

        /// <summary>
        /// The bar.
        /// </summary>
        [Description("bar")]
        Bar = 1,

        /// <summary>
        /// The radar.
        /// </summary>
        [Description("radar")]
        Radar = 2,

        [Description("horizontalBar")]
        HorizontalBar=4
    }
}
