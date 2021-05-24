using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    /*LeetCode September*/
    class HouseRobber
    {
        public int Rob(int[] arr)
        {
            int sum_1 = arr[0];
            int sum_2 = arr[1];
            int i = 0;
            while (i<arr.Count())
            {
                if (i % 2 == 0)
                {
                    sum_1 = sum_1 + arr[i];
                }
                else
                {
                    sum_2 = sum_2 + arr[i];
                }
                i++;
            }
            if (sum_1 >= sum_2)
            {
                return sum_1;
            }
            else
            {
                return sum_2;
            }

        }
        static void Main(string[] args)
        {
            HouseRobber hr = new HouseRobber();
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));
            hr.Rob(arr);
        }
    }
}
