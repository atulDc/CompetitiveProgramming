using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompetativeCoding
{
    class TheaterSquare
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] arr = input.Split(' ');
            int n = Convert.ToInt32(arr[0]);
            int m = Convert.ToInt32(arr[1]);
            int a = Convert.ToInt32(arr[2]);
            TheaterSquare res = new TheaterSquare();

            long result = res.minimumFlagStone(n,m,a);
            string answer = result.ToString(CultureInfo.InvariantCulture);
            Console.WriteLine(answer);


            Console.ReadKey();
        }
        long minimumFlagStone(int n,int m,int a)
        {
            long lengthquotient = n / a;
            long breathquotient = m / a;
            if(n%a != 0)
            {
                lengthquotient = lengthquotient + 1;
            }
            if(m%a != 0)
            {
                breathquotient = breathquotient + 1;
            }
            return lengthquotient * breathquotient;
        }
    }
}
