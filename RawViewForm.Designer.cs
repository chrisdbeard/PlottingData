namespace PlottingData
{
    internal partial class RawViewForm
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
            this.flpRawViewForm = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpRawViewForm
            // 
            this.flpRawViewForm.AutoScroll = true;
            this.flpRawViewForm.BackColor = System.Drawing.Color.Transparent;
            this.flpRawViewForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRawViewForm.Location = new System.Drawing.Point(0, 0);
            this.flpRawViewForm.Name = "flpRawViewForm";
            this.flpRawViewForm.Size = new System.Drawing.Size(800, 450);
            this.flpRawViewForm.TabIndex = 0;
            // 
            // RawViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpRawViewForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RawViewForm";
            this.Text = "RawViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRawViewForm;
    }
}