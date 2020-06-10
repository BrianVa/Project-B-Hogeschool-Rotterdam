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
using System.Data.SQLite;

namespace TicketApp
{

    public partial class Orders : Form
    {
        Session session;
        string type;

        public Orders(Session session, string panel)
        {
            InitializeComponent();
            var topLeftHeaderCell = OrdersTable.TopLeftHeaderCell;
            Functions function = new Functions();
            this.session = session;
            this.type = panel;
            set_activepanel(panel);

        }

        private void set_activepanel(string panel)
        {

            AdminOrderPanel.Visible = false;
            KlantOrderPanel.Visible = false;

            switch (panel)
            {
                case "admin":
                    loadOrdersAdmin(session);
                    AdminOrderPanel.Visible = true;
                    break;
                case "klant":
                    loadOrdersKlant(session);
                    KlantOrderPanel.Visible = true;
                    break;
                default:
                    KlantOrderPanel.Visible = true;
                    break;
            }
        }

        public void loadOrdersAdmin(Session session)
        {
            Functions function = new Functions();
            string query = "SELECT s.naam as stoelnaam, k.naam as ticketnaam, z.naam as zaalnaam, o.user_id as OrderID, * FROM orders o " +
                "LEFT JOIN gebruikers g ON o.user_id = g.id " +
                "LEFT JOIN tijden t ON o.tijd_id = t.id " +
                "LEFT JOIN Films f ON t.film_id = f.id " +
                "LEFT JOIN Tickets k ON o.ticket_id = k.id " +
                "LEFT JOIN zalen z ON t.zaal_id = z.id " +
                "LEFT JOIN stoelen s ON o.stoel_id = s.id";

            DataRowCollection data = Functions.Select(query);

            string name = "";
            if (data.Count > 0)
            {
                OrdertableAdmin.Rows.Clear();

                foreach (DataRow row in data)
                {
                    if (row["OrderID"].ToString() == "0")
                    {
                        name = "Anoniem";
                    }
                    else
                    {
                        name = row["voornaam"].ToString() + " " + row["achternaam"].ToString();

                    }
                    int n = OrdertableAdmin.Rows.Add();
                    OrdertableAdmin.Rows[n].Cells[0].Value = row["id"].ToString();
                    OrdertableAdmin.Rows[n].Cells[1].Value = row["naam"].ToString();
                    OrdertableAdmin.Rows[n].Cells[2].Value = name;
                    OrdertableAdmin.Rows[n].Cells[3].Value = row["speel_date"].ToString();
                    OrdertableAdmin.Rows[n].Cells[4].Value = row["tijd"].ToString().Insert(2, ":");
                    OrdertableAdmin.Rows[n].Cells[5].Value = row["zaalnaam"].ToString();
                    OrdertableAdmin.Rows[n].Cells[6].Value = row["stoelnaam"].ToString();
                    OrdertableAdmin.Rows[n].Cells[7].Value = "Annuleer";
                }
            }
            else
            {
                function.Message("Er zijn geen orders gevonden.");

                int n = OrdersTable.Rows.Add();
                OrdersTable.Rows[n].Cells[0].Value = "Geen orders gevonden.";
            }

        }

        public void loadOrdersKlant(Session session)
        {
            Functions function = new Functions();
            string query = "SELECT s.naam as stoelnaam, k.naam as ticketnaam, z.naam as zaalnaam, * FROM orders o " +
                "LEFT JOIN tijden t ON o.tijd_id = t.id " +
                "LEFT JOIN Films f ON t.film_id = f.id " +
                "LEFT JOIN Tickets k ON o.ticket_id = k.id " +
                "LEFT JOIN zalen z ON t.zaal_id = z.id " +
                "LEFT JOIN stoelen s ON o.stoel_id = s.id WHERE user_id = '" + session.id + "'";

            DataRowCollection data = Functions.Select(query);


            if (data.Count > 0)
            {
                OrdersTable.Rows.Clear();

                foreach (DataRow row in data)
                {
                    int n = OrdersTable.Rows.Add();
                    OrdersTable.Rows[n].Cells[0].Value = row["id"].ToString();
                    OrdersTable.Rows[n].Cells[1].Value = row["naam"].ToString();
                    OrdersTable.Rows[n].Cells[2].Value = row["speel_date"].ToString();
                    OrdersTable.Rows[n].Cells[3].Value = row["tijd"].ToString().Insert(2, ":");
                    OrdersTable.Rows[n].Cells[4].Value = row["zaalnaam"].ToString();
                    OrdersTable.Rows[n].Cells[5].Value = row["stoelnaam"].ToString();
                    OrdersTable.Rows[n].Cells[6].Value = "Annuleer";
                }
            }
            else
            {
                function.Message("Er zijn geen orders gevonden.");

                int n = OrdersTable.Rows.Add();
                OrdersTable.Rows[n].Cells[0].Value = "Geen orders gevonden.";
            }


        }
        private void OrdersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteOrder(sender, e);
        }

        private void OrdertableAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteOrder(sender, e);
        }
        private void DeleteOrder(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var Function = new Functions();
            int index = 0;
            DataGridViewRow r = null;
            DataGridViewRow row = null;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Index.ToString() == "6" && type == "klant" || senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Index.ToString() == "7" && type == "admin")
            {
                if (type == "admin")
                {
                    index = 3;
                    r = OrdertableAdmin.Rows[e.RowIndex];
                }
                else
                {
                    index = 2;
                    r = OrdersTable.Rows[e.RowIndex];

                }

                int result = DateTime.Compare(Convert.ToDateTime(r.Cells[index].Value.ToString()), DateTime.Now);

                if (result > 0)
                {
                    DialogResult = DialogResult = MessageBox.Show("Weet u zeker dat u deze reservering wilt annuleren?", "Tickets Annuleren", MessageBoxButtons.YesNo);
                    if (DialogResult == DialogResult.Yes)
                    {
                        
                        if (type == "admin")
                        {
                            row = OrdertableAdmin.Rows[e.RowIndex];
                        }
                        else
                        {
                            row = OrdersTable.Rows[e.RowIndex];

                        }
                        

                        int film_id = Int32.Parse(row.Cells[0].Value.ToString());
                        string query = ("DELETE FROM orders WHERE id = '" + film_id + "'");
                        Function.ExcQuery(query);
                        if (session.isAdmin)
                        {
                            loadOrdersAdmin(session);
                        }
                        else
                        {
                            loadOrdersKlant(session);
                        }
                        Function.Message("De reservering is geannuleerd. \n\nHet betaalde bedrag wordt binnen 2 weken op uw rekening teruggestort.");
                    }
                }
                else
                {
                    Function.Message("Deze reservering kan niet geannuleerd worden. \n\n- Reserveringen moeten minimaal 1 dag van te voren geannuleerd\n  worden.\n- Verlopen reserveringen kunnen niet meer geannuleerd\n  worden.");
                }
            }
        }

    }

}
