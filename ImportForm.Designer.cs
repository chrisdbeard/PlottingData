namespace PlottingData
{
    partial class ImportForm
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
            this.tbBrowse = new System.Windows.Forms.TextBox();
            this.tlpImportForm = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tlpImportForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBrowse
            // 
            this.tbBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbBrowse.Location = new System.Drawing.Point(123, 87);
            this.tbBrowse.Name = "tbBrowse";
            this.tbBrowse.Size = new System.Drawing.Size(353, 23);
            this.tbBrowse.TabIndex = 0;
            // 
            // tlpImportForm
            // 
            this.tlpImportForm.ColumnCount = 3;
            this.tlpImportForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpImportForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImportForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpImportForm.Controls.Add(this.tbBrowse, 1, 0);
            this.tlpImportForm.Controls.Add(this.label1, 0, 0);
            this.tlpImportForm.Controls.Add(this.btnBrowse, 2, 0);
            this.tlpImportForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpImportForm.Location = new System.Drawing.Point(0, 0);
            this.tlpImportForm.Name = "tlpImportForm";
            this.tlpImportForm.RowCount = 1;
            this.tlpImportForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImportForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpImportForm.Size = new System.Drawing.Size(599, 197);
            this.tlpImportForm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Location:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBrowse.Location = new System.Drawing.Point(482, 73);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(114, 51);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 197);
            this.Controls.Add(this.tlpImportForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.tlpImportForm.ResumeLayout(false);
            this.tlpImportForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbBrowse;
        private System.Windows.Forms.TableLayoutPanel tlpImportForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
    }
}