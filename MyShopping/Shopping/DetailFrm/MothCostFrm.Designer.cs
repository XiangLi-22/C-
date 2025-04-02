namespace Shopping.DetailImage
{
    partial class MothCostFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.returnButon1 = new Shopping.MyUserContorl.ReturnButon();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.dtpSelTime = new Sunny.UI.UIDatePicker();
            this.lbShowType = new Sunny.UI.UIListBox();
            this.btnGoType = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnGoTime = new Sunny.UI.UIButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uPieChart = new Sunny.UI.UIPieChart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.returnButon1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // returnButon1
            // 
            this.returnButon1.Location = new System.Drawing.Point(23, 20);
            this.returnButon1.Name = "returnButon1";
            this.returnButon1.Size = new System.Drawing.Size(60, 60);
            this.returnButon1.TabIndex = 0;
            this.returnButon1.Click += new System.EventHandler(this.returnButon1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.uiGroupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 553);
            this.panel2.TabIndex = 1;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.Controls.Add(this.dtpSelTime);
            this.uiGroupBox1.Controls.Add(this.lbShowType);
            this.uiGroupBox1.Controls.Add(this.btnGoType);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.btnGoTime);
            this.uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiGroupBox1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(4, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(344, 548);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "查询条件";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpSelTime
            // 
            this.dtpSelTime.FillColor = System.Drawing.Color.White;
            this.dtpSelTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpSelTime.Location = new System.Drawing.Point(71, 46);
            this.dtpSelTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpSelTime.MaxLength = 10;
            this.dtpSelTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpSelTime.Name = "dtpSelTime";
            this.dtpSelTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpSelTime.Size = new System.Drawing.Size(150, 29);
            this.dtpSelTime.SymbolDropDown = 61555;
            this.dtpSelTime.SymbolNormal = 61555;
            this.dtpSelTime.SymbolSize = 24;
            this.dtpSelTime.TabIndex = 1;
            this.dtpSelTime.Text = "2025-03-29";
            this.dtpSelTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpSelTime.Value = new System.DateTime(2025, 3, 29, 9, 27, 2, 248);
            this.dtpSelTime.Watermark = "";
            // 
            // lbShowType
            // 
            this.lbShowType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShowType.FillColor = System.Drawing.Color.White;
            this.lbShowType.FillColor2 = System.Drawing.Color.White;
            this.lbShowType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbShowType.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbShowType.ItemSelectForeColor = System.Drawing.Color.White;
            this.lbShowType.Location = new System.Drawing.Point(71, 142);
            this.lbShowType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbShowType.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbShowType.Name = "lbShowType";
            this.lbShowType.Padding = new System.Windows.Forms.Padding(2);
            this.lbShowType.ShowText = false;
            this.lbShowType.Size = new System.Drawing.Size(251, 351);
            this.lbShowType.TabIndex = 7;
            this.lbShowType.Text = "uiListBox1";
            // 
            // btnGoType
            // 
            this.btnGoType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoType.Location = new System.Drawing.Point(222, 506);
            this.btnGoType.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGoType.Name = "btnGoType";
            this.btnGoType.Size = new System.Drawing.Size(100, 35);
            this.btnGoType.TabIndex = 2;
            this.btnGoType.Text = "查询类型";
            this.btnGoType.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoType.Click += new System.EventHandler(this.btnGoType_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(8, 143);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(72, 23);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "类型:";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(8, 52);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(72, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "日期:";
            // 
            // btnGoTime
            // 
            this.btnGoTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoTime.Location = new System.Drawing.Point(222, 94);
            this.btnGoTime.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGoTime.Name = "btnGoTime";
            this.btnGoTime.Size = new System.Drawing.Size(100, 35);
            this.btnGoTime.TabIndex = 1;
            this.btnGoTime.Text = "查询日期";
            this.btnGoTime.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoTime.Click += new System.EventHandler(this.btnGoTime_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.uPieChart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(355, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 553);
            this.panel3.TabIndex = 2;
            // 
            // uPieChart
            // 
            this.uPieChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPieChart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uPieChart.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uPieChart.Location = new System.Drawing.Point(162, 0);
            this.uPieChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.uPieChart.Name = "uPieChart";
            this.uPieChart.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uPieChart.Size = new System.Drawing.Size(702, 547);
            this.uPieChart.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uPieChart.TabIndex = 0;
            this.uPieChart.Text = "uiPieChart1";
            // 
            // MothCostFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MothCostFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MothCostFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MothCostFrm_FormClosing);
            this.Load += new System.EventHandler(this.MothCostFrm_Load);
            this.Resize += new System.EventHandler(this.MothCostFrm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UIPieChart uPieChart;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton btnGoType;
        private Sunny.UI.UIButton btnGoTime;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIListBox lbShowType;
        private Sunny.UI.UIDatePicker dtpSelTime;
        private MyUserContorl.ReturnButon returnButon1;
    }
}