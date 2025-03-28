using System;
using System.Collections.Generic;
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
        private readonly Dictionary<int, T> _rowButtonMap = new Dictionary<int, T>();
        private bool _isFirstPaintHandled = false;

        public DataGridViewButtonBinder(DataGridView gridView, string columnName, Func<DataGridViewRow, T> createButtonAction)
        {
            _gridView = gridView;
            _columnName = columnName;
            _createButtonAction = createButtonAction;
        }

        public void BindButtons()
        {
            ClearButtons();
            AddButtons();
            BindEvents();
            BindFirstPaintEvent();
        }

        private void ClearButtons()
        {
            foreach (var btn in _rowButtonMap.Values)
            {
                _gridView.Controls.Remove(btn);
                btn.Dispose();
            }
            _rowButtonMap.Clear();
        }

        private void AddButtons()
        {
            foreach (DataGridViewRow row in _gridView.Rows)
            {
                if (row.IsNewRow) continue;

                var button = _createButtonAction(row);
                button.Size = new Size(100, 30);
                PositionButton(button, row);

                _gridView.Controls.Add(button);
                _rowButtonMap[row.Index] = button;
            }
        }

        private void PositionButton(T button, DataGridViewRow row)
        {
            Rectangle cellRect = _gridView.GetCellDisplayRectangle(_gridView.Columns[_columnName].Index, row.Index, true);
            button.Location = new Point(cellRect.X + (cellRect.Width - button.Width) / 2,
                                        cellRect.Y + (cellRect.Height - button.Height) / 2);
        }

        private void BindEvents()
        {
            _gridView.Scroll -= GridView_ScrollOrResize;
            _gridView.SizeChanged -= GridView_ScrollOrResize;
            _gridView.ColumnWidthChanged -= GridView_ScrollOrResize;
            _gridView.RowHeightChanged -= GridView_ScrollOrResize;

            _gridView.Scroll += GridView_ScrollOrResize;
            _gridView.SizeChanged += GridView_ScrollOrResize;
            _gridView.ColumnWidthChanged += GridView_ScrollOrResize;
            _gridView.RowHeightChanged += GridView_ScrollOrResize;
        }

        private void BindFirstPaintEvent()
        {
            _gridView.Paint -= GridView_FirstPaint;
            _gridView.Paint += GridView_FirstPaint;
        }

        private void GridView_FirstPaint(object sender, PaintEventArgs e)
        {
            if (_isFirstPaintHandled) return;

            _isFirstPaintHandled = true;
            GridView_ScrollOrResize(sender, EventArgs.Empty);
        }

        private void GridView_ScrollOrResize(object sender, EventArgs e)
        {
            foreach (var kvp in _rowButtonMap)
            {
                int rowIndex = kvp.Key;
                T button = kvp.Value;

                if (rowIndex >= 0 && rowIndex < _gridView.Rows.Count)
                {
                    var row = _gridView.Rows[rowIndex];
                    PositionButton(button, row);
                }
            }
        }
    }
}
