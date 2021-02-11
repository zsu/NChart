namespace NChart.ComplexChart.Bar
{
    /// <summary>
    /// The bar chart.
    /// </summary>
    public class BarChart : ComplexChartBase<BarChartOptions>
    {
        private readonly BarChartOptions chartOptions = new BarChartOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override ComplexChartType ChartType => ComplexChartType.Bar;

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override BarChartOptions ChartConfiguration => chartOptions;
    }
}
