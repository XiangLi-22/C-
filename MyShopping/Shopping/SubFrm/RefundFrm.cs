using Shopping.DetailFrm;
using Shopping.DetailImage;
using System;
using System.Windows.Forms;

namespace Shopping.SubFrm
{
    public partial class RefundFrm : Form
    {
        public RefundFrm()
        {
            InitializeComponent();
        }

        private void RefundFrm_Load(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 0;
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            if (rbtnTime.Checked)
            {
                DayCostFrm dayCostFrm = new DayCostFrm(this,true,dtpTime.Value);
                dayCostFrm.Show();
                this.Hide();
            }
            else
            {
                if(cbbType.SelectedIndex == 0)
                {
                    MessageBox.Show("类型不能为空!","错误",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TypeFrm typeFrm = new TypeFrm(this,cbbType.SelectedIndex);
                typeFrm.Show();
                this.Hide();
            }
        }

       
    }
}
