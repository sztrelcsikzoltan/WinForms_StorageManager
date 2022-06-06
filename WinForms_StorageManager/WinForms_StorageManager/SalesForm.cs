using MySql.Data.MySqlClient;
using WinForms_StorageManager.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms_StorageManager
{
    public partial class SalesForm : Form
    {
        string query = "";
        readonly bool readDb = true;
        readonly string database_name = "WinForms_StorageManager";
        readonly string table_name = "sales";
        readonly List<string> ColumnNameList = new List<string> {"Id", "Product name", "Date", "Amount"}; // list of column names 
        readonly int PK_column_index = 0;
        readonly string PK_field_name = "id";
        bool edit_mode = false;
        bool deleteRow_activated = false;

        string rankId = "DESC";
        string rankProductName = "DESC";
        string rankDate = "DESC";
        string rankAmount = "DESC";
        readonly List <Product> ListProduct = new List<Product>();
        // string filename = "sales.txt";
        int column0CustomWidth = -1;
        int column1CustomWidth = -1;
        int column2CustomWidth = -1;
        int column3CustomWidth = -1;

        public SalesForm()
        {
            InitializeComponent();
            query = $"SELECT `sales`.`id`, `products`.`productName`, `sales`.`date`, `sales`.`amount` FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` ORDER BY `id` DESC;"; 
            
            label_addProductNameError.Text = "";
            label_addDateError.Text = "";
            label_addAmountError.Text = "";
            ShowValues();
            ReadProducts(); // fill up ListProduct list from the `products` table with Product classes
            PopulateComboBox();
            if (comboBox_ProductName.Items.Count > 0) comboBox_ProductName.SelectedIndex = 0; // display first product
            
        }
        private void ShowValues()
        {
            ResetDatagridview();

            if (CheckTable(table_name)) // whether there is a table in the database
            {
                int row_index = 0;
                List<string> DbQueryList = Database.DbQuery(database_name, query, readDb);
                if (DbQueryList[2] != "") { MessageBox.Show(DbQueryList[2], caption: "Error message"); }
                else if (DbQueryList[1] != "0") // if threre is at least 1 row in the database
                {
                    int rec_index = 3; // skip first 3 info items
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
                    // dgv_values.Sort(dgv_values.Columns[0], ListSortDirection.Ascending);
                    button_deleteRow.Enabled = true;
                }
                if (row_index < 1) button_deleteRow.Enabled = false; // if there is no row or only 1, then the delete botton is disabled
                ResizeDatagridview();
            }
            else
            {
                button_deleteRow.Enabled = false;
                MessageBox.Show($"Table '{table_name}' does not exist, or database is not responding! source: CheckDbRecord()");
            }
        }

        private void ResetDatagridview()
        {
            column0CustomWidth = column0CustomWidth > -1 ? dgv_values.Columns[0].Width : 0; // keep column width if changed by the user
            column1CustomWidth = column1CustomWidth > -1 ? dgv_values.Columns[1].Width : 170;
            column2CustomWidth = column2CustomWidth > -1 ? dgv_values.Columns[2].Width : 80;
            column3CustomWidth = column3CustomWidth > -1 ? dgv_values.Columns[3].Width : 70;
            dgv_values.Columns.Clear();
            button_deleteRow.ForeColor = Color.Black;
            dgv_values.AllowUserToAddRows = false; // hide last empty row
            dgv_values.DefaultCellStyle.SelectionBackColor = Color.White; // remove blue selection highlight
            dgv_values.DefaultCellStyle.SelectionForeColor = Color.Navy;
            dgv_values.AllowUserToResizeRows = false;
            // dataGridView_values.AllowUserToResizeColumns = false;
            deleteRow_activated = false;
            if (!edit_mode) // if not edit mode, read view
            {
                dgv_values.ReadOnly = true;
                dgv_values.RowHeadersVisible = false; // hide first empty control column
            }

            if (!edit_mode) label_message.Text = query;
            edit_mode = false;

            // naming columns
            int[] column_width = { column0CustomWidth, column1CustomWidth, column2CustomWidth, column3CustomWidth }; // setting various column width
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
            if (total_width < 340) // original dgv_value.With
            {
                dgv_values.ClientSize = new Size(total_width, 488);
            }
            else
            {
                dgv_values.ClientSize = new Size(340, 488);
            }
        }

        private bool CheckTable(string table_name) // whether table 'eredmenyek' exists
        {
            bool tableExists = false;
            string query_check = $"SHOW TABLES LIKE '{table_name}';";
            List<string> DbQueryList = Database.DbQuery(database_name, query_check, readDb);
            if (DbQueryList[2] != "") { MessageBox.Show(DbQueryList[2], caption: "Error message"); }
            else if (DbQueryList[1] != "0") tableExists = true;

            return tableExists;
        }
        
        private void Button_deleteRow_Click(object sender, EventArgs e)
        {
            if (!deleteRow_activated) // pressing button for the 1. time
            {
                edit_mode = true;
                deleteRow_activated = true;
                button_deleteRow.ForeColor = Color.Red;
                dgv_values.DefaultCellStyle.SelectionBackColor = Color.Blue; // restore blue selection highlight
                dgv_values.DefaultCellStyle.SelectionForeColor = Color.White;
                dgv_values.ClearSelection();
                dgv_values.Rows[dgv_values.FirstDisplayedScrollingRowIndex].Selected = true; // select first VISIBLE row

            }
            else // pressing button for the 2. time
            {
                int selectedRows_count = dgv_values.SelectedRows.Count;
                if (selectedRows_count > 0)
                {
                    // confirm delete
                    string question = selectedRows_count == 1 ? "Are you sure to delete the selected row?" : $"Are you sure to delete the selected {selectedRows_count} rows?";
                    if (Common.UserAnswer(question, caption: "Question"))
                    {
                        string query_delete = "";
                        for (int i = 0; i < dgv_values.SelectedRows.Count; i++)
                        {
                            string field_value = dgv_values.SelectedRows[i].Cells[PK_column_index].Value.ToString(); // ez az aktuális PK mező értéke
                            query_delete += $"DELETE FROM `{database_name}`.`{table_name}` WHERE `{table_name}`.`{PK_field_name}` = '{field_value}';";
                        }
                        label_message.Text = query_delete.Replace(";", ";\n");
                        if (RunQuery(query_delete, readDb: false) == false) return; // delete record(s)

                        dgv_values.DefaultCellStyle.SelectionBackColor = Color.White; // remove blue selection highlight
                        dgv_values.DefaultCellStyle.SelectionForeColor = Color.Navy;
                        ShowValues();
                        
                        Common.menuForm.GetTotals(); // a Menuform public static (global) menuForm példány GetTotals() public metódusának futtatása!
                    }
                }
                else // if no row is selected
                {
                    MessageBox.Show("The entire row(s) must  be selected! \n (Klick on any field of the selected row(s). To select multiple rows, press the Ctrl key while selecting the rows.)", caption: "Delete");
                }
            }
        }
        
        private void Dgv_values_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // when selecting row in case of deleteRow_activated (the header e.RowIndex -1, thus nothing happens when clicking it!)
            if (deleteRow_activated && e.RowIndex > -1 && dgv_values.Rows[e.RowIndex].Selected == false)
            {
                dgv_values.Rows[e.RowIndex].Selected = true;
            }
            if (e.RowIndex == -1)
            {
                string headerText = dgv_values.Columns[e.ColumnIndex].HeaderText;

                if (headerText == "Id")
                {
                    string orderBy = "`sales`.`id`";
                    rankId = rankId == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT `sales`.`id`, `products`.`productName`, `sales`.`date`, `sales`.`amount` FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` ORDER BY {orderBy} {rankId};";

                    BeginInvoke(new MethodInvoker(ShowValues));
                }
                else if (headerText == "Product name")
                {
                    string orderBy = "`products`.`productName`";
                    rankProductName = rankProductName == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT `sales`.`id`, `products`.`productName`, `sales`.`date`, `sales`.`amount` FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` ORDER BY {orderBy} {rankProductName};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
                else if (headerText == "Date")
                {
                    string orderBy = "`sales`.`date`";
                    rankDate = rankDate == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT `sales`.`id`, `products`.`productName`, `sales`.`date`, `sales`.`amount` FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` ORDER BY {orderBy} {rankDate};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
                else if (headerText == "Amount")
                {
                    string orderBy = "`sales`.`amount`";
                    rankAmount = rankAmount == "DESC" ? "ASC" : "DESC";
                    query = $"SELECT `sales`.`id`, `products`.`productName`, `sales`.`date`, `sales`.`amount` FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` ORDER BY {orderBy} {rankAmount};";
                    BeginInvoke(new MethodInvoker(ShowValues));
                }
            }
        }
            private bool CheckAddContent()
        {
            // check productName
            bool productNameOK = true;
            if (comboBox_ProductName.SelectedItem == null) // if no product is selected
            {
                label_addProductNameError.Text = "Please select a product!";
                productNameOK = false;
            }
            if (productNameOK) label_addProductNameError.Text = "";

            // check date
            bool selectedDateOK = true;
            DateTime selectedDateValue = dateTimePicker_addDate.Value;
            DateTime today = DateTime.Now;
            if (selectedDateValue.AddDays(30) < today)
            {
                
                label_addDateError.Text = "Must be within 30 days from know!";
                selectedDateOK = false;
            }
            else if (selectedDateValue > today)
            {

                label_addDateError.Text = "Selected date cannot be a future date!";
                selectedDateOK = false;
            }
            if (selectedDateOK) label_addDateError.Text = "";

            // check Amount - not needed, as if the value is overwritten, the value within the min-max range will be used automatically
            bool amountOK = true;
            decimal amount = numericUpDown_addAmount.Value;
            if (amount < 0 || amount >1000)
            {
                label_addAmountError.Text = "Amount must be within 1-1000!";
                amountOK = false;
            }
            if (amountOK) label_addAmountError.Text = "";

            return productNameOK && selectedDateOK && amountOK;
        }

        private bool SaveResultIntoTable(string database_name, string query)
        {
            bool success = false;
            List<string> DbQueryList = Database.DbQuery(database_name, query, false); // send query to save results
            if (DbQueryList[2] == "")
            {
                success = true;
                label_message.Text = query;
            }
            else MessageBox.Show(DbQueryList[2], caption: "Error message");

            return success;
        }
        
        private void Button_addSale_Click(object sender, EventArgs e)
        {
            if (CheckAddContent() == false) return; // stop if entered data is incorrect

            string productName = comboBox_ProductName.SelectedItem.ToString();
            DateTime selectedDate = dateTimePicker_addDate.Value;
            int amount =  Convert.ToInt32(numericUpDown_addAmount.Value);

            // look up productId in Product class
            int FKproductId = 0;
            foreach (var product in ListProduct)
            {
                if (product.productName == productName)
                {
                    FKproductId = product.productId;
                    break;
                }
            }

            string query_insert = $"INSERT INTO `{table_name}` VALUES (0, '{FKproductId}', '{selectedDate}', {amount});";
            if(SaveResultIntoTable(database_name, query_insert) == false) return;
            edit_mode = true;
            query = $"SELECT `sales`.`id`, `products`.`productName`, `sales`.`date`, `sales`.`amount` FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` ORDER BY `id` DESC;";
            ShowValues();
            PopulateComboBox(); // update products if new products have been added shortly

            Common.menuForm.GetTotals(); // a Menuform public static (global) menuForm példány GetTotals() public metódusának futtatása!
        }

        private void ReadProducts() // fill up ListProduct list from the `products` table with Product classes
        {
            string query_select = $"SELECT * FROM `{database_name}`.`products` ORDER BY `productName`;";
            if (!edit_mode) label_message.Text = query;
            edit_mode = false;

            if (CheckTable("products")) // whether there is a table in the database
            {
                List<string> DbQueryList = Database.DbQuery(database_name, query_select, readDb);
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
                        ListProduct.Add(new Product(Convert.ToInt32(row[0]), row[1], Convert.ToInt32(row[2])));
                        // dgv_values.Rows.Insert(row_index, row);
                        row_index++;
                    }
                }
                else
                {
                    MessageBox.Show("There are no products in your database! First select 'Products' from the menu and add some products.");
                }
            }
            else
            {
                MessageBox.Show("The table `products` is not accessible!");
            }
        }
        

        private void PopulateComboBox()
        {

            int selected = comboBox_ProductName.SelectedIndex; // remember selection
            comboBox_ProductName.Items.Clear();
            for (int i = 0; i < ListProduct.Count; i++)
            {
                comboBox_ProductName.Items.Add(ListProduct[i].productName);
            }
            comboBox_ProductName.SelectedIndex = selected;
        }

        private bool RunQuery(string query, bool readDb) // run and db query and deliver error message
        {
            bool success = false;
            List<string> DbQueryList = Database.DbQuery(database_name, query, readDb); // send query to delete
            if (DbQueryList[2] != "") { MessageBox.Show(DbQueryList[2], caption: "Error message"); }
            else success = true;

            return success;
        }


    }
}
