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
        private List<string> selectedStoelen = new List<string>();
        private List<string> featured = new List<string>();
        private int selectedFilm;
        private int selectedTime;

        public MainApp()
        {
            //deze functie haalt 5 films uit de database en laad deze in het form zien
            InitializeComponent();

            var Function = new Functions();

            this.mijnAccountToolStripMenuItem.Visible = false;
            this.medewerkerToolStripMenuItem.Visible = false;

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
            film_desc.Text = "Film Beschrijving:\n" + data[0]["beschrijving"].ToString();
            film_speelduur.Text = hours.ToString() + " uur " + " en " + minutes + " minuten";
            film_genre.Text = data[0]["genre"].ToString();

            string KijkwijzerFotoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics/pictogram/" + data[0]["leeftijd"].ToString() + ".png");
            Kijkwijzer.Image = Image.FromFile(KijkwijzerFotoPath);

            string picture_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics/films/" + data[0]["img_url"] + ".jpg");
            string BG_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics/BG/" + data[0]["back_url"] + ".png");
            searched_movie.Image = Image.FromFile(picture_path);
            show_film_panel.BackgroundImage = Image.FromFile(BG_path);
            TijdPanel.BackgroundImage = Image.FromFile(BG_path);
            StoelPanel.BackgroundImage = Image.FromFile(BG_path);
            AfrekenPanel.BackgroundImage = Image.FromFile(BG_path);
            BedanktPanel.BackgroundImage = Image.FromFile(BG_path);

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
                        DataRowCollection count = Functions.Select("SELECT COUNT(id) as all_stoelen FROM stoelen WHERE zaal_id = '" + row["zaal_id"] + "'");
                        DataRowCollection orders = Functions.Select("SELECT COUNT(id) as all_orders FROM orders WHERE tijd_id = '" + row["id"] + "'");
                        int n = FilmTijden.Rows.Add();
                        FilmTijden.Rows[n].Cells[0].Value = row["id"].ToString();
                        FilmTijden.Rows[n].Cells[1].Value = "datum";
                        FilmTijden.Rows[n].Cells[2].Value = row["tijd"].ToString();

                        FilmTijden.Rows[n].Cells[3].Value = Int32.Parse(count[0]["all_stoelen"].ToString()) - Int32.Parse(orders[0]["all_orders"].ToString());

                        FilmTijden.Rows[n].Cells[4].Value = "Tickets";
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
                    FilmTijden.Rows[n].Cells[0].Value = row["id"].ToString();
                    FilmTijden.Rows[n].Cells[1].Value = "datum";
                    FilmTijden.Rows[n].Cells[2].Value = row["tijd"].ToString();
                    FilmTijden.Rows[n].Cells[3].Value = row["zaal_id"].ToString();
                    FilmTijden.Rows[n].Cells[4].Value = "Tickets";
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
            AfrekenPanel.Visible = false;
            BedanktPanel.Visible = false;
            in_de_bios_panel.Visible = false;
            genres_panel.Visible = false;

            switch (panel)
            {
                case "main":
                    this.menuComboBox.Text = "Top 5";
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
                case "afrekenen":
                    AfrekenPanel.Visible = true;
                    break;
                case "bedankt":
                    BedanktPanel.Visible = true;
                    break;
                case "bioscoop":
                    in_de_bios_panel.Visible = true;
                    break;
                case "genres":
                    genres_panel.Visible = true;
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

        private void StoelSelectButton_Click(int selectedTime)
        {
            var orders = new List<string>();

            string taken = "";
            var Function = new Functions();
            DataRowCollection zaal = Functions.Select("SELECT zaal_id FROM tijden WHERE id= '" + selectedTime + "'");
            DataRowCollection data = Functions.Select("SELECT * FROM stoelen WHERE zaal_id= '" + zaal[0]["zaal_id"] + "'");

            DataRowCollection ordered = Functions.Select("SELECT stoel_id FROM orders WHERE tijd_id= '" + selectedTime + "'");

            foreach (DataRow row in ordered)
            {
                orders.Add(row["stoel_id"].ToString());        
            }

            StoelSelect.Rows.Clear();
            foreach (DataRow row in data)
            {
                int n = StoelSelect.Rows.Add();
                StoelSelect.Rows[n].Cells[0].Value = row["id"].ToString();
                StoelSelect.Rows[n].Cells[1].Value = row["naam"].ToString();

                if (orders.Contains(row["id"].ToString()))
                {
                    taken = "Bezet";
                }
                else
                {
                    taken = "Beschikbaar";
                }
                StoelSelect.Rows[n].Cells[2].Value = taken;
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
                if(session.isAdmin)
                {
                    medewerkerToolStripMenuItem.Visible = true;
                }
                login_button.Text = "Logout";
            }
            else
            {
                mijnAccountToolStripMenuItem.Visible = false;
                mijnOrdersToolStripMenuItem.Visible = false;
                medewerkerToolStripMenuItem.Visible = false;
                aanmeld_button.Visible = true;
                login_button.Text = "Login";
            }
        }

        private void FilmTijden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = FilmTijden.Rows[e.RowIndex];
                selectedTime = Int32.Parse(row.Cells[0].Value.ToString());
                StoelSelectButton_Click(selectedTime);
            }
        }

        private void mijnOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Function = new Functions();

            Orders orders = new Orders(session);
            orders.Show();
        }

        
        private void algemeneVoorwaardenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Functions = new Functions();
            Functions.Message("Algemene Voorwaarden: \n\n" +
                "1. De consument heeft na het akkoord gaan van de algemene voorwaarden een betalingsverplichting aan Bitfilm \n\n" +
                "2. De consument heeft standaard 14 dagen herroepingsrecht waarin deze zonder verklaring zijn/haar reservering ongedaan kan maken, mits de annulering minimaal 24 uur van te voren plaatsvindt. \n\n" +
                "3. Met het afrekenen gaat de consument akkoord met de betaling en moet de betaling binnen 30 dagen voltooid zijn, tenzij de reservering tijdig wordt geannuleerd. \n\n" +
                "4. Het kopen van tickets kan alleen gedaan worden met een geldige naam en emailadres. Bitfilm verstrekt deze gegevens niet zonder toestemming aan derde partijen. \n\n" +
                "5. Bij het reserveren van een 16+ film wordt bevestiging van een geldige leeftijd gevraagd. Bij een niet-geldige leeftijd kan er geen ticket worden verkocht. \n\n" +
                "6. Bitfilm hanteert de regels van Nicam in de Kijkwijzer. Deze regels zijn vastgelegd in het Wetboek van Strafrecht artikel 240a. Vanwege deze regelgeving kan er om legitimatie gevraagd worden door onze medewerkers. Wilt of kan u uzelf niet legitimeren of voldoet u niet aan de regelgeving dan zal de toegang worden geweigerd.In deze situatie vind geen restitutie of vergoeding plaats.\n");
        }

        private void StoelBackButton_Click(object sender, EventArgs e)
        {
            set_activepanel("tijd");
        }

        private void NaarAfrekenenKnop_Click(object sender, EventArgs e)
        {
            set_activepanel("afrekenen");
        }

        private void AlgVoorwaardenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AlgVoorwaardenCheckBox.Checked)
            {
                AfrekenKnop.Enabled = true;
            }
            else
            {
                AfrekenKnop.Enabled = false;
            }
        }

        private void AfrekenTerugKnop_Click(object sender, EventArgs e)
        {
            set_activepanel("stoel");
        }

        private void BackToHomeButton_Click(object sender, EventArgs e)
        {
            set_activepanel("main");
        }

        private void AfrekenKnop_Click(object sender, EventArgs e)
        {
            set_activepanel("bedankt");
        }

        private void StoelSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Function = new Functions();
            int amount = 3;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (selectedStoelen.Contains(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString()))
                {
                    senderGrid.Rows[e.RowIndex].Cells[2].Value = "Beschikbaar";
                    selectedStoelen.Remove(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                else{
                    if (selectedStoelen.Count < amount)
                    {
                        selectedStoelen.Add(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                        NaarAfrekenenKnop.Enabled = false;
                        senderGrid.Rows[e.RowIndex].Cells[2].Value = ((char)0x221A).ToString();
                    }
                    else {

                        NaarAfrekenenKnop.Enabled = true;

                    }

                }
   
            }  
        }

        private void menuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuComboBox.SelectedIndex == 0)
            {
                set_activepanel("main");
            }
            else if (menuComboBox.SelectedIndex == 1)
            {
                var Function = new Functions();
                DataRowCollection data = Functions.Select("SELECT * FROM Films LIMIT '20'");
                filmSelectGrid.Rows.Clear();
                foreach (DataRow row in data)
                {
                    int n = filmSelectGrid.Rows.Add();
                    filmSelectGrid.Rows[n].Cells[0].Value = row["naam"];
                    filmSelectGrid.Rows[n].Cells[1].Value = row["genre"];
                    filmSelectGrid.Rows[n].Cells[2].Value = row["speel_duur"].ToString() + " minuten";
                    filmSelectGrid.Rows[n].Cells[3].Value = row["leeftijd"].ToString();
                    filmSelectGrid.Rows[n].Cells[4].Value = "Filmpagina";
                }
                set_activepanel("bioscoop");
            }
            else if (menuComboBox.SelectedIndex == 2)
            {
                set_activepanel("genres");
            }
        }

        private void filmSelectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int x = e.RowIndex + 1;
                DataRowCollection data = Functions.Select("SELECT * FROM films WHERE id= '" + x + "'");
                setMoviePage(data);
            }
        }

        private void MainApp_Load(object sender, EventArgs e)
        {

        }
    }
}
