using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBletcheyCodeBreakers.Model;

namespace TheBletcheyCodeBreakers
{
    internal class GameController
    {
        public bool LogIn(string username, string password)
        {
            using (AccountsDBEntities adbe = new AccountsDBEntities())
            {
                if (username == adbe.Accounts.Username && password == adbe.Accounts.Password)
                {

                }
            }
            return true;
        }
    }
}
