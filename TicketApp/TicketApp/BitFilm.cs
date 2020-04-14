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
using static TicketApp.Session;

namespace TicketApp
{
    public partial class BitFilm : Form
    {
        private int childFormNumber = 0;
        private static Session session;
        public BitFilm()
        {
            InitializeComponent();
            string database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database/Database.db");
            SQLiteConnection conn = new SQLiteConnection("data source=" + database + ";Version=3");
            conn.Open();
            string query = "SELECT * FROM Films LIMIT 5";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            foreach (DataRow item in dt.Rows)
            {
                  
            }
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            if (session != null)
            {
                System.Windows.Forms.MessageBox.Show("U bent uitgelogd!!");
                session = null;
            }
            else
            {
                login login = new login();
                login.MdiParent = this;
                login.Show();
            }
        }

        private void aanmelden_button_Click(object sender, EventArgs e)
        {
            if (session != null)
            {
                System.Windows.Forms.MessageBox.Show("U Bent ingelogd!!");
            }
            else
            {
                signup signup = new signup();
                signup.MdiParent = this;
                signup.Show();
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Made by:\n" +
                "\n" +
                "Brian Vaartjes.\n" +
                "Glenn Visser.\n" +
                "Jeroen Struijk.\n" +
                "Jeroen Uijtdewilligen.\n" +
                "Sam Birahij.");
        }
        public void Loggedin(DataRow data)
        {
            session = new Session();
            session.voornaam = data["voornaam"].ToString();
            session.achternaam = data["achternaam"].ToString();
            session.email = data["email"].ToString();
            session.role = data["role_id"].ToString();

            System.Windows.Forms.MessageBox.Show("Welcome " + data["voornaam"].ToString() + " " + data["achternaam"].ToString() + "\n"
                + "U bent ingelogd!" + " \n" + " \n" + " Uw Role is: " + data["name"]);

            this.Login_button.Text = "Logout";
        }
        private void BitFilm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
