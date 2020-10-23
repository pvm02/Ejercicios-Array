using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Num = new int[10];

            Num[0] = 2;
            Num[1] = 45;
            Num[2] = 100;
            Num[3] = 200;
            Num[4] = 40;
            Num[5] = 30;
            Num[6] = 79;
            Num[7] = 26;
            Num[8] = 87;
            Num[9] = 12;

            Console.WriteLine(Num.Max());
        }
    }
}
