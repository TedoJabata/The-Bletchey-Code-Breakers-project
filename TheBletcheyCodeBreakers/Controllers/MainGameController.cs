using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBletcheyCodeBreakers.Model;
using TheBletcheyCodeBreakers.Views;

namespace TheBletcheyCodeBreakers.Controllers
{
    internal class MainGameController
    {

        string[] usedNums = { "", "", "", "" };
        int currBulls;
        int currCows;

        bool addGame = false;

        public string[] GenerateNewNums()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 0 };

            for (int i = 1; i <= 4; i++)
            {
                int z = i - 1;
                Random a = new Random();
                int r = a.Next(0, nums.Length - 1);
                usedNums[z] = nums[r].ToString();
                List<int> tmp = new List<int>(nums);
                tmp.RemoveAt(r);
                nums = tmp.ToArray();
            }
            return usedNums;
        }

        public string[] UpdateLabels(string num1, string num2, string num3, string num4)
        {
            currBulls = 0;
            currCows = 0;

            if (num1 == usedNums[0])
            {
                currBulls++;
            }
            else if (num1 == usedNums[1] || num1 == usedNums[2] || num1 == usedNums[3])
            {
                currCows++;
            }

            if (num2 == usedNums[1])
            {
                currBulls++;
            }
            else if (num2 == usedNums[0] || num2 == usedNums[2] || num2 == usedNums[3])
            {
                currCows++;
            }

            if (num3 == usedNums[2])
            {
                currBulls++;
            }
            else if (num3 == usedNums[0] || num3 == usedNums[1] || num3 == usedNums[3])
            {
                currCows++;
            }

            if (num4 == usedNums[3])
            {
                currBulls++;
            }
            else if (num4 == usedNums[0] || num4 == usedNums[1] || num4 == usedNums[2])
            {
                currCows++;
            }

            string[] bullsAndCows = { currBulls.ToString(), currCows.ToString() };
            return bullsAndCows;
        }

        public string PlayedGames()
        {
            using (AccountsDBEntities adbe = new AccountsDBEntities())
            {
                var acc = adbe.Accounts.Where(s => s.Username == LoginView.currLoggedUsername).FirstOrDefault();
                var id = acc.Id;

                if (adbe.Games.Where(s => s.UserId == id).FirstOrDefault() != null)
                {
                    var userGames = adbe.Games.Where(s => s.UserId == id).FirstOrDefault();

                    if (addGame == true)
                    {
                        addGame = false;
                        adbe.Games.Where(s => s == userGames).FirstOrDefault().GamesPlayed++;
                        adbe.SaveChanges();
                    }

                    return $"You have played {userGames.GamesPlayed.ToString()}";
                }
                else
                {
                    Game game = new Game();

                    if (adbe.Games.ToList().LastOrDefault() == null)
                    {
                        game.Id = 0;
                    }
                    else
                    {
                        game.Id = adbe.Games.ToList().LastOrDefault().Id + 1;
                    }

                    game.UserId = id;
                    game.GamesPlayed = 0;

                    adbe.Games.Add(game);
                    adbe.SaveChanges();

                    return "You haven't played any games yet";
                }
            }
        }
    }
}
