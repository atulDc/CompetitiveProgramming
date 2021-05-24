using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class ThePleasantWalk
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] arr = input.Split(' ');
            String input2 = Console.ReadLine();
            String[] arr2 = input2.Split(' ');

            int n = int.Parse(arr[0]);
            int c = int.Parse(arr[1]);
            int[] a = new int[n];

            HashSet<int> ht = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(arr2[i]);
            }
            int maxCount = 0;
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                ht.Add(a[i]);
                if (!ht.Contains(a[i + 1]))
                {
                    count += 1;
                    ht.Clear();
                }
                else
                {
                    count = count + 1;
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
            }

            Console.WriteLine(maxCount > count + 1 ? maxCount : count + 1);
            Console.ReadKey();
        }
    }
}
