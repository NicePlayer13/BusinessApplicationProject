using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplicationProject
{

    /// <summary>
    /// Utility class for common operations
    /// </summary>
    public class Utils
    {
        public static T? GetSelectedItem<T>(DataGridView dataGridView) where T : class?
        {
            if (dataGridView.DataSource != null)
            {
                List<T> dataGridContent = (List<T>)dataGridView.DataSource;

                if (dataGridView.SelectedCells.Count > 0)
                {
                    return dataGridContent[dataGridView.SelectedCells[0].RowIndex];
                }
            }

            return null;
        }
    }
}
