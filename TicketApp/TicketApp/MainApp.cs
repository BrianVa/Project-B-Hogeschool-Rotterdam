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
using static TicketApp.MainApp;

namespace TicketApp
{
    public partial class MainApp : Form
    {
        //de session variable word gedeclareed voor later bij de login
        public static Session session;
        private List<Label> featuredFilmsTitle = new List<Label>();
        private List<Label> featuredFilmsPic = new List<Label>();
        private List<string> featured = new List<string>();
        private int selectedFilm;
        private int selectedTime;

        public MainApp()
        {
            //deze functie haalt 5 films uit de database en laad deze in het form zien
            InitializeComponent();

            var Function = new Functions();

            this.mijnAccountToolStripMenuItem.Visible = false;
            DataRowCollection data = Functions.Select("SELECT * FROM Films LIMIT 5");

            //nieuwe functie voor feature films
            //setfeaturedFilms(5);

            //id's van films in list geplaatst

            //id worden niet goed op volgorde gezet !
            featured.Add(data[0]["id"].ToString());
            featured.Add(data[1]["id"].ToString());
            featured.Add(data[2]["id"].ToString());
            featured.Add(data[3]["id"].ToString());
            featured.Add(data[4]["id"].ToString());


            //film naam word bij de labels gezet
            label1.Text = data[0]["naam"].ToString();
            label2.Text = data[1]["naam"].ToString();
            label3.Text = data[2]["naam"].ToString();
            label4.Text = data[3]["naam"].ToString();
            label5.Text = data[4]["naam"].ToString();

            LoadFonts();

            set_activepanel("main");
        }
        public string loginText
        {
            get
            {
                return this.login_button.Text;
            
            }
            set
            {
                this.login_button.Text = value; 
            
            }
        
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

        public void setMoviePage(DataRowCollection data)
        {
            var totalMinutes = Int32.Parse(data[0]["speel_duur"].ToString());
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;

            var Function = new Functions();
            film_name.Text = data[0]["naam"].ToString();
            film_desc.Text = "Film Beschrijving: " + data[0]["beschrijving"].ToString();
            film_speelduur.Text = hours.ToString() + " uur " + " en " + minutes + " minuten";
            film_genre.Text = data[0]["genre"].ToString();

            string KijkwijzerFotoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics/pictogram/" + data[0]["leeftijd"].ToString() + ".png");
            Kijkwijzer.Image = Image.FromFile(KijkwijzerFotoPath);

            string picture_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics/films/" + data[0]["img_url"] + ".jpg");
            string BG_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics/BG/" + data[0]["back_url"] + ".png");
            searched_movie.Image = Image.FromFile(picture_path);
            show_film_panel.BackgroundImage = Image.FromFile(BG_path);
            TijdPanel.BackgroundImage = Image.FromFile(BG_path);

            //inladen yt trailer:

            string html = Function.SetHtmlLink(data[0]["youtube_code"].ToString());
            this.TrailerVideo.DocumentText = string.Format(html, data[0]["youtube_code"].ToString()); //stopt de HTML Link in de WebBrowser box

            selectedFilm = Int32.Parse(data[0]["id"].ToString());
            set_activepanel("film");
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            TrailerVideo.DocumentText = "";
            set_activepanel("main");
        }

        private void TicketBack_Click(object sender, EventArgs e)
        {
            DataRowCollection data = Functions.Select("SELECT * FROM films WHERE id= '" + selectedFilm + "'");
            setMoviePage(data);
        }

        private void OrderTijdButton_Click(object sender, EventArgs e)
        {
            var Function = new Functions();
            DataRowCollection age = Functions.Select("SELECT leeftijd FROM films WHERE id= '" + selectedFilm + "'");


            if (Int32.Parse(age[0]["leeftijd"].ToString()) >= 16)
            {
                if (Function.CheckAge(session, age))
                {
                    DataRowCollection data = Functions.Select("SELECT * FROM tijden WHERE film_id = '" + selectedFilm + "'");

                    FilmTijden.Rows.Clear();
                    foreach (DataRow row in data)
                    {
                   
                        int n = FilmTijden.Rows.Add();
                        FilmTijden.Rows[n].Cells[0].Value = "datum";
                        FilmTijden.Rows[n].Cells[1].Value = row["tijd"].ToString();
                        FilmTijden.Rows[n].Cells[2].Value = row["zaal_id"].ToString();
                        FilmTijden.Rows[n].Cells[3].Value = "Tickets";
                    }

                    set_activepanel("tijd");
                }
            }
            else
            {
                DataRowCollection data = Functions.Select("SELECT * FROM tijden WHERE film_id = '" + selectedFilm + "'");

                FilmTijden.Rows.Clear();
                foreach (DataRow row in data)
                {
                    int n = FilmTijden.Rows.Add();
                    FilmTijden.Rows[n].Cells[0].Value = row["date"];
                    FilmTijden.Rows[n].Cells[1].Value = row["tijd"].ToString();
                    FilmTijden.Rows[n].Cells[2].Value = row["zaal_id"].ToString();
                    FilmTijden.Rows[n].Cells[3].Value = "Tickets";
                }

                set_activepanel("tijd");

            }
        }

        private void set_activepanel(string panel)
        {
            TijdPanel.Visible = false;
            StoelPanel.Visible = false;
            Main_panel.Visible = false;
            show_film_panel.Visible = false;

            switch (panel)
            {
                case "main":
                    Main_panel.Visible = true;
                    break;
                case "tijd":
                    TijdPanel.Visible = true;
                    break;
                case "film":
                    show_film_panel.Visible = true;
                    break;
                case "stoel":
                    StoelPanel.Visible = true;
                    break;
                default:
                    Main_panel.Visible = true;
                    break;   
            }
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

        private void StoelSelectButton_Click(object sender, EventArgs e)
        {

            DataRowCollection zaal = Functions.Select("SELECT zaal_id FROM tijden WHERE id= '" + selectedTime + "'");
            DataRowCollection data = Functions.Select("SELECT * FROM stoelen WHERE zaal_id= '" + zaal[0]["zaal_id"] + "'");

            StoelSelect.Rows.Clear();
            foreach (DataRow row in data)
            {

                int n = FilmTijden.Rows.Add();
                StoelSelect.Rows[n].Cells[0].Value = data[0]["naam"].ToString();
                StoelSelect.Rows[n].Cells[3].Value = "Selecteer";
            }
            set_activepanel("stoel");
        }
        private void setfeaturedFilms(int amount)
        {
            int count = 0;
            var Function = new Functions();

            DataRowCollection data = Functions.Select("SELECT * FROM Films LIMIT '" + amount + "'");
            //id's van films in list geplaatst

            featured.Add(data[0]["id"].ToString());
            featured.Add(data[1]["id"].ToString());
            featured.Add(data[2]["id"].ToString());
            featured.Add(data[3]["id"].ToString());
            featured.Add(data[4]["id"].ToString());


            for (int i = 0; i < amount + 1; i++)
            {
                var label =
                    this.Controls.OfType<Label>().Where(lb => lb.Name == "label" + i).FirstOrDefault();
                if (label != null)
                    featuredFilmsTitle.Add(label);
            }

            featuredFilmsTitle.ForEach(delegate (Label name)
            {
                name.Text = data[count]["naam"].ToString();
                count++;
            });

            count = 0;

            featuredFilmsPic.ForEach(delegate (Label name)
            {
                string picture_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics/films/" + data[count]["img_url"] + ".jpg");
                name.Image = Image.FromFile(picture_path);
                count++;
            });

        }

        private void SecondeTimer_Tick(object sender, EventArgs e)
        {
            int xAxis = BackLoop.Location.X;
            if (xAxis <= -1280)
            {
                xAxis = 0;
            }
            else
            {
                xAxis -= 1;
            }

            BackLoop.Location = new Point(xAxis, 0);
        }

        private void mijnAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Function = new Functions();

            signup SingupForm = new signup();
            SingupForm.Show();
        }

        private void loggen_menu_Click(object sender, EventArgs e)
        {
            if (session != null)
            {
                mijnAccountToolStripMenuItem.Visible = true;
                mijnOrdersToolStripMenuItem.Visible = true;
                aanmeld_button.Visible = false;
                login_button.Text = "Logout";
            }
            else
            {
                mijnAccountToolStripMenuItem.Visible = false;
                mijnOrdersToolStripMenuItem.Visible = false;
                aanmeld_button.Visible = true;
                login_button.Text = "Login";
            }
        }

        public void LoadFonts()
        {
            var Function = new Functions();
            Function.UseCustomFont("CoutureBold", 36, BitfilmTekst);
            
        }

        private void StoelBackButton_Click(object sender, EventArgs e)
        {
            set_activepanel("ticket");
        }

        private void FilmTijden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FilmTijden.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (FilmTijden.CurrentCell != null && FilmTijden.CurrentCell.Value != null)
                    set_activepanel("stoel");
            }
        }

        private void mijnOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Function = new Functions();

            Orders orders = new Orders();
            orders.Show();
        }
    }
}
