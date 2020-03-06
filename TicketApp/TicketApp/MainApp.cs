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
    public partial class MainApp : Form
    {
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

            foreach (DataRow item in dt.Rows)
            {
                //System.Windows.Forms.MessageBox.Show(item["naam"].ToString());
            }

            //pictureBox1.Hide();

        }
        private void search_button_Click(object sender, EventArgs e)
        {
            string value = SearchBox.Text;
            //pictureBox1.Show();
            //System.Windows.Forms.MessageBox.Show(value);

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
            login popUpForm = new login();
            popUpForm.Show();

        }

        private void aanmeld_button_Click(object sender, EventArgs e)
        {
            signup popUpForm = new signup();
            popUpForm.Show();
        }
        private void movie_select(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Form Pop-up");
        }
    }
}
