using MySql.Data.MySqlClient;
using System;
using WinForms_StorageManager.Classes;
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
    public partial class StartForm : Form
    {
        int progressbar_counter = 0;
        int progressbar_counter0 = 0;
        int progressbar_counter1 = 0;
        string query = "";
        readonly bool readDb = true;
        string SQL_errorMessage = "";
        bool databaseExists = false;
        readonly string database_name = "winforms_storagemanager";
        string table_name = "";

        public StartForm()
        {
            InitializeComponent();
            
            label_status0.Visible = false;
            label_status1.Visible = false;
            progressBar1.Visible = false;

            SQL_errorMessage = DatabaseConnectionCheck();
            progressTimer.Start();
            DatabaseSet();
        }

        private void MenuForm_Click(object sender, EventArgs e)
        {
            // show form only if does not exist
            if (Common.CheckOpenForms("MenuForm") == false)
            {
                Common.menuForm = new MenuForm();
                //MenuForm menuForm = new MenuForm();
                Common.menuForm.Show();
            }
        }

        private void DatabaseForm_Click(object sender, EventArgs e)
        {
            // show form only if does not exist
            if (Common.CheckOpenForms("DatabaseForm") == false)
            {
                DatabaseForm databaseForm = new DatabaseForm();
                databaseForm.Show();
            }

        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (progressbar_counter == 20) // after 1 second
            {
                label_title.Visible = true;
            }
            if (progressbar_counter == 40) // after 2 seconds
            {
                label_status0.Visible = true;
            }
            if (progressbar_counter == 60) // after 3 seconds
            {
                progressBar1.Visible = true;
            }
            if (progressbar_counter > 70)
            {
                if (progressBar1.Value < 100)
                {
                    progressBar1.Value += 2;
                }
                else
                {
                    progressBar1.Visible = false;
                    // if there is a database connection
                    if (SQL_errorMessage == "")
                    {

                        label_status1.Visible = true;
                        progressBar1.Visible = false;
                        EnableButtons();
                    }
                    else
                    {

                        if (label_noConnection.Visible == false)
                        {
                            label_noConnection.Visible = true;
                            button_errorMessageDetails.Visible = true;
                            button_connectToDatabase.Visible = true;
                            label_status1.Visible = false;
                        }

                        if (SQL_errorMessage.Contains("Unable to connect to any of the specified MySQL hosts.") && label_status0.Visible == true)
                        {
                            label_status0.Visible = false;
                            MessageBox.Show("Connection to the MySQL database failed! \nPlease make sure that the database server is available and your connection settings are correct (datasource=localhost;port=3306).", caption: "Error message");
                        }
                        EnableButtons();
                    }
                }
            }
            progressbar_counter++;
        }

        private void EnableButtons()
        {
            if (progressbar_counter0 == 0)
            {
                progressbar_counter0 = progressbar_counter;
                progressbar_counter1 = progressbar_counter;
            }
            if (progressbar_counter1 - progressbar_counter0 == 5)
            {
                
            }
            if (progressbar_counter1 - progressbar_counter0 == 10)
            {
                
            }
            if (progressbar_counter1 - progressbar_counter0 == 20)
            {
                if(SQL_errorMessage == "") button_menu.Enabled = true;
            }
            if (progressbar_counter1 - progressbar_counter0 == 40)
            {
                if (SQL_errorMessage == "") button_database.Enabled = true;
            }
            if (progressbar_counter1 - progressbar_counter0 == 100)
            {
                label_status0.Visible = false;
                label_status1.Visible = false;
                progressTimer.Stop();
                progressbar_counter0 = 0;

            }
            progressbar_counter1++;
        }
        
        private string DatabaseConnectionCheck()
        {
            query = "SHOW DATABASES;";
            List<string> DbQueryList =  Database.DbQuery("", query, readDb);

            if (DbQueryList[2] == "" && DbQueryList[1] !="0") // if no error and there are rows in the database
            {
                for (int i = 3; i < DbQueryList.Count; i++)
                {
                    if (DbQueryList[i] == database_name)
                    {
                        databaseExists = true;
                        break;
                    }
                }
            }
            return DbQueryList[2]; // return error message
        }

        private void CreateDatabase()
        {
            if (databaseExists == false) // if there is no such database, we create it
            {
                string query = $"CREATE DATABASE `{database_name}` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;";
                Database.DbQuery("", query, false);
            }
        }

        private bool CreateTable(string query)
        {
            bool createTable = false;
            if (CheckTable(table_name) == false)// if table not present, we create it
            {
                List<string> DbQueryList = Database.DbQuery(database_name, query, false);
                if (DbQueryList[2] != "")
                {
                    MessageBox.Show(DbQueryList[2], caption: "Error message");
                }
                else
                {
                    createTable = true;
                }
            }
            return createTable;
        }

        private bool CheckTable(string table_name) // whether table exists
        {
            bool tableExists = false;
            query = $"SHOW TABLES LIKE '{table_name}';";
            List<string> DbQueryList = Database.DbQuery(database_name, query, readDb:false);
            if (DbQueryList[2] != "") { MessageBox.Show(DbQueryList[2], caption: "Error message"); }
            else if (DbQueryList[1] != "0") tableExists = true;

            return tableExists;
        }

        private void SaveResultIntoTable(string database_name, string query)
        {
            List<string> DbQueryList = Database.DbQuery(database_name, query, false);
            if (DbQueryList[2] != "") MessageBox.Show(DbQueryList[2], caption: "Error message");
        }
                
        
        private void Button_errorMessageDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SQL_errorMessage, caption: "Details of the error message");
        }

        private void Button_connectToDatabase_Click(object sender, EventArgs e)
        {
            label_status0.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            button_connectToDatabase.Visible = false;
            label_noConnection.Visible = false;
            button_errorMessageDetails.Visible = false;
            SQL_errorMessage = DatabaseConnectionCheck();
            progressTimer.Start();
            DatabaseSet();
        }

        private void DatabaseSet()
        {
            // SQL_errorMessage = DatabaseConnectionCheck();
            if (SQL_errorMessage == "") // if there is database connection
            {
                CreateDatabase();
                table_name = "users";
                query = $"CREATE TABLE `users` (`username` varchar(30) PRIMARY KEY, `password` varchar(30), `date` datetime)";
                if (CreateTable(query))
                {
                    SaveResultIntoTable(database_name, $"INSERT INTO `users` VALUES ('Pete', 'Password', '{DateTime.Now}');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `users` VALUES ('Ms. Mary', 'Password', '{DateTime.Now}');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `users` VALUES ('User', 'Password', '{DateTime.Now}');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `users` VALUES ('Bill', 'Password', '{DateTime.Now}');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `users` VALUES ('Cindy', 'Password', '{DateTime.Now}');");
                };

                table_name = "products";
                query = $"CREATE TABLE `products` (`productId` int(11) PRIMARY KEY, `productName` varchar(30) UNIQUE, `price` int(11))";
                if (CreateTable(query))
                {
                    SaveResultIntoTable(database_name, $"INSERT INTO `products` VALUES (1, 'Product 1', '200');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `products` VALUES (2, 'Product 2', '300');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `products` VALUES (3, 'Product 3', '400');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `products` VALUES (4, 'Product 4', '100');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `products` VALUES (5, 'Product 5', '500');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `products` VALUES (6, 'Product 6', '600');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `products` VALUES (7, 'Product 7', '700');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `products` VALUES (8, 'Product 8', '800');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `products` VALUES (9, 'Product 9', '900');");
                    SaveResultIntoTable(database_name, $"INSERT INTO `products` VALUES (10, 'Product 10', '1000');");
                };

                table_name = "sales";
                query = $"CREATE TABLE `sales` (`id` int(11) auto_increment PRIMARY KEY, `FKproductId` int(11), `date` datetime, `amount` int(11), CONSTRAINT `FKproductId` FOREIGN KEY (`FKproductId`) REFERENCES `products`(`productId`))";
                if (CreateTable(query))
                {
                    SaveResultIntoTable(database_name, $"INSERT INTO `sales` VALUES (1, 2, '2021-11-13 19:21:27', 10);");
                    SaveResultIntoTable(database_name, $"INSERT INTO `sales` VALUES (2, 4, '2021-11-13 19:21:27', 10);");
                    SaveResultIntoTable(database_name, $"INSERT INTO `sales` VALUES (3, 7, '2021-11-13 19:21:27', 10);");
                    SaveResultIntoTable(database_name, $"INSERT INTO `sales` VALUES (4, 6, '2021-11-13 19:21:27', 10);");
                    SaveResultIntoTable(database_name, $"INSERT INTO `sales` VALUES (5, 8, '2021-11-13 19:21:27', 10);");
                    SaveResultIntoTable(database_name, $"INSERT INTO `sales` VALUES (6, 10, '2021-11-13 19:21:27', 10);");
                };

                // CONSTRAINT `FKproductId` FOREIGN KEY REFERENCES `products`(`productId`));

            }
        }


    }
}
