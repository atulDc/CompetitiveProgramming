using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class MinMax
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int maxIndex = -1;
            int minIndex = -1;
            int temp = 0;
            for(int i = 0;i< arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
                
                if(arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }

            temp = arr[maxIndex];
            arr[maxIndex] = arr[minIndex];
            arr[minIndex] = temp;

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
