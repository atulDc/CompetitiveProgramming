using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class DuplicateElement
    {
        static void Main(string[] args)
        {
            bool hasDuplicate = false;
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            HashSet<int> set = new HashSet<int>();

            for(int i =0;i<arr.Length; i++)
            {
                if (set.Contains(arr[i]))
                {
                    hasDuplicate = true;
                    break;
                }
                else
                {
                    set.Add(arr[i]);
                }
            }

            if (hasDuplicate)
            {
                Console.WriteLine("Array has duplicate elements!");
            }
        }
    }
}
