﻿namespace PlottingData
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpStatisticsForm = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpStatisticsForm
            // 
            this.flpStatisticsForm.AutoScroll = true;
            this.flpStatisticsForm.BackColor = System.Drawing.Color.Transparent;
            this.flpStatisticsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpStatisticsForm.Location = new System.Drawing.Point(0, 0);
            this.flpStatisticsForm.Name = "flpStatisticsForm";
            this.flpStatisticsForm.Size = new System.Drawing.Size(800, 450);
            this.flpStatisticsForm.TabIndex = 0;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpStatisticsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpStatisticsForm;
    }
}