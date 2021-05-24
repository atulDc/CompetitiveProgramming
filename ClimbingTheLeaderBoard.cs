using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class ClimbingTheLeaderBoard
    {
        public int binarySearch(int[] a, int l, int r, int i)
        {
            int res = -1;
            int mid = -1;
            while(l<=r)
            {
                mid = l + (r - l) / 2;
                if(a[mid] == i)
                {
                    res = mid;
                    return res+1;
                }
                else if(i>a[mid])
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
                return l+1;
        }
        static void Main(string[] args)
        {
            ClimbingTheLeaderBoard cb = new ClimbingTheLeaderBoard();
            HashSet<int> a = new HashSet<int>();
            int x = 0;
            int n = Convert.ToInt32(Console.ReadLine()); // total players
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            for (int i = 0; i < n; i++)
            {
               x = arr[i];
                if (!a.Contains<int>(x))
                {
                    a.Add(x);
                }
            }
            int[] c = a.ToArray<int>();
            int m = Convert.ToInt32(Console.ReadLine()); // alice played
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp));
            foreach(int i in b)
            {
                int index = -1;
                index = cb.binarySearch(c, 0, c.Count() - 1, i); // to find the rank
                if(index == c.Count() && i < c[c.Count()-1])
                {
                    Console.WriteLine(index + 1);
                }
                else
                {
                    Console.WriteLine(index);
                }
            }
            Console.ReadKey();
        }
    }
}
