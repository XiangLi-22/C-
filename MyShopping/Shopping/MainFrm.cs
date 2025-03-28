using BLL;
using Maticsoft.Model;
using Shopping.DetailImage;
using SQLDAL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping
{
    public partial class MainFrm : Form
    {
        DayCastBLL dayCastBLL = new DayCastBLL();

        static float totalMoney = 1500;  //总限额

        static float money;       //历史消费=总限额 - 剩余金额

        static float remainMoney;   //剩余金额

        string message = string.Empty;

        public MainFrm()
        {
            InitializeComponent();
            remainMoney = dayCastBLL.GetLastRemainMoney();
            money = totalMoney - remainMoney;
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"../../aaa.gif");
            pictureBox1.Image = Image.FromFile(path);
            BindDoughnutChart();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            var model = new DayCastInfo()
            {
                GoodsName = "午餐",
                GoodsType = Convert.ToInt32(textBox1.Text),
                GoodsPrice = 10,
                //CurrentTime = DateTime.Parse("2025.3.26")
            };
            dayCastBLL.Add(model, out message);
            money = money + model.GoodsPrice;
            remainMoney = totalMoney - money;
            if (!string.IsNullOrWhiteSpace(message))
                MessageBox.Show(message);
            BindDoughnutChart();
        }

        #region 页面美化
        private void BindDoughnutChart()
        {
            var option = new UIDoughnutOption();

            //设置Title
            option.Title = new UITitle();
            option.Title.Text = $"";
            option.Title.SubText = "";
            option.Title.Left = UILeftAlignment.Center;

            //设置ToolTip
            option.ToolTip.Visible = true;

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

            if (remainMoney <= 450) option.Legend.AddData("剩余金额", Color.Red);
            else option.Legend.AddData("剩余金额");
            if (money >= totalMoney) option.Legend.AddData("消费金额", Color.Red);
            else option.Legend.AddData("消费金额", Color.Gold);


            //设置Series
            var series = new UIDoughnutSeries();
            series.Name = "";
            series.Center = new UICenter(50, 55);
            series.Radius.Inner = 40;
            series.Radius.Outer = 70;
            series.Label.Show = true;
            series.Label.Position = UIPieSeriesLabelPosition.Center;

            //增加数据
            if (remainMoney <= 450) series.AddData("剩余金额", remainMoney, Color.Red);
            else series.AddData("剩余金额", remainMoney);
            if (money >= totalMoney) series.AddData("消费金额", money, Color.Red);
            else series.AddData("消费金额", money, Color.Gold);

            //增加Series
            option.Series.Clear();
            option.Series.Add(series);

            //显示数据小数位数
            option.DecimalPlaces = 1;

            //设置Option
            uiDoughnutChart1.SetOption(option);
        }

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

            g.DrawString($"{dateTime.Year}年{dateTime.Month}月消费情况", font, brush, new PointF(panel1.Width / 2F, panel1.Height / 2F), stringFormat);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // 抗锯齿
            g.CompositingQuality = CompositingQuality.HighQuality; // 组合图像质量
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; // 插值模式（影响缩放质量）
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; // 像素偏移模式，提升抗锯齿效果


            Font font = new Font("日系可爱情书体", 18, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.DeepPink);
            // 创建一个StringFormat并设置对齐方式
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;  // 水平居中
            stringFormat.LineAlignment = StringAlignment.Center; // 垂直居中

            g.DrawString($"限额{totalMoney}元", font, brush, new PointF(panel3.Width / 2F, panel3.Height / 2F), stringFormat);
        }
        #endregion



        #region 详情图
        private void uiButton1_Click(object sender, EventArgs e)
        {
            DayCostFrm dayCostFrm = new DayCostFrm(this);
            dayCostFrm.Show();
            this.Hide();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            MothCostFrm mothCostFrm = new MothCostFrm(this);
            mothCostFrm.Show();
            this.Hide();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            YearCostFrm yearCostFrm = new YearCostFrm(this);
            yearCostFrm.Show();
            this.Hide();
        }
        #endregion


    }
}
