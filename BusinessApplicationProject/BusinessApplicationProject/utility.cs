using System.Windows.Forms;

namespace BusinessApplicationProject
{
    /// <summary>
    /// Provides utility methods for working with UI elements.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Retrieves the selected item of type <typeparamref name="T"/> from a DataGridView.
        /// </summary>
        /// <typeparam name="T">The type of the objects bound to the DataGridView.</typeparam>
        /// <param name="dataGridView">The DataGridView to read from.</param>
        /// <returns>The selected item, or null if nothing is selected or data is unavailable.</returns>
        public static T? GetSelectedItem<T>(DataGridView dataGridView) where T : class?
        {
            if (dataGridView.DataSource is List<T> dataGridContent && dataGridView.SelectedCells.Count > 0)
            {
                return dataGridContent[dataGridView.SelectedCells[0].RowIndex];
            }

            return null;
        }
    }
}
