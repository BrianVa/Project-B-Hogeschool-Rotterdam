using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using static TicketApp.Functions;
using System.Security.Cryptography;

namespace TicketApp
{
    class Functions
    {
        public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void Message(string message) 
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        public SQLiteConnection conn;
        public SQLiteCommand cmd;
        public SQLiteDataAdapter da;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();

        public void DataBaseConnection()
        {
            string database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database/Database.db");
            conn = new SQLiteConnection("data source=" + database + ";Version=3");
        }
        public void ExcQuery(string Query)
        {
            DataBaseConnection();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = Query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public int SelectData(string query) 
        {
            DataBaseConnection();
            conn.Open();
            cmd = conn.CreateCommand();
            da = new SQLiteDataAdapter(query, conn);
            return da.Fill(dt);

        }
    }
}
