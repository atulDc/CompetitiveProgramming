using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int d = Convert.ToInt32(Console.ReadLine().Trim());
            Program res = new Program();
            
            int result = res.minimumMoves(s, d);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        int minimumMoves(string s, int d)
        {
            int count = 0;
            StringBuilder sb = new StringBuilder(s);
            string temp = s;
            for(int i = 0; i<=s.Length-d; i++)
            {
                string subStr = temp.Substring(i,d);
                if (Convert.ToInt32(subStr, 2) == 0)
                {
                    sb[i+(d-1)] = '1';
                    temp = sb.ToString();
                    count++;
                }
            }
            return count;
        }
    }
}
