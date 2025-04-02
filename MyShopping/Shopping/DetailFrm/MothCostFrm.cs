using BLL;
using Domains;
using Shopping.DetailFrm;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Shopping.DetailImage
{
    public partial class MothCostFrm : Form
    {
        public MainFrm MainFrm;
        MothCastBLL mothCastBLL = new MothCastBLL();
        public MothCostFrm(MainFrm mainFrm)
        {
            InitializeComponent();
            MainFrm = mainFrm;
        }

        #region 窗体事件
        private void MothCostFrm_Load(object sender, EventArgs e)
        {
            dtpSelTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
            mothCastBLL.Add();
            BindLiveView();
            BindDataGirdView();
        }
        private void MothCostFrm_Resize(object sender, EventArgs e)
        {
            BindLiveView();
            panel1.Invalidate();
        }
        private void MothCostFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 数据绑定事件
        private void BindLiveView()
        {
            List<GoodsType> list = new List<GoodsType>();
            for (int i = 1; i < 19; i++)
            {
                list.Add((GoodsType)i);
            }
            lbShowType.DataSource = list;
        }
        private void BindDataGirdView()
        {
            var option = new UIPieOption();

            option.Title = new UITitle();
            option.Title.Text = "";
            option.Title.SubText = "";

            option.ToolTip.Visible = true;

            //legend的位置
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Right;

            //legend的数据绑定
            List<GoodsType> list = new List<GoodsType>();
            for (int i = 1; i < 19; i++)
            {
                list.Add((GoodsType)i);
            }
            for (int i = 0; i < 18; i++)
            {
                option.Legend.AddData(list[i].ToString());
            }
            option.Legend.AddData("剩余金额");

            //series 位置
            var series = new UIPieSeries();
            series.Name = "";
            series.Center = new UICenter(35, 50);
            series.Radius = 70;
            //series.Label.Show = true;

            //series 数据绑定
            for(int i = 0;i < 18;i++)
            {
                double value = mothCastBLL.GetMothTypePrice(i+1);
                //判断如果类型没有值的时候跳过
                if (value == 0) continue;
                series.AddData(list[i].ToString(), value);
            }
            series.AddData("剩余金额", mothCastBLL.GetCurrentMonth().TotalRemain);

            //series绑定
            option.Series.Clear();
            option.Series.Add(series);

            //显示数据的小数个数
            //option.DecimalPlaces = 1;

            //option绑定
            uPieChart.SetOption(option);

            //允许和用户交互
            uPieChart.Enabled = true;
        }
        #endregion   

        #region 美化页面
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateTime dateTime = DateTime.Now;

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

            string text = $"{dateTime.Year}年{dateTime.Month}月消费详情";

            //测量字体的大小
            SizeF size = g.MeasureString(text, font);
            g.DrawString(text, font, brush, new PointF(panel1.Width / 2, panel1.Height / 2), stringFormat);
        }
        #endregion

        #region 查询跳转
        private void btnGoType_Click(object sender, EventArgs e)
        {
            int t = lbShowType.SelectedIndex + 1;
            TypeFrm typeFrm = new TypeFrm(this,t);
            typeFrm.Show();
            this.Hide();
        }

        private void btnGoTime_Click(object sender, EventArgs e)
        {
            DateTime time = dtpSelTime.Value;
            DayCostFrm dayCostFrm = new DayCostFrm(this,true,time);
            this.Hide();
            dayCostFrm.Show();
        }
        #endregion

        #region 返回主窗体
        private void returnButon1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainFrm.Show();
        }
        #endregion


    }
}
