using Domains;
using Domains.Context;
using Helper;
using Shopping.DTO;
using Shopping.MyUserContorl;
using Sunny.UI;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Shopping.DetailImage
{
    public partial class DayCostFrm : Form
    {
        public MainFrm MainFrm;

        ShoppingModel context = new ShoppingModel();

        public DayCostFrm(MainFrm mainFrm)
        {
            InitializeComponent();
            MainFrm = mainFrm;
        }

        #region 窗体事件
        private void DayCostFrm_Load(object sender, EventArgs e)
        {
            BindGridView();
        }
        private void DayCostFrm_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
        private void DayCostFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();  // 关闭所有窗体并退出应用
        }
        #endregion

        private void BindGridView()
        {
            DateTime start = DateTime.Parse($"{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day} 00:00:00");
            DateTime end = DateTime.Parse($"{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day} 23:59:59");
            var query = from d in context.DayCastInfo
                        where d.CurrentTime >=start && d.CurrentTime <= end
                        orderby d.CurrentTime ascending
                        select new DayDTO()
                        {
                            Id = d.Id,
                            GoodsName = d.GoodsName,
                            GoodsType = (GoodsType)d.GoodsType,
                            GoodsPrice = d.GoodsPrice,
                            DaysCast = d.DaysCast,
                            TotalRemain = d.TotalRemain,
                            CurrentTime = d.CurrentTime,
                            State = d.State == 0?"正常":"已退款",
                        };
            uiDataGridView1.RowTemplate.Height = 45;

            uiDataGridView1.DataSource = query.ToList();
            uiDataGridView1.Columns[0].Visible = false;
            uiDataGridView1.Columns[1].HeaderText = "商品名称";
            uiDataGridView1.Columns[2].HeaderText = "商品类型";
            uiDataGridView1.Columns[3].HeaderText = "商品价格";
            uiDataGridView1.Columns[4].HeaderText = "当日消费";
            uiDataGridView1.Columns[5].HeaderText = "剩余金额";
            uiDataGridView1.Columns[6].HeaderText = "消费时间";
            uiDataGridView1.Columns[7].HeaderText = "是否退款";
            if (!uiDataGridView1.Columns.Contains("操作")) uiDataGridView1.Columns.Add("operate", "操作");
            //封装一个方法 , 获取全部行,循环行数在单元格中进行添加自定义用户控件(即实例化),当定点击事件

            BindGridViewButton();

            if (query.Count() == 0) MessageBox.Show("你还没有添加当日消费记录!");
        }

        private void BindGridViewButton()
        {
            var binder = new DataGridViewButtonBinder<DelectButton>(uiDataGridView1, "operate", row =>
            {
                var button = new DelectButton();
                int id = Convert.ToInt32(row.Cells["Id"].Value);

                button.btnRefClicked += (s, e) =>
                {
                    MessageBox.Show("退款按钮点击");
                };
                button.btnUpdClicked += (s, e) =>
                {
                    MessageBox.Show($"编辑按钮点击，ID: {id}");
                };
                return button;
            });

            binder.BindButtons();
        }

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

            string text = $"{dateTime.Year}年{dateTime.Month}月{dateTime.Day}日消费详情";

            //测量字体的大小
            SizeF size = g.MeasureString(text, font);
            g.DrawString(text, font, brush, new PointF(panel1.Width / 2, panel1.Height / 2), stringFormat);
        }
        #endregion

        #region 返回上一个窗体
        private void returnButon1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainFrm.Show();
        }
        #endregion



    }
}
