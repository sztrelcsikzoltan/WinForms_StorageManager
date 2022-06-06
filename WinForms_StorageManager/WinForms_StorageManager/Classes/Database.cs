using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace WinForms_StorageManager.Classes
{
    class Database
    {

        public static List<string> DbQuery (string database_name, string query, bool readDb)
        {
            string errorMessage = "";
            List<string> DbQueryList = new List<string>();
            string connectionString = $"datasource=localhost;port=3306;username=root;password=; {(database_name !="" ? $"database={database_name};" : "")} CharSet=utf8;Convert Zero Datetime=True;"; // to avoid System.DateTime conversion error
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            int num_columns = 0;
            int num_rows = 0;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    num_columns = reader.FieldCount;
                    while (reader.Read())
                    {
                        string value = "";
                        for (int i = 0; i < num_columns; i++)
                        {
                            value = !reader.IsDBNull(i) ? reader.GetValue(i).ToString() : "";
                            //string fieldType = reader.GetFieldType(i).ToString();
                            if (value == "01.01.01 00:00:00") value = "00.00.00 00:00:00";
                            // if (value == "01.01.01 00:00:00") row[i] = "00-00-00";
                            DbQueryList.Add(value);
                        }
                        num_rows++;
                        if (readDb == false) break; // read only one row if readADb = false
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
                // MessageBox.Show(ex.ToString(), caption: "Error message");
            }
            databaseConnection.Close();
            DbQueryList.Insert(0, num_columns.ToString()); // insert number of columns
            DbQueryList.Insert(1, num_rows.ToString()); // insert number of rows
            DbQueryList.Insert(2, errorMessage); // insert error message
            return DbQueryList;
        }
    }
}
