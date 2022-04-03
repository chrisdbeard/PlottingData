﻿using System;
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
    public partial class MainForm : Form
    {
        private DataViewerController dataViewerController { get; set; }
        private Form CurrentForm { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.dataViewerController = new DataViewerController();

            this.CurrentForm = new ImportForm();
            LoadForm();
        }

        private void LoadForm()
        {
            CurrentForm.TopLevel = false;
            CurrentForm.AutoScroll = true;
            CurrentForm.Dock = DockStyle.Fill;
            this.panelMainForm.Controls.Clear();
            this.panelMainForm.Controls.Add(CurrentForm);
            CurrentForm.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            this.CurrentForm = new ImportForm();
            LoadForm();
        }

        private void btnRawView_Click(object sender, EventArgs e)
        {
            if (this.CurrentForm is ImportForm)
            {
                ImportForm frm = (ImportForm)this.CurrentForm;
                dataViewerController.ReadDataSet(frm.FilePath);
            }
            this.CurrentForm = new RawViewForm(dataViewerController.Data);
            LoadForm();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (this.CurrentForm is ImportForm)
            {
                ImportForm frm = (ImportForm)this.CurrentForm;
                dataViewerController.ReadDataSet(frm.FilePath);
            }
            this.CurrentForm = new StatisticsForm();
            LoadForm();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}