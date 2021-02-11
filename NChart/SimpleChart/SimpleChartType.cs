using System.ComponentModel;

namespace NChart.SimpleChart
{
    /// <summary>
    /// The simple chart type.
    /// </summary>
    public enum SimpleChartType
    {
        /// <summary>
        /// The polar area.
        /// </summary>
        [Description("polarArea")]
        PolarArea = 0,

        /// <summary>
        /// The pie.
        /// </summary>
        [Description("pie")]
        Pie = 1,

        /// <summary>
        /// The doughnut.
        /// </summary>
        [Description("doughnut")]
        Doughnut = 2
    }
}
