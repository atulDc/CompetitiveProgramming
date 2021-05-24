using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    /*LeetCode September*/
    class LengthOfLastWord
    {
        public int LengthOfLastWord_1(string s)
        {
            s = s.Trim();
            if (s.Count() > 0)
            {
                string[] arr = s.Split(' ');
                string temp = arr[arr.Count() - 1];
                return temp.Count();
            }
            else
            {
                return 0;
            }
            
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            LengthOfLastWord l = new LengthOfLastWord();
            Console.WriteLine(l.LengthOfLastWord_1(str));
            Console.ReadKey();
        }
    }
}
