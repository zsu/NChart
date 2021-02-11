using System.Collections.Generic;
using NChart.SimpleChart;

namespace NChart.Sample.Models
{
    public static class FakeSimpleChartData
    {
        public static List<SimpleData> Data
        {
            get
            {
                return new List<SimpleData>
                {
                    new SimpleData
                    {
                        Value = 300,
                        BackgroundColor = "#F7464A",
                        HoverBackgroundColor = "#FF5A5E",
                        Label = "Red"
                    },
                    new SimpleData
                    {
                        Value = 50,
                        BackgroundColor = "#46BFBD",
                        HoverBackgroundColor = "#5AD3D1",
                        Label = "Green"
                    },
                    new SimpleData
                    {
                        Value = 100,
                        BackgroundColor = "#FDB45C",
                        HoverBackgroundColor = "#FFC870",
                        Label = "Yellow"
                    }
                };
            }
        }
    }
}
