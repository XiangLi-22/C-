using BLL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shopping.DetailFrm
{
    public partial class YearMothFrm : Form
    {
        YearCastBLL yearCastBLL = new YearCastBLL();

        int yearCount = 0;
        string message = string.Empty;

        public YearMothFrm(int yearCount)
        {
            InitializeComponent();
            this.yearCount = yearCount;
        }

        private void YearMothFrm_Load(object sender, EventArgs e)
        {
            BindLineChart();
        }

        private void BindLineChart()
        {
            DateTime dt = new DateTime(2025, 1, 1);


            // 初始化 UILineOption 对象，设置图表的基本选项。
            UILineOption option = new UILineOption();
            option.ToolTip.Visible = true;  // 显示数据点的提示信息
            option.Title = new UITitle();  // 设置图表的标题
            option.Title.Text = ""; // 主标题
            option.Title.SubText = ""; // 副标题

            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value = 1500 });

            option.XAxis.SetRange(1, 12);  // 设置X轴显示范围，0到12

            // 创建第一个折线系列 "Line1"
            var series = option.AddSeries(new UILineSeries("月消费"));
            List<float> values = yearCastBLL.GetMothCost(yearCount, out message);
           
            for (int i = 0; i < values.Count; i++)
            {
                series.Add(i+1, values[i]);
            }

            // 设置数据点样式：使用圆符号，并调整符号的大小、线宽等
            series.Symbol = UILinePointSymbol.Round;
            series.SymbolSize = 4;
            series.SymbolLineWidth = 2;
            //series.SymbolColor = Color.Blue;

            // 显示折线，设置为显示数据点，不显示线条
            series.ShowLine = true;

            // 设置Y轴小数点显示的位数为0（例如：1000, 1200）
            option.YAxis.AxisLabel.DecimalPlaces = 0;

            // 设置Y轴上限为1500
            option.YAxis.SetRange(0, 2000);

            // 设置X轴的标签格式为：1-12
            option.XAxis.Name = "日期（单位：月份）";  // 设置X轴名称
            option.YAxis.Name = "消费金额（单位：元）";  // 设置Y轴名称

            // 绘制图表，应用上述选项
            uiLineChart1.SetOption(option);
        }
    }
}
