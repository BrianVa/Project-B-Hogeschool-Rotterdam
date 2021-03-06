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
using static TicketApp.Session;
using static TicketApp.Functions;
using System.Security.Cryptography;

namespace TicketApp
{
    class Functions
    {
        public Functions() { 
        
        
        }

        //database variable worden aangemaakt
        public SQLiteConnection conn;
        public SQLiteCommand cmd;
        public SQLiteDataAdapter da;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();


        //globale select function die een query krijgt deze uitvoert en resulaat terug stuurt
        static public DataRowCollection Select(string query)
        {
            //deze functie haalt data op uit de database en returnd het resultaat
            string database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database/Database.db");
            SQLiteConnection conn = new SQLiteConnection("data source=" + database + ";Version=3");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt.Rows;
        }

        public string ComputeSha256Hash(string rawData)
        {
            //in deze functie worden wachtworden geencrypt
            using (SHA256 sha256Hash = SHA256.Create())
            { 
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //deze functie displayed messages
        public void Message(string message) 
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        public bool CheckAge(Session session, DataRowCollection age, string date = "")
        {
            if (session != null || date.Length > 0)
            {
                DateTime Birth = DateTime.Now;
                if (date.Length > 0)
                {
                    Birth = Convert.ToDateTime(date);
                }

                if(session != null){
                    
                    Birth = Convert.ToDateTime(session.DateOfBirth.ToString());
                }
                DateTime PresentYear = DateTime.Now;
                TimeSpan ts = PresentYear - Birth;
                DateTime Age = DateTime.MinValue.AddDays(ts.Days);   

                if (Age.Year -1 < Int32.Parse(age[0]["leeftijd"].ToString()))                   
                {
                    MessageBox.Show("U bent te jong voor deze film");
                    return false;
                }
                else {

                    return true;
                }
            }
            else
            {
                if (MessageBox.Show("Bent u 16 jaar of ouder?", "Leeftijds check", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //database connectie word aangemaakt
        public void DataBaseConnection()
        {
            string database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database/Database.db");
            conn = new SQLiteConnection("data source=" + database + ";Version=3");
        }

        //query naar de database word uitgevoerd
        public void ExcQuery(string Query)
        {
            DataBaseConnection();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = Query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //test functie word select uit database
        public int SelectData(string query) 
        {
            DataBaseConnection();
            conn.Open();
            cmd = conn.CreateCommand();
            da = new SQLiteDataAdapter(query, conn);
            return da.Fill(dt);

        }

        public string SetHtmlLink(string VideoCode)
        {
            //maakt de HTML code om in te laden in de browser:
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' height = 100% width = 100% src='https://www.youtube.com/embed/" + VideoCode + "' style='position: fixed; top: 0; left: 0; bottom: 0; right: 0; width: 100 %; height: 100 %; border: none; margin: 0; padding: 0; overflow: hidden; z - index:999999;'></iframe>";
            html += "</body></html>"; //einde HTML code
            return html;
        }

        //zorgt ervoor dat we custom fonts kunnen inladen en gebruiken.
        public void UseCustomFont(string name, int size, Label label)
        {
            string FontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fonts/" + name + ".otf");
            System.Drawing.Text.PrivateFontCollection ModernFont = new System.Drawing.Text.PrivateFontCollection();

            ModernFont.AddFontFile(FontPath);

            label.Font = new Font(ModernFont.Families[0], size);
        }
        private static Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
