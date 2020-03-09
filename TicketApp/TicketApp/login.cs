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

namespace TicketApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }
        private void username_TextChanged(object sender, EventArgs e)
        {
            string temp = Email.Text;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            string temp = Password.Text;
        }

        private void login_button_Click(object sender, EventArgs e)
        {

            if (Email.Text.Trim() == "" && Password.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("error empty fields!");
            }
            else if (Email.Text.Trim().Contains("@") && Email.Text.Trim().Contains("."))
            {
                var Function = new Functions();
                string hash = Function.ComputeSha256Hash(Password.Text.Trim());
                string database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database/Database.db");
                SQLiteConnection conn = new SQLiteConnection("data source=" + database + ";Version=3");
                string query = "SELECT * FROM gebruikers WHERE Email = @email AND password = @password";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", Email.Text.Trim());
                cmd.Parameters.AddWithValue("@password", hash);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string voornaam = row["voornaam"].ToString();
                        string achternaam = row["achternaam"].ToString();
                        System.Windows.Forms.MessageBox.Show("Welcome " + voornaam + " " + achternaam + "\n" + "U bent ingelogd!");
                        this.Close();
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Verkeerd Email of Wachtwoord!");
                }
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(Email.Text.Trim() + " is geen gelding emailadres!");
            }

            //MainApp main = new MainApp();

            //main.login_button.Text = "Logout";
        }
    }
}
