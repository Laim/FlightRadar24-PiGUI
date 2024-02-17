namespace pi24gui.Helpers
{
    public static class DataGridExtensions
    {
        /// <summary>
        /// Returns the value of the specific cell based on the column name to prevent having to screw with indexes
        /// </summary>
        /// <param name="cellCollection"><see cref="DataGridViewRow.Cells"/></param>
        /// <param name="columnName">Name of the column</param>
        /// <returns></returns>
        public static object GetCellValueFromColumnName(this DataGridViewCellCollection cellCollection, string columnName)
        {
            return cellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.HeaderText == columnName).Value;
        }
    }
}
