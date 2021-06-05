using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rem.Models
{
    public class LoggedState
    {
        public bool IsLoggedIn { get; set; }
        public string Username { get; set; }

        public bool Gestor { get; set; }

        public string Pass { get; set; }

        public void SetLogin(bool login, string user,string passInput,bool gestor)
        {
            IsLoggedIn = login;
            Username = user;
            Gestor = gestor;
            Pass = passInput;
        }
    }
}
