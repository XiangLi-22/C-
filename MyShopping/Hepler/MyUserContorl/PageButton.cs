using System;
using System.Windows.Forms;

namespace Shopping.MyUserContorl
{
    public partial class PageButton : UserControl
    {
        public event EventHandler tsbFirstClick;
        public event EventHandler tsbPrevClick;
        public event EventHandler tsbNextClick;
        public event EventHandler tsbLastClick;
        public event EventHandler tsbGoClick;
        public event EventHandler tscbPageSizeSelectedIndexChanged;

        public string lblText
        {
            get { return tslCurrentPageAndTotalPage.Text; }
            set { tslCurrentPageAndTotalPage.Text = value; }
        }
        public string textBoxeText
        {
            get { return tsbTxtCurrentPage.Text; }
            set { tsbTxtCurrentPage.Text = value; }
        }
        public object pageSizeSelectItem
        {
            get { return tscbPageSize.SelectedItem; }
            set { tscbPageSize.SelectedItem = value; }
        }

        public PageButton()
        {
            InitializeComponent();
        }

        #region 事件赋值
        private void tsbFirst_Click(object sender, EventArgs e)
        {
            tsbFirstClick(sender, e);
        }

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            tsbPrevClick(sender, e);
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            tsbNextClick(sender, e);
        }

        private void tsbLast_Click(object sender, EventArgs e)
        {
            tsbLastClick(sender, e);
        }

        private void tsbGo_Click(object sender, EventArgs e)
        {
            tsbGoClick(sender, e);
        }

        private void tscbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            tscbPageSizeSelectedIndexChanged(sender, e);
        }
        #endregion

    }
}
