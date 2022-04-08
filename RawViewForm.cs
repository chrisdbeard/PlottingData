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
    internal partial class RawViewForm : Form
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public RawViewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor that takes in a dataset and extracts each column of data and plots it.
        /// </summary>
        /// <param name="data"></param>
        public RawViewForm(DataSet data)
        {
            InitializeComponent();

            int heightOfPlot = 400;
            int widthOfPlot = 600;
            Dictionary<string, double[]> dictData = data.ToDict();
            double[] dictValues;
            double[] dataX;
            List<string> keys = new List<string>();
            
            // Creates a scatterplot for each element in the dictionary dictData.
            // Adds each plot to the flowlayoutpanel.
            foreach (string key in dictData.Keys)
            {
                FormsPlot plot = new FormsPlot();
                dataX = dictData["Time"];
                //dictData.Remove(dictData.Keys.First());
                keys.Add(key);
                dictValues = dictData[key];
                // Continues if data is null or empty.
                if (dictValues == null || dictValues.Length == 0)
                {
                    continue;
                }                              
                plot.Height = heightOfPlot;
                plot.Width = widthOfPlot;
                plot.Plot.AddScatter(dataX, dictValues);
            
                // Sets color of plot.
                plot.Plot.Palette = ScottPlot.Palette.OneHalfDark;
                plot.Plot.AxisAuto(0, 0.1);
                plot.Plot.Style(ScottPlot.Style.Gray1);
                var bnColor = System.Drawing.ColorTranslator.FromHtml("#2e3440");
                plot.Plot.Style(figureBackground: bnColor, dataBackground: bnColor);
            
                // Sets labels of the plot.
                plot.Plot.XAxis.DateTimeFormat(true);
                plot.Plot.XLabel($"{keys[0]}");
                plot.Plot.YLabel($"{key}");
                plot.Plot.Title($"{key} vs {keys[0]}");
                plot.Refresh();
                flpRawViewForm.Controls.Add(plot);
            }
        }
    }
}
