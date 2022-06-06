using MySql.Data.MySqlClient;
using WinForms_StorageManager.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms_StorageManager
{
    public partial class ProductsForm : Form
    {
        string query = "";
        readonly bool readDb = true;
        readonly string database_name = "WinForms_StorageManager";
        readonly string table_name = "products";
        readonly List<string> ColumnNameList = new List<string> {"Id", "Product name", "Price" }; // list of column names

        readonly int PK_column_index = 0;
        readonly string  PK_field_name = "productId";
        bool edit_mode = false;
        bool deleteRow_activated = false;

        string rankProductId = "DESC";
        string rankProductName = "DESC";
        string rankPrice = "DESC";

        int column0CustomWidth = -1;
        int column1CustomWidth = -1;
        int column2CustomWidth = -1;

        public ProductsForm()
        {
            InitializeComponent();
            query = $"SELECT * FROM `{database_name}`.`{table_name}` ORDER BY `productId` DESC;";
            ShowValues();
            label_addProductIdError.Text = "";
            label_addProductNameError.Text = "";
            label_addPriceError.Text = "";
            label_deleteProductIdError.Text = "";
        }
        private void ShowValues()
        {
            ResetDatagridview();

            string query_check = $"SHOW TABLES LIKE '{table_name}';";
            if (CheckDbRecord(query_check)) // whether there is a table in the database
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

                    // CountRowsDatagridview();

                    button_deleteRow.Enabled = true;
                }
                ResizeDatagridview();
                if (row_index == 1) button_deleteRow.Enabled = false; // if there is no row, then the delete botton is disabled
                else textBox_addProductId.Text = (int.Parse(DbQueryList[1]) + 1).ToString();
                                
            }
            else
            {
                button_deleteRow.Enabled = false;
                MessageBox.Show($"Table '{table_name}' does not exist, or database is not responding! source: CheckDbRecord()");
            }
        }

        private void ResetDatagridview()
        {
            column0CustomWidth = column0CustomWidth > -1 ? dgv_values.Columns[0].Width : 40; // keep column width if changed by the user
            column1CustomWidth = column1CustomWidth > -1 ? dgv_values.Columns[1].Width : 190;
            column2CustomWidth = column2CustomWidth > -1 ? dgv_values.Columns[2].Width : 70;
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

            int total_width = + dgv_values.RowHeadersWidth*0;

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
            if (total_width < 330) // original dgv_value.With
            {
                dgv_values.ClientSize = new Size(total_width, 488);
            }
            else
            {
                dgv_values.ClientSize = new Size(330, 488);
            }
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

                if (headerText == "Id") // productId
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

            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (CheckAddContent() == false) return; // stop if entered data is incorrect

            int productId = Convert.ToInt32(textBox_addProductId.Text);
            string productName = textBox_addProductName.Text;
            int price = Convert.ToInt32(textBox_addPrice.Text);

            string query_insert = $"INSERT INTO `{table_name}` VALUES ({productId}, '{productName}', '{price}');";
            if (SaveResultIntoTable(database_name, query_insert) == false) return;
            edit_mode = true;
            ShowValues(); // if there is no error message
            // textBox_addProductId.Text = (productId + 1).ToString(); //increase productId in the textbox to make entry easier

            // MenuForm.Test();
            Common.menuForm.GetTotals(); // a Menuform public static (global) menuForm példány GetTotals() public metódusának futtatása!
        }

        private bool CheckAddContent()
        {
            // check productID
            bool productIdOK = true;
            string productId = textBox_addProductId.Text;
            if (productId.Length < 1) // (MaxLength property is set to 9)
            {
                label_addProductIdError.Text = "Must be at least 1 digit!";
                productIdOK = false;
            }
            else
            {
                bool intExists = int.TryParse(productId, out int result);
                if (intExists == false)
                {
                    label_addProductIdError.Text = "Please enter a whole number!";
                    productIdOK = false;
                }
                if (result <0)
                {
                    label_addProductIdError.Text = "Must be a positive number!";
                    productIdOK = false;
                }
            }
            if (productIdOK) label_addProductIdError.Text = "";

            // check productName
            bool productNameOK = true;
            if (textBox_addProductName.Text.Length < 4) // (MaxLength property is set to 30)
            {
                label_addProductNameError.Text = "Must be at least 4 characters!";
                productNameOK = false;
            }
            else
            {
                label_addProductNameError.Text = "";
            }
            if (productNameOK) label_addProductNameError.Text = "";

            // check price
            bool priceOK = true;
            string price = textBox_addPrice.Text;
            if (price.Length < 1) // (MaxLength property is set to 9)
            {
                label_addPriceError.Text = "Must be at least 1 digit!";
                priceOK = false;
            }
            else
            {
                bool intExists = int.TryParse(price, out int result);
                if (intExists == false)
                {
                    label_addPriceError.Text = "Please enter a whole number!";
                    priceOK = false;
                }
                if (result < 0)
                {
                    label_addPriceError.Text = "Must be a positive number!";
                    priceOK = false;
                }
            }
            if (priceOK) label_addPriceError.Text = "";

            return productIdOK && productNameOK && priceOK;
        }

        private bool CheckDeleteContent()
        {
            // check productID
            bool productIdOK = true;
            string productId = textBox_deleteProductId.Text;
            if (productId.Length < 1) // (MaxLength property is set to 9)
            {
                label_deleteProductIdError.Text = "Must be at least 1 digit!";
                productIdOK = false;
            }
            else
            {
                bool intExists = int.TryParse(productId, out int result);
                if (intExists == false)
                {
                    label_deleteProductIdError.Text = "Please enter a whole number!";
                    productIdOK = false;
                }
                if (result < 0)
                {
                    label_deleteProductIdError.Text = "Must be a positive number!";
                    productIdOK = false;
                }
            }
            if (productIdOK) label_deleteProductIdError.Text = "";

            return productIdOK;
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
            else
            {
                string message = DbQueryList[2];
                if (DbQueryList[2].Contains("Duplicate entry") && DbQueryList[2].Contains("for key 'PRIMARY'"))
                {
                    message = $"An entry with Product id '{textBox_addProductId.Text}' already exists. Please choose another Id!";
                }
                else if (DbQueryList[2].Contains("Duplicate entry") && DbQueryList[2].Contains("for key 'productName'"))
                {
                    message= $"An entry with Product name '{textBox_addProductName.Text}' already exists. Please choose another Id!";
                }
                MessageBox.Show(message, caption: "Error message");
            }
            return success;
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (CheckDeleteContent() == false) return; // stop if entered data is incorrect

            int productId = Convert.ToInt32(textBox_deleteProductId.Text);

            string query = $"SELECT * FROM `{table_name}` WHERE `productId` = '{productId}';";
            // stops if there is no record to delete
            if (CheckDbRecord(query) == false)
            {
                MessageBox.Show($"Record with product Id {productId} does not exist!", caption: "Alert");
                return;
            }

            // confirm delete
            string question = $"Are you sure to delete the product with id {productId}?";
            if (Common.UserAnswer(question, caption: "Question"))
            {
                int field_value = productId;
                query = $"DELETE FROM `{database_name}`.`{table_name}` WHERE `{table_name}`.`{PK_field_name}` = '{field_value}';";
                if (RunQuery(query, readDb: false) == false) return; // delete record

                edit_mode = true;
                ShowValues();
                Common.menuForm.GetTotals(); // a Menuform public static (global) menuForm példány GetTotals() public metódusának futtatása!
            }
        }

        private bool CheckDbRecord(string query) // check whether a record exists in the database
        {
            bool recordExits = false;
            List<string> DbQueryList = Database.DbQuery(database_name, query, readDb: false); // send query
            if (DbQueryList[2] != "") { MessageBox.Show(DbQueryList[2], caption: "Error message"); }
            else if (DbQueryList[1] != "0") // if at least a row is returned from the database
            {
                recordExits = true;
            }
            return recordExits;
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
