using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    /* It can be solved with split function, iteratively moving forward,
     * if any time when split functiondoes not return any value then return true else false 
     * LeetCode September */
    class RepitativeSubString
    {
        public bool RepeatedSubstringPattern(string str)
        {
            bool flag = false;
            bool flag2 = false;
            int n = str.Count();
            string str2 = string.Empty;
            for(int i = 0; i < (n / 2); i++)
            {
                if(str.ElementAt(i) != str.ElementAt(i + 1))
                {
                    flag2 = false;
                    break;
                }
                str2 += str.ElementAt(i);
                flag2 = true;
            }
            if (flag2)
            {
                if(str2.Substring(0,str2.Count()) == str.Substring(str2.Count(), str.Count()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for(int i = 0; i < (n / 2); i++)
            {
                if (str.Substring(0, i+1) == str.Substring(i + 1, i+1))
                {
                    int temp = (str.Substring(0, i+1)).Count();
                    string subStr = str.Substring(0, i+1);
                    int j = 0;
                    while (j < n)
                    {
                        if((str.Count() % subStr.Count()) != 0 || subStr != str.Substring(j,temp))
                        {
                            flag = false;
                            goto outerLoop;
                        }
                        if((str.Count()%subStr.Count()) == 0 && subStr == str.Substring(j,temp))
                        {
                            flag = true;
                        }

                        j = j + temp;
                    }
                }
                if (flag)
                {
                    break;
                }
            outerLoop: continue;
            }
            return flag;
        }
        static void Main(string[] args)
        {
            RepitativeSubString rs = new RepitativeSubString();
            string str = Console.ReadLine();
            Console.WriteLine(rs.RepeatedSubstringPattern(str));
            Console.ReadKey();
        }
    }
}
