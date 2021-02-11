namespace NChart.ComplexChart.Bar
{
    /// <summary>
    /// The bar chart.
    /// </summary>
    public class HorizontalBarChart : BarChart
    {
        private readonly BarChartOptions chartOptions = new BarChartOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override ComplexChartType ChartType => ComplexChartType.HorizontalBar;

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override BarChartOptions ChartConfiguration => chartOptions;
    }
}
