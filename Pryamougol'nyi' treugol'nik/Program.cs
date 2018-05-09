using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pryamougol_nyi__treugol_nik
{
    class Program
    {
        static void Main()
        {
            int i1 = 0, i2 = 0;
            for (int a = 0; a < 14; a++)
            {
                for (int b = 0; b < 15; b++)
                {
                    if (b == i1 || b == i2) Console.Write("*");
                    else Console.Write("7");
                }
                Console.Write("\n");
                i2++;
            }
            for (int b = 0; b < 15; b++)
            {
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
