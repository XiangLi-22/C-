using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping.MyUserContorl
{
    public partial class UpdAndREFButton : UserControl
    {
        public event EventHandler btnUpdClicked;
        public event EventHandler btnRefClicked;
        public UpdAndREFButton()
        {
            InitializeComponent();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            btnUpdClicked(sender, e);
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            btnRefClicked(sender, e);
        }
    }
}
