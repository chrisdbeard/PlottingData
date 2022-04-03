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
        public RawViewForm()
        {
            InitializeComponent();
        }

        public RawViewForm(DataSet data)
        {
            InitializeComponent();
            int heightOfPlot = 400;
            int widthOfPlot = 600;

            FormsPlot altitudePlot = new FormsPlot();
            altitudePlot.Height = heightOfPlot;
            altitudePlot.Width = widthOfPlot;
            double[] dataX = data.Data.Select(x => x.Time.ToOADate()).ToArray();            
            double[] dataY = data.Data.Select(x => x.Altitude).ToArray();
            altitudePlot.Plot.AddScatter(dataX, dataY);
            altitudePlot.Plot.XAxis.DateTimeFormat(true);
            altitudePlot.Plot.XLabel("Time");
            altitudePlot.Plot.YLabel("Altitude (ft)");
            altitudePlot.Plot.Title("Altitude vs Time");
            altitudePlot.Refresh();
            flpRawViewForm.Controls.Add(altitudePlot);

            FormsPlot pitchPlot = new FormsPlot();
            pitchPlot.Height = heightOfPlot;
            pitchPlot.Width = widthOfPlot;
            dataY = data.Data.Select(x => x.Pitch).ToArray();
            pitchPlot.Plot.AddScatter(dataX, dataY);
            pitchPlot.Plot.XAxis.DateTimeFormat(true);
            pitchPlot.Plot.XLabel("Time");
            pitchPlot.Plot.YLabel("Pitch (°)");
            pitchPlot.Plot.Title("Pitch vs Time");
            pitchPlot.Refresh();
            flpRawViewForm.Controls.Add(pitchPlot);

            FormsPlot bitRatePlot = new FormsPlot();
            bitRatePlot.Height = heightOfPlot;
            bitRatePlot.Width = widthOfPlot;
            dataY = data.Data.Select(x => x.BitRate).ToArray();
            bitRatePlot.Plot.AddScatter(dataX, dataY);
            bitRatePlot.Plot.XAxis.DateTimeFormat(true);
            bitRatePlot.Plot.XLabel("Time");
            bitRatePlot.Plot.YLabel("Bit Rate (Baud)");
            bitRatePlot.Plot.Title("Bit Rate vs Time");
            bitRatePlot.Refresh();
            flpRawViewForm.Controls.Add(bitRatePlot);

            FormsPlot slantRangePlot = new FormsPlot();
            slantRangePlot.Height = heightOfPlot;
            slantRangePlot.Width = widthOfPlot;
            dataY = data.Data.Select(x => x.SlantRange).ToArray();
            slantRangePlot.Plot.AddScatter(dataX, dataY);
            slantRangePlot.Plot.XAxis.DateTimeFormat(true);
            slantRangePlot.Plot.XLabel("Time");
            slantRangePlot.Plot.YLabel("Slant Range (ft)");
            slantRangePlot.Plot.Title("Slant Range vs Time");
            slantRangePlot.Refresh();
            flpRawViewForm.Controls.Add(slantRangePlot);

            FormsPlot distanceToTargetPlot = new FormsPlot();
            distanceToTargetPlot.Height = heightOfPlot;
            distanceToTargetPlot.Width = widthOfPlot;
            dataY = data.Data.Select(x => x.DistanceToTarget).ToArray();
            distanceToTargetPlot.Plot.AddScatter(dataX, dataY);
            distanceToTargetPlot.Plot.XAxis.DateTimeFormat(true);
            distanceToTargetPlot.Plot.XLabel("Time");
            distanceToTargetPlot.Plot.YLabel("Distance To Target (ft)");
            distanceToTargetPlot.Plot.Title("Distance To Target vs Time");
            distanceToTargetPlot.Refresh();
            flpRawViewForm.Controls.Add(distanceToTargetPlot);

            FormsPlot rollPlot = new FormsPlot();
            rollPlot.Height = heightOfPlot;
            rollPlot.Width = widthOfPlot;
            dataY = data.Data.Select(x => x.Roll).ToArray();
            rollPlot.Plot.AddScatter(dataX, dataY);
            rollPlot.Plot.XAxis.DateTimeFormat(true);
            rollPlot.Plot.XLabel("Time");
            rollPlot.Plot.YLabel("Roll (°)");
            rollPlot.Plot.Title("Roll vs Time");
            rollPlot.Refresh();
            flpRawViewForm.Controls.Add(rollPlot);

            FormsPlot pressurePlot = new FormsPlot();
            pressurePlot.Height = heightOfPlot;
            pressurePlot.Width = widthOfPlot;
            dataY = data.Data.Select(x => x.Pressure).ToArray();
            pressurePlot.Plot.AddScatter(dataX, dataY);
            pressurePlot.Plot.XAxis.DateTimeFormat(true);
            pressurePlot.Plot.XLabel("Time");
            pressurePlot.Plot.YLabel("Pressure (mmHG)");
            pressurePlot.Plot.Title("Pressure vs Time");
            pressurePlot.Refresh();
            flpRawViewForm.Controls.Add(pressurePlot);
        }
    }
}
