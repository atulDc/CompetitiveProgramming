using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    /*It is an inversion in an array problem. An inversion happens when a number has greater number before it or vice versa.
     * Suppose u have a number 2,6,5,1,4,3 . 
     * For 6 no inversion. 
     * For 5, 1 inversion i.e. 6
     * For 1, 3 inversion i.e. 2,6,5
     * For 4, 2 inversion i.e. 6,5
     * For 3, 3 inversion i.e. 6,5,4 
     * hence total inversion 9 and not divisible by 2 i.e. (9%2 == 0)*/
    class LarrysArray
    {
        static void Main(string[] args)
        {
            LarrysArray la = new LarrysArray();
            int t = Convert.ToInt32(Console.ReadLine());
            while (t-- > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));
                int count = 0;
                for(int i = 1; i < n; i++)
                {
                    for(int j = 0; j < i; j++)
                    {
                        if (arr[j] > arr[i])
                        {
                            count++;
                        }
                    }
                }
                if(count != 0 && count%2 == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            Console.ReadKey();
        }
    }
}

