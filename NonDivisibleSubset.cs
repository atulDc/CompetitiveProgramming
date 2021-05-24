using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Suppose k = 7 then 1+6,2+5,3+4 so subset can have 1 or 6, 2 or 5, 3 or 4 
 * we need to choose according to the greater occurence and special case if 0 has occerence then add it once 
 * next if half of k has occurence add it once
 */
namespace CompetativeCoding
{
    class NonDivisibleSubset
    {
        static void Main(string[] args)
        {
            NonDivisibleSubset nds = new NonDivisibleSubset();
            int count = 0;
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));
            int n = a[0];
            int k = a[1];
            int[] c = new int[k];
            int sum = 0;
            for (int i = 0; i<k; i++)
            {
                c[i] = 0;
            }
            for (int j = 0; j<b.Count(); j++)
            {
                c[b[j] % k] = c[b[j] % k] + 1;
            }
            if(k%2 == 0)
            c[k/2] = Math.Min(c[k/2],1);
            for(int i = 1; i<=(c.Count())/2; i++)
            {
                sum = sum + Math.Max(c[i], c[k - i]); 
            }
            sum = sum + Math.Min(c[0], 1);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

