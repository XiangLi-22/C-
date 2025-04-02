using System.Linq;
using System.Windows.Forms;

namespace Hepler
{
    public static class InitializationDataGirdView
    {
        public static void InitializeGridView(DataGridView dataGridView)
        {

            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowTemplate.Height = 45;

            dataGridView.Columns.Clear();

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", Visible = false });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "GoodsName", DataPropertyName = "GoodsName", HeaderText = "商品名称" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "GoodsType", DataPropertyName = "GoodsType", HeaderText = "商品类型" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "GoodsPrice", DataPropertyName = "GoodsPrice", HeaderText = "商品价格" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "DaysCast", DataPropertyName = "DaysCast", HeaderText = "当日消费" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "TotalRemain", DataPropertyName = "TotalRemain", HeaderText = "剩余金额" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "CurrentTime", DataPropertyName = "CurrentTime", HeaderText = "消费时间" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "State", DataPropertyName = "State", HeaderText = "是否退款" });

            if (!dataGridView.Columns.Contains("操作"))
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "operate", HeaderText = "操作" });
        }
    }
}
