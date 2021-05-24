using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    /*For example, given an array of [1, 2, 3, 4] and a target value of 1, we have three values meeting the condition: 1-2, 2-3, 3-4.Hence result is 3.
     * Reduce the complexities to pass all the test caes.*/
    class Pairs
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), x=> Convert.ToInt32(x));
            int n = input[0], k = input[1];
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));
            Array.Sort(arr);
            int[] diff = new int[arr.Count() - 1];
            int count = 0;
            for(int i=0;i<arr.Count()-1; i++)
            {
                diff[i] = Math.Abs(arr[i] - arr[i + 1]);
                //if(diff[i] == k)
                //{
                //    count++;
                //}
            }
            int index = 0;
            int sum = 0;
            for(int i = 0; i < diff.Count(); i++)
            {
                sum += diff[i];
                if(sum == k)
                {
                    count++;
                    sum -= diff[index];
                    index++;
                }
                else if (sum > k)
                {
                    while (!(sum < k))
                    {
                        sum -= diff[index];
                        if (sum == k)
                        {
                            count++;
                        }
                        index++;
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
