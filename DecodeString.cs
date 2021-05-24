using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class DecodeString
    {
        string decodeString(string str)
        {
            StringBuilder s = new StringBuilder(str);
            int count = 0;
            int countBrancket = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '[') count = count + 1;
                else if (s[i] == ']') count = count - 1;

                if (countBrancket < count) countBrancket = count;
            }
            StringBuilder param = s;
            for(int i = 0; i < countBrancket; i++)
            {
                s = innerDecode(param);
                param = s;
            }
            return s.ToString();
        }

        StringBuilder innerDecode(StringBuilder s)
        {
            int startIndex = -1;
            int numberEndIndex = -1;
            int endIndex = -1;
            int count = 0;
            bool isEnd = false;
            Dictionary<string, string> dt = new Dictionary<string, string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '[')
                {
                    if (count == 0)
                    {
                        int j = i-1;
                        while(j>= 0 && s[j] >= 48 && s[j] <= 57)
                        {
                            j--;
                        }
                        startIndex = j + 1;
                        numberEndIndex = i - 1;
                    }
                    count = count + 1;
                }
                if(s[i] == ']')
                {
                    count = count - 1;
                    if (count == 0)
                    {
                        endIndex = i;
                        isEnd = true;
                    }
                }
                if(isEnd && count == 0)
                {
                    int len = endIndex - startIndex;
                    int numLen = (numberEndIndex - startIndex) + 1;
                    int times = Int32.Parse((s.ToString()).Substring(startIndex, numLen))-1;
                    string tempStr = (s.ToString()).Substring(startIndex, len+1);
                    string newStr = tempStr.Substring(numLen+1, len-(numLen+1));
                    StringBuilder sb = new StringBuilder(newStr);
                    while (times-- > 0)
                    {
                        sb.Append(newStr);
                    }
                    if(!dt.ContainsKey(tempStr))
                    dt.Add(tempStr, sb.ToString());
                    isEnd = !isEnd;
                }
            }
            int countDT = dt.Count;
            foreach (KeyValuePair<string, string> entry in dt)
            {
                s.Replace(entry.Key, entry.Value);
            }
            return s;
        }

        static void Main(string[] args)
        {
            DecodeString ds = new DecodeString();
            string str = Console.ReadLine();
            string res = ds.decodeString(str);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
