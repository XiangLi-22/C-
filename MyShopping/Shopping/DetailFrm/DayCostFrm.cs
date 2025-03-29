using BLL;
using Domains;
using Domains.Context;
using Helper;
using HZH_Controls;
using Shopping.MyUserContorl;
using Sunny.UI;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping.DetailImage
{
    public partial class DayCostFrm : Form
    {
        public Form MainFrm;

        ShoppingModel context = new ShoppingModel();
        DayCastBLL dayCastBLL = new DayCastBLL();

        string message = string.Empty;

        public bool IsSelect = false;
        public DateTime Time;

        public DayCostFrm(Form mainFrm = null, bool isSelect = false, DateTime time = default)
        {
            InitializeComponent();
            MainFrm = mainFrm;
            this.IsSelect = isSelect;
            this.Time = time;
        }

        #region 窗体事件
        private void DayCostFrm_Load(object sender, EventArgs e)
        {
            InitializeGridView();
            if (!IsSelect) BindGridView();
            else BindTimeGridView();
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

        #region 网格初始化
        private void InitializeGridView()
        {
            uiDataGridView1.AutoGenerateColumns = false;
            uiDataGridView1.RowTemplate.Height = 45;

            uiDataGridView1.Columns.Clear();

            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", Visible = false });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "GoodsName", DataPropertyName = "GoodsName", HeaderText = "商品名称" });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "GoodsType", DataPropertyName = "GoodsType", HeaderText = "商品类型" });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "GoodsPrice", DataPropertyName = "GoodsPrice", HeaderText = "商品价格" });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "DaysCast", DataPropertyName = "DaysCast", HeaderText = "当日消费" });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "TotalRemain", DataPropertyName = "TotalRemain", HeaderText = "剩余金额" });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "CurrentTime", DataPropertyName = "CurrentTime", HeaderText = "消费时间" });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "State", DataPropertyName = "State", HeaderText = "是否退款" });

            if (!uiDataGridView1.Columns.Contains("操作"))
                uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "operate", HeaderText = "操作" });
        }
        #endregion

        #region 数据绑定
        private async void BindTimeGridView()
        {
            string time = Time.ToString("yyyy-MM-dd");
            var query = dayCastBLL.SelectSpecifyTime(time, out message);

            uiDataGridView1.RowTemplate.Height = 45;

            uiDataGridView1.DataSource = query;

            BindGridViewButton();

            if (query.Count == 0)
            {
                await Task.Delay(500); // 等待UI线程空闲
                MessageBox.Show(message);
            }

        }
        private async void BindGridView()
        {
            var (list, message) = await dayCastBLL.GetTodayCastAsync();

            uiDataGridView1.RowTemplate.Height = 45;
            uiDataGridView1.DataSource = list;

            if (list.Count == 0)
            {
                MessageBox.Show(message);
                return;
            }
            BindGridViewButton();
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

            string text = string.Empty;
            if (!IsSelect)
                text = $"{dateTime.Year}年{dateTime.Month}月{dateTime.Day}日消费详情";
            else
                text = $"{Time.Year}年{Time.Month}月{Time.Day}日消费详情";

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
