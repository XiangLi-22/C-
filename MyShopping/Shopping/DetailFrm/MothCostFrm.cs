using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping.DetailImage
{
    public partial class MothCostFrm : Form
    {
        public MainFrm MainFrm;

        public MothCostFrm(MainFrm mainFrm)
        {
            InitializeComponent();
            MainFrm = mainFrm;
        }

    }
}
