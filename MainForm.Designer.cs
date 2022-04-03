﻿namespace PlottingData
{
    partial class MainForm
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
            this.tlpMainForm = new System.Windows.Forms.TableLayoutPanel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRawView = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelMainForm = new System.Windows.Forms.Panel();
            this.tlpMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainForm
            // 
            this.tlpMainForm.ColumnCount = 1;
            this.tlpMainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainForm.Controls.Add(this.btnImport, 0, 0);
            this.tlpMainForm.Controls.Add(this.btnRawView, 0, 1);
            this.tlpMainForm.Controls.Add(this.btnStatistics, 0, 2);
            this.tlpMainForm.Controls.Add(this.btnSettings, 0, 4);
            this.tlpMainForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpMainForm.Location = new System.Drawing.Point(0, 0);
            this.tlpMainForm.Name = "tlpMainForm";
            this.tlpMainForm.RowCount = 5;
            this.tlpMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMainForm.Size = new System.Drawing.Size(142, 896);
            this.tlpMainForm.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnImport.Location = new System.Drawing.Point(3, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(136, 44);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRawView
            // 
            this.btnRawView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRawView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRawView.Location = new System.Drawing.Point(3, 53);
            this.btnRawView.Name = "btnRawView";
            this.btnRawView.Size = new System.Drawing.Size(136, 44);
            this.btnRawView.TabIndex = 1;
            this.btnRawView.Text = "Raw View";
            this.btnRawView.UseVisualStyleBackColor = true;
            this.btnRawView.Click += new System.EventHandler(this.btnRawView_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStatistics.Location = new System.Drawing.Point(3, 103);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(136, 44);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSettings.Location = new System.Drawing.Point(3, 849);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(136, 44);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelMainForm
            // 
            this.panelMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm.Location = new System.Drawing.Point(142, 0);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(1412, 896);
            this.panelMainForm.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 896);
            this.Controls.Add(this.panelMainForm);
            this.Controls.Add(this.tlpMainForm);
            this.MinimumSize = new System.Drawing.Size(812, 452);
            this.Name = "MainForm";
            this.Text = "Data Viewer";
            this.tlpMainForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainForm;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnRawView;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelMainForm;
    }
}

