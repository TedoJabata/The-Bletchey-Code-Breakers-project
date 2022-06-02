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

        string[] usedNums = { "", "", "", "" };
        int currBulls;
        int currCows;
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
    }
}
