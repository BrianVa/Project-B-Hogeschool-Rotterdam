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

        private void Submit_Click(object sender, EventArgs e)
        {
            // hier worden de gegevens gevalideert
            var Function = new Functions();
            if (Email.Text.Trim() == "" && Password.Text.Trim() == "")
            {
                Function.Message("error empty fields!");
            }
            else if (Email.Text.Trim().Contains("@") && Email.Text.Trim().Contains("."))
            {
                //hier word gekeken of het email en wachtwoord overeen komen
                string hash = Function.ComputeSha256Hash(Password.Text.Trim());
                string database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database/Database.db");
                SQLiteConnection conn = new SQLiteConnection("data source=" + database + ";Version=3");
                string query = "SELECT * FROM gebruikers g LEFT JOIN Roles r ON g.Role_id = r.ID  WHERE g.Email = '"+Email.Text.Trim()+"' AND g.password = '"+hash+"'";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0)
                {
                    //als het email adress en wachtword overeen komen word de gebuiker ingelogd
                    this.Close();
                    BitFilm main = new BitFilm();
                    dt.Rows[0]["password"] = "";
                    main.Loggedin(dt.Rows[0]);

                }
                else
                {
                    Function.Message("Verkeerd Email of Wachtwoord!");
                }

            }
            else
            {
                Function.Message(Email.Text.Trim() + " is geen gelding emailadres!");
            }
        }
    }
}
