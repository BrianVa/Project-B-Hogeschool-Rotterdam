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
            Agefield.Format = DateTimePickerFormat.Custom;
            Agefield.CustomFormat = "dd/MM/yyyy";

            if (MainApp.session != null)
            {
                DataRowCollection data = Functions.Select("SELECT * FROM gebruikers WHERE id= '" + MainApp.session.id + "'");

                email_field.Text = data[0]["email"].ToString();
                voornaam_field.Text = data[0]["Voornaam"].ToString();
                achternaam_field.Text = data[0]["Achternaam"].ToString();
                DateTime Birth = Convert.ToDateTime(data[0]["geboorteDatum"].ToString());
                Agefield.Value = Birth;
                Agefield.Enabled = false;

                label4.Text = "Nieuw wachtwoord";
                label5.Text = "Herhaal nieuw wachtwoord";
                aanmeld_button.Text = "Update";

            }
        }

        private void aanmeld_Click(object sender, EventArgs e)
        {

            //deze functie valideerd het ingevoerde gegevens van een gebruiker

            if (MainApp.session != null)
            {
                validate_update();
            }
            else
            {
                validate_new();        
            }

        }
        public void validate_new() {
            var Function = new Functions();
            string date = Agefield.Value.ToString("dd/MM/yyyy");

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
            else if (voornaam_field.Text.Trim().Length > 25 || achternaam_field.Text.Trim().Length > 25)
            {
                Function.Message("Voornaam en achternaam mogen niet langer zijn dan 25 characters");
            }
            else if (password_field.Text.Trim() != password_r_field.Text.Trim())
            {
                Function.Message("Wachtwoord en herhaal wachtwoord moeten hetzelfde zijn.");
            }
            else if (password_field.Text.Length < 6 || password_field.Text.Length > 24)
            {
                Function.Message("Wachtwoord moet minimaal 6 characters lang zijn en maximaal 24.");
            }
            else
            {
                DataRowCollection data = Functions.Select("SELECT email FROM gebruikers WHERE email= '" + email_field.Text.Trim() + "'");

                if (data.Count > 0)
                {
                    Function.Message(email_field.Text + " word al gebruikt kies a.u.b een ander email adres.");

                }
                else
                {
                    //hier worden de gegevens in de database opgeslagen en word het formulier gesloten
                    Function.Message("Uw account is aangemaakt");
                    string hash = Function.ComputeSha256Hash(password_field.Text.Trim());
                    string query = "INSERT INTO gebruikers(Voornaam, Achternaam, Email, password, Role_id, geboorteDatum) values ('" + voornaam_field.Text.Trim() + "', '" + achternaam_field.Text.Trim() + "','" + email_field.Text.Trim() + "','" + hash + "','" + 2 + "','" + date + "')";
                    Function.ExcQuery(query);
                    this.Close();
                }
            }


        }
        public void validate_update() 
        {
            var Function = new Functions();
            string hash = "";
            string query = "";

            if (email_field.Text.Trim() == "" || voornaam_field.Text.Trim() == "" || achternaam_field.Text.Trim() == "")
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
            else
            {

                if (password_field.Text.Trim() != "" || password_r_field.Text.Trim() != "")
                {
                    if (password_field.Text.Trim() != password_r_field.Text.Trim())
                    {
                        Function.Message("Wachtwoord en herhaal wachtwoord moeten hetzelfde zijn.");
                    }
                    else if (password_field.Text.Length < 6 || password_field.Text.Length > 24)
                    {
                        Function.Message("Wachtwoord moet minimaal 6 characters lang zijn en maximaal 24.");
                    }
                    else
                    {
                        hash = Function.ComputeSha256Hash(password_field.Text.Trim());
                    }
                }

                if (email_field.Text.Trim() != MainApp.session.email)
                {
                    DataRowCollection data = Functions.Select("SELECT email FROM gebruikers WHERE email= '" + email_field.Text.Trim() + "'");

                    if (data.Count > 0)
                    {
                        Function.Message(email_field.Text + "word al gebruikt kies a.u.b een ander email adres.");

                    }
                    else
                    {
                        if (hash != "")
                        {
                            query = "UPDATE gebruikers SET Voornaam ='" + voornaam_field.Text.Trim() + "',  Achternaam = '" + achternaam_field.Text.Trim() + "', Email = '" + email_field.Text.Trim() + "', password = '" + hash + "' WHERE id= '" + MainApp.session.id + "'";
                        }
                        else
                        {
                            query = "UPDATE gebruikers SET Voornaam ='" + voornaam_field.Text.Trim() + "',  Achternaam = '" + achternaam_field.Text.Trim() + "', Email = '" + email_field.Text.Trim() + "' WHERE id= '" + MainApp.session.id + "'";
                        }

                        Function.ExcQuery(query);
                        this.Close();

                    }
                }
                else
                {
                    if (hash != "")
                    {
                        query = "UPDATE gebruikers SET Voornaam ='" + voornaam_field.Text.Trim() + "',  Achternaam = '" + achternaam_field.Text.Trim() + "', Email = '" + email_field.Text.Trim() + "', password = '" + hash + "' WHERE id= '" + MainApp.session.id + "'";
                    }
                    else
                    {
                        query = "UPDATE gebruikers SET Voornaam ='" + voornaam_field.Text.Trim() + "',  Achternaam = '" + achternaam_field.Text.Trim() + "', Email = '" + email_field.Text.Trim() + "' WHERE id= '" + MainApp.session.id + "'";
                    }


                    //hier worden de gegevens in de database opgeslagen en word het formulier gesloten
                    Function.ExcQuery(query);
                    this.Close();
                }

        
            }

        }
    }
}
