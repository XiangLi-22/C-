using BLL;
using Maticsoft.Model;
using System;
using System.Windows.Forms;

namespace Shopping.SubFrm
{
    public partial class AddUpdFrm : Form
    {
        private Form t;
        private bool isAdd = false;
        DayCastBLL dayCastBLL = new DayCastBLL();
        string message = string.Empty;
        public float goodsPrice;


        public AddUpdFrm(Form T,bool isAdd = true)
        {
            InitializeComponent();
            t = T;
            this.isAdd = isAdd;
        }

        private void AddUpdFrm_Load(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 0;
        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            if (isAdd)
            {
                if (!CheckAdd(out string mgs))
                {
                    MessageBox.Show(mgs);
                    return;
                }
                var model = new DayCastInfo()
                {
                    GoodsName = txtName.Text,
                    GoodsType = cbbType.SelectedIndex,
                    GoodsPrice = Convert.ToSingle(txtPrice.Text),
                    CurrentTime = dtpCastTime.Value,
                };
                dayCastBLL.Add(model, out message);

                if (!string.IsNullOrWhiteSpace(message))
                    MessageBox.Show(message);

                goodsPrice = Convert.ToSingle(txtPrice.Text);

                    DialogResult = DialogResult.OK;
            }
            else
            {
                button1.Text = "编辑";
            }
            this.Close();
        }

        #region 校验函数
        private bool CheckAdd(out string mgs)
        {
            mgs = string.Empty;
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                mgs = "商品名称不能为空!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                mgs = "商品价格不能为空!";
                return false;
            }
            if (cbbType.SelectedIndex == 0)
            {
                mgs = "商品类型不能为空!";
                return false;
            }
            return true;
        }
        #endregion

    }
}
