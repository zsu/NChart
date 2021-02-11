namespace NChart.SimpleChart.Pie
{
    /// <summary>
    /// The pie chart.
    /// </summary>
    public class PieChart : SimpleChartBase<PieChartOptions>
    {
        private readonly PieChartOptions chartOptions = new PieChartOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override SimpleChartType ChartType => SimpleChartType.Pie;

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override PieChartOptions ChartConfiguration => chartOptions;
    }
}
