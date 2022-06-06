using System;
using System.Collections.Generic;
using WinForms_StorageManager.Classes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using WinForms_StorageManager.Properties;

namespace WinForms_StorageManager
{

    public partial class MenuForm : Form
    {
        string query = "";
        readonly string database_name = "WinForms_StorageManager";
        readonly string table_name = "users";

        public static void Test()
        {
            // query = "";
        }
        public MenuForm()
        {
            InitializeComponent();
            // if (Common.static_ == true) return;
            ResetLogin();
            InitTimer();
        }

        private void ResetLogin()
        {
            productsToolStripMenuItem.Enabled = false;
            salesToolStripMenuItem.Enabled = false;
            statisticsToolStripMenuItem.Enabled = false;
            label_info.Text = "First select Login then enter username and password.";
            textBox_loginName.Text = "";
            textBox_password.Text = "";
            label_loginNameError.Text = "";
            label_passwordError.Text = "";
            loginToolStripMenuItem.Text = "Login";
            label_user.Text = "Logged out";
            pictureBox1.Image = Resources.login_button;
            label_totalProducts.Text = "";
            label_totalSales.Text = "";
        }

        public void GetTotals()
        {
            // get total number of products from database
            query = "SELECT COUNT(*) FROM `products`;";
            label_totalProducts.Text = "total: 0";
            if (CheckDbRecord(checkEmpty: true) == true) label_totalProducts.Text = $"total: {Database.DbQuery(database_name, query, readDb: true)[3]}";

            // get total amount sold
            query = "SELECT SUM(`sales`.`amount`) FROM `sales`;";

            int totalAmount = 0;
            if (CheckDbRecord(checkEmpty: true) == true) totalAmount = Convert.ToInt32(Database.DbQuery(database_name, query, readDb: true)[3]);

            // get total revenue
            query = "SELECT SUM(`sales`.`amount`)*`products`.`price` FROM `products` INNER JOIN `sales` ON `products`.`productId` = `sales`.`FKproductId` GROUP BY `productName`";
            int totalRevenue = 0;
            if (CheckDbRecord(checkEmpty: true) == true)
            {
                List<string> DbQueryList = Database.DbQuery(database_name, query, readDb: true);
                for (int i = 3; i < DbQueryList.Count; i++) // skip first two items (num_columns, num_rows, errorMessage)
                {
                    totalRevenue += Convert.ToInt32(DbQueryList[i]);
                }
            }
            label_totalSales.Text = $"total sold:  {totalAmount:#,0}\nrevenue:   {totalRevenue:#,0} EUR";
            // Button_login.Focus();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Text == "Login")
            {
                panel_Login.Visible = true;
            }
            else
            {
                ResetLogin();
            }
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            Button_login_ClickOrEnter();
        }

        private void MenuForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && panel_Login.Visible) // the KeyPreview property of the form must be True!
            {
                Button_login_ClickOrEnter();
                e.SuppressKeyPress = true;
            }
        }

        private void Button_login_ClickOrEnter()
        {
            if (CheckLoginContent() == false) return; // stop if username or password format is incorrect

            // check user
            query = $"SELECT * FROM `{table_name}` WHERE `username` = '{textBox_loginName.Text}';";
            // if (CheckDbQuery() == false) return;
            if (CheckUser() == false) return; // stop if username or password is incorrect

            productsToolStripMenuItem.Enabled = true;
            salesToolStripMenuItem.Enabled = true;
            statisticsToolStripMenuItem.Enabled = true;
            label_info.Text = $"Hello {textBox_loginName.Text}, your are logged in.";
            panel_Login.Visible = false;
            loginToolStripMenuItem.Text = "Logout";
            label_user.Text = "Logged in";
            GetTotals();
            pictureBox1.Image = Resources.success;

        }
        private bool CheckLoginContent()
        {
            // check username and password
            bool loginContentOK = true;
            if (textBox_loginName.Text.Length < 4) // (MaxLength property is set to 30)
            {
                label_loginNameError.Text = "User name must be at least 4 characters!";
                loginContentOK = false;
            }
            else
            {
                label_loginNameError.Text = "";
            }
            
            if (textBox_password.Text.Length < 4) // (MaxLength property is set to 30)
            {
                label_passwordError.Text = "Password must be at least 4 characters!";
                loginContentOK = false;
            }
            else
            {
                label_passwordError.Text = "";
            }

            return loginContentOK;
        }

        private bool CheckUser() // whether the user exists
        {
            bool logindataOK = true;
            List<string> DbQueryList = Database.DbQuery(database_name, query, readDb: false);

            if (DbQueryList[2] == "") // if there is no error
            {
                // check user in database
                if (DbQueryList[1] != "0") // username is found if a row was read)
                {
                    if (textBox_password.Text != DbQueryList[4]) // check password
                    {
                        label_passwordError.Text = "Password incorrect!";
                        logindataOK = false;
                    }
                }
                // if there is no user in the database with the entered username
                else
                {
                    label_loginNameError.Text = "User name incorrect!";
                    logindataOK = false;
                }
            }
            else
            {
                logindataOK = false;
                MessageBox.Show(DbQueryList[2], caption: "Error message");
            }
            return logindataOK;
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show form only if does not exist
            if (Common.CheckOpenForms("ProductsForm") == false)
            {
                ProductsForm productsForm = new ProductsForm();
                productsForm.Show();
            }

        }

        private void SalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show form only if does not exist
            if (Common.CheckOpenForms("SalesForm") == false)
            {
                SalesForm salesForm = new SalesForm();
                salesForm.Show();
            }
        }

        private void StatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Common.CheckOpenForms("StatisticsForm") == false)
            {
                StatisticsForm statisticsForm = new StatisticsForm();
                statisticsForm.Show();
            }
        }
        private bool CheckDbRecord(bool checkEmpty) // check whether a record exists in the database
        {
            bool recordExits = false;
            List<string> DbQueryList = Database.DbQuery(database_name, query, readDb: false); // send query
            if (DbQueryList[2] != "") { MessageBox.Show(DbQueryList[2], caption: "Error message"); }
            else if (DbQueryList[1] != "0") // if at least a row is returned from the database
            {
                if (checkEmpty == false || DbQueryList[3] != "") // if first row is not empty
                recordExits = true;
            }
            return recordExits;
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            // timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 1000 * 10; // 10 sec in miliseconds
            timer1.Start();
        }

        /*
        // run GetTotals every minute if ProductsForm or SalesForm is open
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if( Common.runGetTotals && Common.CheckOpenForms("ProductsForm") || Common.CheckOpenForms("SalesForm")) GetTotals();
        }
        */
    }
}
