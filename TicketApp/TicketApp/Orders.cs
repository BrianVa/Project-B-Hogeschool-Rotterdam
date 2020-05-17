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
        public Orders(Session session)
        {
            InitializeComponent();
            
            Functions function = new Functions();
            loadOrders(session);

        }

        public void loadOrders(Session session)
        {
            Functions function = new Functions();

            DataRowCollection data = Functions.Select("SELECT s.naam as stoelnaam, k.naam as ticketnaam,* FROM orders o " +
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
                    OrdersTable.Rows[n].Cells[0].Value = row["order_date"].ToString();
                    OrdersTable.Rows[n].Cells[1].Value = row["naam"].ToString();
                    OrdersTable.Rows[n].Cells[2].Value = row["tijd_id"].ToString();
                    OrdersTable.Rows[n].Cells[3].Value = "Annuleer";
                    OrdersTable.Rows[n].Cells[4].Value = "Bekijk";
                }
            }
            else
            {
                function.Message("Er zijn nog geen orders, ga een kaartje kopen ofzo...zwerver.");

                int n = OrdersTable.Rows.Add();
                OrdersTable.Rows[n].Cells[0].Value = "Geen orders gevonden.";
            }
            

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
