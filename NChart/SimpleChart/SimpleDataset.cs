using System;
using System.Collections.Generic;
using System.Text;

namespace NChart.SimpleChart
{
    public class SimpleDataset
    {
        public string Label { get; set; }
        public IEnumerable<double> Data { get; set; }
        public IEnumerable<string> BackgroundColor { get; set; }
        public IEnumerable<string> HoverBackgroundColor { get; set; }
    }
}
