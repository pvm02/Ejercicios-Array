using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] Num1 = new float[5] { 23, 10, 100, 21, 90 };

            Num1[4] = 23;

            Num1[3] = 10;

            Num1[2] = 100;

            Num1[1] = 21;

            Num1[0] = 90;

            for (int i = 0; i < Num1.Length; i++)
            {
                Console.WriteLine(Num1[i]);
            }
        }
    }
}
