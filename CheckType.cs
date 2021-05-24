using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class CheckType
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isString = false;
            bool isNumber = false;
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] >= 65 && input[i] <= 122)
                {
                    isString = true;
                    isNumber = false;
                }
                if(input[i] >=48 && input[i] <= 57)
                {
                    isNumber = true;
                    isString = false;
                }
            }

            if(isNumber && !isString)
            {
                Console.WriteLine("Integer");
            }
            else if(isString && !isNumber)
            {
                Console.WriteLine("string");
            }
            else
            {
                Console.WriteLine("AlphaNumeric");
            }

        }
    }
}
