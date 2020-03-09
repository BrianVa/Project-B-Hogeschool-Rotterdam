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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void aanmeld_Click(object sender, EventArgs e)
        {
            var Function = new Functions();
            if (email_field.Text.Trim() == "" || password_field.Text.Trim() == "" || password_r_field.Text.Trim() == "" || voornaam_field.Text.Trim() == "" || achternaam_field.Text.Trim() == "")
            {
                Function.Message("error empty fields!");
            }
            else if (!email_field.Text.Trim().Contains("@") || !email_field.Text.Trim().Contains("."))
            {
                Function.Message(email_field.Text.Trim() + " is geen gelding emailadres!");
            }
            else if (voornaam_field.Text.Trim().Length < 3 || achternaam_field.Text.Trim().Length < 3)
            {
                Function.Message("Voornaam en achternaam moeten minimaal 3 characters lang zijn.");
            }
            else if (password_field.Text.Trim() != password_r_field.Text.Trim())
            {
                Function.Message("Wachtwoord en herhaal wachtwoord moeten hetzelfde zijn.");
            }
            else {

                Function.Message("validatie gelukt!");
                string hash = Function.ComputeSha256Hash(password_field.Text.Trim());
                string query = "INSERT INTO gebruikers(Voornaam, Achternaam, Email, password, Role_id) values ('"+voornaam_field.Text.Trim()+ "', '"+achternaam_field.Text.Trim()+"','"+email_field.Text.Trim()+"','"+hash+"','"+ 2 +"')";
                Function.ExcQuery(query);
            }
        }
    }
}
