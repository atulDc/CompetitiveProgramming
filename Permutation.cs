using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class Permutation
    {
        public static String swapString(String a, int i, int j)
        {
            char[] b = a.ToCharArray();
            char ch;
            ch = b[i];
            b[i] = b[j];
            b[j] = ch;
            return string.Join("", b);
        }

        public static void Main()
        {
            String str = "ABC";
            int len = str.Length;
            //Console.WriteLine("All the permutations of the string are: ");
            generatePermutation(str, 0, len);
            Console.ReadKey();

        }

        public static void generatePermutation(String str, int start, int end)
        {
            Console.WriteLine("P({0},{1},{2})", str, start, end);
            if (start == end - 1)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i < end; i++)
                {
                    str = swapString(str, start, i);
                    generatePermutation(str, start + 1, end);
                    str = swapString(str, start, i);
                }
            }
        }
    }
}
