namespace Shopping.DetailFrm
{
    partial class YearTypeFrm
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
            this.uiBarChart1 = new Sunny.UI.UIBarChart();
            this.SuspendLayout();
            // 
            // uiBarChart1
            // 
            this.uiBarChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiBarChart1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBarChart1.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBarChart1.Location = new System.Drawing.Point(0, 0);
            this.uiBarChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBarChart1.Name = "uiBarChart1";
            this.uiBarChart1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiBarChart1.Size = new System.Drawing.Size(1164, 463);
            this.uiBarChart1.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBarChart1.TabIndex = 0;
            this.uiBarChart1.Text = "uiBarChart1";
            // 
            // YearTypeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1164, 463);
            this.Controls.Add(this.uiBarChart1);
            this.Name = "YearTypeFrm";
            this.Text = "YearTypeFrm";
            this.Load += new System.EventHandler(this.YearTypeFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIBarChart uiBarChart1;
    }
}