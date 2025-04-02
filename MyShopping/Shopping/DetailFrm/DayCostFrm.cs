using BLL;
using Domains.Context;
using Helper;
using Hepler;
using Shopping.MyUserContorl;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping.DetailImage
{
    public partial class DayCostFrm : Form
    {
        public Form MainFrm;
        public bool IsSelect = false;
        public DateTime Time;

        DayCastBLL dayCastBLL = new DayCastBLL();
        string message = string.Empty;

        int page = 1;
        int pagesize = 10;
        int totalpage = 1;

        DataGridViewButtonBinder<UpdAndREFButton> binds;

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
            InitializationDataGirdView.InitializeGridView(uiDataGridView1); //对网格进行初始化
            BindGridViewButton();
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

        #region 数据绑定
        private async void BindTimeGridView()
        {
            var query = dayCastBLL.SelectSpecifyTime(Time,page,pagesize , out message);

            uiDataGridView1.RowTemplate.Height = 45;

            uiDataGridView1.DataSource = query;

            BindGridViewButton();

            if (query.Count == 0)
            {
                await Task.Delay(500); // 等待UI线程空闲
                MessageBox.Show(message);
            }

            binds.RefreshButtons();

            totalpage = dayCastBLL.TimeTotalPage(pagesize,Time);
            pageButton1.lblText = $"{page}/{totalpage}";

        }
        private async void BindGridView()
        {
            var (list, message) = await dayCastBLL.GetTodayCastAsync(page,pagesize);

            uiDataGridView1.RowTemplate.Height = 45;
            uiDataGridView1.DataSource = list;

            if (list.Count == 0)
            {
                MessageBox.Show(message);
                return;
            }

            binds.RefreshButtons();

            totalpage = dayCastBLL.TotalPage(pagesize);
            pageButton1.lblText = $"{page}/{totalpage}";
        }
        private void BindGridViewButton()
        {
            binds = new DataGridViewButtonBinder<UpdAndREFButton>(uiDataGridView1, "operate", row =>
            {
                var button = new UpdAndREFButton();
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

        #region 分页事件
        private void pageButton1_tsbFirstClick(object sender, EventArgs e)
        {
            page = 1;
            if (!IsSelect) BindGridView();
            else BindTimeGridView();
        }

        private void pageButton1_tsbGoClick(object sender, EventArgs e)
        {
            if (!char.IsDigit(Convert.ToChar(pageButton1.textBoxeText)))
            {
                MessageBox.Show("请输入正确的数字!", "错误");
                return;
            }
            if (Convert.ToInt32(pageButton1.textBoxeText) > totalpage || Convert.ToInt32(pageButton1.textBoxeText) < 1)
            {
                MessageBox.Show($"页数必须在1和{totalpage}之间!", "错误");
                return;
            }
            page = Convert.ToInt32(pageButton1.textBoxeText);
            if (!IsSelect) BindGridView();
            else BindTimeGridView();
        }

        private void pageButton1_tsbLastClick(object sender, EventArgs e)
        {
            page = totalpage;
            if (!IsSelect) BindGridView();
            else BindTimeGridView();
        }

        private void pageButton1_tsbNextClick(object sender, EventArgs e)
        {
            if (page < totalpage) page++;
            if (!IsSelect) BindGridView();
            else BindTimeGridView();
        }

        private void pageButton1_tsbPrevClick(object sender, EventArgs e)
        {
            if (page > 1) page--;
            if (!IsSelect) BindGridView();
            else BindTimeGridView();
        }

        private void pageButton1_tscbPageSizeSelectedIndexChanged(object sender, EventArgs e)
        {
            pagesize = Convert.ToInt32(pageButton1.pageSizeSelectItem);
            page = 1;
            if (!IsSelect) BindGridView();
            else BindTimeGridView();
        }
        #endregion

    }
}
