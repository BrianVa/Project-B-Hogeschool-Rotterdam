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
using static TicketApp.Session;
using static TicketApp.CustomComboBox;

namespace TicketApp
{
    public partial class Film : Form
    {
        string BgImgPath;
        string FilmImgPath;
        int selectedFilm;

        public Film(Session session, string panel)
        {
            InitializeComponent();
            set_panel(panel);

        }
        public void set_panel(string panel)
        {

            FilmAddPanel.Visible = false;
            FilmOverzichtPanel.Visible = false;
            TijdAddPanel.Visible = false;

            switch (panel)
            {
                case "Add":
                    FilmAddPanel.Visible = true;
                    int film_id = 0;
                    LoadAdd(film_id);
                    break;
                case "Overzicht":
                    FilmOverzichtPanel.Visible = true;
                    LoadOverzicht();
                    break;
                case "Edit":
                    FilmAddPanel.Visible = true;
                    break;
                case "tijd":
                    TijdAddPanel.Visible = true;
                    LoadTijdAdd();
                    break;
                default:
                    FilmAddPanel.Visible = true;
                    break;
            }

        }
        private void LoadTijdAdd()
        {
            FilmDate.MinDate = DateTime.Now;
            var Function = new Functions();

            DataRowCollection film = Functions.Select("SELECT naam,id FROM Films");
            foreach (DataRow row in film)
            {
                CustomComboBox item = new CustomComboBox();
                item.Text = row["naam"].ToString();
                item.Value = Int32.Parse(row["id"].ToString());
                MovieAdd.Items.Add(item);
            }

            DataRowCollection zaal = Functions.Select("SELECT naam,id FROM zalen");
            foreach (DataRow row in zaal)
            {
                CustomComboBox item = new CustomComboBox();
                item.Text = row["naam"].ToString();
                item.Value = Int32.Parse(row["id"].ToString());
                ZaalAdd.Items.Add(item);
            }
        }
        private void FilmAddButton_Click(object sender, EventArgs e)
        {
            if (FilmAddButton.Text == "Aanpassen")
            {
                validateEdit(selectedFilm);
            }
            else
            {
                validate();
            }

        }
        public void LoadAdd(int film_id)
        {

            var Function = new Functions();
            DataRowCollection data = Functions.Select("SELECT * FROM Genres");
            foreach (DataRow row in data)
            {
                CustomComboBox item = new CustomComboBox();
                item.Text = row["naam"].ToString();
                item.Value = Int32.Parse(row["id"].ToString());
                FilmGenre.Items.Add(item);
            }

            FilmAge.Items.Add("0");
            FilmAge.Items.Add("6");
            FilmAge.Items.Add("9");
            FilmAge.Items.Add("12");
            FilmAge.Items.Add("16");
            FilmAge.Items.Add("18");

            if (film_id > 0)
            {
                DataRowCollection film = Functions.Select("SELECT g.naam as GenreNaam, f.naam as FilmNaam, * FROM films f LEFT JOIN Genres g ON f.genre = g.id WHERE f.id= '" + film_id + "'");

                FilmNaam.Text = film[0]["FilmNaam"].ToString();
                FilmAge.Text = film[0]["leeftijd"].ToString();
                FilmTime.Text = film[0]["speel_duur"].ToString();
                FilmTrailer.Text = film[0]["youtube_code"].ToString();
                FilmDisc.Text = film[0]["beschrijving"].ToString();
                FilmGenre.Text = film[0]["GenreNaam"].ToString();
                FilmGenre.SelectedIndex = FilmGenre.FindStringExact(film[0]["GenreNaam"].ToString());
                FilmAge.SelectedIndex = FilmAge.FindStringExact(film[0]["leeftijd"].ToString());
                FilmAddButton.Text = "Aanpassen";
            }

        }
        public void LoadOverzicht()
        {

            DataRowCollection data = Functions.Select("SELECT g.naam as GenreNaam, f.naam as FilmNaam, g.id as GenreID,f.id as FilmID, * FROM films f LEFT JOIN Genres g ON f.genre = g.id");

            FilmOverzichtTabel.Rows.Clear();
            foreach (DataRow row in data)
            {
                int n = FilmOverzichtTabel.Rows.Add();

                FilmOverzichtTabel.Rows[n].Cells[0].Value = row["FilmID"].ToString();
                FilmOverzichtTabel.Rows[n].Cells[1].Value = row["FilmNaam"].ToString();
                FilmOverzichtTabel.Rows[n].Cells[2].Value = row["GenreNaam"].ToString();
                FilmOverzichtTabel.Rows[n].Cells[3].Value = row["speel_duur"].ToString() + " Minuten";
                FilmOverzichtTabel.Rows[n].Cells[4].Value = row["leeftijd"].ToString();
                FilmOverzichtTabel.Rows[n].Cells[5].Value = "Bekijk/Edit";
                FilmOverzichtTabel.Rows[n].Cells[6].Value = "Delete";
            }

        }

        public void validate()
        {
            var Function = new Functions();

            if (FilmNaam.Text.Trim() == "" || FilmGenre.Text.Trim() == "" || FilmAge.Text.Trim() == "" || FilmTime.Text.Trim() == "" || FilmTrailer.Text.Trim() == "" || FilmDisc.Text.Trim() == "" || BgImgPath == "" || FilmImgPath == "")
            {
                Function.Message("Er zijn lege velden!");
            }
            else
            {

                //hier worden de gegevens in de database opgeslagen en word het formulier gesloten
                string poster = set_img("poster", FilmImgPath);
                string back = set_img("back", BgImgPath);
                Function.Message("De Film: " + FilmNaam.Text + " is toegevoegd!");
                string query = "INSERT INTO films(naam, beschrijving, leeftijd, genre, tags, img_url, back_url, speel_duur, youtube_code) " +
                    "values ('" + FilmNaam.Text.Trim() + "', '" + FilmDisc.Text.Trim() + "', '" + FilmAge.Text.Trim() + "','" + (FilmGenre.SelectedItem as CustomComboBox).Value.ToString() + "','" + "tags" + "','" + poster + "','" + back + "','" + FilmTime.Text.Trim() + "','" + FilmTrailer.Text.Trim() + "')";
                Function.ExcQuery(query);
                this.Close();
            }

        }

        public void validateEdit(int selectedFilm)
        {
            var Function = new Functions();

            string query = "UPDATE Films SET naam= '" + FilmNaam.Text.Trim() + "', beschrijving= '" + FilmDisc.Text.Trim() + "', leeftijd= '" + FilmAge.Text.Trim() + "', genre= '" + (FilmGenre.SelectedItem as CustomComboBox).Value.ToString()
                        + "', speel_duur= '" + FilmTime.Text.Trim() + "',";

            if (FilmNaam.Text.Trim() == "" || FilmGenre.Text.Trim() == "" || FilmAge.Text.Trim() == "" || FilmTime.Text.Trim() == "" || FilmTrailer.Text.Trim() == "" || FilmDisc.Text.Trim() == "")
            {
                Function.Message("Er zijn lege velden!");
            }
            else
            {
                if (BgImgPath != null || FilmImgPath != null)
                {
                    if (BgImgPath != null)
                    {
                        string back = set_img("back", BgImgPath);
                        query = query + " back_url= '" + back + "',";
                    }

                    if (FilmImgPath != null)
                    {
                        string poster = set_img("poster", FilmImgPath);
                        query = query + " img_url= '" + poster + "',";
                    }
                }

                query = query + "youtube_code= '" + FilmTrailer.Text.Trim() + "' WHERE id= '" + selectedFilm + "'";
                Function.Message("De Film: " + FilmNaam.Text + " is aangepast!");
                Function.ExcQuery(query);
                this.Close();

            }
        }

        private void FilmPoster_Click(object sender, EventArgs e)
        {
            var Function = new Functions();
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png|*.png)| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FilmImgPath = dialog.FileName.ToString();
                    FilmPosterLabel.Text = dialog.FileName.ToString();
                }

            }
            catch
            {
                MessageBox.Show("Er is iets fout gegaan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilmBack_Click(object sender, EventArgs e)
        {
            var Function = new Functions();
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png|*.png)| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BgImgPath = dialog.FileName.ToString();
                    FilmBackLabel.Text = dialog.FileName.ToString();

                }

            }
            catch
            {
                MessageBox.Show("Er is iets fout gegaan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string set_img(string type, string imgUrl)
        {
            var Function = new Functions();
            string dir = "";
            switch (type)
            {
                case "poster":
                    dir = "pics/films/";
                    break;
                case "back":
                    dir = "pics/BG/";
                    break;
                default:
                    FilmAddPanel.Visible = true;
                    break;
            }
            Random random = new Random();
            string filename = Function.RandomString(random.Next(15));

            string[] words = imgUrl.Split((char)92);
            string[] file = words.Last().Split('.');

            string destFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dir + filename + "." + file.Last());

            System.IO.File.Copy(imgUrl, destFile, false);

            return filename + "." + file.Last();
        }

        private void FilmOverzichtTabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var Function = new Functions();

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Index.ToString() == "5")
            {
                DataGridViewRow row = FilmOverzichtTabel.Rows[e.RowIndex];
                int film_id = Int32.Parse(row.Cells[0].Value.ToString());
                selectedFilm = film_id;
                LoadAdd(film_id);
                set_panel("Edit");
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Index.ToString() == "6")
            {
                DataGridViewRow row = FilmOverzichtTabel.Rows[e.RowIndex];
                int film_id = Int32.Parse(row.Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u deze film wilt verwijderen?", "Film Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Function.ExcQuery("DELETE FROM Films WHERE id= '" + film_id + "'");
                    Function.ExcQuery("DELETE FROM tijden WHERE film_id= '" + film_id + "'");
                    LoadOverzicht();
                    Function.Message("De film is verwijdert!");
                }
            }
        }

        private void AddTime_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(FilmPlayTime.Text, out n);
            Functions Function = new Functions();
            if (FilmPlayTime.Text.Trim() == "" || MovieAdd.Text.Trim() == "" || ZaalAdd.Text.Trim() == "")
            {
                Function.Message("Er zijn lege velden!");

            }
            else if (!isNumeric) {
                Function.Message("Er mogen alleen numers worden ingevuld bij Tijd Bijv. 1200 voor 12 uur");

            }
            else
            {
                string date = FilmDate.Value.ToString("dd/MM/yyyy");
                string query = "INSERT INTO tijden(tijd, film_id, zaal_id, speel_date) values ('" + FilmPlayTime.Text.Trim() + "','" + (ZaalAdd.SelectedItem as CustomComboBox).Value.ToString() + "','" + (MovieAdd.SelectedItem as CustomComboBox).Value.ToString() + "','" + date + "')";
                Function.Message(query);
                Function.ExcQuery(query);
                Function.Message("Tijd is toegevoegd");
                this.Close();

            }
        }
    }
}
