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
    public partial class YearCostFrm : Form
    {
        public MainFrm MainFrm;

        public YearCostFrm(MainFrm mainFrm)
        {
            InitializeComponent();
            MainFrm = mainFrm;
        }

    }
}
