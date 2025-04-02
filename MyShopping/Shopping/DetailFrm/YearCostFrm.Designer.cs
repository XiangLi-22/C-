namespace Shopping.DetailImage
{
    partial class YearCostFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnType = new Sunny.UI.UIButton();
            this.btnMoth = new Sunny.UI.UIButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lastPageButton1 = new Hepler.MyUserContorl.LastPageButton();
            this.returnButon1 = new Shopping.MyUserContorl.ReturnButon();
            this.nextPageButton1 = new Hepler.MyUserContorl.NextPageButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.btnType);
            this.panel2.Controls.Add(this.btnMoth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 553);
            this.panel2.TabIndex = 1;
            // 
            // btnType
            // 
            this.btnType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnType.Location = new System.Drawing.Point(28, 356);
            this.btnType.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(144, 52);
            this.btnType.TabIndex = 2;
            this.btnType.Text = "类型消费";
            this.btnType.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnMoth
            // 
            this.btnMoth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoth.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMoth.Location = new System.Drawing.Point(28, 162);
            this.btnMoth.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoth.Name = "btnMoth";
            this.btnMoth.Size = new System.Drawing.Size(144, 52);
            this.btnMoth.TabIndex = 1;
            this.btnMoth.Text = "月消费";
            this.btnMoth.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMoth.Click += new System.EventHandler(this.btnMoth_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 553);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1182, 510);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nextPageButton1);
            this.panel4.Controls.Add(this.lastPageButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 43);
            this.panel4.TabIndex = 0;
            // 
            // lastPageButton1
            // 
            this.lastPageButton1.Location = new System.Drawing.Point(3, -13);
            this.lastPageButton1.Name = "lastPageButton1";
            this.lastPageButton1.Size = new System.Drawing.Size(70, 70);
            this.lastPageButton1.TabIndex = 1;
            this.lastPageButton1.Click += new System.EventHandler(this.lastPageButton1_Click);
            // 
            // returnButon1
            // 
            this.returnButon1.Location = new System.Drawing.Point(23, 20);
            this.returnButon1.Name = "returnButon1";
            this.returnButon1.Size = new System.Drawing.Size(60, 60);
            this.returnButon1.TabIndex = 0;
            this.returnButon1.Click += new System.EventHandler(this.returnButon1_Click);
            // 
            // nextPageButton1
            // 
            this.nextPageButton1.Location = new System.Drawing.Point(1110, -13);
            this.nextPageButton1.Name = "nextPageButton1";
            this.nextPageButton1.Size = new System.Drawing.Size(70, 70);
            this.nextPageButton1.TabIndex = 2;
            this.nextPageButton1.Click += new System.EventHandler(this.nextPageButton1_Click_1);
            // 
            // YearCostFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "YearCostFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YearCostFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YearCostFrm_FormClosing);
            this.Load += new System.EventHandler(this.YearCostFrm_Load);
            this.Resize += new System.EventHandler(this.YearCostFrm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIButton btnType;
        private Sunny.UI.UIButton btnMoth;
        private System.Windows.Forms.Panel panel3;
        private MyUserContorl.ReturnButon returnButon1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Hepler.MyUserContorl.LastPageButton lastPageButton1;
        private Hepler.MyUserContorl.NextPageButton nextPageButton1;
    }
}