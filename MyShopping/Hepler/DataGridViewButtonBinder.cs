using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Helper
{
    public class DataGridViewButtonBinder<T> where T : Control
    {
        private readonly DataGridView _gridView;
        private readonly string _columnName;
        private readonly Func<DataGridViewRow, T> _createButtonAction;

        public DataGridViewButtonBinder(DataGridView gridView, string columnName, Func<DataGridViewRow, T> createButtonAction)
        {
            _gridView = gridView;
            _columnName = columnName;
            _createButtonAction = createButtonAction;

            BindEvents();
        }

        public void RefreshButtons()
        {
            ClearButtons();
            AddButtons();
        }

        private void ClearButtons()
        {
            var buttons = _gridView.Controls.OfType<T>().ToList();
            foreach (var btn in buttons)
            {
                _gridView.Controls.Remove(btn);
                btn.Dispose();
            }
        }

        private void AddButtons()
        {
            foreach (DataGridViewRow row in _gridView.Rows)
            {
                if (row.IsNewRow) continue;

                var button = _createButtonAction(row);
                button.Size = new Size(100, 30);
                _gridView.Controls.Add(button);

                PositionButton(row, button);
            }
        }

        private void BindEvents()
        {
            _gridView.Scroll += (s, e) => UpdateButtonPositions();
            _gridView.SizeChanged += (s, e) => UpdateButtonPositions();
            _gridView.RowHeightChanged += (s, e) => UpdateButtonPositions();
            _gridView.ColumnWidthChanged += (s, e) => UpdateButtonPositions();
            _gridView.RowPostPaint += (s, e) => UpdateButtonPositions();
        }

        private void UpdateButtonPositions()
        {
            foreach (DataGridViewRow row in _gridView.Rows)
            {
                if (row.IsNewRow) continue;
                var button = _gridView.Controls.OfType<T>().FirstOrDefault(b => b.Tag as DataGridViewRow == row);
                if (button != null)
                {
                    PositionButton(row, button);
                }
            }
        }

        private void PositionButton(DataGridViewRow row, T button)
        {
            Rectangle cellRect = _gridView.GetCellDisplayRectangle(_gridView.Columns[_columnName].Index, row.Index, true);
            if (cellRect.Visible())
            {
                button.Location = new Point(cellRect.X + (cellRect.Width - button.Width) / 2,
                                            cellRect.Y + (cellRect.Height - button.Height) / 2);
                button.Visible = true;
            }
            else
            {
                button.Visible = false;
            }
            button.Tag = row; // 绑定行对象
        }
    }

    public static class RectangleExtensions
    {
        public static bool Visible(this Rectangle rect)
        {
            return rect.Width > 0 && rect.Height > 0 && rect.X >= 0 && rect.Y >= 0;
        }
    }
}
