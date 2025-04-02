using BLL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping.DetailFrm
{
    public partial class YearTypeFrm : Form
    {
        private readonly int yearcount;

        YearCastBLL yearCastBLL = new YearCastBLL();

        string message= string.Empty;


        public YearTypeFrm(int yearcount)
        {
            InitializeComponent();
            this.yearcount = yearcount;
        }

        private void YearTypeFrm_Load(object sender, EventArgs e)
        {
            BindBarChart();
        }

        #region 数据绑定
        private void BindBarChart()
        {
            var d = yearCastBLL.GetMothType(yearcount, out message);

            UIBarOption option = new UIBarOption();

            option.Title = new UITitle();
            option.Title.Text = "";
            option.Title.SubText = "";

            option.ToolTip.Visible = true;

            var series = new UIBarSeries();
            foreach (var item in d.Values)
            {
                series.AddData(item);
            }
            series.DecimalPlaces = 2;
            option.Series.Add(series);

            option.XAxis.Data.AddRange(d.Keys);

            option.XAxis.Name = "类型名";
            option.YAxis.Name = "消费金额 单位(元)";

            uiBarChart1.SetOption(option);

        }
        #endregion

    }
}
