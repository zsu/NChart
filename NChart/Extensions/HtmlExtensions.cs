using NChart.ComplexChart;
using NChart.SimpleChart;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

namespace NChart.Extensions
{
    /// <summary>
    /// The html extensions.
    /// </summary>
    public static class HtmlExtensions
    {
        /// <summary>
        /// The create chart.
        /// </summary>
        /// <param name="htmlHelper">
        /// The html helper.
        /// </param>
        /// <param name="canvasId">
        /// The canvas id.
        /// </param>
        /// <param name="complexChart">
        /// The complex chart.
        /// </param>
        /// <returns>
        /// The <see cref="HtmlString"/>.
        /// </returns>
        public static IHtmlContent CreateChart<TComplexChartOptions>(this IHtmlHelper htmlHelper, string canvasId, ComplexChartBase<TComplexChartOptions> complexChart) where TComplexChartOptions : ComplexChartOptions
        {
            return CreateChart(canvasId, complexChart.ChartType.GetDescription(), complexChart.ComplexData.ToJson(), complexChart.ChartConfiguration.ToJson());
        }

        /// <summary>
        /// The create chart.
        /// </summary>
        /// <param name="htmlHelper">
        /// The html helper.
        /// </param>
        /// <param name="canvasId">
        /// The canvas id.
        /// </param>
        /// <param name="simpleChart">
        /// The simple chart.
        /// </param>
        /// <returns>
        /// The <see cref="HtmlString"/>.
        /// </returns>
        public static IHtmlContent CreateChart<TSimpleChartOptions>(this IHtmlHelper htmlHelper, string canvasId, SimpleChartBase<TSimpleChartOptions> simpleChart) where TSimpleChartOptions : SimpleChartOptions
        {
            return CreateChart(canvasId, simpleChart.ChartType.GetDescription(), simpleChart.GetDataJson(), simpleChart.ChartConfiguration.ToJson());
        }

        private static IHtmlContent CreateChart(string canvasId, string chartType, string jsonData, string jsonOptions)
        {
            var tag = new TagBuilder("script");
            tag.Attributes.Add("type", "text/javascript");
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("var ctx = document.getElementById(\"{0}\").getContext(\"2d\");", canvasId);
            stringBuilder.AppendFormat("var data = JSON.parse('{0}');", jsonData);
            stringBuilder.AppendFormat("var options = JSON.parse('{0}');", jsonOptions);
            stringBuilder.AppendFormat("var {0}_chart = new Chart(ctx, {{ type: '{1}', data: data, options: options }});", canvasId, chartType);
            tag.InnerHtml.SetHtmlContent(stringBuilder.ToString());
            return tag;
        }
    }
}
