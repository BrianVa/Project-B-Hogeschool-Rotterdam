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
        //de session variable word gedeclareed voor later bij de login
        private static Session session;
        public MainApp()
        {
            //deze functie haalt 5 films uit de database en laad deze in het form zien
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
            //film naam word bij de labels gezet
            label1.Text = dt.Rows[0]["naam"].ToString();
            label2.Text = dt.Rows[1]["naam"].ToString();
            label3.Text = dt.Rows[2]["naam"].ToString();
            label4.Text = dt.Rows[3]["naam"].ToString();
            label5.Text = dt.Rows[4]["naam"].ToString();
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            //hier word de functions class aangeroepen hier zitten functies in die veel gebruikt worden zie Functions.cs
            var Function = new Functions();
            string value = SearchBox.Text.Trim();

            //hier word er in de database gezocht of de gezochte film bestaat zo ja word deze getoont 
            string database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database/Database.db");
            SQLiteConnection conn = new SQLiteConnection("data source=" + database + ";Version=3");
            conn.Open();
            string query = "SELECT * FROM films WHERE naam = '" + value.ToLower() + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            if (dt.Rows.Count > 0)
            {
                //als er een film is gevonden word er een melding getoond met film info
                System.Windows.Forms.MessageBox.Show("Film Naam: " + dt.Rows[0]["naam"].ToString() + " " + "\n" +
                     "Film Beschrijving: " + dt.Rows[0]["beschrijving"].ToString() + "\n" + 
                    "Film Leeftijd: " + dt.Rows[0]["leeftijd"].ToString() + " \n" +
                    "Speel duur: " + dt.Rows[0]["speel_duur"].ToString()

                    );
            }
            else {
                Function.Message("Kan film niet vinden!");
            }
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            // deze functie sluit de app af
            Environment.Exit(0);
        }
        private void info_button_click(object sender, EventArgs e)  
        {
            //deze functie geeft een melding met wat info
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
            //deze functie roept het login formulier aan  of logt een gebruikers uit als deze al is ingelogd
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
            //deze functie roept het aanmeld formulier aan of geeft een melding als een gebruiker is ingelogd
            if (session != null)
            {
                System.Windows.Forms.MessageBox.Show("U Bent al ingelogd!!");
            }
            else
            {
                //aanmeld form word geladen 
                signup signup = new signup();
                signup.Show();
            }
        }
        private void movie_select(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Form Pop-up");
        }

        public void Loggedin(DataRow data) 
        {
            //deze functie laad de login gegevens in een session hier kunnen we later in  app gegevens van een ingelogde gebruiker terug vinden
            session = new Session();
            session.voornaam = data["voornaam"].ToString();
            session.achternaam = data["achternaam"].ToString();
            session.email = data["email"].ToString();
            session.role = data["role_id"].ToString();

            System.Windows.Forms.MessageBox.Show("Welcome " + data["voornaam"].ToString() + " " + data["achternaam"].ToString() + "\n" 
                + "U bent ingelogd!" + " \n" + " \n" + " Uw Role is: " + data["name"]);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
