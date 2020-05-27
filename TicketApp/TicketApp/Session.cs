using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    public class Session
    {
        //session variable worden aangemaakt voor later
        public string voornaam;
        public string achternaam;
        public string email;
        public string role;
        public string DateOfBirth;
        public int id;
        public bool isAdmin;

        public Session()
        {
            voornaam = "";
            achternaam = "";
            email = "";
            role = "";
            DateOfBirth = "";
            id = 0;
            isAdmin = false;
        }
        public void set_satus()
        { 
        
        }
    }
}
