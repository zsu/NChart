using NChart.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace NChart.SimpleChart
{
    /// <summary>
    /// The simple chart base.
    /// </summary>
    public abstract class SimpleChartBase<TSimpleChartOptions>
        where TSimpleChartOptions : SimpleChartOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleChartBase"/> class.
        /// </summary>
        protected SimpleChartBase()
        {
            Data = new List<SimpleData>();
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public List<SimpleData> Data { get; set; }

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public abstract SimpleChartType ChartType { get; }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public abstract TSimpleChartOptions ChartConfiguration { get; }

        public string GetDataJson() {
            var labels = new List<string>(Data.Count);
            var hoverBackgroundColour = Data.Select(x => x.HoverBackgroundColor);

            return new SimpleDataJson
            {
                Labels = Data.Select(x => x.Label),
                Datasets = new List<SimpleDataset> {
                    new SimpleDataset {
                        Label = "Dataset",
                        Data = Data.Select(x => x.Value),
                        BackgroundColor = Data.Select(x => x.BackgroundColor),
                        HoverBackgroundColor = hoverBackgroundColour.Any(x => string.IsNullOrWhiteSpace(x)) ? null : hoverBackgroundColour
                    }
                }
            }.ToJson();
        }
    }
}
