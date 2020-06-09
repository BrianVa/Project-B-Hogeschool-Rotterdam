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

namespace TicketApp
{
    public partial class Klant : Form
    {
        public Klant(Session session)
        {
            InitializeComponent();
            loadgrid();
        }

        public void loadgrid() {

            DataRowCollection data = Functions.Select("SELECT g.id as gebruikersID, r.id as roleID, * FROM gebruikers g LEFT JOIN roles r ON g.Role_id = r.id");
            KlantOverzicht.Rows.Clear();
            foreach (DataRow row in data)
            {
                DataRowCollection orders = Functions.Select("SELECT COUNT(id) as all_orders FROM orders WHERE user_id = '" + row["id"].ToString() + "'");
                int n = KlantOverzicht.Rows.Add();

                KlantOverzicht.Rows[n].Cells[0].Value = row["id"].ToString();
                KlantOverzicht.Rows[n].Cells[1].Value = row["voornaam"].ToString() + " " + row["achternaam"].ToString();
                KlantOverzicht.Rows[n].Cells[2].Value = row["email"].ToString();
                KlantOverzicht.Rows[n].Cells[3].Value = Int32.Parse(orders[0]["all_orders"].ToString());
                KlantOverzicht.Rows[n].Cells[4].Value = row["geboorteDatum"].ToString(); ;
                KlantOverzicht.Rows[n].Cells[5].Value = row["name"].ToString();
                KlantOverzicht.Rows[n].Cells[6].Value = "Gebruiker";
                KlantOverzicht.Rows[n].Cells[7].Value = "Medewerker";

            }
        }

        private void KlantOverzicht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var Function = new Functions();

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Index.ToString() == "6")
            {
                DataGridViewRow row = KlantOverzicht.Rows[e.RowIndex];
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                string query = "UPDATE gebruikers SET role_id= '" + 2 + "' WHERE id = '" + id + "'";
                Function.ExcQuery(query);
                loadgrid();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Index.ToString() == "7")
            {
                DataGridViewRow row = KlantOverzicht.Rows[e.RowIndex];
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                string query = "UPDATE gebruikers SET role_id= '" + 1 + "' WHERE id = '" + id + "'";
                Function.ExcQuery(query);
                loadgrid();
            }

        }
    }
}
