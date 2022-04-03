using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlottingData
{
    public partial class ImportForm : Form
    {
        public string FilePath { get; set; }

        public ImportForm()
        {
            InitializeComponent();

            // DEBUG code
            if (Environment.UserName == "heart")
            {
                tbBrowse.Text = @"C:\Users\heart\Documents\Programming\Data\Datasets\Dataset_small.csv";
                this.FilePath = @"C:\Users\heart\Documents\Programming\Data\Datasets\Dataset_small.csv";
            }
        }

        /// <summary>
        /// Sets the Data file location based on the users input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "CSV files(*.csv)| *.csv| Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbBrowse.Text = openFileDialog.FileName;
                this.FilePath = tbBrowse.Text;
            }
        }
    }
}
