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

        public void AccountGCreate(Game gm, int lastUserId)
        {
            using (AccountsDBEntitiesGames adbe = new AccountsDBEntitiesGames())
            {
                var lastGameId = adbe.Games.ToList().LastOrDefault();
                if (lastGameId == null)
                {
                    lastGameId = new Game();
                    lastGameId.Id = 0;
                }

                gm.UserId = lastUserId;
                lastGameId.Id = lastGameId.Id + 1;
                adbe.Games.Add(gm);
                adbe.SaveChanges();
            }
        }
    }
}
