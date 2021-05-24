using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class GamingArray
    {
        public List<KeyValuePair<int, int>> sortIndex(int n, int[] arr)
        {
            List<KeyValuePair<int,int>> sortedArr = arr.Select((x, i) => new KeyValuePair<int, int>(x, i)).OrderByDescending(x => x.Key).ToList();
            return sortedArr;
        }
        static void Main(string[] args)
        {
            GamingArray gm = new GamingArray();
            int t = Convert.ToInt32(Console.ReadLine());
            while (t-- > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));
                List<KeyValuePair<int, int>> sortedElemets = gm.sortIndex(n,arr);
                int smaller = Int32.MaxValue;
                int count = 0;
                foreach(var item in sortedElemets)
                {
                    if (smaller > item.Value)
                    {
                        smaller = item.Value;
                        count++;
                    }
                }
                if(count%2 == 0)
                {
                    Console.WriteLine("ANDY");
                }
                else
                {
                    Console.WriteLine("BOB");
                }
            }
            Console.ReadKey();
        }
    }
}
