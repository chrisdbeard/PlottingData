namespace PlottingData
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
            this.tlpMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tlpMainForm.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
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
            this.tlpMainForm.Size = new System.Drawing.Size(142, 929);
            this.tlpMainForm.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnImport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImport.Location = new System.Drawing.Point(4, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(134, 44);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRawView
            // 
            this.btnRawView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRawView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRawView.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnRawView.FlatAppearance.BorderSize = 0;
            this.btnRawView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRawView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRawView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRawView.Location = new System.Drawing.Point(4, 55);
            this.btnRawView.Name = "btnRawView";
            this.btnRawView.Size = new System.Drawing.Size(134, 44);
            this.btnRawView.TabIndex = 1;
            this.btnRawView.Text = "Scatter Plot";
            this.btnRawView.UseVisualStyleBackColor = false;
            this.btnRawView.Click += new System.EventHandler(this.btnRawView_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatistics.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStatistics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStatistics.Location = new System.Drawing.Point(4, 106);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(134, 44);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Histogram";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Location = new System.Drawing.Point(4, 881);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(134, 44);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelMainForm
            // 
            this.panelMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm.Location = new System.Drawing.Point(142, 0);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(1267, 929);
            this.panelMainForm.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 929);
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

