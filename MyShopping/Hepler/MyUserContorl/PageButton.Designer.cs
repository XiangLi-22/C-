namespace Shopping.MyUserContorl
{
    partial class PageButton
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageButton));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbPrev = new System.Windows.Forms.ToolStripButton();
            this.tslCurrentPageAndTotalPage = new System.Windows.Forms.ToolStripLabel();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbTxtCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsbGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tscbPageSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFirst,
            this.tsbPrev,
            this.tslCurrentPageAndTotalPage,
            this.tsbNext,
            this.tsbLast,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tsbTxtCurrentPage,
            this.toolStripLabel3,
            this.tsbGo,
            this.toolStripSeparator2,
            this.toolStripLabel4,
            this.tscbPageSize,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1052, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbFirst
            // 
            this.tsbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsbFirst.Image")));
            this.tsbFirst.Name = "tsbFirst";
            this.tsbFirst.RightToLeftAutoMirrorImage = true;
            this.tsbFirst.Size = new System.Drawing.Size(29, 25);
            this.tsbFirst.Text = "移到第一条记录";
            this.tsbFirst.Click += new System.EventHandler(this.tsbFirst_Click);
            // 
            // tsbPrev
            // 
            this.tsbPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrev.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrev.Image")));
            this.tsbPrev.Name = "tsbPrev";
            this.tsbPrev.RightToLeftAutoMirrorImage = true;
            this.tsbPrev.Size = new System.Drawing.Size(29, 25);
            this.tsbPrev.Text = "移到上一条记录";
            this.tsbPrev.Click += new System.EventHandler(this.tsbPrev_Click);
            // 
            // tslCurrentPageAndTotalPage
            // 
            this.tslCurrentPageAndTotalPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(226)))));
            this.tslCurrentPageAndTotalPage.Name = "tslCurrentPageAndTotalPage";
            this.tslCurrentPageAndTotalPage.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tslCurrentPageAndTotalPage.Size = new System.Drawing.Size(73, 25);
            this.tslCurrentPageAndTotalPage.Text = "1/1";
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.RightToLeftAutoMirrorImage = true;
            this.tsbNext.Size = new System.Drawing.Size(29, 25);
            this.tsbNext.Text = "移到下一条记录";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbLast
            // 
            this.tsbLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbLast.Image")));
            this.tsbLast.Name = "tsbLast";
            this.tsbLast.RightToLeftAutoMirrorImage = true;
            this.tsbLast.Size = new System.Drawing.Size(29, 25);
            this.tsbLast.Text = "移到最后一条记录";
            this.tsbLast.Click += new System.EventHandler(this.tsbLast_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(24, 25);
            this.toolStripLabel1.Text = "第";
            // 
            // tsbTxtCurrentPage
            // 
            this.tsbTxtCurrentPage.BackColor = System.Drawing.Color.White;
            this.tsbTxtCurrentPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(226)))));
            this.tsbTxtCurrentPage.Name = "tsbTxtCurrentPage";
            this.tsbTxtCurrentPage.Size = new System.Drawing.Size(45, 31);
            this.tsbTxtCurrentPage.Text = "1";
            this.tsbTxtCurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tsbTxtCurrentPage.ToolTipText = "请输入页码";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(24, 25);
            this.toolStripLabel3.Text = "页";
            // 
            // tsbGo
            // 
            this.tsbGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbGo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(226)))));
            this.tsbGo.Image = ((System.Drawing.Image)(resources.GetObject("tsbGo.Image")));
            this.tsbGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGo.Name = "tsbGo";
            this.tsbGo.Size = new System.Drawing.Size(36, 25);
            this.tsbGo.Text = "GO";
            this.tsbGo.ToolTipText = "跳转";
            this.tsbGo.Click += new System.EventHandler(this.tsbGo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(39, 25);
            this.toolStripLabel4.Text = "每页";
            // 
            // tscbPageSize
            // 
            this.tscbPageSize.BackColor = System.Drawing.Color.White;
            this.tscbPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbPageSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(86)))), ((int)(((byte)(226)))));
            this.tscbPageSize.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.tscbPageSize.Name = "tscbPageSize";
            this.tscbPageSize.Size = new System.Drawing.Size(89, 28);
            this.tscbPageSize.SelectedIndexChanged += new System.EventHandler(this.tscbPageSize_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(24, 25);
            this.toolStripLabel2.Text = "条";
            // 
            // PageButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "PageButton";
            this.Size = new System.Drawing.Size(1052, 28);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbFirst;
        private System.Windows.Forms.ToolStripButton tsbPrev;
        private System.Windows.Forms.ToolStripLabel tslCurrentPageAndTotalPage;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tsbTxtCurrentPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton tsbGo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox tscbPageSize;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}
