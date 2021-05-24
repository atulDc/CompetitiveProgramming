using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CompetativeCoding
{
    class NikitaAndTheGame
    {
        static void Main(string[] args)
        {
            NikitaAndTheGame rs = new NikitaAndTheGame();
            int t = Convert.ToInt32(Console.ReadLine());
            while (t-- > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                BigInteger[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => BigInteger.Parse(x));
                BigInteger[] sumArr = new BigInteger[n];
                sumArr[0] = arr[0];
                for(int i = 1; i < arr.Count(); i++)
                {
                    sumArr[i] = sumArr[i - 1] + arr[i];
                }
                BigInteger sum = sumArr[sumArr.Count() - 1];
                BigInteger total = sum;
                BigInteger temp = sum/2;
                int count = 0;
                if (sum != 0)
                {
                    while (sum % 2 == 0)
                    {
                        sum = sum / 2;
                        for (int i = 0; i < n; i++)
                        {
                            if (sumArr[i] == sum || (sumArr[i] != total && sumArr[i] == sum + temp) || arr[i] == sum)
                            {
                                count++;
                                break;
                            }
                        }
                    }
                    Console.WriteLine(count);
                }
                else
                {
                    Console.WriteLine(arr.Count()-1);
                }
            }
        }
    }
}
