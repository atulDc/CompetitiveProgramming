using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    /* the idea is to move from left to right and increasing values when a[i]<a[i+1] 
     * then right to left with increasing values when a[i]<a[i+1]*/
    class Candie2
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] candie = new int[n];
            int sum = 0;
            for (int k = 0; k < n; k++)
            {
                arr[k] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                candie[i] = 1;
            }
            for(int i = 0; i < n-1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    candie[i + 1] = candie[i] + 1;
                }
            }
            for(int i = n - 1; i > 0; i--)
            {
                if(arr[i]<arr[i-1] && candie[i] >= candie[i - 1])
                {
                    candie[i - 1] = candie[i] + 1;
                }
            }
            for(int i = 0; i < n; i++)
            {
                sum += candie[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
