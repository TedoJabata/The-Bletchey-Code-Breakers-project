using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBletcheyCodeBreakers.Model;

namespace TheBletcheyCodeBreakers.Controllers
{
    internal class MainGameController
    {
        public string[] GenerateNewNums()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 0 };
            string[] usedNums = { "", "", "", "" };

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

        public void HistoryCreate(History history)
        {
            using (AccountsDBEntities adbe = new AccountsDBEntities())
            {
                var lastNumsId = adbe.Histories.ToList().LastOrDefault();
                if (lastNumsId == null)
                {
                    lastNumsId = new History();
                    lastNumsId.Id = 0;
                }

                history.Id = lastNumsId.Id + 1;
                adbe.Histories.Add(history);
                adbe.SaveChanges();
            }
        }

        public List<History> GetAll()
        {
            using (AccountsDBEntities adbe = new AccountsDBEntities())
            {
                return adbe.Histories.ToList();
            }
        }
    }
}
