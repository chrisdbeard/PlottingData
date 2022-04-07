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
            foreach (string key in dictData.Keys)
            {
                FormsPlot plot = new FormsPlot();
                plot.Height = heightOfPlot;
                plot.Width = widthOfPlot;
                dictValues = dictData[key];
                if (dictValues == null || dictValues.Length == 0)
                {
                    continue;
                }
                double binSize = (dictValues.Max() - dictValues.Min()) / 10;
                if (binSize == 0)
                {
                    continue;
                }

                (double[] counts, double[] binEdges) = ScottPlot.Statistics.Common.Histogram(dictValues,
                min: dictValues.Min(), max: dictValues.Max(), binSize: binSize);
                double[] leftEdges = binEdges.Take(binEdges.Length - 1).ToArray();

                var bar = plot.Plot.AddBar(values: counts, positions: leftEdges);
                bar.BarWidth = binSize;

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
