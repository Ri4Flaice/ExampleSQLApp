using System.Data;
using System.Windows.Forms;

namespace ExampleSQLApp.searchInfo
{
    class SearchInfo
    {
        public SearchInfo(DataGridView dataGridView, string[] convertName, string searchValue)
        {
            DataView dv = ((DataTable)dataGridView.DataSource).DefaultView;

            if (!string.IsNullOrEmpty(searchValue))
            {
                string filter = string.Empty;
                for (int i = 0; i < convertName.Length; i++)
                {
                    if (i > 0)
                    {
                        filter += " OR ";
                    }
                    filter += $"CONVERT([{convertName[i]}], System.String) LIKE '%{searchValue}%'";
                }
                dv.RowFilter = filter;
            }
            else
            {
                dv.RowFilter = string.Empty;
            }
        }
    }
}
