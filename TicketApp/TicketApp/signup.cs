using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (email_field.Text.Trim() == "" || password_field.Text.Trim() == "" || password_r_field.Text.Trim() == "" || voornaam_field.Text.Trim() == "" || achternaam_field.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("error empty fields!");
            }
            else if (!email_field.Text.Trim().Contains("@") || !email_field.Text.Trim().Contains("."))
            {
                System.Windows.Forms.MessageBox.Show(email_field.Text.Trim() + " is geen gelding emailadres!");

            }
            else if (voornaam_field.Text.Trim().Length < 3 || achternaam_field.Text.Trim().Length < 3)
            {
                System.Windows.Forms.MessageBox.Show("Voornaam en achternaam moeten minimaal 3 characters lang zijn.");
            }
            else if (password_field.Text.Trim() != password_r_field.Text.Trim())
            {
                System.Windows.Forms.MessageBox.Show("Wachtwoord en herhaal wachtwoord moeten hetzelfde zijn.");
            }
            else {

                System.Windows.Forms.MessageBox.Show("validatie gelukt!");
            }
        }
    }
}
