
using System;
using System.Linq;
namespace CompetativeCoding
{
    class Search
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            bool isTrue;
            string str = Console.ReadLine();
            string[] y = str.Split(' ');
            int[] x = new int[y.Length];
            for (int i = 0; i < y.Length; i++)
            {
                x[i] = Convert.ToInt32(y[i]);
            }
            for (int i = 0; i < b; i++)
            {
                int search = Convert.ToInt32(Console.ReadLine());
                isTrue = x.AsQueryable().Any(val => val == search);
                if (isTrue)
                {
                    Console.WriteLine("YES");
                    isTrue = false;
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}

