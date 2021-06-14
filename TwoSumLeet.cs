using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class TwoSumLeet
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int[] arr = new int[2];
            for (int i = 0; i<nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    var list = dict[nums[i]];
                    list.Add(i);
                }
                else
                {
                    List<int> list = new List<int>();
                    list.Add(i);
                    dict.Add(nums[i], list);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int rem = target - nums[i];
                if(dict.ContainsKey(rem) && (dict[rem]).Count() > 0)
                {
                    arr[0] = i;
                    if (rem == nums[i] && (dict[rem]).Count() > 1)
                    {
                        arr[1] = (dict[rem]).ElementAt(1);
                        break;
                    }
                    else
                    {
                        arr[1] = (dict[rem]).ElementAt(0);
                        break;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i<n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            int target = Int32.Parse(Console.ReadLine());
            TwoSumLeet twosum = new TwoSumLeet();
            var arr = twosum.TwoSum(a, target);
            Console.WriteLine(arr[0] + ", "+arr[1]);
                
            Console.ReadKey();
        }
    }
}
