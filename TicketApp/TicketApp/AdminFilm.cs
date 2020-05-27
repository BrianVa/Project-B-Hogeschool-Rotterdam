using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TicketApp.Session;
using static TicketApp.Functions;

namespace TicketApp
{
    public partial class AdminFilm : Form
    {
        public AdminFilm(Session session, string scene)
        {
            InitializeComponent();

            filmviewpanel.Visible = false;
            addfilmpanel.Visible = false;

            switch (scene)
            {
                case "view":
                    filmviewpanel.Visible = true;
                    loadtabel();
                    break;
                case "add":
                    addfilmpanel.Visible = true;
                    break;
                case "edit":
                    filmviewpanel.Visible = true;
                    break;
                default:
                    filmviewpanel.Visible = true;
                    break;
            }
        }


        private void loadtabel() 
        {
            var Function = new Functions();

            DataRowCollection data = Functions.Select("SELECT * FROM films");

            filmtabel.Rows.Clear();
            foreach (DataRow row in data)
            {
                int n = filmtabel.Rows.Add();
                filmtabel.Rows[n].Cells[0].Value = row["id"].ToString();
                filmtabel.Rows[n].Cells[1].Value = row["naam"].ToString();
                filmtabel.Rows[n].Cells[2].Value = row["genre"].ToString();
                filmtabel.Rows[n].Cells[3].Value = row["leeftijd"].ToString();
                filmtabel.Rows[n].Cells[4].Value = row["speel_duur"].ToString();
                filmtabel.Rows[n].Cells[5].Value = "Bekijk";
                filmtabel.Rows[n].Cells[6].Value = "Edit";
                filmtabel.Rows[n].Cells[7].Value = "Delete";

            }
        }

    }
}
