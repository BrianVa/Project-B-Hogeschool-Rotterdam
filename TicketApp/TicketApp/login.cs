﻿using System;
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
using static TicketApp.MainApp;
using static TicketApp.Functions;


namespace TicketApp
{
    public partial class login : Form
    {
        public Session session;
        private MainApp main;
        public login()
        {
            InitializeComponent();

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            string temp = Email.Text;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            string temp = Password.Text;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // hier worden de gegevens gevalideert
            var Function = new Functions();

            if (Email.Text.Trim() == "" && Password.Text.Trim() == "")
            {
                Function.Message("error empty fields!");
            }
            else if (Email.Text.Trim().Contains("@") && Email.Text.Trim().Contains("."))
            {
                //hier word gekeken of het email en wachtwoord overeen komen
                string hash = Function.ComputeSha256Hash(Password.Text.Trim());
                DataRowCollection data = Functions.Select("SELECT * FROM gebruikers g LEFT JOIN Roles r ON g.Role_id = r.ID  WHERE g.Email = '" + Email.Text.Trim() + "' AND g.password = '" + hash + "'");
             
                if (data.Count > 0)
                {
                    //als het email adress en wachtword overeen komen word de gebuiker ingelogd
                    data[0]["password"] = "";
                    Session session = new Session();
                    session.voornaam = data[0]["voornaam"].ToString();
                    session.achternaam = data[0]["achternaam"].ToString();
                    session.email = data[0]["email"].ToString();
                    session.role = data[0]["role_id"].ToString();
                    session.DateOfBirth = data[0]["geboorteDatum"].ToString();
                    session.id = Int32.Parse(data[0]["id"].ToString());
                    if (data[0]["role_id"].ToString() == "1")
                    {
                        session.isAdmin = true;
                    
                    }
                    this.Close();

                    Function.Message("Welkom " + data[0]["voornaam"].ToString() + "\n"
                        + "U bent ingelogd!");
                    MainApp.session = session;
                    main = new MainApp();
                    main.loginText = "Logout";

                }
                else
                {
                    Function.Message("Verkeerd Email of Wachtwoord!");
                }

            }
            else
            {
                Function.Message(Email.Text.Trim() + " is geen gelding emailadres!");
            }
        }
    }
}
