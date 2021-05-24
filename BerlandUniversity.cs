using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class BerlandUniversity
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] arr = input.Split(' ');
            long result = 0;
            long t = int.Parse(arr[0]);
            long n = int.Parse(arr[1]);
            long a = int.Parse(arr[2]);
            long b = int.Parse(arr[3]);
            long k = int.Parse(arr[4]);

            if (n < k)
            {
                Console.WriteLine("0");
            }
            else
            {
                int up = (int)Math.Ceiling(n / 2.0);
                
                int low = (int)Math.Floor(n / 2.0);

                long tot_seats = (a * up) + (b * low);

                long res = tot_seats / k;
                if (n == k && t >= a && t >= b)
                {
                    result = a <= b ? a : b;
                    Console.WriteLine(result);
                }
                else if (n> (a+b))
                {

                }
                else if (res > t)
                {
                    Console.WriteLine(t);
                }
                else
                {
                    Console.WriteLine(res);
                }
            }
            Console.ReadKey();
        }
    }
}
