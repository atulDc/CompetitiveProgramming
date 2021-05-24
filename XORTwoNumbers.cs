using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class XORTwoNumbers
    {
        public int FindMaximumXOR(int[] nums)
        {
            int a = Int32.MinValue;
           for (int i = 0; i < nums.Count(); i++)
            {
                if (a < nums[i])
                {
                    a = nums[i];
                }
            }
            int big = Int32.MinValue;
            for(int i = 0; i < nums.Count()-1; i++)
            {
                if ((a ^ nums[i]) > big)
                {
                    big = a ^ nums[i];
                }
            }
            return big;
        }
        static void Main(string[] args)
        {
            XORTwoNumbers x = new XORTwoNumbers();
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), y => Convert.ToInt32(y));
            Console.WriteLine(x.FindMaximumXOR(nums));
            Console.ReadKey();
        }
    }
}
