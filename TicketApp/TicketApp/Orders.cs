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

        public Orders(Session session)
        {
            InitializeComponent();
            var topLeftHeaderCell = OrdersTable.TopLeftHeaderCell;
            Functions function = new Functions();
            this.session = session;
            loadOrders(session);

        }

        public void loadOrders(Session session)
        {
            Functions function = new Functions();

            DataRowCollection data = Functions.Select("SELECT s.naam as stoelnaam, k.naam as ticketnaam, z.naam as zaalnaam, * FROM orders o " +
                "LEFT JOIN tijden t ON o.tijd_id = t.id " +
                "LEFT JOIN Films f ON t.film_id = f.id " +
                "LEFT JOIN Tickets k ON o.ticket_id = k.id " +
                "LEFT JOIN zalen z ON t.zaal_id = z.id " +
                "LEFT JOIN stoelen s ON o.stoel_id = s.id WHERE user_id = '"+session.id+"'");

            
            if (data.Count > 0)
            {
                OrdersTable.Rows.Clear();

                foreach (DataRow row in data)
                {
                    int n = OrdersTable.Rows.Add();
                    OrdersTable.Rows[n].Cells[0].Value = row["id"].ToString();
                    OrdersTable.Rows[n].Cells[1].Value = row["naam"].ToString();
                    OrdersTable.Rows[n].Cells[2].Value = row["order_date"].ToString();
                    OrdersTable.Rows[n].Cells[3].Value = row["tijd"].ToString();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var Function = new Functions();

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Index.ToString() == "6")
            {
                DataGridViewRow r = OrdersTable.Rows[e.RowIndex];
                int result = DateTime.Compare(Convert.ToDateTime(r.Cells[2].Value.ToString()),DateTime.Now);
                if (result > 0)
                {
                    DialogResult = DialogResult = MessageBox.Show("Weet u zeker dat u deze reservering wilt annuleren?", "Tickets Annuleren", MessageBoxButtons.YesNo);
                    if (DialogResult == DialogResult.Yes)
                    {
                        DataGridViewRow row = OrdersTable.Rows[e.RowIndex];
                        int film_id = Int32.Parse(row.Cells[0].Value.ToString());
                        string query = ("DELETE FROM orders WHERE id = '" + film_id + "'");
                        Function.ExcQuery(query);
                        loadOrders(session);
                        Function.Message("De reservering is geannuleerd. \n\nHet betaalde bedrag wordt binnen 2 weken op uw rekening teruggestort.");
                    }
                }
                else
                {
                    Function.Message("Deze reservering kan niet geannuleerd worden. \n\n- Reserveringen moeten minimaal 1 dag van te voren geannuleerd\n  worden.\n- Verlopen reserveringen kunnen niet meer geannuleerd\n  worden.");
                }

            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }
    }
}
