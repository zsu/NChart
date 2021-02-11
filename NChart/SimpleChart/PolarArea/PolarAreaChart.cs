using Chart.Mvc.SimpleChart;

namespace NChart.SimpleChart.PolarArea
{
    /// <summary>
    /// The polar area chart.
    /// </summary>
    public class PolarAreaChart : SimpleChartBase<PolarAreaOptions>
    {
        private readonly PolarAreaOptions chartOptions = new PolarAreaOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override SimpleChartType ChartType => SimpleChartType.PolarArea;

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override PolarAreaOptions ChartConfiguration => chartOptions;
    }
}
