﻿using System;
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
using static TicketApp.MainApp;

namespace TicketApp
{
    public partial class MainApp : Form
    {
        //de session variable word gedeclareed voor later bij de login
        private static Session session;
        private List<string> featured = new List<string>();
        
        public MainApp()
        {
            //deze functie haalt 5 films uit de database en laad deze in het form zien
            InitializeComponent();
            Main_panel.BringToFront();
            var Function = new Functions();
            DataRowCollection data = Functions.Select("SELECT * FROM Films LIMIT 5");
            //id's van films in list geplaatst

            //id worden niet goed op volgorde gezet !
            featured.Add(data[0]["id"].ToString());
            featured.Add(data[1]["id"].ToString());
            featured.Add(data[2]["id"].ToString());
            featured.Add(data[3]["id"].ToString());
            featured.Add(data[4]["id"].ToString());



            //id worden niet goed op volgorde gezet !
            //film naam word bij de labels gezet
            label1.Text = data[0]["naam"].ToString();
            label2.Text = data[1]["naam"].ToString();
            label3.Text = data[2]["naam"].ToString();
            label4.Text = data[3]["naam"].ToString();
            label5.Text = data[4]["naam"].ToString();

        }
        private void search_button_Click(object sender, EventArgs e)
        {
            //hier word de functions class aangeroepen hier zitten functies in die veel gebruikt worden zie Functions.cs
            var Function = new Functions();
            string value = SearchBox.Text.Trim();

            //hier word er in de database gezocht of de gezochte film bestaat zo ja word deze getoont 
            DataRowCollection data = Functions.Select("SELECT * FROM films WHERE naam = '" + value.ToLower() + "'");

            if (data.Count > 0)
            {
                //film pagina word opgezet
                setMoviePage(data);

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
            var Function = new Functions();
            //deze functie geeft een melding met wat info
            Function.Message("Made by:\n" +
                "\n"+
                "Brian Vaartjes.\n" +
                "Glenn Visser.\n" +
                "Jeroen Struijk.\n" +
                "Jeroen Uijtdewilligen.\n" +
                "Sam Birahij.");
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            var Function = new Functions();
            //deze functie roept het login formulier aan of logt een gebruikers uit als deze al is ingelogd
            if (session != null)
            {
                Function.Message("U bent uitgelogd!!");
                session = null;
            }
            else {
                login loginForm = new login();
                loginForm.Show();
            }
        }

        private void aanmeld_button_Click(object sender, EventArgs e)
        {
            var Function = new Functions();
            //deze functie roept het aanmeld formulier aan of geeft een melding als een gebruiker is ingelogd
            if (session != null)
            {
                Function.Message("U Bent al ingelogd!!");
            }
            else
            {
                //aanmeld form word geladen 
                signup SingupForm = new signup();
                SingupForm.Show();
            }
        }

        public void Loggedin(DataRow data) 
        {
            var Function = new Functions();
            //deze functie laad de login gegevens in een session hier kunnen we later in  app gegevens van een ingelogde gebruiker terug vinden
            session = new Session();
            session.voornaam = data["voornaam"].ToString();
            session.achternaam = data["achternaam"].ToString();
            session.email = data["email"].ToString();
            session.role = data["role_id"].ToString();

            Function.Message("Welcome " + data["voornaam"].ToString() + " " + data["achternaam"].ToString() + "\n" 
                + "U bent ingelogd!" + " \n" + " \n" + " Uw Role is: " + data["name"]);

        }

        private void setMoviePage(DataRowCollection data)
        {
            var Function = new Functions();
            film_name.Text = data[0]["naam"].ToString();
            film_age.Text = data[0]["leeftijd"].ToString();
            film_desc.Text = "Film Beschrijving: " + data[0]["beschrijving"].ToString();
            film_speelduur.Text = data[0]["speel_duur"].ToString() + " Minuten";
            film_genre.Text = data[0]["genre"].ToString();

            string picture_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics/films/" + data[0]["img_url"] + ".jpg");
            string BG_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics/BG/" + data[0]["back_url"] + ".png");
            searched_movie.Image = Image.FromFile(picture_path);
            show_film_panel.BackgroundImage = Image.FromFile(BG_path);
            //inladen yt trailer:
            
            string html = Function.SetHtmlLink(data[0]["youtube_code"].ToString());
            string link = "https://www.youtube.com/watch?v=" + data[0]["youtube_code"].ToString();
            this.TrailerVideo.DocumentText = string.Format(html, link.Split('=')[1]); //stopt de HTML Link in de WebBrowser box
            show_film_panel.BringToFront();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Main_panel.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Function = new Functions();
            Function.Message("Select ticket function call!!!");
        }

        private void featured_1_Click(object sender, EventArgs e)
        {
            DataRowCollection data = Functions.Select("SELECT * FROM films WHERE id= '" + Int32.Parse(featured[0]) + "'");
            setMoviePage(data);
        }

        private void featured_2_Click(object sender, EventArgs e)
        {
            DataRowCollection data = Functions.Select("SELECT * FROM films WHERE id= '" + Int32.Parse(featured[1]) + "'");
            setMoviePage(data);
        }

        private void featured_3_Click(object sender, EventArgs e)
        {
            DataRowCollection data = Functions.Select("SELECT * FROM films WHERE id= '" + Int32.Parse(featured[2]) + "'");
            setMoviePage(data);
        }

        private void featured_4_Click(object sender, EventArgs e)
        {
            DataRowCollection data = Functions.Select("SELECT * FROM films WHERE id= '" + Int32.Parse(featured[3]) + "'");
            setMoviePage(data);
        }

        private void featured_5_Click(object sender, EventArgs e)
        {
            DataRowCollection data = Functions.Select("SELECT * FROM films WHERE id= '" + Int32.Parse(featured[4]) + "'");
            setMoviePage(data);
        }
    }
}
