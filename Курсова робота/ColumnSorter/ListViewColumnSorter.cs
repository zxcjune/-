using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_робота.ColumnSorter
{
    public class ListViewColumnSorter : IComparer
    {
        private int columnIndex;
        private SortOrder sortOrder;

        public int ColumnIndex
        {
            get { return columnIndex; }
            set { columnIndex = value; }
        }

        public SortOrder SortOrder
        {
            get { return sortOrder; }
            set { sortOrder = value; }
        }

        public ListViewColumnSorter()
        {
            columnIndex = 0;
            sortOrder = SortOrder.Ascending;
        }

        public int Compare(object x, object y)
        {
            ListViewItem listViewItemX = (ListViewItem)x;
            ListViewItem listViewItemY = (ListViewItem)y;

            string xText = listViewItemX.SubItems[columnIndex].Text;
            string yText = listViewItemY.SubItems[columnIndex].Text;

            bool xIsNumber = int.TryParse(xText, out int xNumber);
            bool yIsNumber = int.TryParse(yText, out int yNumber);

            int result;
            if (xIsNumber && yIsNumber)
            {
                result = xNumber.CompareTo(yNumber);
            }
            else
            {
                result = string.Compare(xText, yText);
            }

            if (sortOrder == SortOrder.Descending)
                result = -result;

            return result;
        }
    }

}
