namespace Shopping.DetailFrm
{
    partial class YearMothFrm
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
            this.uiLineChart1 = new Sunny.UI.UILineChart();
            this.SuspendLayout();
            // 
            // uiLineChart1
            // 
            this.uiLineChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLineChart1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart1.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart1.Location = new System.Drawing.Point(0, 0);
            this.uiLineChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart1.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            this.uiLineChart1.Name = "uiLineChart1";
            this.uiLineChart1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiLineChart1.Size = new System.Drawing.Size(1164, 463);
            this.uiLineChart1.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLineChart1.TabIndex = 0;
            this.uiLineChart1.Text = "uiLineChart1";
            // 
            // YearMothFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1164, 463);
            this.Controls.Add(this.uiLineChart1);
            this.Name = "YearMothFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YearMothFrm";
            this.Load += new System.EventHandler(this.YearMothFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILineChart uiLineChart1;
    }
}