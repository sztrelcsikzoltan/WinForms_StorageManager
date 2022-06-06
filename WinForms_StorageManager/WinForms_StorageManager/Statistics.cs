using MySql.Data.MySqlClient;
using WinForms_StorageManager.Classes;
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinForms_StorageManager
{
    public partial class StatisticsForm : Form
    {
        string query = "";
        readonly bool readDb = true;
        readonly string database_name = "WinForms_StorageManager";
        readonly string table_name = "sales";
        readonly List<string> ColumnNameList = new List<string> {"Id", "Product name", "Total amount"}; // list of column names
        // int PK_row_index = 0;
        // string PK_field_name = "id";
        bool edit_mode = false;

        string rankId = "DESC";
        string rankName = "ASC";
        string rankAmount = "DESC";
        readonly string filename = "sales.txt";
        int column0CustomWidth = -1;
        int column1CustomWidth = -1;
        int column2CustomWidth = -1;

        public StatisticsForm()
        {
            InitializeComponent();
            query = $"SELECT `sales`.`id`, `products`.`productName`, SUM(`sales`.`amount`) FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` GROUP BY `products`.`productName`  ORDER BY `products`.`productName`;";

            ShowValues();
            
            button_viewFile.Visible = false;
            dgv_file.Visible = false;
            // dgv_values.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
            label_file.Visible = false;
        }

        private void ShowValues()
        {
            ResetDatagridview();

            if (CheckTable(table_name)) // whether there is a table in the database
            {
                List<string> DbQueryList = Database.DbQuery(database_name, query, readDb);
                if (DbQueryList[2] != "") { MessageBox.Show(DbQueryList[2], caption: "Error message"); }
                else if (DbQueryList[1] != "0") // if threre is at least 1 row in the database
                {
                    int rec_index = 3; // skip first 3 info items
                    int row_index = 0;
                    int num_rows = Convert.ToInt32(DbQueryList[1]);
                    int num_columns = Convert.ToInt32(DbQueryList[0]);
                    string[] row = new string[num_columns];
                    while (row_index < num_rows)
                    {
                        // creating row array based on number of table columns
                        string value;
                        for (int i = 0; i < num_columns; i++)
                        {
                            // string test = reader.GetString(i);
                            value = DbQueryList[rec_index]; // reader.GetValue(i).ToString();
                            if (value == "01.01.01 00:00:00") value = "00-00-00 00:00:00";
                            row[i] = value;
                            rec_index++;
                        }
                        dgv_values.Rows.Insert(row_index, row);
                        row_index++;
                    }
                    // dgv_values.Sort(dgv_values.Columns[0], ListSortDirection.Descending);
                    Button_printFile.Visible = true;
                }

                // executed even there is no row in the table (only empty columns with header)
                ResizeDatagridview();
            }
            else
            {
                MessageBox.Show($"Table '{table_name}' does not exist, or database is not responding! source: CheckDbRecord()");
            }
        }

        private void ResetDatagridview()
        {
            column0CustomWidth = column0CustomWidth > -1 ? dgv_values.Columns[0].Width : 0; // keep column width if changed by the user
            column1CustomWidth = column1CustomWidth > -1 ? dgv_values.Columns[1].Width : 185;
            column2CustomWidth = column2CustomWidth > -1 ? dgv_values.Columns[2].Width : 135;
            dgv_values.Columns.Clear();
            dgv_values.AllowUserToAddRows = false; // hide last empty row
            dgv_values.DefaultCellStyle.SelectionBackColor = Color.White; // remove blue selection highlight
            dgv_values.DefaultCellStyle.SelectionForeColor = Color.Navy;
            dgv_values.AllowUserToResizeRows = false;
            // dataGridView_values.AllowUserToResizeColumns = false;

            if (!edit_mode) // if not edit mode, read view
            {
                dgv_values.ReadOnly = true;
                dgv_values.RowHeadersVisible = false; // hide first empty control column
            }

            if (!edit_mode) label_message.Text = query;
            edit_mode = false;

            // naming columns
            int[] column_width = { column0CustomWidth, column1CustomWidth, column2CustomWidth }; // setting various column width
            int column_index = 0;
            dgv_values.ColumnCount = ColumnNameList.Count;
            foreach (var columnName in ColumnNameList)
            {
                dgv_values.Columns[column_index].Name = columnName;
                // dgv_values.Columns.Add(new DataGridViewColumn() { HeaderText = field, CellTemplate = new DataGridViewTextBoxCell() });
                
                dgv_values.Columns[column_index].Width = column_width[column_index]; // column width
                column_index++;
            }
            dgv_values.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11.00F, FontStyle.Bold);
            dgv_values.DefaultCellStyle.Font = new Font("Arial", 10.00F, FontStyle.Regular);
            // dataGridView_values.Columns[0].Visible = false; // id oszlop elrejtése
        }

        private void ResizeDatagridview()
        {
            // setting ClientSize if bigger than the width of columns
            // dataGridView_values.AutoResizeColumns(); // setting column width to the minimum

            int total_width = +dgv_values.RowHeadersWidth * 0;

            // increase total_width if vertical scrollbar is present
            int height_rows = dgv_values.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            if (height_rows + dgv_values.ColumnHeadersHeight + dgv_values.RowTemplate.Height > dgv_values.Height)
            {
                total_width += SystemInformation.VerticalScrollBarWidth;
            }


            for (int i = 0 + 0; i < dgv_values.ColumnCount; i++) // 0+1, ha az id oszlop el van rejtve
            {
                total_width += dgv_values.Columns[i].Width + 1; // 2 pixel a 2 szegély miatt?
            }
            if (total_width < 320) // original dgv_value.With
            {
                dgv_values.ClientSize = new Size(total_width, 400);
            }
            else
            {
                dgv_values.ClientSize = new Size(320, 400);
            }
        }

        
        private void Dgw_values_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                string headerText = dgv_values.Columns[e.ColumnIndex].HeaderText;

                if (headerText == "Id")
                {
                    string db_field = "";
                    if (ColumnNameList[2] == "Total revenue") db_field = "*`products`.`price`";
                    string orderBy = "`sales`.`id`";
                    rankId = rankId == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT `sales`.`id`, `products`.`productName`, SUM(`sales`.`amount`){db_field} FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` GROUP BY `products`.`productName`  ORDER BY {orderBy} {rankId};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                    /*
                    rankId = rankId == "DESC" ? "ASC" : "DESC";
                    if (rankId == "ASC")
                    {
                        dgv_values.Sort(dgv_values.Columns[0], ListSortDirection.Ascending);
                    }
                    else
                    {
                        dgv_values.Sort(dgv_values.Columns[0], ListSortDirection.Descending);
                    }
                    */
                }
                else if (headerText == "Product name")
                {
                    string db_field = "";
                    if (ColumnNameList[2] == "Total revenue") db_field = "*`products`.`price`";
                    string orderBy = "`products`.`productName`";
                    rankName = rankName == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT `sales`.`id`, `products`.`productName`, SUM(`sales`.`amount`){db_field} FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` GROUP BY `products`.`productName`  ORDER BY {orderBy} {rankName};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                    /*
                    rankName = rankName == "DESC" ? "ASC" : "DESC";
                    if (rankName == "ASC")
                    {
                        dgv_values.Sort(dgv_values.Columns[1], ListSortDirection.Ascending);
                    }
                    else
                    {
                        dgv_values.Sort(dgv_values.Columns[1], ListSortDirection.Descending);
                    }
                    */
                }
                else if (headerText == "Total amount" || headerText == "Total revenue")
                {
                    string db_field = "";
                    if (ColumnNameList[2] == "Total revenue") db_field = "*`products`.`price`";
                    string orderBy = "SUM(`sales`.`amount`)";
                    rankAmount = rankAmount == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT `sales`.`id`, `products`.`productName`, SUM(`sales`.`amount`){db_field} FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` GROUP BY `products`.`productName`  ORDER BY {orderBy}{db_field} {rankAmount};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                    /*
                    rankAmount = rankAmount == "DESC" ? "ASC" : "DESC";
                    if (rankAmount == "ASC")
                    {
                        dgv_values.Sort(dgv_values.Columns[2], ListSortDirection.Ascending);
                    }
                    else
                    {
                        dgv_values.Sort(dgv_values.Columns[2], ListSortDirection.Descending);
                    }
                    */
                }

            }
        }

        private void Button_showRevenue_Click(object sender, EventArgs e)
        {
            string db_field = "";
            if (button_showRevenue.Text == "Show revenue")
            {
                db_field = "*`products`.`price`";
                ColumnNameList[2] = "Total revenue";
                button_showRevenue.Text = "Show amount";
            }
            else
            {
                ColumnNameList[2] = "Total amount";
                button_showRevenue.Text = "Show revenue";
            }
            query = $"SELECT `sales`.`id`, `products`.`productName`, SUM(`sales`.`amount`){db_field} FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` GROUP BY `products`.`productName`  ORDER BY `products`.`productName`;";

            BeginInvoke(new MethodInvoker(ShowValues));

            button_viewFile.Visible = false;
        }

        private void Button_printFile_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter(filename, append: false, encoding: Encoding.UTF8);
            int num_columns = ColumnNameList.Count;
            // write file header line
            string header_row = "";
            for (int i = 1; i < num_columns; i++) // skip firt id column by starting at i = 1
            {
                header_row += ColumnNameList[i];
                if (i + 1 < num_columns) header_row += ";";
            }
            sr.WriteLine(header_row);

            // write file lines
            for (int i = 0; i < dgv_values.RowCount; i++)
            {
                string row = "";
                for (int j = 1; j < num_columns; j++)
                {
                    row += dgv_values.Rows[i].Cells[j].Value;
                    if (j + 1 < num_columns) row += ";";
                }
                sr.WriteLine(row);
            }
            sr.Close();
            label_file.Visible = false;
            button_viewFile.Visible = true;
            Button_printFile.Visible = false;
            
        }

        private void Button_viewFile_Click(object sender, EventArgs e)
        {
            dgv_file.Columns.Clear();
            dgv_file.AllowUserToAddRows = false; // hide last empty row
            dgv_file.DefaultCellStyle.SelectionBackColor = Color.White; // remove blue selection highlight
            dgv_file.DefaultCellStyle.SelectionForeColor = Color.Navy;
            dgv_file.AllowUserToResizeRows = false;
            dgv_file.AllowUserToResizeColumns = false;
            if (!edit_mode) // if not edit mode, read view
            {
                dgv_file.ReadOnly = true;
                dgv_file.RowHeadersVisible = false; // hide first empty control column
            }
            edit_mode = false;

            dgv_file.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11.00F, FontStyle.Bold);
            dgv_file.DefaultCellStyle.Font = new Font("Arial", 10.00F, FontStyle.Regular);

            StreamReader sr = new StreamReader(filename);
            // adding and naming gdw columns
            string[] header_line = sr.ReadLine().Split(';');
            int[] column_width = { 185, 130 }; // setting varius column width
            for (int i = 0; i < header_line.Length; i++) // skipping first id column by starting at i = 1
            {
                dgv_file.Columns.Add(new DataGridViewColumn() { HeaderText = header_line[i], CellTemplate = new DataGridViewTextBoxCell() });
                dgv_file.Columns[i].Width = column_width[i]; // column width
            }
            
            // inserting gdw rows
            int row_index = 0;
            while (sr.EndOfStream == false)
            {
                dgv_file.Rows.Insert(row_index, sr.ReadLine().Split(';'));
                row_index++;
            }
            sr.Close();
            dgv_file.Visible = true;
            label_file.Text = filename;
            label_file.Visible = true;
            button_viewFile.Visible = false;
        }

        private bool CheckTable(string table_name) // whether table exists
        {
            bool tableExists = false;
            string query = $"SHOW TABLES LIKE '{table_name}';";
            List<string> DbQueryList = Database.DbQuery(database_name, query, readDb: true);
            if (DbQueryList[2] != "") { MessageBox.Show(DbQueryList[2], caption: "Error message"); }
            else if (DbQueryList[1] != "0") tableExists = true;

            return tableExists;
        }

    }
}
