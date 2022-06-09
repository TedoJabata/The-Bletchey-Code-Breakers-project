using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBletcheyCodeBreakers.Model;

namespace TheBletcheyCodeBreakers.Controllers
{
    internal class LoginController
    {
        public string ShowMessage(string username, string pass)
        {
            using (AccountsDBEntities ex = new AccountsDBEntities())
            {
                var exsistingAccount = ex.Accounts.Where(s => s.Username == username).FirstOrDefault();
                if (exsistingAccount != null)
                {
                    if (exsistingAccount.Password == pass)
                    {
                        return null;
                    }
                    else
                    {
                        return "Wrong Password!";
                    }
                }
                else
                {
                    return "No such user!";
                }
            }
        }
    }
}
