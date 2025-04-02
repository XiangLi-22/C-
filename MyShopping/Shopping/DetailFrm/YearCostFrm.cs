using Shopping.DetailFrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping.DetailImage
{
    public partial class YearCostFrm : Form
    {
        public MainFrm MainFrm;

        int year = Convert.ToInt32(DateTime.Now.Year);

        public YearCostFrm(MainFrm mainFrm)
        {
            InitializeComponent();
            MainFrm = mainFrm;
        }

        #region 窗体事件
        private void YearCostFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void YearCostFrm_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
        private void YearCostFrm_Load(object sender, EventArgs e)
        {
            BindMothCast();
        }
        #endregion

        #region 数据绑定
        private void BindMothCast()
        {
            this.panel5.Controls.Clear();
            YearMothFrm yearMothFrm = new YearMothFrm(year);
            yearMothFrm.TopLevel = false;
            yearMothFrm.FormBorderStyle = FormBorderStyle.None;
            yearMothFrm.Parent = this.panel5;
            yearMothFrm.Dock = DockStyle.Fill;
            yearMothFrm.Show();
        }
        private void BindTypeCast()
        {
            this.panel5.Controls.Clear();
            YearTypeFrm yearMothFrm = new YearTypeFrm(year);
            yearMothFrm.TopLevel = false;
            yearMothFrm.FormBorderStyle = FormBorderStyle.None;
            yearMothFrm.Parent = this.panel5;
            yearMothFrm.Dock = DockStyle.Fill;
            yearMothFrm.Show();
        }
        #endregion

        #region 查看图表
        private void btnMoth_Click(object sender, EventArgs e)
        {
            BindMothCast();
        }
        private void btnType_Click(object sender, EventArgs e)
        {
            BindTypeCast();
        }
        #endregion

        #region 美化窗体
        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // 抗锯齿
            g.CompositingQuality = CompositingQuality.HighQuality; // 组合图像质量
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; // 插值模式（影响缩放质量）
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; // 像素偏移模式，提升抗锯齿效果


            Font font = new Font("日系可爱情书体", 30, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.DeepPink);
            // 创建一个StringFormat并设置对齐方式
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;  // 水平居中
            stringFormat.LineAlignment = StringAlignment.Center; // 垂直居中

            string text = $"{year}年消费记录";

            //测量字体的大小
            SizeF size = g.MeasureString(text, font);
            g.DrawString(text, font, brush, new PointF(panel1.Width / 2, panel1.Height / 2), stringFormat);
        }
        #endregion

        #region 自定义控件点击事件
        private void returnButon1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainFrm.Show();
        }

        private void lastPageButton1_Click(object sender, EventArgs e)
        {
            year--;
            panel1.Invalidate();
            BindTypeCast();
            BindMothCast();
        }

        private void nextPageButton1_Click_1(object sender, EventArgs e)
        {
            year++;
            panel1.Invalidate();
            BindTypeCast();
            BindMothCast();
        }
        #endregion


    }
}
