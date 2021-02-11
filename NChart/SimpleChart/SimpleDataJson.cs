using System.Collections.Generic;

namespace NChart.SimpleChart
{
    public class SimpleDataJson
    {
        public IList<SimpleDataset> Datasets { get; set; }
        public IEnumerable<string> Labels { get; set; }
    }
}
