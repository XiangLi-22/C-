using BLL;
using Domains;
using Helper;
using Hepler;
using Shopping.MyUserContorl;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping.DetailFrm
{
    public partial class TypeFrm : Form
    {
        DayCastBLL dayCastBLL = new DayCastBLL();

        int page;
        int pagesize;
        int totalpage;

        public Form LastFrm;
        public int type;
        public string message;

        DataGridViewButtonBinder<UpdAndREFButton> binder;

        public TypeFrm(Form LastFrm,int t)
        {
            InitializeComponent();
            this.LastFrm = LastFrm;
            this.type = t;
            page = 1;
            pagesize = 10;
            totalpage = 1;
        }

        #region 窗体事件
        private void TypeFrm_Load(object sender, EventArgs e)
        {
            InitializationDataGirdView.InitializeGridView(uiDataGridView1);
            BindDGVUserButtton();
            BindDataGirdView();
        }

        private void TypeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TypeFrm_Resize(object sender, EventArgs e)
        {
            pageButton1.Location = new Point((panel3.Width-pageButton1.Width)/2,(panel3.Height-pageButton1.Height)/2);
            panel1.Invalidate();

        }
        #endregion

        #region 数据绑定事件
        private async void BindDataGirdView()
        {
            //从日消费中获取到指定类型的所有消费
            var list = dayCastBLL.GetTypeCast(type, page,pagesize,out message);
            uiDataGridView1.DataSource = list;
            if (list.Count == 0)
            {
                await Task.Delay(500);
                MessageBox.Show(message);
            }

            binder.RefreshButtons();

            totalpage = dayCastBLL.TotalPage(pagesize, type);
            pageButton1.lblText = $"{page}/{totalpage}";
        }

        private void BindDGVUserButtton()
        {
            if (binder == null)
            {
                binder = new DataGridViewButtonBinder<UpdAndREFButton>(uiDataGridView1, "operate", row =>
                {
                    var button = new UpdAndREFButton();
                    button.btnRefClicked += (s, e) =>
                    {
                        MessageBox.Show("退款");
                    };
                    button.btnUpdClicked += (s, e) =>
                    {
                        MessageBox.Show("编辑");
                    };
                    return button;
                });
            }
        }
        #endregion

        #region 美化窗体事件
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g  = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // 抗锯齿
            g.CompositingQuality = CompositingQuality.HighQuality; // 组合图像质量
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; // 插值模式（影响缩放质量）
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; // 像素偏移模式，提升抗锯齿效果

            string text = $"{(GoodsType)type}总消费";
            Font font = new Font("日系可爱情书体", 30,FontStyle.Bold);
            SizeF textsize = g.MeasureString(text, font);
            Brush brush = new SolidBrush(Color.DeepPink);
            StringFormat format  = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            g.DrawString(text, font, brush, new Point(panel1.Width/2,panel1.Height/2), format);
        }
        #endregion

        #region 分页事件
        private void pageButton1_tsbFirstClick(object sender, EventArgs e)
        {
            page = 1;
            BindDataGirdView();
        }

        private void pageButton1_tsbGoClick(object sender, EventArgs e)
        {
            if (!char.IsDigit(Convert.ToChar( pageButton1.textBoxeText)))
            {
                MessageBox.Show("请输入正确的数字!", "错误");
                return;
            }
            if(Convert.ToInt32(pageButton1.textBoxeText)>totalpage || Convert.ToInt32(pageButton1.textBoxeText) < 1)
            {
                MessageBox.Show($"页数必须在1和{totalpage}之间!","错误");
                return;
            }
            page = Convert.ToInt32(pageButton1.textBoxeText);
            BindDataGirdView();
        }

        private void pageButton1_tsbLastClick(object sender, EventArgs e)
        {
            page = totalpage;
            BindDataGirdView();
        }

        private void pageButton1_tsbNextClick(object sender, EventArgs e)
        {
            if (page < totalpage) page++;
            BindDataGirdView();
        }

        private void pageButton1_tsbPrevClick(object sender, EventArgs e)
        {
            if(page > 1) page--;
            BindDataGirdView();
        }

        private void pageButton1_tscbPageSizeSelectedIndexChanged(object sender, EventArgs e)
        {
            pagesize = Convert.ToInt32(pageButton1.pageSizeSelectItem);
            page = 1;
            BindDataGirdView();
        }
        #endregion

        #region 返回上一个窗体
        private void returnButon1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LastFrm.Show();
        }
        #endregion

        
    }
}
