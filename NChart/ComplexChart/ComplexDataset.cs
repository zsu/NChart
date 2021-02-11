using System.Collections.Generic;

namespace NChart.ComplexChart
{
    /// <summary>
    /// The complex dataset.
    /// </summary>
    public class ComplexDataset
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexDataset"/> class.
        /// </summary>
        public ComplexDataset()
        {
            Data = new List<double>();
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the dataset should be filled
        /// </summary>
        public bool Fill => string.IsNullOrWhiteSpace(BackgroundColor) == false;

                /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the border color.
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the point background colour.
        /// </summary>
        public string PointBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the point border colour.
        /// </summary>
        public string PointBorderColor { get; set; }

        /// <summary>
        /// Gets or sets the point hover background colour.
        /// </summary>
        public string PointHoverBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the point hover border colour.
        /// </summary>
        public string PointHoverBorderColor { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public List<double> Data { get; set; }
    }
}
