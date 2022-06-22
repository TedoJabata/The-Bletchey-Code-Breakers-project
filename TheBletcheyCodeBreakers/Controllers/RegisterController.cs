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
        public int AccountCreate(Account acc)
        {
            var lastUserId = 0;
            using (AccountsDBEntities adbe = new AccountsDBEntities())
            {
                lastUserId = adbe.Accounts.ToList().LastOrDefault().Id;
                var lastUser = adbe.Accounts.ToList().LastOrDefault();

                if (lastUser == null)
                {
                    lastUser = new Account();
                    lastUser.Id = 0;
                }

                acc.Id = lastUser.Id + 1;
                adbe.Accounts.Add(acc);
                adbe.SaveChanges();

                return lastUserId;
            }
        }
    }
}
