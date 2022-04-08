using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace PlottingData
{
    internal partial class StatisticsForm : Form
    {
        /// <summary>
        /// Default Constuctor
        /// </summary>
        public StatisticsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor that takes in a dataset and extracts each column of data and plots it.
        /// </summary>
        /// <param name="data"></param>
        public StatisticsForm(DataSet data)
        {
            InitializeComponent();

            int heightOfPlot = 400;
            int widthOfPlot = 600;                     
            Dictionary<string, double[]> dictData = data.ToDict();
            double[] dictValues;

            // Creates a histogram for each element in the dictionary dictData.
            // Adds each plot to the flowlayoutpanel.
            foreach (string key in dictData.Keys)
            {
                FormsPlot plot = new FormsPlot();
                plot.Height = heightOfPlot;
                plot.Width = widthOfPlot;
                dictValues = dictData[key];
                //// Continues if data is null or empty.
                if (dictValues == null || dictValues.Length == 0)
                {
                    continue;
                }
                double binSize = (dictValues.Max() - dictValues.Min()) / 10;
                // Continues if binSize is 0.
                if (binSize == 0)
                {
                    continue;
                }

                // Creates the histogram
                (double[] counts, double[] binEdges) = ScottPlot.Statistics.Common.Histogram(dictValues,
                min: dictValues.Min(), max: dictValues.Max(), binSize: binSize);
                double[] leftEdges = binEdges.Take(binEdges.Length - 1).ToArray();

                // Adds a bar plot with the values of the histogram. Therefor adding a histogram.
                var bar = plot.Plot.AddBar(values: counts, positions: leftEdges);
                bar.FillColor = ColorTranslator.FromHtml("#9bc3eb");
                bar.BarWidth = binSize;

                // display histogram distribution curve as a line plot on a secondary Y axis
                double[] smoothEdges = ScottPlot.DataGen.Range(start: binEdges.First(), 
                    stop: binEdges.Last(), step: 0.1, includeStop: true);
                double[] smoothDensities = ScottPlot.Statistics.Common.ProbabilityDensity(dictValues, 
                    smoothEdges, percent: true);
                var probPlot = plot.Plot.AddScatterLines(
                    xs: smoothEdges,
                    ys: smoothDensities,
                    lineWidth: 2,
                    label: "probability");
                probPlot.YAxisIndex = 1;
                plot.Plot.YAxis2.Ticks(true);

                // display vertical lines at points of interest
                var stats = new ScottPlot.Statistics.BasicStats(dictValues);
                plot.Plot.AddVerticalLine(stats.Mean, Color.Red, 2, LineStyle.Solid, "mean");
                plot.Plot.AddVerticalLine(stats.Mean - stats.StDev, Color.OrangeRed, 
                    2, LineStyle.Dash, "1 SD");
                plot.Plot.AddVerticalLine(stats.Mean + stats.StDev, Color.OrangeRed, 
                    2, LineStyle.Dash);
                plot.Plot.AddVerticalLine(stats.Mean - stats.StDev * 2, Color.OrangeRed, 
                    2, LineStyle.Dot, "2 SD");
                plot.Plot.AddVerticalLine(stats.Mean + stats.StDev * 2, Color.OrangeRed, 2, LineStyle.Dot);
                plot.Plot.AddVerticalLine(stats.Min, Color.SteelBlue, 1, LineStyle.Dash, "min/max");
                plot.Plot.AddVerticalLine(stats.Max, Color.SteelBlue, 1, LineStyle.Dash);
                plot.Plot.Legend(location: Alignment.UpperRight);

                // Sets color of plot.
                plot.Plot.Palette = ScottPlot.Palette.OneHalfDark;
                plot.Plot.AxisAuto(0, 0.1);
                plot.Plot.Style(ScottPlot.Style.Gray1);
                var bnColor = System.Drawing.ColorTranslator.FromHtml("#2e3440");
                plot.Plot.Style(figureBackground: bnColor, dataBackground: bnColor);

                // Sets labels of the plot.
                plot.Plot.XLabel($"{key}");
                plot.Plot.YLabel("Count (#)");
                plot.Plot.Title($"{key} Histogram");
                plot.Plot.SetAxisLimits(yMin: 0);
                plot.Refresh();
                flpStatisticsForm.Controls.Add(plot);
            }
        }
    }
}
