using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using WinForms_StorageManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_StorageManager
{
    public partial class DatabaseForm : Form
    {
        string query = "";
        readonly bool readDb = true;
        readonly string database_name = "WinForms_StorageManager";
        string table_name = "products";
        readonly List<string> ColumnNameList = new List<string>() { "Product id", "Product name", "Price" }; 
        bool edit_mode = false;
                
        string rankProductId = "ASC";
        string rankProductName = "ASC";
        string rankPrice = "ASC";
        
        string rankId = "DESC";
        string rankFKproductId = "ASC";
        string rankDate = "ASC";
        string rankAmount = "ASC";
        
        string rankUsername = "ASC";
        string rankPassword = "ASC";

        public DatabaseForm()
        {
            InitializeComponent();
            query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY `productId` ASC;";
            ShowValues();
            button_products.Enabled = false;
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
                            if (table_name == "users" && i == 1) value = "*********";
                            row[i] = value;
                            rec_index++;
                        }
                        dgv_values.Rows.Insert(row_index, row);
                        row_index++;
                    }
                    // dgv_values.Sort(dgv_values.Columns[0], ListSortDirection.Ascending);
                }

                // executed even there is no row in the table (only empty columns with header)
                ResizeDatagridview();
            }
            else
            {
                MessageBox.Show($"Table '{table_name}' does not exist, or database is not responding! source: CheckTable()");
            }
        }

        private void ResetDatagridview()
        {
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
            int column_index = 0;
            dgv_values.ColumnCount = ColumnNameList.Count;
            foreach (var columnName in ColumnNameList)
            {
                dgv_values.Columns[column_index].Name = columnName;
                // dgv_values.Columns.Add(new DataGridViewColumn() { HeaderText = field, CellTemplate = new DataGridViewTextBoxCell() });
                
                dgv_values.Columns[column_index].Width = 152;
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
            if (total_width < 731) // original dgv_value.With
            {
                dgv_values.ClientSize = new Size(total_width, 410);
            }
            else
            {
                dgv_values.ClientSize = new Size(731, 410);
            }
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

        private void Dgv_values_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // the header e.RowIndex is -1
            if (e.RowIndex == -1)
            {
                string headerText = dgv_values.Columns[e.ColumnIndex].HeaderText;

                if (headerText == "Product id") // productId
                {
                    string orderBy = "`products`.`productId`";
                    rankProductId = rankProductId == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankProductId};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
                else if (headerText == "Product name")
                {
                    string orderBy = "`products`.`productName`";
                    rankProductName = rankProductName == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankProductName};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
                else if (headerText == "Price")
                {
                    string orderBy = "`products`.`price`";
                    rankPrice = rankPrice == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankPrice};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
                else if (headerText == "Id")
                {
                    string orderBy = "`sales`.`id`";
                    rankId = rankId == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankId};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
                else if (headerText == "FK product id")
                {
                    string orderBy = "`sales`.`FKproductId`";
                    rankFKproductId = rankFKproductId == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankFKproductId};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
                else if (headerText == "Date")
                {
                    string orderBy = "`date`";
                    rankDate = rankDate == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankDate};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
                else if (headerText == "Amount")
                {
                    string orderBy = "`sales`.`amount`";
                    rankAmount = rankAmount == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankAmount};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
                else if (headerText == "User name")
                {
                    string orderBy = "`users`.`username`";
                    rankUsername = rankUsername == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankUsername};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
                else if (headerText == "Password")
                {
                    string orderBy = "`users`.`password`";
                    rankPassword = rankPassword == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankPassword};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
            }
        }

        private void Button_products_Click(object sender, EventArgs e)
        {
            ColumnNameList.Clear();
            ColumnNameList.AddRange(new List<string> {"Product id", "Product name", "Price" });
            table_name = "products";
            string orderBy = "`products`.`productId`";
            // rankProductId = rankProductId == "DESC" ? "ASC" : "DESC";
            query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankProductId};";
            BeginInvoke(new MethodInvoker(ShowValues));
            button_products.Enabled = false;
            button_sales.Enabled = true;
            button_users.Enabled = true;
        }

        private void Button_sales_Click(object sender, EventArgs e)
        {
            ColumnNameList.Clear();
            ColumnNameList.AddRange(new List<string> { "Id", "FK product id", "Date", "Amount" });
            table_name = "sales";
            string orderBy = "`sales`.`id`";
            // rankId = rankId == "DESC" ? "ASC" : "DESC";
            query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankId};";
            BeginInvoke(new MethodInvoker(ShowValues));
            button_sales.Enabled = false;
            button_products.Enabled = true;
            button_users.Enabled = true;
        }

        private void Button_users_Click(object sender, EventArgs e)
        {
            ColumnNameList.Clear();
            ColumnNameList.AddRange(new List<string> { "User name", "Password", "Date" });
            table_name = "users";
            string orderBy = "`users`.`username`";
            // rankUsername = rankUsername == "DESC" ? "ASC" : "DESC";
            query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY {orderBy} {rankUsername};";
            BeginInvoke(new MethodInvoker(ShowValues));
            button_users.Enabled = false;
            button_sales.Enabled = true;
            button_products.Enabled = true;
        }


    }
}
