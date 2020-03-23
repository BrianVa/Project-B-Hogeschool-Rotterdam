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
    public partial class MainApp : Form
    {
        private static Session session;
        public MainApp()
        {
            InitializeComponent();
            string database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database/Database.db");
            SQLiteConnection conn = new SQLiteConnection("data source=" + database + ";Version=3");
            conn.Open();
            string query = "SELECT * FROM Films";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            //inlog_naam.Hide();

            /*foreach (DataRow item in dt.Rows)
            {
               
            }*/
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            string value = SearchBox.Text;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void info_button_click(object sender, EventArgs e)  
        {
            System.Windows.Forms.MessageBox.Show("Made by:\n" +
                "\n"+
                "Brian Vaartjes.\n" +
                "Glenn Visser.\n" +
                "Jeroen Struijk.\n" +
                "Jeroen Uijtdewilligen.\n" +
                "Sam Birahij.");
        }

        private void login_button_Click(object sender, EventArgs e)
        {

            if (session != null)
            {
                System.Windows.Forms.MessageBox.Show("U bent uitgelogd!!");
                session = null;
            }
            else {
                login login = new login();
                login.Show();
            }
        }

        private void aanmeld_button_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
        }
        private void movie_select(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Form Pop-up");
        }
        private void change_label()
        {
            login_button.Text = "Logout";
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

            change_label();

        }
    }
}
