using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBletcheyCodeBreakers.Model;

namespace TheBletcheyCodeBreakers.Controllers
{
    internal class RegisterController
    {
        public void AccountCreate(Account acc)
        {
            using (AccountsDBEntities adbe = new AccountsDBEntities())
            {
                var lastUserId = adbe.Accounts.ToList().LastOrDefault();
                if (lastUserId == null)
                {
                    lastUserId = new Account();
                    lastUserId.Id = 0;
                }

                acc.Id = lastUserId.Id + 1;
                adbe.Accounts.Add(acc);
                adbe.SaveChanges();
            }
        }
    }
}
