namespace NChart.ComplexChart.Line
{
    /// <summary>
    /// The line chart.
    /// </summary>
    public class LineChart : ComplexChartBase<LineChartOptions>
    {
        private readonly LineChartOptions chartOptions = new LineChartOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override ComplexChartType ChartType => ComplexChartType.Line;

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override LineChartOptions ChartConfiguration => chartOptions;
    }
}
